namespace CartridgeWriterForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.cboPrinterType = new System.Windows.Forms.ComboBox();
            this.cmdRead = new System.Windows.Forms.Button();
            this.txtEEPROMUID = new System.Windows.Forms.TextBox();
            this.txtKeyFragment = new System.Windows.Forms.TextBox();
            this.cboMaterialCurrent = new System.Windows.Forms.ComboBox();
            this.cboMaterialChangeTo = new System.Windows.Forms.ComboBox();
            this.txtSerialNumberCurrent = new System.Windows.Forms.TextBox();
            this.txtManufacturingLotCurrent = new System.Windows.Forms.TextBox();
            this.txtManufacturingDateCurrent = new System.Windows.Forms.TextBox();
            this.txtLastUseDateCurrent = new System.Windows.Forms.TextBox();
            this.txtInitialQuantityCurrent = new System.Windows.Forms.TextBox();
            this.txtCurrentQuantityCurrent = new System.Windows.Forms.TextBox();
            this.txtVersionCurrent = new System.Windows.Forms.TextBox();
            this.txtSignatureCurrent = new System.Windows.Forms.TextBox();
            this.txtSignatureChangeTo = new System.Windows.Forms.TextBox();
            this.txtVersionChangeTo = new System.Windows.Forms.TextBox();
            this.txtCurrentQuantityChangeTo = new System.Windows.Forms.TextBox();
            this.txtInitialQuantityChangeTo = new System.Windows.Forms.TextBox();
            this.txtLastUseDateChangeTo = new System.Windows.Forms.TextBox();
            this.txtManufacturingDateChangeTo = new System.Windows.Forms.TextBox();
            this.txtManufacturingLotChangeTo = new System.Windows.Forms.TextBox();
            this.txtSerialNumberChangeTo = new System.Windows.Forms.TextBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(12, 31);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(145, 21);
            this.cboDevice.TabIndex = 0;
            // 
            // cboPrinterType
            // 
            this.cboPrinterType.FormattingEnabled = true;
            this.cboPrinterType.Location = new System.Drawing.Point(163, 31);
            this.cboPrinterType.Name = "cboPrinterType";
            this.cboPrinterType.Size = new System.Drawing.Size(118, 21);
            this.cboPrinterType.TabIndex = 1;
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(287, 28);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(75, 23);
            this.cmdRead.TabIndex = 2;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // txtEEPROMUID
            // 
            this.txtEEPROMUID.Enabled = false;
            this.txtEEPROMUID.Location = new System.Drawing.Point(368, 30);
            this.txtEEPROMUID.Name = "txtEEPROMUID";
            this.txtEEPROMUID.Size = new System.Drawing.Size(144, 20);
            this.txtEEPROMUID.TabIndex = 3;
            // 
            // txtKeyFragment
            // 
            this.txtKeyFragment.Enabled = false;
            this.txtKeyFragment.Location = new System.Drawing.Point(518, 30);
            this.txtKeyFragment.Name = "txtKeyFragment";
            this.txtKeyFragment.Size = new System.Drawing.Size(154, 20);
            this.txtKeyFragment.TabIndex = 4;
            // 
            // cboMaterialCurrent
            // 
            this.cboMaterialCurrent.Enabled = false;
            this.cboMaterialCurrent.FormattingEnabled = true;
            this.cboMaterialCurrent.Location = new System.Drawing.Point(24, 39);
            this.cboMaterialCurrent.Name = "cboMaterialCurrent";
            this.cboMaterialCurrent.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialCurrent.TabIndex = 5;
            // 
            // cboMaterialChangeTo
            // 
            this.cboMaterialChangeTo.FormattingEnabled = true;
            this.cboMaterialChangeTo.Location = new System.Drawing.Point(14, 39);
            this.cboMaterialChangeTo.Name = "cboMaterialChangeTo";
            this.cboMaterialChangeTo.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialChangeTo.TabIndex = 6;
            // 
            // txtSerialNumberCurrent
            // 
            this.txtSerialNumberCurrent.Enabled = false;
            this.txtSerialNumberCurrent.Location = new System.Drawing.Point(24, 13);
            this.txtSerialNumberCurrent.Name = "txtSerialNumberCurrent";
            this.txtSerialNumberCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtSerialNumberCurrent.TabIndex = 7;
            // 
            // txtManufacturingLotCurrent
            // 
            this.txtManufacturingLotCurrent.Enabled = false;
            this.txtManufacturingLotCurrent.Location = new System.Drawing.Point(24, 66);
            this.txtManufacturingLotCurrent.Name = "txtManufacturingLotCurrent";
            this.txtManufacturingLotCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingLotCurrent.TabIndex = 8;
            // 
            // txtManufacturingDateCurrent
            // 
            this.txtManufacturingDateCurrent.Enabled = false;
            this.txtManufacturingDateCurrent.Location = new System.Drawing.Point(24, 92);
            this.txtManufacturingDateCurrent.Name = "txtManufacturingDateCurrent";
            this.txtManufacturingDateCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingDateCurrent.TabIndex = 9;
            // 
            // txtLastUseDateCurrent
            // 
            this.txtLastUseDateCurrent.Enabled = false;
            this.txtLastUseDateCurrent.Location = new System.Drawing.Point(24, 118);
            this.txtLastUseDateCurrent.Name = "txtLastUseDateCurrent";
            this.txtLastUseDateCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtLastUseDateCurrent.TabIndex = 10;
            // 
            // txtInitialQuantityCurrent
            // 
            this.txtInitialQuantityCurrent.Enabled = false;
            this.txtInitialQuantityCurrent.Location = new System.Drawing.Point(24, 144);
            this.txtInitialQuantityCurrent.Name = "txtInitialQuantityCurrent";
            this.txtInitialQuantityCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtInitialQuantityCurrent.TabIndex = 11;
            // 
            // txtCurrentQuantityCurrent
            // 
            this.txtCurrentQuantityCurrent.Enabled = false;
            this.txtCurrentQuantityCurrent.Location = new System.Drawing.Point(24, 170);
            this.txtCurrentQuantityCurrent.Name = "txtCurrentQuantityCurrent";
            this.txtCurrentQuantityCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtCurrentQuantityCurrent.TabIndex = 12;
            // 
            // txtVersionCurrent
            // 
            this.txtVersionCurrent.Enabled = false;
            this.txtVersionCurrent.Location = new System.Drawing.Point(24, 196);
            this.txtVersionCurrent.Name = "txtVersionCurrent";
            this.txtVersionCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtVersionCurrent.TabIndex = 13;
            // 
            // txtSignatureCurrent
            // 
            this.txtSignatureCurrent.Enabled = false;
            this.txtSignatureCurrent.Location = new System.Drawing.Point(24, 222);
            this.txtSignatureCurrent.Name = "txtSignatureCurrent";
            this.txtSignatureCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtSignatureCurrent.TabIndex = 14;
            // 
            // txtSignatureChangeTo
            // 
            this.txtSignatureChangeTo.Location = new System.Drawing.Point(14, 222);
            this.txtSignatureChangeTo.Name = "txtSignatureChangeTo";
            this.txtSignatureChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtSignatureChangeTo.TabIndex = 22;
            // 
            // txtVersionChangeTo
            // 
            this.txtVersionChangeTo.Location = new System.Drawing.Point(14, 196);
            this.txtVersionChangeTo.Name = "txtVersionChangeTo";
            this.txtVersionChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtVersionChangeTo.TabIndex = 21;
            // 
            // txtCurrentQuantityChangeTo
            // 
            this.txtCurrentQuantityChangeTo.Location = new System.Drawing.Point(14, 170);
            this.txtCurrentQuantityChangeTo.Name = "txtCurrentQuantityChangeTo";
            this.txtCurrentQuantityChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtCurrentQuantityChangeTo.TabIndex = 20;
            // 
            // txtInitialQuantityChangeTo
            // 
            this.txtInitialQuantityChangeTo.Location = new System.Drawing.Point(14, 144);
            this.txtInitialQuantityChangeTo.Name = "txtInitialQuantityChangeTo";
            this.txtInitialQuantityChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtInitialQuantityChangeTo.TabIndex = 19;
            // 
            // txtLastUseDateChangeTo
            // 
            this.txtLastUseDateChangeTo.Location = new System.Drawing.Point(14, 118);
            this.txtLastUseDateChangeTo.Name = "txtLastUseDateChangeTo";
            this.txtLastUseDateChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtLastUseDateChangeTo.TabIndex = 18;
            // 
            // txtManufacturingDateChangeTo
            // 
            this.txtManufacturingDateChangeTo.Location = new System.Drawing.Point(14, 92);
            this.txtManufacturingDateChangeTo.Name = "txtManufacturingDateChangeTo";
            this.txtManufacturingDateChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingDateChangeTo.TabIndex = 17;
            // 
            // txtManufacturingLotChangeTo
            // 
            this.txtManufacturingLotChangeTo.Location = new System.Drawing.Point(14, 66);
            this.txtManufacturingLotChangeTo.Name = "txtManufacturingLotChangeTo";
            this.txtManufacturingLotChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingLotChangeTo.TabIndex = 16;
            // 
            // txtSerialNumberChangeTo
            // 
            this.txtSerialNumberChangeTo.Location = new System.Drawing.Point(14, 13);
            this.txtSerialNumberChangeTo.Name = "txtSerialNumberChangeTo";
            this.txtSerialNumberChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtSerialNumberChangeTo.TabIndex = 15;
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(581, 394);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(75, 23);
            this.cmdWrite.TabIndex = 23;
            this.cmdWrite.Text = "Write";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Printer Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "EEPROM UID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Key Fragment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Serial Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Manufacturing lot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Manufacturing Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Version:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Current Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Initial Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Last Use Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Signature:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Current Cartridge Values:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(484, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Change Cartridge Values To:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSerialNumberCurrent);
            this.panel1.Controls.Add(this.cboMaterialCurrent);
            this.panel1.Controls.Add(this.txtManufacturingLotCurrent);
            this.panel1.Controls.Add(this.txtManufacturingDateCurrent);
            this.panel1.Controls.Add(this.txtLastUseDateCurrent);
            this.panel1.Controls.Add(this.txtInitialQuantityCurrent);
            this.panel1.Controls.Add(this.txtCurrentQuantityCurrent);
            this.panel1.Controls.Add(this.txtVersionCurrent);
            this.panel1.Controls.Add(this.txtSignatureCurrent);
            this.panel1.Location = new System.Drawing.Point(261, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 265);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSerialNumberChangeTo);
            this.panel2.Controls.Add(this.cboMaterialChangeTo);
            this.panel2.Controls.Add(this.txtManufacturingLotChangeTo);
            this.panel2.Controls.Add(this.txtManufacturingDateChangeTo);
            this.panel2.Controls.Add(this.txtLastUseDateChangeTo);
            this.panel2.Controls.Add(this.txtInitialQuantityChangeTo);
            this.panel2.Controls.Add(this.txtCurrentQuantityChangeTo);
            this.panel2.Controls.Add(this.txtVersionChangeTo);
            this.panel2.Controls.Add(this.txtSignatureChangeTo);
            this.panel2.Location = new System.Drawing.Point(471, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 265);
            this.panel2.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.txtKeyFragment);
            this.Controls.Add(this.txtEEPROMUID);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.cboPrinterType);
            this.Controls.Add(this.cboDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CartridgeWriter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.ComboBox cboPrinterType;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.TextBox txtEEPROMUID;
        private System.Windows.Forms.TextBox txtKeyFragment;
        private System.Windows.Forms.ComboBox cboMaterialCurrent;
        private System.Windows.Forms.ComboBox cboMaterialChangeTo;
        private System.Windows.Forms.TextBox txtSerialNumberCurrent;
        private System.Windows.Forms.TextBox txtManufacturingLotCurrent;
        private System.Windows.Forms.TextBox txtManufacturingDateCurrent;
        private System.Windows.Forms.TextBox txtLastUseDateCurrent;
        private System.Windows.Forms.TextBox txtInitialQuantityCurrent;
        private System.Windows.Forms.TextBox txtCurrentQuantityCurrent;
        private System.Windows.Forms.TextBox txtVersionCurrent;
        private System.Windows.Forms.TextBox txtSignatureCurrent;
        private System.Windows.Forms.TextBox txtSignatureChangeTo;
        private System.Windows.Forms.TextBox txtVersionChangeTo;
        private System.Windows.Forms.TextBox txtCurrentQuantityChangeTo;
        private System.Windows.Forms.TextBox txtInitialQuantityChangeTo;
        private System.Windows.Forms.TextBox txtLastUseDateChangeTo;
        private System.Windows.Forms.TextBox txtManufacturingDateChangeTo;
        private System.Windows.Forms.TextBox txtManufacturingLotChangeTo;
        private System.Windows.Forms.TextBox txtSerialNumberChangeTo;
        private System.Windows.Forms.Button cmdWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

