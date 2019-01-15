using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartridgeWriter;

namespace CartridgeWriterForms
{
    public partial class Form1 : Form
    {

        private DeviceManager dm = new DeviceManager();
        private Cartridge c = null;


        public Form1()
        {
            InitializeComponent();

            cboDevice.Items.AddRange(dm.Devices.ToArray());
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
            //txtEEPROMUID.Text = c.EEPROMUID.HexString();
            //txtKeyFragment.Text = c.KeyFragment;
            //txtSerialNumberCurrent.Text = c.SerialNumber.ToString("f1");
            //txtSerialNumberChangeTo.Text = txtSerialNumberCurrent.Text;
            //cboMaterialCurrent.Text = c.Material.Name;
            //cboMaterialChangeTo.Text = cboMaterialCurrent.Text;
            //txtManufacturingLotCurrent.Text = c.ManufacturingLot;
            //txtManufacturingLotChangeTo.Text = txtManufacturingLotCurrent.Text;
            //txtManufacturingDateCurrent.Text = c.ManfuacturingDate.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            //txtManufacturingDateChangeTo.Text = txtManufacturingDateCurrent.Text;
            //txtLastUseDateCurrent.Text = c.UseDate.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            //txtLastUseDateChangeTo.Text = txtLastUseDateCurrent.Text;
            //txtInitialQuantityCurrent.Text = c.InitialMaterialQuantity.ToString();
            //txtInitialQuantityChangeTo.Text = txtInitialQuantityCurrent.Text;
            //txtCurrentQuantityCurrent.Text = c.CurrentMaterialQuantity.ToString();
            //txtCurrentQuantityChangeTo.Text = txtCurrentQuantityCurrent.Text;
            //txtVersionCurrent.Text = c.Version.ToString();
            //txtVersionChangeTo.Text = txtVersionCurrent.Text;
            //txtSignatureCurrent.Text = c.Signature;
            //txtSignatureChangeTo.Text = txtSignatureCurrent.Text;
        }
    }
}
