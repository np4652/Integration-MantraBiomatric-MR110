namespace MantraBioTimeSDK
{
    partial class FrmDevice
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
            this.pnlDeviceScreen = new System.Windows.Forms.Panel();
            this.tabDevice = new System.Windows.Forms.TabControl();
            this.tabMORX = new System.Windows.Forms.TabPage();
            this.lnkLblBIOTIMEMR110 = new System.Windows.Forms.LinkLabel();
            this.imgMR110 = new System.Windows.Forms.PictureBox();
            this.pnlDeviceScreen.SuspendLayout();
            this.tabDevice.SuspendLayout();
            this.tabMORX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMR110)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeviceScreen
            // 
            this.pnlDeviceScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeviceScreen.Controls.Add(this.tabDevice);
            this.pnlDeviceScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlDeviceScreen.Name = "pnlDeviceScreen";
            this.pnlDeviceScreen.Size = new System.Drawing.Size(930, 460);
            this.pnlDeviceScreen.TabIndex = 4;
            // 
            // tabDevice
            // 
            this.tabDevice.Controls.Add(this.tabMORX);
            this.tabDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDevice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDevice.Location = new System.Drawing.Point(0, 0);
            this.tabDevice.Margin = new System.Windows.Forms.Padding(0);
            this.tabDevice.Multiline = true;
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.SelectedIndex = 0;
            this.tabDevice.Size = new System.Drawing.Size(928, 458);
            this.tabDevice.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDevice.TabIndex = 3;
            // 
            // tabMORX
            // 
            this.tabMORX.BackColor = System.Drawing.Color.White;
            this.tabMORX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMORX.Controls.Add(this.lnkLblBIOTIMEMR110);
            this.tabMORX.Controls.Add(this.imgMR110);
            this.tabMORX.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMORX.ForeColor = System.Drawing.Color.White;
            this.tabMORX.Location = new System.Drawing.Point(4, 25);
            this.tabMORX.Name = "tabMORX";
            this.tabMORX.Size = new System.Drawing.Size(920, 429);
            this.tabMORX.TabIndex = 2;
            this.tabMORX.Text = "MORX";
            // 
            // lnkLblBIOTIMEMR110
            // 
            this.lnkLblBIOTIMEMR110.AutoSize = true;
            this.lnkLblBIOTIMEMR110.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblBIOTIMEMR110.Location = new System.Drawing.Point(386, 315);
            this.lnkLblBIOTIMEMR110.Name = "lnkLblBIOTIMEMR110";
            this.lnkLblBIOTIMEMR110.Size = new System.Drawing.Size(140, 18);
            this.lnkLblBIOTIMEMR110.TabIndex = 2;
            this.lnkLblBIOTIMEMR110.TabStop = true;
            this.lnkLblBIOTIMEMR110.Tag = "MORX";
            this.lnkLblBIOTIMEMR110.Text = "BIOTIME-MR110";
            this.lnkLblBIOTIMEMR110.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblBIOTIMEMR110_LinkClicked);
            // 
            // imgMR110
            // 
            this.imgMR110.BackgroundImage = global::MantraBioTimeSDK.Properties.Resources.BioTime___MR110;
            this.imgMR110.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMR110.Location = new System.Drawing.Point(301, 40);
            this.imgMR110.Name = "imgMR110";
            this.imgMR110.Size = new System.Drawing.Size(305, 270);
            this.imgMR110.TabIndex = 1;
            this.imgMR110.TabStop = false;
            // 
            // FrmDevice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlDeviceScreen);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDevice";
            this.Text = "FrmDevice";
            this.Load += new System.EventHandler(this.FrmDevice_Load);
            this.pnlDeviceScreen.ResumeLayout(false);
            this.tabDevice.ResumeLayout(false);
            this.tabMORX.ResumeLayout(false);
            this.tabMORX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMR110)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeviceScreen;
        private System.Windows.Forms.TabControl tabDevice;
        private System.Windows.Forms.TabPage tabMORX;
        private System.Windows.Forms.LinkLabel lnkLblBIOTIMEMR110;
        private System.Windows.Forms.PictureBox imgMR110;
    }
}