namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class WorkerSalaryManagement
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
            this.dgvWks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.workerSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersSalaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvWks);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(721, 389);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvWks
            // 
            this.dgvWks.AutoGenerateColumns = false;
            this.dgvWks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workersSalaryIDDataGridViewTextBoxColumn,
            this.constructionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dgvWks.DataSource = this.workerSalaryDTOBindingSource;
            this.dgvWks.Location = new System.Drawing.Point(0, 99);
            this.dgvWks.Name = "dgvWks";
            this.dgvWks.Size = new System.Drawing.Size(718, 278);
            this.dgvWks.TabIndex = 0;
            // 
            // workerSalaryDTOBindingSource
            // 
            this.workerSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerSalaryDTO);
            // 
            // workersSalaryIDDataGridViewTextBoxColumn
            // 
            this.workersSalaryIDDataGridViewTextBoxColumn.DataPropertyName = "WorkersSalaryID";
            this.workersSalaryIDDataGridViewTextBoxColumn.HeaderText = "WorkersSalaryID";
            this.workersSalaryIDDataGridViewTextBoxColumn.Name = "workersSalaryIDDataGridViewTextBoxColumn";
            this.workersSalaryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // constructionIDDataGridViewTextBoxColumn
            // 
            this.constructionIDDataGridViewTextBoxColumn.DataPropertyName = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.HeaderText = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.Name = "constructionIDDataGridViewTextBoxColumn";
            this.constructionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "ToDate";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "TotalSalary";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // WorkerSalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 389);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "WorkerSalaryManagement";
            this.Text = "WorkerSalaryManagement";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWks;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersSalaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workerSalaryDTOBindingSource;
    }
}

