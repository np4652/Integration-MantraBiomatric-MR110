namespace MantraBioTimeSDK
{
    partial class FrmLogDataManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLogDataManagement = new System.Windows.Forms.Panel();
            this.grpLogDataManagement = new System.Windows.Forms.GroupBox();
            this.dgvLogData = new System.Windows.Forms.DataGridView();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.btnSyncData = new System.Windows.Forms.Button();
            this.btnTimePeriodLogData = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAllLogData = new System.Windows.Forms.Button();
            this.btnReadAllLogData = new System.Windows.Forms.Button();
            this.btnReadNewLogData = new System.Windows.Forms.Button();
            this.pnlLogDataManagement.SuspendLayout();
            this.grpLogDataManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogData)).BeginInit();
            this.grpUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogDataManagement
            // 
            this.pnlLogDataManagement.Controls.Add(this.grpLogDataManagement);
            this.pnlLogDataManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogDataManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlLogDataManagement.Name = "pnlLogDataManagement";
            this.pnlLogDataManagement.Size = new System.Drawing.Size(1129, 449);
            this.pnlLogDataManagement.TabIndex = 1;
            // 
            // grpLogDataManagement
            // 
            this.grpLogDataManagement.Controls.Add(this.dgvLogData);
            this.grpLogDataManagement.Controls.Add(this.grpUserInfo);
            this.grpLogDataManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLogDataManagement.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogDataManagement.Location = new System.Drawing.Point(0, 0);
            this.grpLogDataManagement.Name = "grpLogDataManagement";
            this.grpLogDataManagement.Size = new System.Drawing.Size(1129, 449);
            this.grpLogDataManagement.TabIndex = 3;
            this.grpLogDataManagement.TabStop = false;
            this.grpLogDataManagement.Text = "Log Data Management";
            // 
            // dgvLogData
            // 
            this.dgvLogData.AllowUserToAddRows = false;
            this.dgvLogData.AllowUserToOrderColumns = true;
            this.dgvLogData.AllowUserToResizeRows = false;
            this.dgvLogData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogData.Location = new System.Drawing.Point(3, 68);
            this.dgvLogData.MultiSelect = false;
            this.dgvLogData.Name = "dgvLogData";
            this.dgvLogData.ReadOnly = true;
            this.dgvLogData.RowHeadersWidth = 20;
            this.dgvLogData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLogData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogData.RowTemplate.Height = 23;
            this.dgvLogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogData.Size = new System.Drawing.Size(1123, 378);
            this.dgvLogData.TabIndex = 98;
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.btnSyncData);
            this.grpUserInfo.Controls.Add(this.btnTimePeriodLogData);
            this.grpUserInfo.Controls.Add(this.dtpToDate);
            this.grpUserInfo.Controls.Add(this.dtpFromDate);
            this.grpUserInfo.Controls.Add(this.btnDeleteAllLogData);
            this.grpUserInfo.Controls.Add(this.btnReadAllLogData);
            this.grpUserInfo.Controls.Add(this.btnReadNewLogData);
            this.grpUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUserInfo.Location = new System.Drawing.Point(3, 18);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(1123, 50);
            this.grpUserInfo.TabIndex = 83;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Read Log Data";
            // 
            // btnSyncData
            // 
            this.btnSyncData.BackColor = System.Drawing.Color.IndianRed;
            this.btnSyncData.FlatAppearance.BorderSize = 0;
            this.btnSyncData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncData.Location = new System.Drawing.Point(443, 20);
            this.btnSyncData.Name = "btnSyncData";
            this.btnSyncData.Size = new System.Drawing.Size(142, 23);
            this.btnSyncData.TabIndex = 112;
            this.btnSyncData.Text = "Sync Data";
            this.btnSyncData.UseVisualStyleBackColor = false;
            this.btnSyncData.Click += new System.EventHandler(this.btnSyncData_Click);
            // 
            // btnTimePeriodLogData
            // 
            this.btnTimePeriodLogData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimePeriodLogData.FlatAppearance.BorderSize = 0;
            this.btnTimePeriodLogData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimePeriodLogData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimePeriodLogData.Location = new System.Drawing.Point(38, 21);
            this.btnTimePeriodLogData.Name = "btnTimePeriodLogData";
            this.btnTimePeriodLogData.Size = new System.Drawing.Size(125, 23);
            this.btnTimePeriodLogData.TabIndex = 111;
            this.btnTimePeriodLogData.Text = "Time Period Log";
            this.btnTimePeriodLogData.UseVisualStyleBackColor = false;
            this.btnTimePeriodLogData.Click += new System.EventHandler(this.btnTimePeriodLogData_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(204, 21);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(124, 22);
            this.dtpToDate.TabIndex = 1;
            this.dtpToDate.Visible = false;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(53, 21);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(124, 22);
            this.dtpFromDate.TabIndex = 107;
            this.dtpFromDate.Value = new System.DateTime(2019, 12, 27, 10, 11, 13, 0);
            this.dtpFromDate.Visible = false;
            // 
            // btnDeleteAllLogData
            // 
            this.btnDeleteAllLogData.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteAllLogData.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllLogData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllLogData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllLogData.Location = new System.Drawing.Point(346, 21);
            this.btnDeleteAllLogData.Name = "btnDeleteAllLogData";
            this.btnDeleteAllLogData.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteAllLogData.TabIndex = 72;
            this.btnDeleteAllLogData.Text = "Delete Log";
            this.btnDeleteAllLogData.UseVisualStyleBackColor = false;
            this.btnDeleteAllLogData.Click += new System.EventHandler(this.btnDeleteAllLogData_Click);
            // 
            // btnReadAllLogData
            // 
            this.btnReadAllLogData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReadAllLogData.FlatAppearance.BorderSize = 0;
            this.btnReadAllLogData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadAllLogData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAllLogData.Location = new System.Drawing.Point(258, 20);
            this.btnReadAllLogData.Name = "btnReadAllLogData";
            this.btnReadAllLogData.Size = new System.Drawing.Size(82, 23);
            this.btnReadAllLogData.TabIndex = 71;
            this.btnReadAllLogData.Text = "All Log";
            this.btnReadAllLogData.UseVisualStyleBackColor = false;
            this.btnReadAllLogData.Click += new System.EventHandler(this.btnReadAllLogData_Click);
            // 
            // btnReadNewLogData
            // 
            this.btnReadNewLogData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReadNewLogData.FlatAppearance.BorderSize = 0;
            this.btnReadNewLogData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadNewLogData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadNewLogData.Location = new System.Drawing.Point(169, 21);
            this.btnReadNewLogData.Name = "btnReadNewLogData";
            this.btnReadNewLogData.Size = new System.Drawing.Size(83, 23);
            this.btnReadNewLogData.TabIndex = 100;
            this.btnReadNewLogData.Text = "New Log";
            this.btnReadNewLogData.UseVisualStyleBackColor = false;
            this.btnReadNewLogData.Click += new System.EventHandler(this.btnReadNewLogData_Click);
            // 
            // FrmLogDataManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 449);
            this.Controls.Add(this.pnlLogDataManagement);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogDataManagement";
            this.Text = "FrmLogDataManagement";
            this.pnlLogDataManagement.ResumeLayout(false);
            this.grpLogDataManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogData)).EndInit();
            this.grpUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogDataManagement;
        private System.Windows.Forms.GroupBox grpLogDataManagement;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Button btnReadAllLogData;
        private System.Windows.Forms.Button btnReadNewLogData;
        private System.Windows.Forms.Button btnDeleteAllLogData;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnTimePeriodLogData;
        private System.Windows.Forms.DataGridView dgvLogData;
        private System.Windows.Forms.Button btnSyncData;
    }
}