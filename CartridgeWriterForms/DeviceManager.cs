// Major portions ported from tool.py by David Slayton (2014); copyright below.

// Copyright (c) 2013 Matthew Goodman
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// The Software shall be used for Good, not Evil.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using CartridgeWriterExtensions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using CartridgeWriterForms;

namespace CartridgeWriter
{
    public class DeviceManager
    {
        private int baudRate = 9600;
        private int serialInitializationWait = 3000;
        
        private struct device
        {
            public string Name;
        }

        private IList<device> devices = new List<device>();

        public IEnumerable<string> Devices
        {
            get { return devices.Select(d => d.Name); }
        }

        public DeviceManager()
        {
            LoadApplicationSettings();
            LoadDevices();
        }

        public Cartridge ReadCartridge(string name, Machine machine, bool decrypt = true)
        {
            Cartridge c = null;
            byte[] rom = null;
            byte[] flash = null;

            using (SerialPort sp = new SerialPort(name, baudRate))
            {
                sp.ReadTimeout = 3000;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.DataBits = 8;
                sp.Handshake = Handshake.None;
                sp.DtrEnable = true;

                if (!sp.IsOpen)
                    sp.Open();

                WaitForChip(sp);

                rom = ReadROM(sp);

                flash = ReadFlash(sp);

                sp.Close();
            }

            if (BitConverter.IsLittleEndian)
                rom = rom.Reverse();

            //SaveFlashToFile(rom, flash);

            c = new Cartridge(flash, machine, rom, decrypt);

            return c;
        }

        public string ReadSerial(string port, string bayText)
        {
            using (SerialPort serialPort = new SerialPort(port, 38400))
            {
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.RequestToSend;
                serialPort.DtrEnable = true;
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.Write(Bay.FromName(bayText).code_read);
                serialPort.Write("\r\n");
                Thread.Sleep(5000);
                var result = serialPort.ReadExisting();
                serialPort.Close();
                if (String.IsNullOrEmpty(result))
                    MessageBox.Show("I received nothing! Make sure the printer is connected.", "");
                return result;
            }
        }

        public CartridgeUprint ReadUprintCartridge(string inputFlash, bool decrypt = true)
        {
            var rom = ConvertHexStringToByteArray(clear_ID(inputFlash));
            var flash = ConvertHexStringToByteArray(clear_code(inputFlash));

            if (BitConverter.IsLittleEndian)
                rom = rom.Reverse();

            return new CartridgeUprint(flash, Machine.FromType("uPrint / uPrint Plus"), rom.Reverse(), decrypt);
        }

        public byte[] WriteCartridge(string name, ICartridge c)
        {
            byte[] result = null;

            using (SerialPort sp = new SerialPort(name, baudRate))
            {
                sp.ReadTimeout = 3000;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.DataBits = 8;
                sp.Handshake = Handshake.None;
                sp.DtrEnable = true;

                if (!sp.IsOpen)
                    sp.Open();

                WaitForChip(sp);

                result = WriteFlash(sp, c.Encrypted);

                sp.Close();
            }

            return result;
        }

        public void WriteUprintCartridge(ICartridge c, string bayName, string portName)
        {
            string newflash = Bay.FromName(bayName).code_write + CreateOutput(c.Encrypted);

            using (SerialPort serialPort = new SerialPort(portName, 38400))
            {
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.RequestToSend;
                serialPort.DtrEnable = true;
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.Write(newflash);
                serialPort.Write("\r\n");
                serialPort.Close();
                System.Threading.Thread.Sleep(2000);
                MessageBox.Show("Please check if it worked, by removing and reinserting the cartridge!", "");
            }
        }

        //Creating the output string in the correct form for writing it back to the chip
        public static string CreateOutput(byte[] output_flash)
        {
            string output;
            output = "\"" + BitConverter.ToString(output_flash).Replace("-", ",") + "\"";
            return output;
        }

        private static bool IsOSUnix()
        {
            int p = (int)Environment.OSVersion.Platform;
            return ((p == 4) || (p == 6) || (p == 128));
        }
        private void LoadDevices()
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                devices.Add(new device { Name = port.ToString() });
            }

            //if (IsOSUnix())
            //{
            //    string[] ttys = Directory.GetFiles("/dev/", "tty*");

            //}
            //SelectQuery q = new SelectQuery("Win32_PNPEntity", "Name LIKE '%(COM%)%'");

            //using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(q))
            //{
            //    using (ManagementObjectCollection moc = searcher.Get())
            //    {
            //        foreach (ManagementObject mo in moc)
            //        {
            //            devices.Add(new device { Name = mo["Name"].ToString() });
            //        }
            //    }
            //}
        }

        private bool PollForChip(SerialPort sp, int retries = 5)
        {
            byte[] buffer = new byte[1];
            sp.Write("x");

            // Pause for buffer to fill.
            while (sp.BytesToRead < 1 && retries > 0)
            {
                retries--;
                Thread.Sleep(10);
            }
            if (sp.BytesToRead == 0)
                throw new Exception("Timeout");

            sp.Read(buffer, 0, 1);
            return Encoding.ASCII.GetString(buffer).Equals("p");
        }

        private byte[] ReadFlash(SerialPort sp)
        {
            byte[] buffer = new byte[512];

            sp.DiscardInBuffer();

            sp.Write("f");

            // Pause for buffer to fill.
            while (sp.BytesToRead < 512)
                Thread.Sleep(10);

            sp.Read(buffer, 0, 512);

            return buffer;
        }

        private byte[] ReadROM(SerialPort sp)
        {
            byte[] buffer = new byte[8];
            sp.Write("r");

            // Pause for buffer to fill.
            while (sp.BytesToRead < 8)
                Thread.Sleep(10);

            sp.Read(buffer, 0, 8);
            return buffer;
        }

        private void WaitForChip(SerialPort sp)
        {
            Thread.Sleep(serialInitializationWait);

            sp.DiscardInBuffer();

            while (!PollForChip(sp))
                Thread.Sleep(500);

            sp.DiscardInBuffer();
        }

        private byte[] WriteFlash(SerialPort sp, byte[] flash)
        {
            byte[] result = new byte[3];

            sp.Write("w");
            sp.Write(flash, 0, flash.Length);

            //Pause for buffer to fill.
            while (sp.BytesToRead < 3)
                Thread.Sleep(10);

            sp.Read(result, 0, 3);
            return result;
        }

        // Create a file of the DS2433 chip contents.
        //private void SaveFlashToFile(byte[] rom, byte[] flash)
        //{
        //    string path = @".\EEPROMFiles";

        //    if (!Directory.Exists(path))
        //        Directory.CreateDirectory(path);

        //    path = path + @"\" + rom.HexString();

        //    if (!Directory.Exists(path))
        //        Directory.CreateDirectory(path);

        //    DateTime now = DateTime.Now;

        //    path = path + @"\" + now.ToString("yyyyMMdd.HHmmss") + ".bin";

        //    using (FileStream fs = File.Create(path))
        //    {
        //        fs.Write(flash, 0, 512);
        //        fs.Flush();
        //        fs.Close();
        //    }
        //}

        // Get the application settings and load them.
        private void LoadApplicationSettings()
        {
            int br;
            int siw;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0) return;

            if (appSettings["BaudRate"] != null && int.TryParse(appSettings["BaudRate"], out br)) baudRate = br;

            if (appSettings["SerialInitializationWait"] != null
                && int.TryParse(appSettings["SerialInitializationWait"], out siw)) serialInitializationWait = siw;
        }

        // Get the name of the com port.
        private string ParseComPortName(string deviceName)
        {
            string comPortName = string.Empty;

            if (String.IsNullOrEmpty(deviceName))
                return comPortName;

            int startIndex = deviceName.IndexOf("(") + 1;
            int length = deviceName.IndexOf(")") - startIndex;

            if (startIndex > 0 && length > 0)
                comPortName = deviceName.Substring(startIndex, length);

            return comPortName;
        }

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", String.Empty);
            byte[] HexAsBytes = new byte[(hexString.Length) / 2];

            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                HexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return HexAsBytes;

        }

        //extract the hexcode from the rest of the code sent over the serial port
        private string clear_code(string uncut)
        {
            string[] splittedStrings = uncut.Split(new[] { "000000: " }, StringSplitOptions.None);
            string Dump = splittedStrings[2];
            string code = Dump.Substring(0, 48);
            for (int i = 1; i <= (Dump.Length - 48) / 76; i++)
            {
                code = code + Dump.Substring(76 * i, 48);
            }


            return code;
        }

        //extract the ID from the rest of the code sent over the serial port
        private string clear_ID(string uncut)
        {
            try
            {
                string[] splittedStrings = uncut.Split(new[] { "000000: " }, StringSplitOptions.None);
                string clearcode = splittedStrings[1];
                string ID = clearcode.Substring(0, 23);
                return ID;
            }
            catch (Exception e)
            {
                MessageBox.Show("Not the right Form");
                MessageBox.Show(e.ToString());
                return "";
            }
        }
    }
}
