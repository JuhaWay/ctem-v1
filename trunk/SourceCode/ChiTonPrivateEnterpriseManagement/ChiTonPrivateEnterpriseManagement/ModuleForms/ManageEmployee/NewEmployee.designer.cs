namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
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
            this.timerLayoutSLC = new System.Windows.Forms.Timer(this.components);
            this.txtTotalDebt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.gbxAdd2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlButton = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxButton = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbxAdd1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbbRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.roleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd2)).BeginInit();
            this.gbxAdd2.Panel.SuspendLayout();
            this.gbxAdd2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).BeginInit();
            this.gbxButton.Panel.SuspendLayout();
            this.gbxButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd1)).BeginInit();
            this.gbxAdd1.Panel.SuspendLayout();
            this.gbxAdd1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(130, 178);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalDebt.Size = new System.Drawing.Size(284, 22);
            this.txtTotalDebt.TabIndex = 45;
            this.txtTotalDebt.Text = "0";
            this.txtTotalDebt.Enter += new System.EventHandler(this.txtTotalDebt_Enter);
            this.txtTotalDebt.Leave += new System.EventHandler(this.txtTotalDebt_Leave);
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(14, 181);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(102, 19);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel11.TabIndex = 44;
            this.kryptonLabel11.Values.Text = "Nợ Doanh Nghiệp";
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatus.DropDownWidth = 278;
            this.cbbStatus.Location = new System.Drawing.Point(135, 89);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(284, 22);
            this.cbbStatus.TabIndex = 43;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(135, 63);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(284, 20);
            this.dtpDOB.TabIndex = 42;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(135, 145);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(284, 79);
            this.txtNote.TabIndex = 41;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(74, 145);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel9.TabIndex = 40;
            this.kryptonLabel9.Values.Text = "Ghi Chú";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(135, 117);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(284, 22);
            this.txtPhoneNumber.TabIndex = 39;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(135, 35);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(284, 22);
            this.txtCMND.TabIndex = 38;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 22);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 99);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(284, 73);
            this.txtAddress.TabIndex = 36;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(130, 43);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(284, 22);
            this.txtFullname.TabIndex = 35;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 22);
            this.txtUsername.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.TabIndex = 34;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(44, 117);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(80, 19);
            this.kryptonLabel8.TabIndex = 33;
            this.kryptonLabel8.Values.Text = "Số Điện Thoại";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(58, 92);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(61, 19);
            this.kryptonLabel7.TabIndex = 32;
            this.kryptonLabel7.Values.Text = "Tình trạng";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(63, 64);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(61, 19);
            this.kryptonLabel6.TabIndex = 31;
            this.kryptonLabel6.Values.Text = "Ngày Sinh";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(80, 38);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(44, 19);
            this.kryptonLabel5.TabIndex = 30;
            this.kryptonLabel5.Values.Text = "CMND";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(80, 7);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 19);
            this.kryptonLabel4.TabIndex = 29;
            this.kryptonLabel4.Values.Text = "E-mail";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(68, 99);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 28;
            this.kryptonLabel3.Values.Text = "Địa Chỉ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(48, 46);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(68, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Tên Đầy Đủ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(30, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(89, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Tên Đăng Nhập";
            // 
            // gbxAdd2
            // 
            this.gbxAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd2.Location = new System.Drawing.Point(0, 0);
            this.gbxAdd2.Name = "gbxAdd2";
            // 
            // gbxAdd2.Panel
            // 
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxAdd2.Panel.Controls.Add(this.cbbStatus);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxAdd2.Panel.Controls.Add(this.dtpDOB);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxAdd2.Panel.Controls.Add(this.txtNote);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxAdd2.Panel.Controls.Add(this.txtEmail);
            this.gbxAdd2.Panel.Controls.Add(this.txtPhoneNumber);
            this.gbxAdd2.Panel.Controls.Add(this.txtCMND);
            this.gbxAdd2.Size = new System.Drawing.Size(458, 266);
            this.gbxAdd2.TabIndex = 5;
            this.gbxAdd2.Values.Heading = "Thông Tin Thêm";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.gbxButton);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 527);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(458, 92);
            this.pnlButton.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.pnlButton.TabIndex = 48;
            // 
            // gbxButton
            // 
            this.gbxButton.CaptionOverlap = 0D;
            this.gbxButton.Location = new System.Drawing.Point(42, 9);
            this.gbxButton.Name = "gbxButton";
            // 
            // gbxButton.Panel
            // 
            this.gbxButton.Panel.Controls.Add(this.btnClear);
            this.gbxButton.Panel.Controls.Add(this.btnClose);
            this.gbxButton.Panel.Controls.Add(this.btnSave);
            this.gbxButton.Size = new System.Drawing.Size(379, 72);
            this.gbxButton.TabIndex = 0;
            this.gbxButton.Values.Heading = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.edit_clear;
            this.btnClear.Values.Text = "Làm Mới";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxAdd1
            // 
            this.gbxAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd1.Location = new System.Drawing.Point(5, 0);
            this.gbxAdd1.Name = "gbxAdd1";
            // 
            // gbxAdd1.Panel
            // 
            this.gbxAdd1.Panel.Controls.Add(this.cbbRole);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxAdd1.Panel.Controls.Add(this.txtTotalDebt);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel11);
            this.gbxAdd1.Panel.Controls.Add(this.txtUsername);
            this.gbxAdd1.Panel.Controls.Add(this.txtFullname);
            this.gbxAdd1.Panel.Controls.Add(this.txtAddress);
            this.gbxAdd1.Size = new System.Drawing.Size(453, 251);
            this.gbxAdd1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.gbxAdd1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxAdd1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxAdd1.TabIndex = 5;
            this.gbxAdd1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // cbbRole
            // 
            this.cbbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRole.DisplayMember = "RoleID";
            this.cbbRole.DropDownWidth = 271;
            this.cbbRole.Location = new System.Drawing.Point(130, 71);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(284, 22);
            this.cbbRole.TabIndex = 45;
            this.cbbRole.ValueMember = "RoleID";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(62, 74);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(52, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 44;
            this.kryptonLabel10.Values.Text = "Chức Vụ";
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            this.slcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.gbxAdd1);
            this.slcMain.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.slcMain.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.gbxAdd2);
            this.slcMain.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcMain.Size = new System.Drawing.Size(458, 527);
            this.slcMain.SplitterDistance = 256;
            this.slcMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcMain.TabIndex = 47;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 619);
            this.Controls.Add(this.slcMain);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEmployee";
            this.ShowIcon = false;
            this.Text = "Thông Tin Chi Tiết";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            this.gbxAdd2.Panel.ResumeLayout(false);
            this.gbxAdd2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd2)).EndInit();
            this.gbxAdd2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.gbxButton.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).EndInit();
            this.gbxButton.ResumeLayout(false);
            this.gbxAdd1.Panel.ResumeLayout(false);
            this.gbxAdd1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd1)).EndInit();
            this.gbxAdd1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).EndInit();
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource rightDTOBindingSource;
        private System.Windows.Forms.BindingSource roleDTOBindingSource;
        private System.Windows.Forms.Timer timerLayoutSLC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalDebt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatus;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCMND;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullname;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxAdd2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxAdd1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbRole;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
    }
}

