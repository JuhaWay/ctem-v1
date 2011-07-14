namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class NewSalary
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
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.genarateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpMonth = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtActualIncome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDebtPay = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPhoneCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAllowance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbIsPay = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
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
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genarateToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(164, 26);
            // 
            // genarateToolStripMenuItem
            // 
            this.genarateToolStripMenuItem.Name = "genarateToolStripMenuItem";
            this.genarateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.genarateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.genarateToolStripMenuItem.Text = "Genarate";
            this.genarateToolStripMenuItem.Click += new System.EventHandler(this.genarateToolStripMenuItem_Click);
            // 
            // employeeSalaryDTOBindingSource
            // 
            this.employeeSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EmployeeSalaryDTO);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(146, 19);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(250, 21);
            this.dtpMonth.TabIndex = 19;
            // 
            // txtActualIncome
            // 
            this.txtActualIncome.ContextMenuStrip = this.cmsMain;
            this.txtActualIncome.Location = new System.Drawing.Point(146, 99);
            this.txtActualIncome.Name = "txtActualIncome";
            this.txtActualIncome.Size = new System.Drawing.Size(250, 20);
            this.txtActualIncome.TabIndex = 34;
            this.txtActualIncome.Text = "0";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(69, 99);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 33;
            this.kryptonLabel8.Values.Text = "Thực Lãnh";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(151, 111);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(250, 96);
            this.txtNote.TabIndex = 32;
            // 
            // txtDebtPay
            // 
            this.txtDebtPay.ContextMenuStrip = this.cmsMain;
            this.txtDebtPay.Location = new System.Drawing.Point(151, 58);
            this.txtDebtPay.Name = "txtDebtPay";
            this.txtDebtPay.Size = new System.Drawing.Size(250, 20);
            this.txtDebtPay.TabIndex = 31;
            this.txtDebtPay.Text = "0";
            // 
            // txtPhoneCost
            // 
            this.txtPhoneCost.ContextMenuStrip = this.cmsMain;
            this.txtPhoneCost.Location = new System.Drawing.Point(151, 32);
            this.txtPhoneCost.Name = "txtPhoneCost";
            this.txtPhoneCost.Size = new System.Drawing.Size(250, 20);
            this.txtPhoneCost.TabIndex = 30;
            this.txtPhoneCost.Text = "0";
            // 
            // txtAllowance
            // 
            this.txtAllowance.ContextMenuStrip = this.cmsMain;
            this.txtAllowance.Location = new System.Drawing.Point(151, 6);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(250, 20);
            this.txtAllowance.TabIndex = 29;
            this.txtAllowance.Text = "0";
            // 
            // txtSalary
            // 
            this.txtSalary.ContextMenuStrip = this.cmsMain;
            this.txtSalary.Location = new System.Drawing.Point(146, 46);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(250, 20);
            this.txtSalary.TabIndex = 28;
            this.txtSalary.Text = "0";
            // 
            // cbbIsPay
            // 
            this.cbbIsPay.DropDownWidth = 223;
            this.cbbIsPay.Location = new System.Drawing.Point(151, 84);
            this.cbbIsPay.Name = "cbbIsPay";
            this.cbbIsPay.Size = new System.Drawing.Size(250, 21);
            this.cbbIsPay.TabIndex = 27;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.DropDownWidth = 223;
            this.cbbEmployee.Location = new System.Drawing.Point(146, 72);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(250, 21);
            this.cbbEmployee.TabIndex = 26;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(86, 111);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel7.TabIndex = 25;
            this.kryptonLabel7.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(72, 85);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel6.TabIndex = 24;
            this.kryptonLabel6.Values.Text = "Trạng Thái";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 58);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(134, 20);
            this.kryptonLabel5.TabIndex = 23;
            this.kryptonLabel5.Values.Text = "Tiền Nhân Viên Trả Nợ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(45, 32);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel4.TabIndex = 22;
            this.kryptonLabel4.Values.Text = "Tiền Điện Thoại";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(84, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "Phụ Cấp";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(90, 46);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 20;
            this.kryptonLabel2.Values.Text = "Lương";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(44, 73);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Tên Nhân Viên";
            // 
            // gbxAdd2
            // 
            this.gbxAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd2.Location = new System.Drawing.Point(0, 0);
            this.gbxAdd2.Name = "gbxAdd2";
            // 
            // gbxAdd2.Panel
            // 
            this.gbxAdd2.Panel.Controls.Add(this.txtDebtPay);
            this.gbxAdd2.Panel.Controls.Add(this.txtNote);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxAdd2.Panel.Controls.Add(this.cbbIsPay);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxAdd2.Panel.Controls.Add(this.txtPhoneCost);
            this.gbxAdd2.Panel.Controls.Add(this.txtAllowance);
            this.gbxAdd2.Size = new System.Drawing.Size(440, 244);
            this.gbxAdd2.TabIndex = 5;
            this.gbxAdd2.Values.Heading = "Thông Tin Thêm";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btnClose.Values.Text = "Đóng";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.gbxButton);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 404);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(440, 126);
            this.pnlButton.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.pnlButton.TabIndex = 42;
            // 
            // gbxButton
            // 
            this.gbxButton.CaptionOverlap = 0D;
            this.gbxButton.Location = new System.Drawing.Point(37, 27);
            this.gbxButton.Name = "gbxButton";
            // 
            // gbxButton.Panel
            // 
            this.gbxButton.Panel.Controls.Add(this.btnClear);
            this.gbxButton.Panel.Controls.Add(this.btnClose);
            this.gbxButton.Panel.Controls.Add(this.btnSave);
            this.gbxButton.Size = new System.Drawing.Size(379, 78);
            this.gbxButton.TabIndex = 0;
            this.gbxButton.Values.Heading = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.edit_clear;
            this.btnClear.Values.Text = "Làm Mới";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Values.Text = "Lưu";
            // 
            // gbxAdd1
            // 
            this.gbxAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd1.Location = new System.Drawing.Point(5, 0);
            this.gbxAdd1.Name = "gbxAdd1";
            // 
            // gbxAdd1.Panel
            // 
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxAdd1.Panel.Controls.Add(this.dtpMonth);
            this.gbxAdd1.Panel.Controls.Add(this.cbbEmployee);
            this.gbxAdd1.Panel.Controls.Add(this.txtActualIncome);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxAdd1.Panel.Controls.Add(this.txtSalary);
            this.gbxAdd1.Size = new System.Drawing.Size(435, 150);
            this.gbxAdd1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.gbxAdd1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxAdd1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxAdd1.TabIndex = 5;
            this.gbxAdd1.Values.Heading = "Thông Tin Bắt Buộc";
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
            this.slcMain.Size = new System.Drawing.Size(440, 404);
            this.slcMain.SplitterDistance = 155;
            this.slcMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcMain.TabIndex = 41;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(90, 19);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 35;
            this.kryptonLabel9.Values.Text = "Tháng";
            // 
            // NewSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 530);
            this.Controls.Add(this.slcMain);
            this.Controls.Add(this.pnlButton);
            this.Name = "NewSalary";
            this.Text = "NewSalary";
            this.Load += new System.EventHandler(this.NewSalary_Load);
            this.SizeChanged += new System.EventHandler(this.NewSalary_SizeChanged);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).EndInit();
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
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource employeeSalaryDTOBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem genarateToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtActualIncome;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDebtPay;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAllowance;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbIsPay;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbEmployee;
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
    }
}

