using System;

namespace MantraBioTimeSDK
{
    partial class FrmUserDataManagement
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
            this.pnlUserDataManagement = new System.Windows.Forms.Panel();
            this.grpUserDataManagement = new System.Windows.Forms.GroupBox();
            this.tabAddUser = new System.Windows.Forms.TabControl();
            this.tabAddUserMain = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorEmail = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPhone = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAdhaar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.grpVerifyStyle = new System.Windows.Forms.GroupBox();
            this.txtUserID3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVerifyStyle = new System.Windows.Forms.ComboBox();
            this.btSetUserVerifyStyl = new System.Windows.Forms.Button();
            this.btGetUserVerifyStyle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbUserEnable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbPrivilege = new System.Windows.Forms.ComboBox();
            this.txtCardnumber = new System.Windows.Forms.TextBox();
            this.Privilege = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabMainUserEnrollData = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBioUsers = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrivilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInputNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemplate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsEnable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAllEnrollData = new System.Windows.Forms.Button();
            this.btnDeleteEnrollData = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSetAllUserEnrollData = new System.Windows.Forms.Button();
            this.btnGetAllUserEnrollData = new System.Windows.Forms.Button();
            this.btnSetUserEnrollData = new System.Windows.Forms.Button();
            this.btnGetUserEnrollData = new System.Windows.Forms.Button();
            this.txtDBDUserID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabAction = new System.Windows.Forms.TabPage();
            this.grpValidDate = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.btn_ReactiveUser = new System.Windows.Forms.Button();
            this.btn_DeleteExpiredSubscription = new System.Windows.Forms.Button();
            this.pnlUserDataManagement.SuspendLayout();
            this.grpUserDataManagement.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.tabAddUserMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpVerifyStyle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabMainUserEnrollData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAction.SuspendLayout();
            this.grpValidDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserDataManagement
            // 
            this.pnlUserDataManagement.Controls.Add(this.grpUserDataManagement);
            this.pnlUserDataManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserDataManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlUserDataManagement.Name = "pnlUserDataManagement";
            this.pnlUserDataManagement.Size = new System.Drawing.Size(930, 460);
            this.pnlUserDataManagement.TabIndex = 0;
            // 
            // grpUserDataManagement
            // 
            this.grpUserDataManagement.Controls.Add(this.tabAddUser);
            this.grpUserDataManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDataManagement.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserDataManagement.Location = new System.Drawing.Point(0, 0);
            this.grpUserDataManagement.Name = "grpUserDataManagement";
            this.grpUserDataManagement.Size = new System.Drawing.Size(930, 460);
            this.grpUserDataManagement.TabIndex = 3;
            this.grpUserDataManagement.TabStop = false;
            this.grpUserDataManagement.Text = "User Data Management";
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.tabAddUserMain);
            this.tabAddUser.Controls.Add(this.tabMainUserEnrollData);
            this.tabAddUser.Controls.Add(this.tabAction);
            this.tabAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAddUser.Location = new System.Drawing.Point(3, 18);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.SelectedIndex = 0;
            this.tabAddUser.Size = new System.Drawing.Size(924, 439);
            this.tabAddUser.TabIndex = 0;
            this.tabAddUser.SelectedIndexChanged += new System.EventHandler(this.tabUserDataManagement_SelectedIndexChanged);
            // 
            // tabAddUserMain
            // 
            this.tabAddUserMain.Controls.Add(this.groupBox4);
            this.tabAddUserMain.Controls.Add(this.grpVerifyStyle);
            this.tabAddUserMain.Controls.Add(this.groupBox3);
            this.tabAddUserMain.Location = new System.Drawing.Point(4, 23);
            this.tabAddUserMain.Name = "tabAddUserMain";
            this.tabAddUserMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUserMain.Size = new System.Drawing.Size(916, 412);
            this.tabAddUserMain.TabIndex = 2;
            this.tabAddUserMain.Text = "Add User";
            this.tabAddUserMain.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.errorEmail);
            this.groupBox4.Controls.Add(this.txtDOB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.errorPhone);
            this.groupBox4.Controls.Add(this.errorName);
            this.groupBox4.Controls.Add(this.cbGender);
            this.groupBox4.Controls.Add(this.cbMaritalStatus);
            this.groupBox4.Controls.Add(this.cbMembershipType);
            this.groupBox4.Controls.Add(this.btnAddNewUser);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtOccupation);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtAdhaar);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtPhoneNumber);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtUName);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(20, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 382);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add User";
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.Location = new System.Drawing.Point(62, 81);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(73, 14);
            this.errorEmail.TabIndex = 91;
            this.errorEmail.Text = "(Required)";
            // 
            // txtDOB
            // 
            this.txtDOB.CustomFormat = "dd MMM yyyy";
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDOB.Location = new System.Drawing.Point(15, 162);
            this.txtDOB.MaxDate = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            this.txtDOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(200, 22);
            this.txtDOB.TabIndex = 90;
            this.txtDOB.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(519, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 89;
            this.label1.Text = "(Required)";
            // 
            // errorPhone
            // 
            this.errorPhone.AutoSize = true;
            this.errorPhone.ForeColor = System.Drawing.Color.Red;
            this.errorPhone.Location = new System.Drawing.Point(337, 22);
            this.errorPhone.Name = "errorPhone";
            this.errorPhone.Size = new System.Drawing.Size(73, 14);
            this.errorPhone.TabIndex = 88;
            this.errorPhone.Text = "(Required)";
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(61, 22);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(73, 14);
            this.errorName.TabIndex = 87;
            this.errorName.Text = "(Required)";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(240, 103);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(207, 22);
            this.cbGender.TabIndex = 86;
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Location = new System.Drawing.Point(240, 219);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(207, 22);
            this.cbMaritalStatus.TabIndex = 85;
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Location = new System.Drawing.Point(15, 280);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(213, 22);
            this.cbMembershipType.TabIndex = 84;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddNewUser.Location = new System.Drawing.Point(324, 333);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(127, 39);
            this.btnAddNewUser.TabIndex = 83;
            this.btnAddNewUser.Text = "ADD";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 14);
            this.label12.TabIndex = 82;
            this.label12.Text = "Membership Type";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(241, 280);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 22);
            this.txtAddress.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(238, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 14);
            this.label13.TabIndex = 80;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(238, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 14);
            this.label14.TabIndex = 79;
            this.label14.Text = "Marital Status";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(15, 219);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(213, 22);
            this.txtOccupation.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(12, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 14);
            this.label16.TabIndex = 77;
            this.label16.Text = "Occupation";
            // 
            // txtAdhaar
            // 
            this.txtAdhaar.Location = new System.Drawing.Point(240, 162);
            this.txtAdhaar.Name = "txtAdhaar";
            this.txtAdhaar.Size = new System.Drawing.Size(207, 22);
            this.txtAdhaar.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(238, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 14);
            this.label17.TabIndex = 75;
            this.label17.Text = "Adhaar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(12, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 14);
            this.label18.TabIndex = 74;
            this.label18.Text = "DOB";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 22);
            this.txtEmail.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(12, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 14);
            this.label19.TabIndex = 72;
            this.label19.Text = "E-Mail";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(241, 43);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(206, 22);
            this.txtPhoneNumber.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(238, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 14);
            this.label20.TabIndex = 70;
            this.label20.Text = "Phone Number";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(238, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 14);
            this.label21.TabIndex = 69;
            this.label21.Text = "Gender";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(15, 43);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(213, 22);
            this.txtUName.TabIndex = 68;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(12, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 14);
            this.label22.TabIndex = 67;
            this.label22.Text = "Name";
            // 
            // grpVerifyStyle
            // 
            this.grpVerifyStyle.Controls.Add(this.txtUserID3);
            this.grpVerifyStyle.Controls.Add(this.label7);
            this.grpVerifyStyle.Controls.Add(this.label6);
            this.grpVerifyStyle.Controls.Add(this.cbVerifyStyle);
            this.grpVerifyStyle.Controls.Add(this.btSetUserVerifyStyl);
            this.grpVerifyStyle.Controls.Add(this.btGetUserVerifyStyle);
            this.grpVerifyStyle.Location = new System.Drawing.Point(514, 260);
            this.grpVerifyStyle.Name = "grpVerifyStyle";
            this.grpVerifyStyle.Size = new System.Drawing.Size(387, 129);
            this.grpVerifyStyle.TabIndex = 85;
            this.grpVerifyStyle.TabStop = false;
            this.grpVerifyStyle.Text = "VerifyStyle";
            // 
            // txtUserID3
            // 
            this.txtUserID3.Location = new System.Drawing.Point(108, 21);
            this.txtUserID3.Name = "txtUserID3";
            this.txtUserID3.Size = new System.Drawing.Size(257, 22);
            this.txtUserID3.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(23, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 110;
            this.label7.Text = "Vefiry Style:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(50, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 109;
            this.label6.Text = "User ID";
            // 
            // cbVerifyStyle
            // 
            this.cbVerifyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerifyStyle.FormattingEnabled = true;
            this.cbVerifyStyle.Items.AddRange(new object[] {
            "Group Verify",
            "FP/PW/RF",
            "FP",
            "PIN\t",
            "PW",
            "RF",
            "FP/PW",
            "FP/RF",
            "PW/RF",
            "PIN&FP",
            "FP&PW",
            "FP&RF\t",
            "PW&RF",
            "FP&PW&RF",
            "PIN&FP&PW",
            "FP&RF/PIN"});
            this.cbVerifyStyle.Location = new System.Drawing.Point(108, 62);
            this.cbVerifyStyle.Name = "cbVerifyStyle";
            this.cbVerifyStyle.Size = new System.Drawing.Size(257, 22);
            this.cbVerifyStyle.TabIndex = 93;
            // 
            // btSetUserVerifyStyl
            // 
            this.btSetUserVerifyStyl.BackColor = System.Drawing.Color.SteelBlue;
            this.btSetUserVerifyStyl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetUserVerifyStyl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btSetUserVerifyStyl.Location = new System.Drawing.Point(61, 98);
            this.btSetUserVerifyStyl.Name = "btSetUserVerifyStyl";
            this.btSetUserVerifyStyl.Size = new System.Drawing.Size(156, 25);
            this.btSetUserVerifyStyl.TabIndex = 91;
            this.btSetUserVerifyStyl.Text = "SetUserVerifyStyle";
            this.btSetUserVerifyStyl.UseVisualStyleBackColor = false;
            this.btSetUserVerifyStyl.Click += new System.EventHandler(this.btSetUserVerifyStyl_Click);
            // 
            // btGetUserVerifyStyle
            // 
            this.btGetUserVerifyStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.btGetUserVerifyStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetUserVerifyStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btGetUserVerifyStyle.Location = new System.Drawing.Point(223, 98);
            this.btGetUserVerifyStyle.Name = "btGetUserVerifyStyle";
            this.btGetUserVerifyStyle.Size = new System.Drawing.Size(156, 25);
            this.btGetUserVerifyStyle.TabIndex = 90;
            this.btGetUserVerifyStyle.Text = "GetUserVerifyStyle";
            this.btGetUserVerifyStyle.UseVisualStyleBackColor = false;
            this.btGetUserVerifyStyle.Click += new System.EventHandler(this.btGetUserVerifyStyle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbUserEnable);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnGetUserInfo);
            this.groupBox3.Controls.Add(this.txtUserID);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.cbPrivilege);
            this.groupBox3.Controls.Add(this.txtCardnumber);
            this.groupBox3.Controls.Add(this.Privilege);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(514, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 241);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload the Card Number(part of users information)";
            // 
            // cbUserEnable
            // 
            this.cbUserEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserEnable.FormattingEnabled = true;
            this.cbUserEnable.Items.AddRange(new object[] {
            "0 - disable",
            "1 - enable"});
            this.cbUserEnable.Location = new System.Drawing.Point(215, 172);
            this.cbUserEnable.Name = "cbUserEnable";
            this.cbUserEnable.Size = new System.Drawing.Size(156, 22);
            this.cbUserEnable.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(212, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 72;
            this.label3.Text = "User Enable";
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetUserInfo.FlatAppearance.BorderSize = 0;
            this.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUserInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserInfo.Location = new System.Drawing.Point(274, 212);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(97, 23);
            this.btnGetUserInfo.TabIndex = 70;
            this.btnGetUserInfo.Text = "GetUserInfo";
            this.btnGetUserInfo.UseVisualStyleBackColor = false;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(16, 53);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(177, 22);
            this.txtUserID.TabIndex = 56;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 51);
            this.txtName.MaxLength = 24;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(212, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 64;
            this.label5.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 172);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 22);
            this.txtPassword.TabIndex = 58;
            // 
            // cbPrivilege
            // 
            this.cbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivilege.FormattingEnabled = true;
            this.cbPrivilege.Location = new System.Drawing.Point(16, 118);
            this.cbPrivilege.Name = "cbPrivilege";
            this.cbPrivilege.Size = new System.Drawing.Size(177, 22);
            this.cbPrivilege.TabIndex = 59;
            // 
            // txtCardnumber
            // 
            this.txtCardnumber.Location = new System.Drawing.Point(215, 118);
            this.txtCardnumber.MaxLength = 24;
            this.txtCardnumber.Name = "txtCardnumber";
            this.txtCardnumber.Size = new System.Drawing.Size(159, 22);
            this.txtCardnumber.TabIndex = 61;
            // 
            // Privilege
            // 
            this.Privilege.AutoSize = true;
            this.Privilege.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Privilege.Location = new System.Drawing.Point(13, 90);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(60, 14);
            this.Privilege.TabIndex = 65;
            this.Privilege.Text = "Privilege";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(212, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 14);
            this.label9.TabIndex = 66;
            this.label9.Text = "CardNumber";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(13, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 68;
            this.label11.Text = "Password";
            // 
            // tabMainUserEnrollData
            // 
            this.tabMainUserEnrollData.Controls.Add(this.groupBox2);
            this.tabMainUserEnrollData.Controls.Add(this.groupBox1);
            this.tabMainUserEnrollData.Location = new System.Drawing.Point(4, 23);
            this.tabMainUserEnrollData.Name = "tabMainUserEnrollData";
            this.tabMainUserEnrollData.Size = new System.Drawing.Size(916, 412);
            this.tabMainUserEnrollData.TabIndex = 1;
            this.tabMainUserEnrollData.Text = "User Enrolled Data";
            this.tabMainUserEnrollData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBioUsers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 343);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User BioData";
            // 
            // listBioUsers
            // 
            this.listBioUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colUserID,
            this.colName,
            this.colPwd,
            this.colCard,
            this.colPrivilege,
            this.colInputNo,
            this.colTemplate,
            this.colIsEnable});
            this.listBioUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBioUsers.GridLines = true;
            this.listBioUsers.HideSelection = false;
            this.listBioUsers.LabelEdit = true;
            this.listBioUsers.Location = new System.Drawing.Point(3, 18);
            this.listBioUsers.Name = "listBioUsers";
            this.listBioUsers.Size = new System.Drawing.Size(910, 322);
            this.listBioUsers.TabIndex = 0;
            this.listBioUsers.UseCompatibleStateImageBehavior = false;
            this.listBioUsers.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            // 
            // colUserID
            // 
            this.colUserID.Text = "UserId";
            // 
            // colName
            // 
            this.colName.Text = "UserName";
            this.colName.Width = 107;
            // 
            // colPwd
            // 
            this.colPwd.Text = "Password";
            this.colPwd.Width = 125;
            // 
            // colCard
            // 
            this.colCard.Text = "Card No.";
            this.colCard.Width = 104;
            // 
            // colPrivilege
            // 
            this.colPrivilege.Text = "Privilege";
            this.colPrivilege.Width = 79;
            // 
            // colInputNo
            // 
            this.colInputNo.Text = "InputNo";
            this.colInputNo.Width = 79;
            // 
            // colTemplate
            // 
            this.colTemplate.Text = "Template";
            this.colTemplate.Width = 200;
            // 
            // colIsEnable
            // 
            this.colIsEnable.Text = "IsEnabled";
            this.colIsEnable.Width = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAllEnrollData);
            this.groupBox1.Controls.Add(this.btnDeleteEnrollData);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnSetAllUserEnrollData);
            this.groupBox1.Controls.Add(this.btnGetAllUserEnrollData);
            this.groupBox1.Controls.Add(this.btnSetUserEnrollData);
            this.groupBox1.Controls.Add(this.btnGetUserEnrollData);
            this.groupBox1.Controls.Add(this.txtDBDUserID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 69);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Biometrics Data";
            // 
            // btnDeleteAllEnrollData
            // 
            this.btnDeleteAllEnrollData.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteAllEnrollData.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllEnrollData.Location = new System.Drawing.Point(738, 43);
            this.btnDeleteAllEnrollData.Name = "btnDeleteAllEnrollData";
            this.btnDeleteAllEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteAllEnrollData.TabIndex = 98;
            this.btnDeleteAllEnrollData.Text = "DeleteAllEnrollData";
            this.btnDeleteAllEnrollData.UseVisualStyleBackColor = false;
            this.btnDeleteAllEnrollData.Click += new System.EventHandler(this.btnDeleteAllEnrollData_Click);
            // 
            // btnDeleteEnrollData
            // 
            this.btnDeleteEnrollData.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteEnrollData.FlatAppearance.BorderSize = 0;
            this.btnDeleteEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEnrollData.Location = new System.Drawing.Point(390, 43);
            this.btnDeleteEnrollData.Name = "btnDeleteEnrollData";
            this.btnDeleteEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteEnrollData.TabIndex = 97;
            this.btnDeleteEnrollData.Text = "DeleteEnrollData";
            this.btnDeleteEnrollData.UseVisualStyleBackColor = false;
            this.btnDeleteEnrollData.Click += new System.EventHandler(this.btnDeleteEnrollData_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label15.Location = new System.Drawing.Point(5, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(385, 14);
            this.label15.TabIndex = 96;
            this.label15.Text = "--> (0-9:FP, 11:Card, 10 or 15:Pwd, 17:Face, 51 Photo)";
            // 
            // btnSetAllUserEnrollData
            // 
            this.btnSetAllUserEnrollData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetAllUserEnrollData.FlatAppearance.BorderSize = 0;
            this.btnSetAllUserEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAllUserEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAllUserEnrollData.Location = new System.Drawing.Point(738, 17);
            this.btnSetAllUserEnrollData.Name = "btnSetAllUserEnrollData";
            this.btnSetAllUserEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnSetAllUserEnrollData.TabIndex = 75;
            this.btnSetAllUserEnrollData.Text = "SetAllUserEnrollData";
            this.btnSetAllUserEnrollData.UseVisualStyleBackColor = false;
            this.btnSetAllUserEnrollData.Click += new System.EventHandler(this.btnSetAllUserEnrollData_Click);
            // 
            // btnGetAllUserEnrollData
            // 
            this.btnGetAllUserEnrollData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetAllUserEnrollData.FlatAppearance.BorderSize = 0;
            this.btnGetAllUserEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllUserEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllUserEnrollData.Location = new System.Drawing.Point(564, 17);
            this.btnGetAllUserEnrollData.Name = "btnGetAllUserEnrollData";
            this.btnGetAllUserEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnGetAllUserEnrollData.TabIndex = 74;
            this.btnGetAllUserEnrollData.Text = "GetAllUserEnrollData";
            this.btnGetAllUserEnrollData.UseVisualStyleBackColor = false;
            this.btnGetAllUserEnrollData.Click += new System.EventHandler(this.btnGetAllUserEnrollData_Click);
            // 
            // btnSetUserEnrollData
            // 
            this.btnSetUserEnrollData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetUserEnrollData.FlatAppearance.BorderSize = 0;
            this.btnSetUserEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUserEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUserEnrollData.Location = new System.Drawing.Point(390, 17);
            this.btnSetUserEnrollData.Name = "btnSetUserEnrollData";
            this.btnSetUserEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnSetUserEnrollData.TabIndex = 71;
            this.btnSetUserEnrollData.Text = "SetUserEnrollData";
            this.btnSetUserEnrollData.UseVisualStyleBackColor = false;
            this.btnSetUserEnrollData.Click += new System.EventHandler(this.btnSetUserEnrollData_Click);
            // 
            // btnGetUserEnrollData
            // 
            this.btnGetUserEnrollData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetUserEnrollData.FlatAppearance.BorderSize = 0;
            this.btnGetUserEnrollData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUserEnrollData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserEnrollData.Location = new System.Drawing.Point(216, 17);
            this.btnGetUserEnrollData.Name = "btnGetUserEnrollData";
            this.btnGetUserEnrollData.Size = new System.Drawing.Size(168, 23);
            this.btnGetUserEnrollData.TabIndex = 70;
            this.btnGetUserEnrollData.Text = "GetUserEnrollData";
            this.btnGetUserEnrollData.UseVisualStyleBackColor = false;
            this.btnGetUserEnrollData.Click += new System.EventHandler(this.btnGetUserEnrollData_Click);
            // 
            // txtDBDUserID
            // 
            this.txtDBDUserID.Location = new System.Drawing.Point(76, 18);
            this.txtDBDUserID.Name = "txtDBDUserID";
            this.txtDBDUserID.Size = new System.Drawing.Size(129, 22);
            this.txtDBDUserID.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(19, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 63;
            this.label10.Text = "User ID";
            // 
            // tabAction
            // 
            this.tabAction.Controls.Add(this.grpValidDate);
            this.tabAction.Location = new System.Drawing.Point(4, 23);
            this.tabAction.Name = "tabAction";
            this.tabAction.Padding = new System.Windows.Forms.Padding(3);
            this.tabAction.Size = new System.Drawing.Size(916, 412);
            this.tabAction.TabIndex = 3;
            this.tabAction.Text = "Action";
            this.tabAction.UseVisualStyleBackColor = true;
            // 
            // grpValidDate
            // 
            this.grpValidDate.Controls.Add(this.btnDeleteUser);
            this.grpValidDate.Controls.Add(this.label2);
            this.grpValidDate.Controls.Add(this.txtUID);
            this.grpValidDate.Controls.Add(this.btn_ReactiveUser);
            this.grpValidDate.Controls.Add(this.btn_DeleteExpiredSubscription);
            this.grpValidDate.Location = new System.Drawing.Point(254, 129);
            this.grpValidDate.Name = "grpValidDate";
            this.grpValidDate.Size = new System.Drawing.Size(393, 155);
            this.grpValidDate.TabIndex = 84;
            this.grpValidDate.TabStop = false;
            this.grpValidDate.Text = "Actions";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.Location = new System.Drawing.Point(201, 84);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(121, 25);
            this.btnDeleteUser.TabIndex = 99;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "UserId";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(68, 53);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(254, 22);
            this.txtUID.TabIndex = 97;
            // 
            // btn_ReactiveUser
            // 
            this.btn_ReactiveUser.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ReactiveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReactiveUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ReactiveUser.Location = new System.Drawing.Point(68, 84);
            this.btn_ReactiveUser.Name = "btn_ReactiveUser";
            this.btn_ReactiveUser.Size = new System.Drawing.Size(121, 25);
            this.btn_ReactiveUser.TabIndex = 96;
            this.btn_ReactiveUser.Text = "Re-Active";
            this.btn_ReactiveUser.UseVisualStyleBackColor = false;
            this.btn_ReactiveUser.Click += new System.EventHandler(this.btn_ReactiveUser_Click);
            // 
            // btn_DeleteExpiredSubscription
            // 
            this.btn_DeleteExpiredSubscription.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_DeleteExpiredSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteExpiredSubscription.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteExpiredSubscription.Location = new System.Drawing.Point(68, 115);
            this.btn_DeleteExpiredSubscription.Name = "btn_DeleteExpiredSubscription";
            this.btn_DeleteExpiredSubscription.Size = new System.Drawing.Size(254, 25);
            this.btn_DeleteExpiredSubscription.TabIndex = 95;
            this.btn_DeleteExpiredSubscription.Text = "Disable All Expired Subscription";
            this.btn_DeleteExpiredSubscription.UseVisualStyleBackColor = false;
            this.btn_DeleteExpiredSubscription.Click += new System.EventHandler(this.btn_DeleteExpiredSubscription_Click);
            // 
            // FrmUserDataManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlUserDataManagement);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserDataManagement";
            this.Text = "FrmUserDataManagement";
            this.Load += new System.EventHandler(this.FrmUserDataManagement_Load);
            this.pnlUserDataManagement.ResumeLayout(false);
            this.grpUserDataManagement.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUserMain.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpVerifyStyle.ResumeLayout(false);
            this.grpVerifyStyle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabMainUserEnrollData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAction.ResumeLayout(false);
            this.grpValidDate.ResumeLayout(false);
            this.grpValidDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserDataManagement;
        private System.Windows.Forms.GroupBox grpUserDataManagement;
        private System.Windows.Forms.TabControl tabAddUser;
        private System.Windows.Forms.TabPage tabMainUserEnrollData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetUserEnrollData;
        private System.Windows.Forms.Button btnGetUserEnrollData;
        private System.Windows.Forms.TextBox txtDBDUserID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSetAllUserEnrollData;
        private System.Windows.Forms.Button btnGetAllUserEnrollData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listBioUsers;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPwd;
        private System.Windows.Forms.ColumnHeader colCard;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colPrivilege;
        private System.Windows.Forms.ColumnHeader colInputNo;
        private System.Windows.Forms.ColumnHeader colIsEnable;
        private System.Windows.Forms.ColumnHeader colTemplate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDeleteAllEnrollData;
        private System.Windows.Forms.Button btnDeleteEnrollData;
        private System.Windows.Forms.TabPage tabAddUserMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbUserEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbPrivilege;
        private System.Windows.Forms.TextBox txtCardnumber;
        private System.Windows.Forms.Label Privilege;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpVerifyStyle;
        private System.Windows.Forms.TextBox txtUserID3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVerifyStyle;
        private System.Windows.Forms.Button btSetUserVerifyStyl;
        private System.Windows.Forms.Button btGetUserVerifyStyle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorPhone;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.ComboBox cbMembershipType;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdhaar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.TabPage tabAction;
        private System.Windows.Forms.GroupBox grpValidDate;
        public System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Button btn_ReactiveUser;
        public System.Windows.Forms.Button btn_DeleteExpiredSubscription;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label2;
    }
}