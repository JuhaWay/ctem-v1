namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class Disbursement
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
            this.ipTaker = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btSaveRoad = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvDisbur = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.numberFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othersCostFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.disbursementDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ipNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTakers = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbReason = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ipOthersCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbReason = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ipTaker)).BeginInit();
            this.ipTaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disbursementDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReason)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTaker
            // 
            this.ipTaker.Controls.Add(this.kryptonLabel6);
            this.ipTaker.Controls.Add(this.hdDebt);
            this.ipTaker.Controls.Add(this.dgvDisbur);
            this.ipTaker.Controls.Add(this.ipNote);
            this.ipTaker.Controls.Add(this.kryptonLabel5);
            this.ipTaker.Controls.Add(this.ipTakers);
            this.ipTaker.Controls.Add(this.kryptonLabel4);
            this.ipTaker.Controls.Add(this.dtDate);
            this.ipTaker.Controls.Add(this.cbReason);
            this.ipTaker.Controls.Add(this.ipOthersCost);
            this.ipTaker.Controls.Add(this.ipNumber);
            this.ipTaker.Controls.Add(this.lbReason);
            this.ipTaker.Controls.Add(this.kryptonLabel3);
            this.ipTaker.Controls.Add(this.kryptonLabel2);
            this.ipTaker.Controls.Add(this.kryptonLabel1);
            this.ipTaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipTaker.Location = new System.Drawing.Point(0, 0);
            this.ipTaker.Name = "ipTaker";
            this.ipTaker.Size = new System.Drawing.Size(523, 477);
            this.ipTaker.TabIndex = 0;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(6, 57);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(102, 19);
            this.kryptonLabel6.TabIndex = 87;
            this.kryptonLabel6.UseMnemonic = false;
            this.kryptonLabel6.Values.Text = "Chi phí khác(VND)";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btAdd,
            this.btDelete,
            this.btSaveRoad});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(523, 27);
            this.hdDebt.TabIndex = 86;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Chi tiết giải ngân";
            this.hdDebt.Values.Image = null;
            // 
            // btAdd
            // 
            this.btAdd.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btAdd.UniqueName = "13970361D6DB4098EF860D9D2BFE9DFF";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btDelete.UniqueName = "9450E2B308834AC9F6BE9EE32DAF62E6";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSaveRoad
            // 
            this.btSaveRoad.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSaveRoad.Text = "Lưu";
            this.btSaveRoad.UniqueName = "B7AB72DEA1804627E69660B7DB96E79F";
            this.btSaveRoad.Click += new System.EventHandler(this.btSaveRoad_Click);
            // 
            // dgvDisbur
            // 
            this.dgvDisbur.AutoGenerateColumns = false;
            this.dgvDisbur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberFormatedDataGridViewTextBoxColumn,
            this.takerDataGridViewTextBoxColumn,
            this.othersCostFormatedDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvDisbur.DataSource = this.disbursementDTOBindingSource;
            this.dgvDisbur.Location = new System.Drawing.Point(6, 179);
            this.dgvDisbur.Name = "dgvDisbur";
            this.dgvDisbur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisbur.Size = new System.Drawing.Size(514, 295);
            this.dgvDisbur.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDisbur.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDisbur.TabIndex = 13;
            // 
            // numberFormatedDataGridViewTextBoxColumn
            // 
            this.numberFormatedDataGridViewTextBoxColumn.DataPropertyName = "NumberFormated";
            this.numberFormatedDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.numberFormatedDataGridViewTextBoxColumn.Name = "numberFormatedDataGridViewTextBoxColumn";
            // 
            // takerDataGridViewTextBoxColumn
            // 
            this.takerDataGridViewTextBoxColumn.DataPropertyName = "Taker";
            this.takerDataGridViewTextBoxColumn.HeaderText = "Người nhận";
            this.takerDataGridViewTextBoxColumn.Name = "takerDataGridViewTextBoxColumn";
            // 
            // othersCostFormatedDataGridViewTextBoxColumn
            // 
            this.othersCostFormatedDataGridViewTextBoxColumn.DataPropertyName = "OthersCostFormated";
            this.othersCostFormatedDataGridViewTextBoxColumn.HeaderText = "Chi phí khác";
            this.othersCostFormatedDataGridViewTextBoxColumn.Name = "othersCostFormatedDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Lý do";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 400;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2011, 7, 24, 0, 0, 0, 0);
            this.dateDataGridViewTextBoxColumn.Checked = false;
            this.dateDataGridViewTextBoxColumn.CustomFormat = "dd/MM/yyyy";
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dateDataGridViewTextBoxColumn.Width = 100;
            // 
            // disbursementDTOBindingSource
            // 
            this.disbursementDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DisbursementDTO);
            // 
            // ipNote
            // 
            this.ipNote.Location = new System.Drawing.Point(108, 113);
            this.ipNote.Multiline = true;
            this.ipNote.Name = "ipNote";
            this.ipNote.Size = new System.Drawing.Size(386, 53);
            this.ipNote.TabIndex = 12;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(44, 107);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.UseMnemonic = false;
            this.kryptonLabel5.Values.Text = "Ghi chú";
            // 
            // ipTakers
            // 
            this.ipTakers.Location = new System.Drawing.Point(108, 85);
            this.ipTakers.Name = "ipTakers";
            this.ipTakers.Size = new System.Drawing.Size(143, 22);
            this.ipTakers.TabIndex = 10;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 82);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 19);
            this.kryptonLabel4.TabIndex = 9;
            this.kryptonLabel4.UseMnemonic = false;
            this.kryptonLabel4.Values.Text = "Người nhận tiền";
            // 
            // dtDate
            // 
            this.dtDate.CalendarTodayDate = new System.DateTime(2011, 7, 24, 0, 0, 0, 0);
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(339, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(143, 20);
            this.dtDate.TabIndex = 8;
            // 
            // cbReason
            // 
            this.cbReason.DropDownWidth = 143;
            this.cbReason.Items.AddRange(new object[] {
            "Thưởng",
            "Phạt",
            "Khác"});
            this.cbReason.Location = new System.Drawing.Point(341, 57);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(143, 22);
            this.cbReason.TabIndex = 7;
            this.cbReason.Text = "Thưởng";
            // 
            // ipOthersCost
            // 
            this.ipOthersCost.Location = new System.Drawing.Point(108, 57);
            this.ipOthersCost.Name = "ipOthersCost";
            this.ipOthersCost.Size = new System.Drawing.Size(143, 22);
            this.ipOthersCost.TabIndex = 5;
            this.ipOthersCost.Leave += new System.EventHandler(this.ipOthersCost_Leave);
            this.ipOthersCost.MouseLeave += new System.EventHandler(this.ipOthersCost_MouseLeave);
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(108, 29);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(143, 22);
            this.ipNumber.TabIndex = 4;
            this.ipNumber.Leave += new System.EventHandler(this.ipNumber_Leave);
            this.ipNumber.MouseLeave += new System.EventHandler(this.ipNumber_MouseLeave);
            // 
            // lbReason
            // 
            this.lbReason.Location = new System.Drawing.Point(288, 60);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(37, 19);
            this.lbReason.TabIndex = 3;
            this.lbReason.UseMnemonic = false;
            this.lbReason.Values.Text = "Lý do";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(250, -41);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(95, 19);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.UseMnemonic = false;
            this.kryptonLabel3.Values.Text = "Chi phí phát sinh";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(247, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 19);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.UseMnemonic = false;
            this.kryptonLabel2.Values.Text = "Ngày giải ngân";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 19);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.UseMnemonic = false;
            this.kryptonLabel1.Values.Text = "Số tiền(VND)";
            // 
            // Disbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 477);
            this.Controls.Add(this.ipTaker);
            this.Name = "Disbursement";
            this.ShowIcon = false;
            this.Text = "Gỉai ngân";
            this.Load += new System.EventHandler(this.Disbursement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipTaker)).EndInit();
            this.ipTaker.ResumeLayout(false);
            this.ipTaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disbursementDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel ipTaker;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipOthersCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbReason;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbReason;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTakers;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDisbur;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btSaveRoad;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private System.Windows.Forms.BindingSource disbursementDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othersCostFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dateDataGridViewTextBoxColumn;
    }
}

