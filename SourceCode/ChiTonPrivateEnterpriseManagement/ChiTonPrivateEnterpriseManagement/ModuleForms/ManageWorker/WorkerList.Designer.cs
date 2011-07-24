namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.workerTempDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAddNew = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvWorker = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ipSummary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.workerTempDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerTempDTOBindingSource
            // 
            this.workerTempDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerTempDTO);
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
            this.btDelete,
            this.btEdit});
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
            // btEdit
            // 
            this.btEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.Edit;
            this.btEdit.UniqueName = "4A0A075AC5884C9566976BFA5C997BDA";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            this.dgvWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorker.Location = new System.Drawing.Point(0, 34);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorker.Size = new System.Drawing.Size(662, 528);
            this.dgvWorker.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWorker.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWorker.TabIndex = 0;
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
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.ipSummary);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 562);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(662, 35);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 5;
            // 
            // ipSummary
            // 
            this.ipSummary.Location = new System.Drawing.Point(372, 6);
            this.ipSummary.Name = "ipSummary";
            this.ipSummary.ReadOnly = true;
            this.ipSummary.Size = new System.Drawing.Size(179, 22);
            this.ipSummary.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.ipSummary.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipSummary.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(45, 6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(305, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tổng số tiền lương công nhân bảng lương(VND)";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvWorker);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(662, 597);
            this.kryptonPanel.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.workerTempDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource workerTempDTOBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddNew;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWorker;
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
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSummary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
    }
}

