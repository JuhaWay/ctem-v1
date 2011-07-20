﻿namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class WorkerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvWorker = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAddNew = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipManDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbManDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipSummary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.workerTempDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersSalaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerTempDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.dgvWorker);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(662, 597);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvWorker
            // 
            this.dgvWorker.AutoGenerateColumns = false;
            this.dgvWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerID,
            this.fullnameDataGridViewTextBoxColumn,
            this.workersSalaryIDDataGridViewTextBoxColumn,
            this.manDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dgvWorker.DataSource = this.workerTempDTOBindingSource;
            this.dgvWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvWorker.Location = new System.Drawing.Point(0, 34);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorker.Size = new System.Drawing.Size(662, 293);
            this.dgvWorker.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWorker.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWorker.TabIndex = 0;
            this.dgvWorker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvWorker_MouseClick);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(662, 34);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btAddNew,
            this.btDelete});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(662, 34);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách";
            this.kryptonHeader1.Values.Image = null;
            // 
            // btAddNew
            // 
            this.btAddNew.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btAddNew.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAddNew.UniqueName = "5F5F44A33C36477B3BA3AE00ADECCBEA";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btDelete.UniqueName = "0B3F65E1EA844AD0C79B57238C4A9762";
            this.btDelete.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btSave);
            this.kryptonPanel1.Controls.Add(this.ipPosition);
            this.kryptonPanel1.Controls.Add(this.lbPosition);
            this.kryptonPanel1.Controls.Add(this.ipSalary);
            this.kryptonPanel1.Controls.Add(this.lbSalary);
            this.kryptonPanel1.Controls.Add(this.ipManDate);
            this.kryptonPanel1.Controls.Add(this.lbManDate);
            this.kryptonPanel1.Controls.Add(this.ipName);
            this.kryptonPanel1.Controls.Add(this.lbName);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 404);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(638, 190);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(284, 155);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(47, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipPosition
            // 
            this.ipPosition.Location = new System.Drawing.Point(284, 54);
            this.ipPosition.Name = "ipPosition";
            this.ipPosition.Size = new System.Drawing.Size(181, 22);
            this.ipPosition.TabIndex = 2;
            // 
            // lbPosition
            // 
            this.lbPosition.Location = new System.Drawing.Point(233, 51);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(34, 19);
            this.lbPosition.TabIndex = 18;
            this.lbPosition.Values.Text = "Vị trí";
            // 
            // ipSalary
            // 
            this.ipSalary.Location = new System.Drawing.Point(284, 120);
            this.ipSalary.Name = "ipSalary";
            this.ipSalary.Size = new System.Drawing.Size(181, 22);
            this.ipSalary.TabIndex = 4;
            this.ipSalary.Leave += new System.EventHandler(this.ipSalary_Leave);
            this.ipSalary.MouseLeave += new System.EventHandler(this.ipSalary_MouseLeave);
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(173, 123);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(103, 19);
            this.lbSalary.TabIndex = 16;
            this.lbSalary.Values.Text = "Lương/Ngày(VND)";
            // 
            // ipManDate
            // 
            this.ipManDate.Location = new System.Drawing.Point(284, 89);
            this.ipManDate.Name = "ipManDate";
            this.ipManDate.Size = new System.Drawing.Size(181, 22);
            this.ipManDate.TabIndex = 3;
            // 
            // lbManDate
            // 
            this.lbManDate.Location = new System.Drawing.Point(195, 92);
            this.lbManDate.Name = "lbManDate";
            this.lbManDate.Size = new System.Drawing.Size(72, 19);
            this.lbManDate.TabIndex = 14;
            this.lbManDate.Values.Text = "Số ngày làm ";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(284, 26);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(181, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(182, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 19);
            this.lbName.TabIndex = 12;
            this.lbName.Values.Text = "Tên công nhân";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.ipSummary);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 327);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(662, 35);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 5;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 362);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(662, 34);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(662, 34);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Chi tiết";
            this.kryptonHeader2.Values.Image = null;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(181, 6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tổng (VND)";
            // 
            // ipSummary
            // 
            this.ipSummary.Location = new System.Drawing.Point(272, 6);
            this.ipSummary.Name = "ipSummary";
            this.ipSummary.ReadOnly = true;
            this.ipSummary.Size = new System.Drawing.Size(179, 22);
            this.ipSummary.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.ipSummary.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipSummary.TabIndex = 1;
            // 
            // workerTempDTOBindingSource
            // 
            this.workerTempDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerTempDTO);
            // 
            // workerID
            // 
            this.workerID.DataPropertyName = "WorkerID";
            this.workerID.HeaderText = "WorkerID";
            this.workerID.Name = "workerID";
            this.workerID.Visible = false;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Công nhân";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // workersSalaryIDDataGridViewTextBoxColumn
            // 
            this.workersSalaryIDDataGridViewTextBoxColumn.DataPropertyName = "WorkersSalaryID";
            this.workersSalaryIDDataGridViewTextBoxColumn.HeaderText = "WorkersSalaryID";
            this.workersSalaryIDDataGridViewTextBoxColumn.Name = "workersSalaryIDDataGridViewTextBoxColumn";
            this.workersSalaryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // manDateDataGridViewTextBoxColumn
            // 
            this.manDateDataGridViewTextBoxColumn.DataPropertyName = "ManDate";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.manDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.manDateDataGridViewTextBoxColumn.HeaderText = "Ngày công";
            this.manDateDataGridViewTextBoxColumn.Name = "manDateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "SalaryFormated";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.salaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Lương ngày công(VND)";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalaryFormated";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.totalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "Tổng lương(VND)";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Vị trí";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDateFormated";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedFormated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "Cập nhật ngày";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Tạo bởi";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Cập nhật bởi";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // WorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.kryptonPanel);
            this.MaximizeBox = false;
            this.Name = "WorkerList";
            this.ShowIcon = false;
            this.Text = "Danh sách công nhân";
            this.Load += new System.EventHandler(this.WorkerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerTempDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWorker;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.BindingSource workerTempDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddNew;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSummary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersSalaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}
