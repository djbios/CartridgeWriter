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
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(12, 12);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(145, 21);
            this.cboDevice.TabIndex = 0;
            // 
            // cboPrinterType
            // 
            this.cboPrinterType.FormattingEnabled = true;
            this.cboPrinterType.Location = new System.Drawing.Point(163, 12);
            this.cboPrinterType.Name = "cboPrinterType";
            this.cboPrinterType.Size = new System.Drawing.Size(84, 21);
            this.cboPrinterType.TabIndex = 1;
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(253, 10);
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
            this.txtEEPROMUID.Location = new System.Drawing.Point(349, 12);
            this.txtEEPROMUID.Name = "txtEEPROMUID";
            this.txtEEPROMUID.Size = new System.Drawing.Size(100, 20);
            this.txtEEPROMUID.TabIndex = 3;
            // 
            // txtKeyFragment
            // 
            this.txtKeyFragment.Enabled = false;
            this.txtKeyFragment.Location = new System.Drawing.Point(468, 12);
            this.txtKeyFragment.Name = "txtKeyFragment";
            this.txtKeyFragment.Size = new System.Drawing.Size(100, 20);
            this.txtKeyFragment.TabIndex = 4;
            // 
            // cboMaterialCurrent
            // 
            this.cboMaterialCurrent.Enabled = false;
            this.cboMaterialCurrent.FormattingEnabled = true;
            this.cboMaterialCurrent.Location = new System.Drawing.Point(174, 99);
            this.cboMaterialCurrent.Name = "cboMaterialCurrent";
            this.cboMaterialCurrent.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialCurrent.TabIndex = 5;
            // 
            // cboMaterialChangeTo
            // 
            this.cboMaterialChangeTo.FormattingEnabled = true;
            this.cboMaterialChangeTo.Location = new System.Drawing.Point(349, 99);
            this.cboMaterialChangeTo.Name = "cboMaterialChangeTo";
            this.cboMaterialChangeTo.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialChangeTo.TabIndex = 6;
            // 
            // txtSerialNumberCurrent
            // 
            this.txtSerialNumberCurrent.Enabled = false;
            this.txtSerialNumberCurrent.Location = new System.Drawing.Point(174, 73);
            this.txtSerialNumberCurrent.Name = "txtSerialNumberCurrent";
            this.txtSerialNumberCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtSerialNumberCurrent.TabIndex = 7;
            // 
            // txtManufacturingLotCurrent
            // 
            this.txtManufacturingLotCurrent.Enabled = false;
            this.txtManufacturingLotCurrent.Location = new System.Drawing.Point(174, 126);
            this.txtManufacturingLotCurrent.Name = "txtManufacturingLotCurrent";
            this.txtManufacturingLotCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingLotCurrent.TabIndex = 8;
            // 
            // txtManufacturingDateCurrent
            // 
            this.txtManufacturingDateCurrent.Enabled = false;
            this.txtManufacturingDateCurrent.Location = new System.Drawing.Point(174, 152);
            this.txtManufacturingDateCurrent.Name = "txtManufacturingDateCurrent";
            this.txtManufacturingDateCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingDateCurrent.TabIndex = 9;
            // 
            // txtLastUseDateCurrent
            // 
            this.txtLastUseDateCurrent.Enabled = false;
            this.txtLastUseDateCurrent.Location = new System.Drawing.Point(174, 178);
            this.txtLastUseDateCurrent.Name = "txtLastUseDateCurrent";
            this.txtLastUseDateCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtLastUseDateCurrent.TabIndex = 10;
            // 
            // txtInitialQuantityCurrent
            // 
            this.txtInitialQuantityCurrent.Enabled = false;
            this.txtInitialQuantityCurrent.Location = new System.Drawing.Point(174, 204);
            this.txtInitialQuantityCurrent.Name = "txtInitialQuantityCurrent";
            this.txtInitialQuantityCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtInitialQuantityCurrent.TabIndex = 11;
            // 
            // txtCurrentQuantityCurrent
            // 
            this.txtCurrentQuantityCurrent.Enabled = false;
            this.txtCurrentQuantityCurrent.Location = new System.Drawing.Point(174, 230);
            this.txtCurrentQuantityCurrent.Name = "txtCurrentQuantityCurrent";
            this.txtCurrentQuantityCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtCurrentQuantityCurrent.TabIndex = 12;
            // 
            // txtVersionCurrent
            // 
            this.txtVersionCurrent.Enabled = false;
            this.txtVersionCurrent.Location = new System.Drawing.Point(174, 256);
            this.txtVersionCurrent.Name = "txtVersionCurrent";
            this.txtVersionCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtVersionCurrent.TabIndex = 13;
            // 
            // txtSignatureCurrent
            // 
            this.txtSignatureCurrent.Enabled = false;
            this.txtSignatureCurrent.Location = new System.Drawing.Point(174, 282);
            this.txtSignatureCurrent.Name = "txtSignatureCurrent";
            this.txtSignatureCurrent.Size = new System.Drawing.Size(145, 20);
            this.txtSignatureCurrent.TabIndex = 14;
            // 
            // txtSignatureChangeTo
            // 
            this.txtSignatureChangeTo.Location = new System.Drawing.Point(349, 282);
            this.txtSignatureChangeTo.Name = "txtSignatureChangeTo";
            this.txtSignatureChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtSignatureChangeTo.TabIndex = 22;
            // 
            // txtVersionChangeTo
            // 
            this.txtVersionChangeTo.Location = new System.Drawing.Point(349, 256);
            this.txtVersionChangeTo.Name = "txtVersionChangeTo";
            this.txtVersionChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtVersionChangeTo.TabIndex = 21;
            // 
            // txtCurrentQuantityChangeTo
            // 
            this.txtCurrentQuantityChangeTo.Location = new System.Drawing.Point(349, 230);
            this.txtCurrentQuantityChangeTo.Name = "txtCurrentQuantityChangeTo";
            this.txtCurrentQuantityChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtCurrentQuantityChangeTo.TabIndex = 20;
            // 
            // txtInitialQuantityChangeTo
            // 
            this.txtInitialQuantityChangeTo.Location = new System.Drawing.Point(349, 204);
            this.txtInitialQuantityChangeTo.Name = "txtInitialQuantityChangeTo";
            this.txtInitialQuantityChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtInitialQuantityChangeTo.TabIndex = 19;
            // 
            // txtLastUseDateChangeTo
            // 
            this.txtLastUseDateChangeTo.Location = new System.Drawing.Point(349, 178);
            this.txtLastUseDateChangeTo.Name = "txtLastUseDateChangeTo";
            this.txtLastUseDateChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtLastUseDateChangeTo.TabIndex = 18;
            // 
            // txtManufacturingDateChangeTo
            // 
            this.txtManufacturingDateChangeTo.Location = new System.Drawing.Point(349, 152);
            this.txtManufacturingDateChangeTo.Name = "txtManufacturingDateChangeTo";
            this.txtManufacturingDateChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingDateChangeTo.TabIndex = 17;
            // 
            // txtManufacturingLotChangeTo
            // 
            this.txtManufacturingLotChangeTo.Location = new System.Drawing.Point(349, 126);
            this.txtManufacturingLotChangeTo.Name = "txtManufacturingLotChangeTo";
            this.txtManufacturingLotChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtManufacturingLotChangeTo.TabIndex = 16;
            // 
            // txtSerialNumberChangeTo
            // 
            this.txtSerialNumberChangeTo.Location = new System.Drawing.Point(349, 73);
            this.txtSerialNumberChangeTo.Name = "txtSerialNumberChangeTo";
            this.txtSerialNumberChangeTo.Size = new System.Drawing.Size(145, 20);
            this.txtSerialNumberChangeTo.TabIndex = 15;
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(419, 318);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(75, 23);
            this.cmdWrite.TabIndex = 23;
            this.cmdWrite.Text = "Write";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 455);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.txtSignatureChangeTo);
            this.Controls.Add(this.txtVersionChangeTo);
            this.Controls.Add(this.txtCurrentQuantityChangeTo);
            this.Controls.Add(this.txtInitialQuantityChangeTo);
            this.Controls.Add(this.txtLastUseDateChangeTo);
            this.Controls.Add(this.txtManufacturingDateChangeTo);
            this.Controls.Add(this.txtManufacturingLotChangeTo);
            this.Controls.Add(this.txtSerialNumberChangeTo);
            this.Controls.Add(this.txtSignatureCurrent);
            this.Controls.Add(this.txtVersionCurrent);
            this.Controls.Add(this.txtCurrentQuantityCurrent);
            this.Controls.Add(this.txtInitialQuantityCurrent);
            this.Controls.Add(this.txtLastUseDateCurrent);
            this.Controls.Add(this.txtManufacturingDateCurrent);
            this.Controls.Add(this.txtManufacturingLotCurrent);
            this.Controls.Add(this.txtSerialNumberCurrent);
            this.Controls.Add(this.cboMaterialChangeTo);
            this.Controls.Add(this.cboMaterialCurrent);
            this.Controls.Add(this.txtKeyFragment);
            this.Controls.Add(this.txtEEPROMUID);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.cboPrinterType);
            this.Controls.Add(this.cboDevice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

