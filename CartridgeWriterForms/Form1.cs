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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
