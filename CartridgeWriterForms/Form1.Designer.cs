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
            this.cboMaterialCurrent.FormattingEnabled = true;
            this.cboMaterialCurrent.Location = new System.Drawing.Point(183, 77);
            this.cboMaterialCurrent.Name = "cboMaterialCurrent";
            this.cboMaterialCurrent.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialCurrent.TabIndex = 5;
            // 
            // cboMaterialChangeTo
            // 
            this.cboMaterialChangeTo.FormattingEnabled = true;
            this.cboMaterialChangeTo.Location = new System.Drawing.Point(358, 77);
            this.cboMaterialChangeTo.Name = "cboMaterialChangeTo";
            this.cboMaterialChangeTo.Size = new System.Drawing.Size(145, 21);
            this.cboMaterialChangeTo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 455);
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
    }
}

