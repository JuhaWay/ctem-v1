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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.scBot = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.debtDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.warehouseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbcMenuBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.removeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddWarehouse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).BeginInit();
            this.gbcMenuBot.Panel.SuspendLayout();
            this.gbcMenuBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 59);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(825, 452);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(815, 3);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.scBot);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(5, 59);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(815, 447);
            this.kryptonPanel2.TabIndex = 13;
            // 
            // scBot
            // 
            this.scBot.Cursor = System.Windows.Forms.Cursors.Default;
            this.scBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBot.Location = new System.Drawing.Point(0, 3);
            this.scBot.Name = "scBot";
            // 
            // scBot.Panel1
            // 
            this.scBot.Panel1.Controls.Add(this.gbxLeftBot);
            // 
            // scBot.Panel2
            // 
            this.scBot.Panel2.Controls.Add(this.gbcRightBot);
            this.scBot.Size = new System.Drawing.Size(815, 444);
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
            this.gbxLeftBot.Panel.Controls.Add(this.kryptonHeader1);
            this.gbxLeftBot.Size = new System.Drawing.Size(632, 444);
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
            this.dgvLeftBot.Location = new System.Drawing.Point(0, 23);
            this.dgvLeftBot.Name = "dgvLeftBot";
            this.dgvLeftBot.Size = new System.Drawing.Size(628, 415);
            this.dgvLeftBot.TabIndex = 0;
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
            // debtDTOBindingSource
            // 
            this.debtDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DebtDTO);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(628, 23);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh Nhà Cung Cấp";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            this.gbcRightBot.Size = new System.Drawing.Size(178, 444);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
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
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 59);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(5, 452);
            this.kryptonPanel4.TabIndex = 11;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel6.Location = new System.Drawing.Point(820, 59);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(5, 452);
            this.kryptonPanel6.TabIndex = 10;
            // 
            // warehouseDTOBindingSource
            // 
            this.warehouseDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WarehouseDTO);
            // 
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // finalAccountDetailDTOBindingSource
            // 
            this.finalAccountDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDetailDTO);
            // 
            // gbcMenuBot
            // 
            this.gbcMenuBot.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbcMenuBot.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCustom1;
            this.gbcMenuBot.Location = new System.Drawing.Point(0, 0);
            this.gbcMenuBot.Name = "gbcMenuBot";
            this.gbcMenuBot.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // gbcMenuBot.Panel
            // 
            this.gbcMenuBot.Panel.Controls.Add(this.removeButton);
            this.gbcMenuBot.Panel.Controls.Add(this.btnEdit);
            this.gbcMenuBot.Panel.Controls.Add(this.btnAddWarehouse);
            this.gbcMenuBot.Size = new System.Drawing.Size(825, 59);
            this.gbcMenuBot.TabIndex = 14;
            this.gbcMenuBot.Values.Heading = "";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(180, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(78, 46);
            this.removeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.removeButton.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.removeButton.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.removeButton.TabIndex = 5;
            this.removeButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Values.Image")));
            this.removeButton.Values.Text = "Xóa Nhà Cung Cấp";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(92, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 46);
            this.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnEdit.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Values.Image")));
            this.btnEdit.Values.Text = "Sửa Nhà Cung Cấp";
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnAddWarehouse.Location = new System.Drawing.Point(5, 3);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(81, 46);
            this.btnAddWarehouse.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddWarehouse.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAddWarehouse.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnAddWarehouse.TabIndex = 3;
            this.btnAddWarehouse.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWarehouse.Values.Image")));
            this.btnAddWarehouse.Values.Text = "Tạo Nhà Cung Cấp";
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
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
            this.Controls.Add(this.gbcMenuBot);
            this.Name = "DebtManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DebtManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.scBot.Panel1.ResumeLayout(false);
            this.scBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).EndInit();
            this.scBot.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            this.gbcMenuBot.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).EndInit();
            this.gbcMenuBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.BindingSource warehouseDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource debtDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer scBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLeftBot;
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
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcMenuBot;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddWarehouse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton removeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}

