namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class Profiles
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtTotalDebt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnFinish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtFullname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtNewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtOldPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmNewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.roleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.slcMain);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(429, 403);
            this.kryptonPanel.TabIndex = 0;
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(131, 192);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalDebt.Size = new System.Drawing.Size(248, 20);
            this.txtTotalDebt.TabIndex = 23;
            this.txtTotalDebt.Text = "0";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(13, 192);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel11.TabIndex = 22;
            this.kryptonLabel11.Values.Text = "Nợ Doanh Nghiệp";
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPre.Location = new System.Drawing.Point(149, 357);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(77, 25);
            this.btnPre.TabIndex = 1;
            this.btnPre.Values.Text = "Quay Lại";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(131, 270);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(248, 20);
            this.dtpDOB.TabIndex = 20;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(131, 244);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(248, 20);
            this.txtCMND.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(131, 296);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 20);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 119);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 68);
            this.txtAddress.TabIndex = 11;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(232, 357);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(78, 25);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Values.Text = "Thay Đổi";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(131, 93);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(248, 20);
            this.txtFullname.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(131, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(248, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(33, 296);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Số Điện Thoại";
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
            this.slcMain.Panel1.Controls.Add(this.btnClose);
            this.slcMain.Panel1.Controls.Add(this.txtTotalDebt);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel11);
            this.slcMain.Panel1.Controls.Add(this.dtpDOB);
            this.slcMain.Panel1.Controls.Add(this.txtPhoneNumber);
            this.slcMain.Panel1.Controls.Add(this.txtCMND);
            this.slcMain.Panel1.Controls.Add(this.txtEmail);
            this.slcMain.Panel1.Controls.Add(this.txtAddress);
            this.slcMain.Panel1.Controls.Add(this.txtFullname);
            this.slcMain.Panel1.Controls.Add(this.txtUsername);
            this.slcMain.Panel1.Controls.Add(this.kryptonLabel8);
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
            this.slcMain.Panel2.Controls.Add(this.btnClose2);
            this.slcMain.Panel2.Controls.Add(this.kryptonGroupBox1);
            this.slcMain.Panel2.Controls.Add(this.btnFinish);
            this.slcMain.Panel2.Controls.Add(this.btnPre);
            this.slcMain.Panel2MinSize = 0;
            this.slcMain.Size = new System.Drawing.Size(429, 403);
            this.slcMain.SplitterDistance = 416;
            this.slcMain.SplitterWidth = 10;
            this.slcMain.TabIndex = 1;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(53, 270);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel6.TabIndex = 6;
            this.kryptonLabel6.Values.Text = "Ngày Sinh";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(72, 244);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "CMND";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(74, 218);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "E-mail";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(70, 119);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Địa Chỉ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(49, 93);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Tên Đầy Đủ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(27, 67);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Tên Đăng Nhập";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(312, 357);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 25);
            this.btnNext.TabIndex = 0;
            this.btnNext.Values.Text = "Đổi Mật Khẩu";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(22, 105);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel12);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel10);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtConfirmNewPass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtNewPass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtOldPass);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(372, 196);
            this.kryptonGroupBox1.TabIndex = 8;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(167, 84);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(178, 20);
            this.txtNewPass.TabIndex = 9;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(167, 33);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(178, 20);
            this.txtOldPass.TabIndex = 8;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Location = new System.Drawing.Point(167, 135);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(178, 20);
            this.txtConfirmNewPass.TabIndex = 10;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(50, 33);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(111, 20);
            this.kryptonLabel9.TabIndex = 11;
            this.kryptonLabel9.Values.Text = "Mật Khẩu Hiện Tại";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(73, 83);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel10.TabIndex = 12;
            this.kryptonLabel10.Values.Text = "Mật Khẩu Mới";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(22, 135);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(139, 20);
            this.kryptonLabel12.TabIndex = 13;
            this.kryptonLabel12.Values.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(218, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 25);
            this.btnClose.TabIndex = 24;
            this.btnClose.Values.Text = "Đóng";
            // 
            // btnClose2
            // 
            this.btnClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose2.Location = new System.Drawing.Point(316, 357);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(77, 25);
            this.btnClose2.TabIndex = 9;
            this.btnClose2.Values.Text = "Đóng";
            // 
            // roleDTOBindingSource
            // 
            this.roleDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RoleDTO);
            // 
            // rightDTOBindingSource
            // 
            this.rightDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RightDTO);
            // 
            // Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 403);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "Profiles";
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.Profiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel1.PerformLayout();
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalDebt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCMND;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFinish;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPre;
        private System.Windows.Forms.BindingSource roleDTOBindingSource;
        private System.Windows.Forms.BindingSource rightDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmNewPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOldPass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose2;
    }
}

