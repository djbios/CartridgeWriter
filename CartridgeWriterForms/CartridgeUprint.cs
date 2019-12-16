using CartridgeWriterExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using CartridgeWriter;

namespace CartridgeWriterForms
{
    public class CartridgeUprint : ICartridge
    {
        public byte[] _encrypted = null;
        private byte[] _decrypted = new byte[128];
        private Machine _machine = null;
        private byte[] _eepromUID = null;
        private byte[] _key = new byte[16];
        private byte[] _keyFragment = new byte[8];
        private byte[] _keyFragmentCRC = new byte[2];
        private byte[] _plainContentCRC = new byte[2];
        private byte[] _cryptedContentCRC = new byte[2];
        private byte[] _currentMaterialQuantityCryptedCRC = new byte[2];
        private byte[] _currentMaterialQuantityCRC = new byte[2];


        public CartridgeUprint(byte[] encrypted, Machine machine, byte[] eepromUID, bool decrypt = true)
        {
            _encrypted = encrypted;
            _machine = machine;
            _eepromUID = eepromUID;
            Buffer.BlockCopy(_encrypted, 0x48, _keyFragment, 0, 8);

            BuildKey();
            LoadCRC();
            if (decrypt)
                Decrypt();
            else
            {
                //FillDefaultValues();
            }
        }

        private void FillDefaultValues()
        {

        }

        // Encrypted
        public byte[] Encrypted
        {
            get
            {
                Encrypt();
                return _encrypted;
            }
        }
        
        // EEPROMUID
        public byte[] EEPROMUID { get { return _eepromUID; } }

        

        // Serial number
        public double SerialNumber
        {
            get { return BitConverter.ToDouble(_decrypted, 0x00); }
            set { Buffer.BlockCopy(BitConverter.GetBytes(value), 0, _decrypted, 0x00, 8); }
        }

        // Material (see Material.cs)
        public Material Material
        {
            get { return Material.FromId(BitConverter.ToDouble(_decrypted, 0x08)); }
            set { Buffer.BlockCopy(BitConverter.GetBytes(value.Id), 0, _decrypted, 0x08, 8); }
        }

        // Manufacturing lot
        public string ManufacturingLot
        {
            get { return Encoding.ASCII.GetString(_decrypted, 0x10, 20).Split('\x00').First(); }
            set { Buffer.BlockCopy(Encoding.ASCII.GetBytes(value), 0, _decrypted, 0x10, value.Length); }
        }

        // Manufacturing date
        public DateTime ManfuacturingDate
        {
            get
            {
                int year = BitConverter.ToUInt16(_decrypted, 0x28) + 1900;
                int month = _decrypted[0x2a];
                int day = _decrypted[0x2b];
                int hour = _decrypted[0x2c];
                int minute = _decrypted[0x2d];
                int second = BitConverter.ToUInt16(_decrypted, 0x2e);
                return new DateTime(year, month, day, hour, minute, second);
            }
            set
            {
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Year)), 0, _decrypted, 0x28, 2);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Month)), 0, _decrypted, 0x2a, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Day)), 0, _decrypted, 0x2b, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Hour)), 0, _decrypted, 0x2c, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Minute)), 0, _decrypted, 0x2d, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Second)), 0, _decrypted, 0x2e, 2);
            }
        }

        // Last use date
        public DateTime UseDate
        {
            get
            {
                int year = BitConverter.ToUInt16(_decrypted, 0x30) + 1900;
                int month = _decrypted[0x32];
                int day = _decrypted[0x33];
                int hour = _decrypted[0x34];
                int minute = _decrypted[0x35];
                int second = BitConverter.ToUInt16(_decrypted, 0x36);
                return new DateTime(year, month, day, hour, minute, second);
            }
            set
            {
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Year)), 0, _decrypted, 0x30, 2);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Month)), 0, _decrypted, 0x32, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Day)), 0, _decrypted, 0x33, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Hour)), 0, _decrypted, 0x34, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Minute)), 0, _decrypted, 0x35, 1);
                Buffer.BlockCopy(BitConverter.GetBytes((ushort)(value.Second)), 0, _decrypted, 0x36, 2);
            }
        }

        // Initial material quantity, in cubic inches
        public double InitialMaterialQuantity
        {
            get { return 16.3871*BitConverter.ToDouble(_decrypted, 0x38); }
            set { Buffer.BlockCopy(BitConverter.GetBytes(value), 0, _decrypted, 0x38, 8); }
        }

        // Remaining material quantity
        public double CurrentMaterialQuantity
        {
            get { return 16.3871*BitConverter.ToDouble(_decrypted, 0x58); }
            set { Buffer.BlockCopy(BitConverter.GetBytes(value), 0, _decrypted, 0x58, 8); }
        }

        // Key used to encrypt / decrypt
        public string KeyFragment { get { return _keyFragment.HexString(); } }

        // Version
        public ushort Version
        {
            get { return BitConverter.ToUInt16(_decrypted, 0x24); }
            set { Buffer.BlockCopy(BitConverter.GetBytes(value), 0, _decrypted, 0x24, 2); }
        }

        // Signature
        public string Signature
        {
            get { return Encoding.ASCII.GetString(_decrypted, 0x68, 9); }
            set { Buffer.BlockCopy(Encoding.ASCII.GetBytes(value), 0, _decrypted, 0x68, value.Length); }
        }

        //
        // Encrypt a packed cartridge into a crypted cartridge
        //
        private void Encrypt()
        {
            _decrypted.CopyTo(_encrypted, 0);

            //
            // Content
            //
            byte[] content = new byte[0x40];
            Buffer.BlockCopy(_decrypted, 0, content, 0, 0x40);
            // Checksum content
            Buffer.BlockCopy(Crc16_Checksum.Checksum(content), 0, _encrypted, 0x40, 2);
            // Encrypt content
            byte[] contentEncrypted = Desx_Crypto.Encrypt(_key, content);
            Buffer.BlockCopy(contentEncrypted, 0, _encrypted, 0, 0x40);
            // Checksum crypted content
            Buffer.BlockCopy(Crc16_Checksum.Checksum(contentEncrypted), 0, _encrypted, 0x46, 2);

            //
            // Current Material Quantity
            //
            byte[] currentMaterialQuantity = new byte[8];
            Buffer.BlockCopy(_decrypted, 0x58, currentMaterialQuantity, 0, 8);
            // Checksum current material quantity
            Buffer.BlockCopy(Crc16_Checksum.Checksum(currentMaterialQuantity), 0, _encrypted, 0x62, 2);
            // Encrypt current material quantity
            byte[] currentMaterialQuantityEncrypted = Desx_Crypto.Encrypt(_key, currentMaterialQuantity);
            Buffer.BlockCopy(currentMaterialQuantityEncrypted, 0, _encrypted, 0x58, 8);
            // Checksum crypted current material quantity
            Buffer.BlockCopy(Crc16_Checksum.Checksum(currentMaterialQuantityEncrypted), 0, _encrypted, 0x60, 2);
        }

        //
        // Decrypt a crypted cartridge into a packed cartridge
        //
        private void Decrypt()
        {
            _encrypted.CopyTo(_decrypted, 0);

            //
            // Content
            //
            byte[] contentEncrypted = new byte[0x40];
            Buffer.BlockCopy(_encrypted, 0, contentEncrypted, 0, 0x40);

            // Validate crypted content checksum
            if (!Crc16_Checksum.Checksum(contentEncrypted).SequenceEqual(_cryptedContentCRC))
                throw new Exception("invalid crypted content checksum");
            // Decrypt content
            byte[] content = Desx_Crypto.Decrypt(_key, contentEncrypted);
            Buffer.BlockCopy(content, 0, _decrypted, 0, 0x40);
            // Validating plaintext checksum
            if (!Crc16_Checksum.Checksum(content).SequenceEqual(_plainContentCRC))
                throw new Exception(
                    "invalid content checksum: should have " + _plainContentCRC.HexString() +
                    " but have " + Crc16_Checksum.Checksum(content).HexString());

            //
            // Current Material Quantity
            //
            byte[] currentMaterialQuantityEncrypted = new byte[8];
            Buffer.BlockCopy(_encrypted, 0x58, currentMaterialQuantityEncrypted, 0, 8);

            // Validate crypted current material quantity checksum
            if (!Crc16_Checksum.Checksum(currentMaterialQuantityEncrypted).SequenceEqual(_currentMaterialQuantityCryptedCRC))
                throw new Exception("invalid current material quantity checksum");
            // Decrypt current material quantity
            byte[] currentMaterialQuantityDecrypted = Desx_Crypto.Decrypt(_key, currentMaterialQuantityEncrypted);
            Buffer.BlockCopy(currentMaterialQuantityDecrypted, 0, _decrypted, 0x58, 8);
            // Validating current material quantity checksum
            if (!Crc16_Checksum.Checksum(currentMaterialQuantityDecrypted).SequenceEqual(_currentMaterialQuantityCRC))
                throw new Exception("invalid current material quantity checksum");
        }


        //
        // Build a key used to encrypt/decrypt a cartridge
        //
        private void BuildKey()
        {
            // Validate key fragment checksum
            // TODO

            byte[] machine_number = _machine.Number;

            _key[0] = (byte)(~_keyFragment[0] & 0xff);
            _key[1] = (byte)(~_keyFragment[2] & 0xff);
            _key[2] = (byte)(~_eepromUID[5] & 0xff);
            _key[3] = (byte)(~_keyFragment[6] & 0xff);
            _key[4] = (byte)(~machine_number[0] & 0xff);
            _key[5] = (byte)(~machine_number[2] & 0xff);
            _key[6] = (byte)(~_eepromUID[1] & 0xff);
            _key[7] = (byte)(~machine_number[6] & 0xff);
            _key[8] = (byte)(~machine_number[7] & 0xff);
            _key[9] = (byte)(~_eepromUID[6] & 0xff);
            _key[10] = (byte)(~machine_number[3] & 0xff);
            _key[11] = (byte)(~machine_number[1] & 0xff);
            _key[12] = (byte)(~_keyFragment[7] & 0xff);
            _key[13] = (byte)(~_eepromUID[2] & 0xff);
            _key[14] = (byte)(~_keyFragment[3] & 0xff);
            _key[15] = (byte)(~_keyFragment[1] & 0xff);

            machine_number = null;
        }

        private void LoadCRC()
        {
            Buffer.BlockCopy(_encrypted, 0x40, _plainContentCRC, 0, 2);
            Buffer.BlockCopy(_encrypted, 0x46, _cryptedContentCRC, 0, 2);
            Buffer.BlockCopy(_encrypted, 0x50, _keyFragmentCRC, 0, 2);
            Buffer.BlockCopy(_encrypted, 0x60, _currentMaterialQuantityCryptedCRC, 0, 2);
            Buffer.BlockCopy(_encrypted, 0x62, _currentMaterialQuantityCRC, 0, 2);
        }
    }
}
