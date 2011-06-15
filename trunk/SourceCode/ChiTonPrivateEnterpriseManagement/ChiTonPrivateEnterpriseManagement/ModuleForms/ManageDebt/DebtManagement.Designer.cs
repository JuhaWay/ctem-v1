namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    partial class DebtManagement
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
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.warehouseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddWarehouse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbcMenuBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.scBot = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOweDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).BeginInit();
            this.gbcMenuBot.Panel.SuspendLayout();
            this.gbcMenuBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).BeginInit();
            this.scBot.Panel1.SuspendLayout();
            this.scBot.Panel2.SuspendLayout();
            this.scBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(825, 511);
            this.kryptonPanel.TabIndex = 0;
            // 
            // warehouseDTOBindingSource
            // 
            this.warehouseDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WarehouseDTO);
            // 
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            this.gbcRightBot.Size = new System.Drawing.Size(178, 425);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 78);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(815, 3);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Values.Text = "Sửa";
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(28, 27);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(90, 25);
            this.btnAddWarehouse.TabIndex = 0;
            this.btnAddWarehouse.Values.Text = "Thêm";
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // gbcMenuBot
            // 
            this.gbcMenuBot.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbcMenuBot.Location = new System.Drawing.Point(0, 0);
            this.gbcMenuBot.Name = "gbcMenuBot";
            // 
            // gbcMenuBot.Panel
            // 
            this.gbcMenuBot.Panel.Controls.Add(this.btnEdit);
            this.gbcMenuBot.Panel.Controls.Add(this.btnAddWarehouse);
            this.gbcMenuBot.Size = new System.Drawing.Size(815, 78);
            this.gbcMenuBot.TabIndex = 5;
            this.gbcMenuBot.Values.Heading = "";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.scBot);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Controls.Add(this.gbcMenuBot);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(5, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(815, 506);
            this.kryptonPanel2.TabIndex = 13;
            // 
            // scBot
            // 
            this.scBot.Cursor = System.Windows.Forms.Cursors.Default;
            this.scBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBot.Location = new System.Drawing.Point(0, 81);
            this.scBot.Name = "scBot";
            // 
            // scBot.Panel1
            // 
            this.scBot.Panel1.Controls.Add(this.gbxLeftBot);
            // 
            // scBot.Panel2
            // 
            this.scBot.Panel2.Controls.Add(this.gbcRightBot);
            this.scBot.Size = new System.Drawing.Size(815, 425);
            this.scBot.SplitterDistance = 632;
            this.scBot.TabIndex = 8;
            // 
            // gbxLeftBot
            // 
            this.gbxLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLeftBot.Location = new System.Drawing.Point(0, 0);
            this.gbxLeftBot.Name = "gbxLeftBot";
            // 
            // gbxLeftBot.Panel
            // 
            this.gbxLeftBot.Panel.Controls.Add(this.dgvLeftBot);
            this.gbxLeftBot.Size = new System.Drawing.Size(632, 425);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // dgvLeftBot
            // 
            this.dgvLeftBot.AutoGenerateColumns = false;
            this.dgvLeftBot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.debtIDDataGridViewTextBoxColumn,
            this.debtNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.totalOweDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dgvLeftBot.DataSource = this.debtDTOBindingSource;
            this.dgvLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeftBot.Location = new System.Drawing.Point(0, 0);
            this.dgvLeftBot.Name = "dgvLeftBot";
            this.dgvLeftBot.Size = new System.Drawing.Size(628, 419);
            this.dgvLeftBot.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(5, 506);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(815, 5);
            this.kryptonPanel3.TabIndex = 12;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(5, 511);
            this.kryptonPanel4.TabIndex = 11;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel6.Location = new System.Drawing.Point(820, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(5, 511);
            this.kryptonPanel6.TabIndex = 10;
            // 
            // finalAccountDetailDTOBindingSource
            // 
            this.finalAccountDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDetailDTO);
            // 
            // debtDTOBindingSource
            // 
            this.debtDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DebtDTO);
            // 
            // debtIDDataGridViewTextBoxColumn
            // 
            this.debtIDDataGridViewTextBoxColumn.DataPropertyName = "DebtID";
            this.debtIDDataGridViewTextBoxColumn.HeaderText = "DebtID";
            this.debtIDDataGridViewTextBoxColumn.Name = "debtIDDataGridViewTextBoxColumn";
            // 
            // debtNameDataGridViewTextBoxColumn
            // 
            this.debtNameDataGridViewTextBoxColumn.DataPropertyName = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.HeaderText = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.Name = "debtNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // totalOweDataGridViewTextBoxColumn
            // 
            this.totalOweDataGridViewTextBoxColumn.DataPropertyName = "TotalOwe";
            this.totalOweDataGridViewTextBoxColumn.HeaderText = "TotalOwe";
            this.totalOweDataGridViewTextBoxColumn.Name = "totalOweDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
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
            // DebtManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 511);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kryptonPanel6);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "DebtManagement";
            this.Text = "DebtManagement";
            this.Load += new System.EventHandler(this.DebtManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.gbcMenuBot.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).EndInit();
            this.gbcMenuBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.scBot.Panel1.ResumeLayout(false);
            this.scBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).EndInit();
            this.scBot.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.BindingSource warehouseDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddWarehouse;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcMenuBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer scBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOweDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource debtDTOBindingSource;
    }
}

