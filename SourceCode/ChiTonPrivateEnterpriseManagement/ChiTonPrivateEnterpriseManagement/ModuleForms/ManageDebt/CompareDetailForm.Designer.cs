namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    partial class CompareDetailForm
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
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpDatepay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtPayed = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtNamePerson = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hd1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvCompareDetail = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.hd2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComparationDebtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepresentationDebtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePayFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayedFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compareDebtDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDel = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompareDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareDebtDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(692, 566);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.hd1);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.dgvCompareDetail);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.hd2);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(692, 566);
            this.kryptonSplitContainer1.SplitterDistance = 214;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(360, 35);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtNote);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(320, 168);
            this.kryptonGroupBox2.TabIndex = 2;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(71, 21);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(229, 118);
            this.txtNote.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 21);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "Ghi Chú";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 35);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpDatepay);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPayed);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtNamePerson);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(342, 168);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // dtpDatepay
            // 
            this.dtpDatepay.CustomFormat = "dd/MM/yyyy";
            this.dtpDatepay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatepay.Location = new System.Drawing.Point(114, 66);
            this.dtpDatepay.Name = "dtpDatepay";
            this.dtpDatepay.Size = new System.Drawing.Size(208, 20);
            this.dtpDatepay.TabIndex = 6;
            // 
            // txtPayed
            // 
            this.txtPayed.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtPayed.Location = new System.Drawing.Point(114, 92);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(208, 25);
            this.txtPayed.TabIndex = 5;
            this.txtPayed.Enter += new System.EventHandler(this.txtPayed_Enter);
            this.txtPayed.Leave += new System.EventHandler(this.txtPayed_Leave);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Text = "(VND)";
            this.buttonSpecAny1.UniqueName = "74F84F03FAA143EF40AE01869A06A17C";
            // 
            // txtNamePerson
            // 
            this.txtNamePerson.Location = new System.Drawing.Point(114, 38);
            this.txtNamePerson.Name = "txtNamePerson";
            this.txtNamePerson.Size = new System.Drawing.Size(208, 22);
            this.txtNamePerson.TabIndex = 4;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(42, 98);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Số Tiền Trả";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(17, 67);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Ngày Nhận Tiền";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 41);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(96, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Người Nhận Tiền";
            // 
            // hd1
            // 
            this.hd1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSave,
            this.btnClear});
            this.hd1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hd1.Location = new System.Drawing.Point(0, 0);
            this.hd1.Name = "hd1";
            this.hd1.Size = new System.Drawing.Size(692, 29);
            this.hd1.TabIndex = 0;
            this.hd1.Values.Description = "";
            this.hd1.Values.Heading = "Thêm Hoặc Sửa Lịch Trả Tiền Công Nợ";
            this.hd1.Values.Image = null;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnSave.Text = "Lưu";
            this.btnSave.UniqueName = "F358C2ABD88D4C575D979F8B34CB68D4";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.edit_clear;
            this.btnClear.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnClear.Text = "Tạo Mới";
            this.btnClear.UniqueName = "11E9C1DA9AA840C7FEB1D1777CB5CEAE";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvCompareDetail
            // 
            this.dgvCompareDetail.AutoGenerateColumns = false;
            this.dgvCompareDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailID,
            this.ComparationDebtID,
            this.RepresentationDebtName,
            this.DatePay,
            this.Payed,
            this.CreatedBy,
            this.UpdatedBy,
            this.CreatedDate,
            this.UpdatedDate,
            this.DatePayFormat,
            this.PayedFormat,
            this.Note});
            this.dgvCompareDetail.DataSource = this.compareDebtDetailDTOBindingSource;
            this.dgvCompareDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompareDetail.Location = new System.Drawing.Point(0, 29);
            this.dgvCompareDetail.Name = "dgvCompareDetail";
            this.dgvCompareDetail.Size = new System.Drawing.Size(692, 318);
            this.dgvCompareDetail.TabIndex = 2;
            this.dgvCompareDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompareDetail_CellClick);
            // 
            // hd2
            // 
            this.hd2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDel});
            this.hd2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hd2.Location = new System.Drawing.Point(0, 0);
            this.hd2.Name = "hd2";
            this.hd2.Size = new System.Drawing.Size(692, 29);
            this.hd2.TabIndex = 1;
            this.hd2.Values.Description = "";
            this.hd2.Values.Heading = "Lịch Sử Trả Tiền";
            this.hd2.Values.Image = null;
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "DetailID";
            this.DetailID.HeaderText = "DetailID";
            this.DetailID.Name = "DetailID";
            this.DetailID.Visible = false;
            // 
            // ComparationDebtID
            // 
            this.ComparationDebtID.DataPropertyName = "ComparationDebtID";
            this.ComparationDebtID.HeaderText = "ComparationDebtID";
            this.ComparationDebtID.Name = "ComparationDebtID";
            this.ComparationDebtID.Visible = false;
            // 
            // RepresentationDebtName
            // 
            this.RepresentationDebtName.DataPropertyName = "RepresentationDebtName";
            this.RepresentationDebtName.HeaderText = "Người Nhận Tiền";
            this.RepresentationDebtName.Name = "RepresentationDebtName";
            this.RepresentationDebtName.Width = 200;
            // 
            // DatePay
            // 
            this.DatePay.DataPropertyName = "DatePay";
            this.DatePay.HeaderText = "Ngày Trả";
            this.DatePay.Name = "DatePay";
            this.DatePay.Visible = false;
            // 
            // Payed
            // 
            this.Payed.DataPropertyName = "Payed";
            this.Payed.HeaderText = "Số Tiền Trả";
            this.Payed.Name = "Payed";
            this.Payed.Visible = false;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Visible = false;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            this.UpdatedBy.HeaderText = "UpdatedBy";
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.Visible = false;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Visible = false;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.DataPropertyName = "UpdatedDate";
            this.UpdatedDate.HeaderText = "UpdatedDate";
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.Visible = false;
            // 
            // DatePayFormat
            // 
            this.DatePayFormat.DataPropertyName = "DatePayFormat";
            this.DatePayFormat.HeaderText = "Ngày Trả";
            this.DatePayFormat.Name = "DatePayFormat";
            this.DatePayFormat.Width = 150;
            // 
            // PayedFormat
            // 
            this.PayedFormat.DataPropertyName = "PayedFormat";
            this.PayedFormat.HeaderText = "Số Tiền Trả (VND)";
            this.PayedFormat.Name = "PayedFormat";
            this.PayedFormat.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 200;
            // 
            // compareDebtDetailDTOBindingSource
            // 
            this.compareDebtDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.CompareDebtDetailDTO);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btnDel.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDel.Text = "Xóa";
            this.btnDel.UniqueName = "09AE38FFC9C64AC44CB5E3993FAED46B";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // CompareDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 566);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "CompareDetailForm";
            this.Text = "Chi Tiếp Trả Công Nợ";
            this.Load += new System.EventHandler(this.CompareDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompareDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareDebtDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hd1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCompareDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hd2;
        private System.Windows.Forms.BindingSource compareDebtDetailDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComparationDebtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepresentationDebtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePayFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayedFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNamePerson;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDatepay;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPayed;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnClear;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDel;
    }
}

