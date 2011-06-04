﻿namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class NewEmployee
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
            this.components = new System.ComponentModel.Container();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.cbbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCMND = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFullname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rdbFull = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdbCustomize = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btnFinish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.clbRights = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.btnPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timerLayoutSLC = new System.Windows.Forms.Timer(this.components);
            this.roleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.cbbStatus);
            this.slcMain.Panel1.Controls.Add(this.dtpDOB);
            this.slcMain.Panel1.Controls.Add(this.txtNote);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel9);
            this.slcMain.Panel1.Controls.Add(this.txtPhoneNumber);
            this.slcMain.Panel1.Controls.Add(this.txtCMND);
            this.slcMain.Panel1.Controls.Add(this.txtEmail);
            this.slcMain.Panel1.Controls.Add(this.txtAddress);
            this.slcMain.Panel1.Controls.Add(this.txtFullname);
            this.slcMain.Panel1.Controls.Add(this.txtUsername);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel8);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel7);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel6);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel5);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel4);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel3);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel2);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel1);
            this.slcMain.Panel1.Controls.Add(this.btnNext);
            this.slcMain.Panel1MinSize = 0;
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.kryptonGroupBox1);
            this.slcMain.Panel2.Controls.Add(this.btnFinish);
            this.slcMain.Panel2.Controls.Add(this.cbbRole);
            this.slcMain.Panel2.Controls.Add(this.kryptonLabel10);
            this.slcMain.Panel2.Controls.Add(this.clbRights);
            this.slcMain.Panel2.Controls.Add(this.btnPre);
            this.slcMain.Panel2MinSize = 0;
            this.slcMain.Size = new System.Drawing.Size(433, 470);
            this.slcMain.SplitterDistance = 3;
            this.slcMain.SplitterWidth = 10;
            this.slcMain.TabIndex = 0;
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatus.DropDownWidth = 278;
            this.cbbStatus.Location = new System.Drawing.Point(116, 283);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(248, 21);
            this.cbbStatus.TabIndex = 21;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(116, 257);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(248, 20);
            this.dtpDOB.TabIndex = 20;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(116, 335);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(248, 92);
            this.txtNote.TabIndex = 18;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(50, 335);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel9.TabIndex = 17;
            this.kryptonLabel9.Values.Text = "Ghi Chú";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(116, 309);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(116, 231);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(248, 20);
            this.txtCMND.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 131);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 68);
            this.txtAddress.TabIndex = 11;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(116, 105);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(248, 20);
            this.txtFullname.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(18, 309);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Số Điện Thoại";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(38, 283);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel7.TabIndex = 7;
            this.kryptonLabel7.Values.Text = "Tình trạng";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(38, 257);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel6.TabIndex = 6;
            this.kryptonLabel6.Values.Text = "Ngày Sinh";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(57, 231);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "CMND";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(59, 205);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "E-mail";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(55, 131);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Địa Chỉ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(34, 105);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Tên Đầy Đủ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 79);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Tên Đăng Nhập";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(-47, 433);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 25);
            this.btnNext.TabIndex = 0;
            this.btnNext.Values.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(37, 67);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rdbFull);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rdbCustomize);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(331, 48);
            this.kryptonGroupBox1.TabIndex = 6;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // rdbFull
            // 
            this.rdbFull.Location = new System.Drawing.Point(195, 12);
            this.rdbFull.Name = "rdbFull";
            this.rdbFull.Size = new System.Drawing.Size(96, 20);
            this.rdbFull.TabIndex = 1;
            this.rdbFull.Values.Text = "Tất Cả Quyền";
            this.rdbFull.CheckedChanged += new System.EventHandler(this.rdbFull_CheckedChanged);
            // 
            // rdbCustomize
            // 
            this.rdbCustomize.Checked = true;
            this.rdbCustomize.Location = new System.Drawing.Point(40, 12);
            this.rdbCustomize.Name = "rdbCustomize";
            this.rdbCustomize.Size = new System.Drawing.Size(91, 20);
            this.rdbCustomize.TabIndex = 0;
            this.rdbCustomize.Values.Text = "Chọn Quyền";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(336, 433);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(56, 25);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Values.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.DisplayMember = "RoleID";
            this.cbbRole.DropDownWidth = 271;
            this.cbbRole.Location = new System.Drawing.Point(131, 121);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(237, 21);
            this.cbbRole.TabIndex = 4;
            this.cbbRole.ValueMember = "RoleID";
            this.cbbRole.SelectedIndexChanged += new System.EventHandler(this.cbbRole_SelectedIndexChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(37, 121);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel10.TabIndex = 3;
            this.kryptonLabel10.Values.Text = "Chọn Chức Vụ";
            // 
            // clbRights
            // 
            this.clbRights.CheckOnClick = true;
            this.clbRights.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.clbRights.Location = new System.Drawing.Point(37, 148);
            this.clbRights.Name = "clbRights";
            this.clbRights.Size = new System.Drawing.Size(331, 279);
            this.clbRights.TabIndex = 2;
            this.clbRights.SelectedIndexChanged += new System.EventHandler(this.clbRights_SelectedIndexChanged);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPre.Location = new System.Drawing.Point(5, 433);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(38, 25);
            this.btnPre.TabIndex = 1;
            this.btnPre.Values.Text = "<<";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // timerLayoutSLC
            // 
            this.timerLayoutSLC.Tick += new System.EventHandler(this.timerLayoutSLC_Tick);
            // 
            // roleDTOBindingSource
            // 
            this.roleDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RoleDTO);
            // 
            // rightDTOBindingSource
            // 
            this.rightDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RightDTO);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 470);
            this.Controls.Add(this.slcMain);
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel1.PerformLayout();
            this.slcMain.Panel2.ResumeLayout(false);
            this.slcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPre;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCMND;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private System.Windows.Forms.BindingSource rightDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox clbRights;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbRole;
        private System.Windows.Forms.BindingSource roleDTOBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFinish;
        private System.Windows.Forms.Timer timerLayoutSLC;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdbFull;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdbCustomize;
    }
}

