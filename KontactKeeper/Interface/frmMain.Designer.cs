﻿namespace Interface
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnCallAgents = new System.Windows.Forms.Button();
            this.btnEndUsers = new System.Windows.Forms.Button();
            this.panAdmins = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAAdminID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtAUname = new System.Windows.Forms.MaskedTextBox();
            this.txtALname = new System.Windows.Forms.MaskedTextBox();
            this.btnAUpdate = new System.Windows.Forms.Button();
            this.btnADelete = new System.Windows.Forms.Button();
            this.btnAAdd = new System.Windows.Forms.Button();
            this.btnASearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAFName = new System.Windows.Forms.TextBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.panCallAgents = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCUserName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPerformance = new System.Windows.Forms.TextBox();
            this.txtCAVG = new System.Windows.Forms.TextBox();
            this.txtCTotalHours = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.txtCAgentEXT = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCTotalCalls = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCFName = new System.Windows.Forms.TextBox();
            this.dgvCallAgent = new System.Windows.Forms.DataGridView();
            this.panEndUsers = new System.Windows.Forms.Panel();
            this.txtEPassword = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtEUName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtELName = new System.Windows.Forms.TextBox();
            this.txtEFName = new System.Windows.Forms.TextBox();
            this.txtEFBID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEUpdate = new System.Windows.Forms.Button();
            this.btnEDelete = new System.Windows.Forms.Button();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.btnESearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEEmail = new System.Windows.Forms.TextBox();
            this.txtECell = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.dgvEndUser = new System.Windows.Forms.DataGridView();
            this.panHome = new System.Windows.Forms.Panel();
            this.btnEndUsers1 = new System.Windows.Forms.Button();
            this.btnCallAgents1 = new System.Windows.Forms.Button();
            this.btnAdmins1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panButtons = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.panCallAgents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallAgent)).BeginInit();
            this.panEndUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndUser)).BeginInit();
            this.panHome.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmins
            // 
            this.btnAdmins.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAdmins.Location = new System.Drawing.Point(121, 11);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(75, 25);
            this.btnAdmins.TabIndex = 1;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnCallAgents
            // 
            this.btnCallAgents.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCallAgents.Location = new System.Drawing.Point(202, 11);
            this.btnCallAgents.Name = "btnCallAgents";
            this.btnCallAgents.Size = new System.Drawing.Size(75, 25);
            this.btnCallAgents.TabIndex = 2;
            this.btnCallAgents.Text = "Call agents";
            this.btnCallAgents.UseVisualStyleBackColor = true;
            this.btnCallAgents.Click += new System.EventHandler(this.btnCallAgents_Click);
            // 
            // btnEndUsers
            // 
            this.btnEndUsers.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEndUsers.Location = new System.Drawing.Point(283, 11);
            this.btnEndUsers.Name = "btnEndUsers";
            this.btnEndUsers.Size = new System.Drawing.Size(75, 25);
            this.btnEndUsers.TabIndex = 3;
            this.btnEndUsers.Text = "End users";
            this.btnEndUsers.UseVisualStyleBackColor = true;
            this.btnEndUsers.Click += new System.EventHandler(this.btnEndUsers_Click);
            // 
            // panAdmins
            // 
            this.panAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAdmins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panAdmins.Controls.Add(this.label10);
            this.panAdmins.Controls.Add(this.txtAAdminID);
            this.panAdmins.Controls.Add(this.label6);
            this.panAdmins.Controls.Add(this.txtAPassword);
            this.panAdmins.Controls.Add(this.txtAUname);
            this.panAdmins.Controls.Add(this.txtALname);
            this.panAdmins.Controls.Add(this.btnAUpdate);
            this.panAdmins.Controls.Add(this.btnADelete);
            this.panAdmins.Controls.Add(this.btnAAdd);
            this.panAdmins.Controls.Add(this.btnASearch);
            this.panAdmins.Controls.Add(this.label9);
            this.panAdmins.Controls.Add(this.label8);
            this.panAdmins.Controls.Add(this.label2);
            this.panAdmins.Controls.Add(this.txtAFName);
            this.panAdmins.Controls.Add(this.dgvAdmin);
            this.panAdmins.Location = new System.Drawing.Point(13, 68);
            this.panAdmins.Name = "panAdmins";
            this.panAdmins.Size = new System.Drawing.Size(559, 481);
            this.panAdmins.TabIndex = 0;
            this.panAdmins.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Admin ID";
            // 
            // txtAAdminID
            // 
            this.txtAAdminID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAAdminID.Location = new System.Drawing.Point(451, 6);
            this.txtAAdminID.Name = "txtAAdminID";
            this.txtAAdminID.Size = new System.Drawing.Size(100, 20);
            this.txtAAdminID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password";
            // 
            // txtAPassword
            // 
            this.txtAPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAPassword.Location = new System.Drawing.Point(451, 111);
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAPassword.TabIndex = 27;
            this.txtAPassword.ValidatingType = typeof(System.DateTime);
            // 
            // txtAUname
            // 
            this.txtAUname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAUname.Location = new System.Drawing.Point(451, 85);
            this.txtAUname.Name = "txtAUname";
            this.txtAUname.Size = new System.Drawing.Size(100, 20);
            this.txtAUname.TabIndex = 26;
            this.txtAUname.ValidatingType = typeof(System.DateTime);
            // 
            // txtALname
            // 
            this.txtALname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtALname.Location = new System.Drawing.Point(451, 58);
            this.txtALname.Name = "txtALname";
            this.txtALname.Size = new System.Drawing.Size(100, 20);
            this.txtALname.TabIndex = 25;
            this.txtALname.ValidatingType = typeof(System.DateTime);
            // 
            // btnAUpdate
            // 
            this.btnAUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAUpdate.Location = new System.Drawing.Point(451, 223);
            this.btnAUpdate.Name = "btnAUpdate";
            this.btnAUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAUpdate.TabIndex = 24;
            this.btnAUpdate.Text = "Update";
            this.btnAUpdate.UseVisualStyleBackColor = true;
            // 
            // btnADelete
            // 
            this.btnADelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADelete.Location = new System.Drawing.Point(451, 195);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(75, 23);
            this.btnADelete.TabIndex = 23;
            this.btnADelete.Text = "Delete";
            this.btnADelete.UseVisualStyleBackColor = true;
            // 
            // btnAAdd
            // 
            this.btnAAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAAdd.Location = new System.Drawing.Point(451, 166);
            this.btnAAdd.Name = "btnAAdd";
            this.btnAAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAAdd.TabIndex = 22;
            this.btnAAdd.Text = "Add";
            this.btnAAdd.UseVisualStyleBackColor = true;
            this.btnAAdd.Click += new System.EventHandler(this.btnCAAdd_Click);
            // 
            // btnASearch
            // 
            this.btnASearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnASearch.Location = new System.Drawing.Point(451, 137);
            this.btnASearch.Name = "btnASearch";
            this.btnASearch.Size = new System.Drawing.Size(75, 23);
            this.btnASearch.TabIndex = 21;
            this.btnASearch.Text = "Search";
            this.btnASearch.UseVisualStyleBackColor = true;
            this.btnASearch.Click += new System.EventHandler(this.btnASearch_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // txtAFName
            // 
            this.txtAFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAFName.Location = new System.Drawing.Point(451, 32);
            this.txtAFName.Name = "txtAFName";
            this.txtAFName.Size = new System.Drawing.Size(100, 20);
            this.txtAFName.TabIndex = 7;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(4, 4);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.Size = new System.Drawing.Size(350, 470);
            this.dgvAdmin.TabIndex = 0;
            // 
            // panCallAgents
            // 
            this.panCallAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCallAgents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panCallAgents.Controls.Add(this.label25);
            this.panCallAgents.Controls.Add(this.txtCUserName);
            this.panCallAgents.Controls.Add(this.label24);
            this.panCallAgents.Controls.Add(this.label19);
            this.panCallAgents.Controls.Add(this.label12);
            this.panCallAgents.Controls.Add(this.label11);
            this.panCallAgents.Controls.Add(this.txtCPerformance);
            this.panCallAgents.Controls.Add(this.txtCAVG);
            this.panCallAgents.Controls.Add(this.txtCTotalHours);
            this.panCallAgents.Controls.Add(this.txtCPassword);
            this.panCallAgents.Controls.Add(this.txtCAgentEXT);
            this.panCallAgents.Controls.Add(this.txtCID);
            this.panCallAgents.Controls.Add(this.btnCUpdate);
            this.panCallAgents.Controls.Add(this.btnCDelete);
            this.panCallAgents.Controls.Add(this.btnCAdd);
            this.panCallAgents.Controls.Add(this.btnCSearch);
            this.panCallAgents.Controls.Add(this.label13);
            this.panCallAgents.Controls.Add(this.label14);
            this.panCallAgents.Controls.Add(this.label15);
            this.panCallAgents.Controls.Add(this.label16);
            this.panCallAgents.Controls.Add(this.label17);
            this.panCallAgents.Controls.Add(this.txtCTotalCalls);
            this.panCallAgents.Controls.Add(this.txtCLName);
            this.panCallAgents.Controls.Add(this.txtCFName);
            this.panCallAgents.Controls.Add(this.dgvCallAgent);
            this.panCallAgents.Location = new System.Drawing.Point(13, 68);
            this.panCallAgents.Name = "panCallAgents";
            this.panCallAgents.Size = new System.Drawing.Size(559, 481);
            this.panCallAgents.TabIndex = 1;
            this.panCallAgents.Visible = false;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(359, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Username";
            // 
            // txtCUserName
            // 
            this.txtCUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCUserName.Location = new System.Drawing.Point(451, 81);
            this.txtCUserName.Name = "txtCUserName";
            this.txtCUserName.Size = new System.Drawing.Size(100, 20);
            this.txtCUserName.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(359, 240);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "Performance";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(359, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "AVG Call Length";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Total Hours";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Password";
            // 
            // txtCPerformance
            // 
            this.txtCPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPerformance.Location = new System.Drawing.Point(451, 237);
            this.txtCPerformance.Name = "txtCPerformance";
            this.txtCPerformance.Size = new System.Drawing.Size(100, 20);
            this.txtCPerformance.TabIndex = 47;
            // 
            // txtCAVG
            // 
            this.txtCAVG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAVG.Location = new System.Drawing.Point(451, 211);
            this.txtCAVG.Name = "txtCAVG";
            this.txtCAVG.Size = new System.Drawing.Size(100, 20);
            this.txtCAVG.TabIndex = 46;
            // 
            // txtCTotalHours
            // 
            this.txtCTotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTotalHours.Location = new System.Drawing.Point(451, 185);
            this.txtCTotalHours.Name = "txtCTotalHours";
            this.txtCTotalHours.Size = new System.Drawing.Size(100, 20);
            this.txtCTotalHours.TabIndex = 45;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPassword.Location = new System.Drawing.Point(451, 107);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCPassword.TabIndex = 44;
            // 
            // txtCAgentEXT
            // 
            this.txtCAgentEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAgentEXT.Location = new System.Drawing.Point(451, 133);
            this.txtCAgentEXT.Name = "txtCAgentEXT";
            this.txtCAgentEXT.Size = new System.Drawing.Size(100, 20);
            this.txtCAgentEXT.TabIndex = 43;
            // 
            // txtCID
            // 
            this.txtCID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCID.Location = new System.Drawing.Point(451, 3);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 20);
            this.txtCID.TabIndex = 42;
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCUpdate.Location = new System.Drawing.Point(452, 368);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCUpdate.TabIndex = 41;
            this.btnCUpdate.Text = "Update";
            this.btnCUpdate.UseVisualStyleBackColor = true;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCDelete.Location = new System.Drawing.Point(452, 340);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCDelete.TabIndex = 40;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = true;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCAdd.Location = new System.Drawing.Point(452, 311);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAdd.TabIndex = 39;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCSearch
            // 
            this.btnCSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSearch.Location = new System.Drawing.Point(452, 282);
            this.btnCSearch.Name = "btnCSearch";
            this.btnCSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCSearch.TabIndex = 38;
            this.btnCSearch.Text = "Search";
            this.btnCSearch.UseVisualStyleBackColor = true;
            this.btnCSearch.Click += new System.EventHandler(this.btnCSearch_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Total Calls";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Agent EXT";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Last Name";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "First Name";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Call agent ID";
            // 
            // txtCTotalCalls
            // 
            this.txtCTotalCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTotalCalls.Location = new System.Drawing.Point(451, 159);
            this.txtCTotalCalls.Name = "txtCTotalCalls";
            this.txtCTotalCalls.Size = new System.Drawing.Size(100, 20);
            this.txtCTotalCalls.TabIndex = 31;
            // 
            // txtCLName
            // 
            this.txtCLName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLName.Location = new System.Drawing.Point(451, 55);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 28;
            // 
            // txtCFName
            // 
            this.txtCFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCFName.Location = new System.Drawing.Point(451, 29);
            this.txtCFName.Name = "txtCFName";
            this.txtCFName.Size = new System.Drawing.Size(100, 20);
            this.txtCFName.TabIndex = 27;
            // 
            // dgvCallAgent
            // 
            this.dgvCallAgent.AllowUserToAddRows = false;
            this.dgvCallAgent.AllowUserToDeleteRows = false;
            this.dgvCallAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCallAgent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCallAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallAgent.Location = new System.Drawing.Point(3, 4);
            this.dgvCallAgent.Name = "dgvCallAgent";
            this.dgvCallAgent.ReadOnly = true;
            this.dgvCallAgent.Size = new System.Drawing.Size(350, 470);
            this.dgvCallAgent.TabIndex = 25;
            // 
            // panEndUsers
            // 
            this.panEndUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panEndUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panEndUsers.Controls.Add(this.txtEPassword);
            this.panEndUsers.Controls.Add(this.label27);
            this.panEndUsers.Controls.Add(this.txtEUName);
            this.panEndUsers.Controls.Add(this.label26);
            this.panEndUsers.Controls.Add(this.txtELName);
            this.panEndUsers.Controls.Add(this.txtEFName);
            this.panEndUsers.Controls.Add(this.txtEFBID);
            this.panEndUsers.Controls.Add(this.label4);
            this.panEndUsers.Controls.Add(this.btnEUpdate);
            this.panEndUsers.Controls.Add(this.btnEDelete);
            this.panEndUsers.Controls.Add(this.btnEAdd);
            this.panEndUsers.Controls.Add(this.btnESearch);
            this.panEndUsers.Controls.Add(this.label7);
            this.panEndUsers.Controls.Add(this.label18);
            this.panEndUsers.Controls.Add(this.label20);
            this.panEndUsers.Controls.Add(this.label21);
            this.panEndUsers.Controls.Add(this.label22);
            this.panEndUsers.Controls.Add(this.txtEEmail);
            this.panEndUsers.Controls.Add(this.txtECell);
            this.panEndUsers.Controls.Add(this.txtEID);
            this.panEndUsers.Controls.Add(this.dgvEndUser);
            this.panEndUsers.Location = new System.Drawing.Point(13, 68);
            this.panEndUsers.Name = "panEndUsers";
            this.panEndUsers.Size = new System.Drawing.Size(559, 481);
            this.panEndUsers.TabIndex = 1;
            this.panEndUsers.Visible = false;
            // 
            // txtEPassword
            // 
            this.txtEPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEPassword.Location = new System.Drawing.Point(451, 107);
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEPassword.TabIndex = 64;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(359, 111);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 63;
            this.label27.Text = "Password";
            // 
            // txtEUName
            // 
            this.txtEUName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEUName.Location = new System.Drawing.Point(451, 81);
            this.txtEUName.Name = "txtEUName";
            this.txtEUName.Size = new System.Drawing.Size(100, 20);
            this.txtEUName.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(359, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 61;
            this.label26.Text = "Username";
            // 
            // txtELName
            // 
            this.txtELName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtELName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtELName.Location = new System.Drawing.Point(451, 55);
            this.txtELName.Name = "txtELName";
            this.txtELName.Size = new System.Drawing.Size(100, 20);
            this.txtELName.TabIndex = 56;
            // 
            // txtEFName
            // 
            this.txtEFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEFName.Location = new System.Drawing.Point(451, 29);
            this.txtEFName.Name = "txtEFName";
            this.txtEFName.Size = new System.Drawing.Size(100, 20);
            this.txtEFName.TabIndex = 55;
            // 
            // txtEFBID
            // 
            this.txtEFBID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEFBID.Location = new System.Drawing.Point(451, 185);
            this.txtEFBID.Name = "txtEFBID";
            this.txtEFBID.Size = new System.Drawing.Size(100, 20);
            this.txtEFBID.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Facebook ID";
            // 
            // btnEUpdate
            // 
            this.btnEUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEUpdate.Location = new System.Drawing.Point(451, 297);
            this.btnEUpdate.Name = "btnEUpdate";
            this.btnEUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEUpdate.TabIndex = 41;
            this.btnEUpdate.Text = "Update";
            this.btnEUpdate.UseVisualStyleBackColor = true;
            this.btnEUpdate.Click += new System.EventHandler(this.btnEUpdate_Click);
            // 
            // btnEDelete
            // 
            this.btnEDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEDelete.Location = new System.Drawing.Point(451, 269);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEDelete.TabIndex = 40;
            this.btnEDelete.Text = "Delete";
            this.btnEDelete.UseVisualStyleBackColor = true;
            this.btnEDelete.Click += new System.EventHandler(this.btnEDelete_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEAdd.Location = new System.Drawing.Point(451, 240);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEAdd.TabIndex = 39;
            this.btnEAdd.Text = "Add";
            this.btnEAdd.UseVisualStyleBackColor = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // btnESearch
            // 
            this.btnESearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESearch.Location = new System.Drawing.Point(451, 211);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(75, 23);
            this.btnESearch.TabIndex = 38;
            this.btnESearch.Text = "Search";
            this.btnESearch.UseVisualStyleBackColor = true;
            this.btnESearch.Click += new System.EventHandler(this.btnESearch_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Email";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cell number";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(359, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(359, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "First Name";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(359, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "EndUser ID";
            // 
            // txtEEmail
            // 
            this.txtEEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEEmail.Location = new System.Drawing.Point(451, 159);
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEEmail.TabIndex = 31;
            // 
            // txtECell
            // 
            this.txtECell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtECell.Location = new System.Drawing.Point(451, 133);
            this.txtECell.Name = "txtECell";
            this.txtECell.Size = new System.Drawing.Size(100, 20);
            this.txtECell.TabIndex = 30;
            // 
            // txtEID
            // 
            this.txtEID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEID.Location = new System.Drawing.Point(451, 3);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(100, 20);
            this.txtEID.TabIndex = 26;
            // 
            // dgvEndUser
            // 
            this.dgvEndUser.AllowUserToAddRows = false;
            this.dgvEndUser.AllowUserToDeleteRows = false;
            this.dgvEndUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEndUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndUser.Location = new System.Drawing.Point(3, 4);
            this.dgvEndUser.Name = "dgvEndUser";
            this.dgvEndUser.ReadOnly = true;
            this.dgvEndUser.Size = new System.Drawing.Size(350, 470);
            this.dgvEndUser.TabIndex = 25;
            this.dgvEndUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEndUser_CellContentClick);
            // 
            // panHome
            // 
            this.panHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panHome.Controls.Add(this.btnEndUsers1);
            this.panHome.Controls.Add(this.btnCallAgents1);
            this.panHome.Controls.Add(this.btnAdmins1);
            this.panHome.Controls.Add(this.label1);
            this.panHome.Location = new System.Drawing.Point(13, 68);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(559, 481);
            this.panHome.TabIndex = 2;
            // 
            // btnEndUsers1
            // 
            this.btnEndUsers1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEndUsers1.Location = new System.Drawing.Point(147, 167);
            this.btnEndUsers1.Name = "btnEndUsers1";
            this.btnEndUsers1.Size = new System.Drawing.Size(272, 29);
            this.btnEndUsers1.TabIndex = 3;
            this.btnEndUsers1.Text = "End users";
            this.btnEndUsers1.UseMnemonic = false;
            this.btnEndUsers1.UseVisualStyleBackColor = true;
            // 
            // btnCallAgents1
            // 
            this.btnCallAgents1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCallAgents1.Location = new System.Drawing.Point(147, 132);
            this.btnCallAgents1.Name = "btnCallAgents1";
            this.btnCallAgents1.Size = new System.Drawing.Size(272, 29);
            this.btnCallAgents1.TabIndex = 2;
            this.btnCallAgents1.Text = "Call agents";
            this.btnCallAgents1.UseMnemonic = false;
            this.btnCallAgents1.UseVisualStyleBackColor = true;
            // 
            // btnAdmins1
            // 
            this.btnAdmins1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdmins1.Location = new System.Drawing.Point(147, 97);
            this.btnAdmins1.Name = "btnAdmins1";
            this.btnAdmins1.Size = new System.Drawing.Size(272, 29);
            this.btnAdmins1.TabIndex = 1;
            this.btnAdmins1.Text = "Admins";
            this.btnAdmins1.UseMnemonic = false;
            this.btnAdmins1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "ContactKeeper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(18, 39);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(31, 25);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(547, 36);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 28);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnAdmins);
            this.panButtons.Controls.Add(this.btnCallAgents);
            this.panButtons.Controls.Add(this.btnEndUsers);
            this.panButtons.Location = new System.Drawing.Point(53, 27);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(488, 40);
            this.panButtons.TabIndex = 7;
            this.panButtons.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(188, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(217, 31);
            this.label23.TabIndex = 8;
            this.label23.Text = "Admin interface";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 27);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "refr";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panAdmins);
            this.Controls.Add(this.panCallAgents);
            this.Controls.Add(this.panEndUsers);
            this.Controls.Add(this.panHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactKeeper";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.panAdmins.ResumeLayout(false);
            this.panAdmins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.panCallAgents.ResumeLayout(false);
            this.panCallAgents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallAgent)).EndInit();
            this.panEndUsers.ResumeLayout(false);
            this.panEndUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndUser)).EndInit();
            this.panHome.ResumeLayout(false);
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnCallAgents;
        private System.Windows.Forms.Button btnEndUsers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panAdmins;
        private System.Windows.Forms.Panel panCallAgents;
        private System.Windows.Forms.Panel panEndUsers;
        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndUsers1;
        private System.Windows.Forms.Button btnCallAgents1;
        private System.Windows.Forms.Button btnAdmins1;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnEUpdate;
        private System.Windows.Forms.Button btnEDelete;
        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.Button btnESearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtEEmail;
        private System.Windows.Forms.TextBox txtECell;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.DataGridView dgvEndUser;
        private System.Windows.Forms.Button btnAUpdate;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.Button btnAAdd;
        private System.Windows.Forms.Button btnASearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAFName;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCTotalCalls;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCFName;
        private System.Windows.Forms.DataGridView dgvCallAgent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.MaskedTextBox txtALname;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox txtAUname;
        private System.Windows.Forms.TextBox txtCAgentEXT;
        private System.Windows.Forms.TextBox txtEFBID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtAPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAAdminID;
        private System.Windows.Forms.TextBox txtELName;
        private System.Windows.Forms.TextBox txtEFName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPerformance;
        private System.Windows.Forms.TextBox txtCAVG;
        private System.Windows.Forms.TextBox txtCTotalHours;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCUserName;
        private System.Windows.Forms.TextBox txtEPassword;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtEUName;
        private System.Windows.Forms.Label label26;
    }
}

