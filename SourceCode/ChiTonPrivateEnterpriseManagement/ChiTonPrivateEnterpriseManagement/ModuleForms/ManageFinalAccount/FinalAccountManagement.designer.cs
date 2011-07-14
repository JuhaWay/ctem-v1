namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    partial class FinalAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalAccountManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.dgvAccount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finalAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdAccount = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.hdSearch = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 557);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(784, 5);
            this.kryptonPanel3.TabIndex = 8;
            // 
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // finalAccountDetailDTOBindingSource
            // 
            this.finalAccountDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDetailDTO);
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
            this.slcMain.Panel1.Controls.Add(this.hdSearch);
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.dgvAccount);
            this.slcMain.Panel2.Controls.Add(this.hdAccount);
            this.slcMain.Size = new System.Drawing.Size(784, 557);
            this.slcMain.SplitterDistance = 175;
            this.slcMain.TabIndex = 9;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.finalAccountIDDataGridViewTextBoxColumn,
            this.finalAccountNameDataGridViewTextBoxColumn,
            this.constructionNameDataGridViewTextBoxColumn,
            this.dateAccountDataGridViewTextBoxColumn,
            this.debtNameDataGridViewTextBoxColumn,
            this.transportationCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.personAccountDataGridViewTextBoxColumn,
            this.isPayDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvAccount.DataSource = this.finalAccountDTOBindingSource;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 23);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(784, 354);
            this.dgvAccount.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // finalAccountIDDataGridViewTextBoxColumn
            // 
            this.finalAccountIDDataGridViewTextBoxColumn.DataPropertyName = "FinalAccountID";
            this.finalAccountIDDataGridViewTextBoxColumn.HeaderText = "Mã Số";
            this.finalAccountIDDataGridViewTextBoxColumn.Name = "finalAccountIDDataGridViewTextBoxColumn";
            // 
            // finalAccountNameDataGridViewTextBoxColumn
            // 
            this.finalAccountNameDataGridViewTextBoxColumn.DataPropertyName = "FinalAccountName";
            this.finalAccountNameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.finalAccountNameDataGridViewTextBoxColumn.Name = "finalAccountNameDataGridViewTextBoxColumn";
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "Công Trình";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            // 
            // dateAccountDataGridViewTextBoxColumn
            // 
            this.dateAccountDataGridViewTextBoxColumn.DataPropertyName = "DateAccount";
            this.dateAccountDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateAccountDataGridViewTextBoxColumn.Name = "dateAccountDataGridViewTextBoxColumn";
            // 
            // debtNameDataGridViewTextBoxColumn
            // 
            this.debtNameDataGridViewTextBoxColumn.DataPropertyName = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.debtNameDataGridViewTextBoxColumn.Name = "debtNameDataGridViewTextBoxColumn";
            // 
            // transportationCostDataGridViewTextBoxColumn
            // 
            this.transportationCostDataGridViewTextBoxColumn.DataPropertyName = "TransportationCost";
            this.transportationCostDataGridViewTextBoxColumn.HeaderText = "Tiền Vận Chuyễn";
            this.transportationCostDataGridViewTextBoxColumn.Name = "transportationCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Tổng Số Tiền";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // personAccountDataGridViewTextBoxColumn
            // 
            this.personAccountDataGridViewTextBoxColumn.DataPropertyName = "PersonAccount";
            this.personAccountDataGridViewTextBoxColumn.HeaderText = "Chịu Trách Nhiệm";
            this.personAccountDataGridViewTextBoxColumn.Name = "personAccountDataGridViewTextBoxColumn";
            // 
            // isPayDataGridViewTextBoxColumn
            // 
            this.isPayDataGridViewTextBoxColumn.DataPropertyName = "IsPay";
            this.isPayDataGridViewTextBoxColumn.HeaderText = "Đã Thanh Toán";
            this.isPayDataGridViewTextBoxColumn.Name = "isPayDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // hdAccount
            // 
            this.hdAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdAccount.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdAccount.Location = new System.Drawing.Point(0, 0);
            this.hdAccount.Name = "hdAccount";
            this.hdAccount.Size = new System.Drawing.Size(784, 23);
            this.hdAccount.TabIndex = 22;
            this.hdAccount.Values.Description = "";
            this.hdAccount.Values.Heading = "Danh Sách Quyết Toán";
            this.hdAccount.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // hdSearch
            // 
            this.hdSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdSearch.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdSearch.Location = new System.Drawing.Point(0, 0);
            this.hdSearch.Name = "hdSearch";
            this.hdSearch.Size = new System.Drawing.Size(784, 23);
            this.hdSearch.TabIndex = 23;
            this.hdSearch.Values.Description = "";
            this.hdSearch.Values.Heading = "Danh Sách Quyết Toán";
            this.hdSearch.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // FinalAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.slcMain);
            this.Controls.Add(this.kryptonPanel3);
            this.Name = "FinalAccountManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Quyết Toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinalAccountManagement_Load);
            this.SizeChanged += new System.EventHandler(this.FinalAccountManagement_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel1.PerformLayout();
            this.slcMain.Panel2.ResumeLayout(false);
            this.slcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdAccount;
    }
}

