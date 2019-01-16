using System;
using System.Linq;
using System.Windows.Forms;
using CartridgeWriter;
using CartridgeWriterExtensions;

namespace CartridgeWriterForms
{
    public partial class Form1 : Form
    {

        private DeviceManager dm = new DeviceManager();
        private Cartridge c = null;


        public Form1()
        {
            InitializeComponent();
            var devices = dm.Devices.ToArray();
            cboDevice.Items.AddRange(dm.Devices.ToArray());
            var i = cboDevice.FindStringExact("/dev/ttyUSB0");
            if (i >=0)
                cboDevice.SelectedIndex = i;
            cboPrinterType.Items.AddRange(Machine.GetAllTypes().ToArray());
            cboMaterialCurrent.Items.AddRange(Material.GetAllNames().ToArray());
            cboMaterialChangeTo.Items.AddRange(Material.GetAllNames().ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboDevice.Text) || String.IsNullOrEmpty(cboPrinterType.Text))
            {
                MessageBox.Show("I need a Device and Printer Type before I can read.");
                return;
            }

            c = dm.ReadCartridge(cboDevice.Text, Machine.FromType(cboPrinterType.Text));

            if (c == null)
                return;
            LoadControls();
        }

        private void LoadControls()
        {
            txtEEPROMUID.Text = c.EEPROMUID.HexString();
            txtKeyFragment.Text = c.KeyFragment;
            txtSerialNumberCurrent.Text = c.SerialNumber.ToString("f1");
            txtSerialNumberChangeTo.Text = txtSerialNumberCurrent.Text;
            cboMaterialCurrent.Text = c.Material.Name;
            cboMaterialChangeTo.Text = cboMaterialCurrent.Text;
            txtManufacturingLotCurrent.Text = c.ManufacturingLot;
            txtManufacturingLotChangeTo.Text = txtManufacturingLotCurrent.Text;
            txtManufacturingDateCurrent.Text = c.ManfuacturingDate.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            txtManufacturingDateChangeTo.Text = txtManufacturingDateCurrent.Text;
            txtLastUseDateCurrent.Text = c.UseDate.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            txtLastUseDateChangeTo.Text = txtLastUseDateCurrent.Text;
            txtInitialQuantityCurrent.Text = c.InitialMaterialQuantity.ToString();
            txtInitialQuantityChangeTo.Text = txtInitialQuantityCurrent.Text;
            txtCurrentQuantityCurrent.Text = c.CurrentMaterialQuantity.ToString();
            txtCurrentQuantityChangeTo.Text = txtCurrentQuantityCurrent.Text;
            txtVersionCurrent.Text = c.Version.ToString();
            txtVersionChangeTo.Text = txtVersionCurrent.Text;
            txtSignatureCurrent.Text = c.Signature;
            txtSignatureChangeTo.Text = txtSignatureCurrent.Text;
        }

        private void UpdateCartridge()
        {
            if (!txtSerialNumberCurrent.Text.Equals(txtSerialNumberChangeTo.Text))
                c.SerialNumber = double.Parse(txtSerialNumberChangeTo.Text);

            if (!cboMaterialCurrent.Text.Equals(cboMaterialChangeTo.Text))
                c.Material = Material.FromName(cboMaterialChangeTo.Text);

            if (!txtManufacturingLotCurrent.Text.Equals(txtManufacturingLotChangeTo.Text))
                c.ManufacturingLot = txtManufacturingLotChangeTo.Text;

            if (!txtManufacturingDateCurrent.Text.Equals(txtManufacturingDateChangeTo.Text))
                c.ManfuacturingDate = DateTime.ParseExact(txtManufacturingDateChangeTo.Text, "yyyy-MM-dd HH:mm:ss", null);

            if (!txtLastUseDateCurrent.Text.Equals(txtLastUseDateChangeTo.Text))
                c.UseDate = DateTime.ParseExact(txtLastUseDateChangeTo.Text, "yyyy-MM-dd HH:mm:ss", null);

            if (!txtInitialQuantityCurrent.Text.Equals(txtInitialQuantityChangeTo.Text))
                c.InitialMaterialQuantity = double.Parse(txtInitialQuantityChangeTo.Text);

            if (!txtCurrentQuantityCurrent.Text.Equals(txtCurrentQuantityChangeTo.Text))
                c.CurrentMaterialQuantity = double.Parse(txtCurrentQuantityChangeTo.Text);

            if (!txtVersionCurrent.Text.Equals(txtVersionChangeTo.Text))
                c.Version = ushort.Parse(txtVersionChangeTo.Text);

            if (!txtSignatureCurrent.Text.Equals(txtSignatureChangeTo.Text))
                c.Signature = txtSignatureChangeTo.Text;
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                MessageBox.Show("I need to Read before I can Write.");
                return;
            }


            UpdateCartridge();

            // Write the cartridge.
            byte[] result = new byte[3];
            result = dm.WriteCartridge(cboDevice.Text, c);

            LoadControls();
        }

    }
}
