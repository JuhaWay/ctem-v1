namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    partial class WarehouseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.scBot = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbcMenuBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddWarehouse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.warehouseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).BeginInit();
            this.scBot.Panel1.SuspendLayout();
            this.scBot.Panel2.SuspendLayout();
            this.scBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).BeginInit();
            this.gbcMenuBot.Panel.SuspendLayout();
            this.gbcMenuBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel6.Location = new System.Drawing.Point(779, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(5, 562);
            this.kryptonPanel6.TabIndex = 6;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(5, 562);
            this.kryptonPanel2.TabIndex = 7;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(5, 557);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(774, 5);
            this.kryptonPanel3.TabIndex = 8;
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.scBot);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.gbcMenuBot);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(5, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(774, 557);
            this.kryptonPanel.TabIndex = 9;
            // 
            // scBot
            // 
            this.scBot.Cursor = System.Windows.Forms.Cursors.Default;
            this.scBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBot.Location = new System.Drawing.Point(0, 62);
            this.scBot.Name = "scBot";
            // 
            // scBot.Panel1
            // 
            this.scBot.Panel1.Controls.Add(this.gbxLeftBot);
            // 
            // scBot.Panel2
            // 
            this.scBot.Panel2.Controls.Add(this.gbcRightBot);
            this.scBot.Size = new System.Drawing.Size(774, 495);
            this.scBot.SplitterDistance = 601;
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
            this.gbxLeftBot.Size = new System.Drawing.Size(601, 495);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // dgvLeftBot
            // 
            this.dgvLeftBot.AutoGenerateColumns = false;
            this.dgvLeftBot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.warehouseIDDataGridViewTextBoxColumn,
            this.warehouseNameDataGridViewTextBoxColumn,
            this.constructionIDDataGridViewTextBoxColumn,
            this.constructionNameDataGridViewTextBoxColumn,
            this.managerNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.dgvLeftBot.DataSource = this.warehouseDTOBindingSource;
            this.dgvLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeftBot.Location = new System.Drawing.Point(0, 23);
            this.dgvLeftBot.Name = "dgvLeftBot";
            this.dgvLeftBot.Size = new System.Drawing.Size(597, 466);
            this.dgvLeftBot.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            this.gbcRightBot.Size = new System.Drawing.Size(168, 495);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 59);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(774, 3);
            this.kryptonPanel1.TabIndex = 7;
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
            this.gbcMenuBot.Panel.Controls.Add(this.btnEdit);
            this.gbcMenuBot.Panel.Controls.Add(this.btnAddWarehouse);
            this.gbcMenuBot.Size = new System.Drawing.Size(774, 59);
            this.gbcMenuBot.TabIndex = 5;
            this.gbcMenuBot.Values.Heading = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(92, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 45);
            this.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnEdit.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Values.Image")));
            this.btnEdit.Values.Text = "Sửa Kho";
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
            this.btnAddWarehouse.Values.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Values.Image")));
            this.btnAddWarehouse.Values.Text = "Tạo Kho";
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(597, 23);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách Kho";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // warehouseIDDataGridViewTextBoxColumn
            // 
            this.warehouseIDDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.HeaderText = "WarehouseID";
            this.warehouseIDDataGridViewTextBoxColumn.Name = "warehouseIDDataGridViewTextBoxColumn";
            // 
            // warehouseNameDataGridViewTextBoxColumn
            // 
            this.warehouseNameDataGridViewTextBoxColumn.DataPropertyName = "WarehouseName";
            this.warehouseNameDataGridViewTextBoxColumn.HeaderText = "WarehouseName";
            this.warehouseNameDataGridViewTextBoxColumn.Name = "warehouseNameDataGridViewTextBoxColumn";
            // 
            // constructionIDDataGridViewTextBoxColumn
            // 
            this.constructionIDDataGridViewTextBoxColumn.DataPropertyName = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.HeaderText = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.Name = "constructionIDDataGridViewTextBoxColumn";
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "ConstructionName";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            // 
            // managerNameDataGridViewTextBoxColumn
            // 
            this.managerNameDataGridViewTextBoxColumn.DataPropertyName = "ManagerName";
            this.managerNameDataGridViewTextBoxColumn.HeaderText = "ManagerName";
            this.managerNameDataGridViewTextBoxColumn.Name = "managerNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
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
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel6);
            this.Name = "WarehouseManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.scBot.Panel1.ResumeLayout(false);
            this.scBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).EndInit();
            this.scBot.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.gbcMenuBot.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbcMenuBot)).EndInit();
            this.gbcMenuBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer scBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcMenuBot;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLeftBot;
        private System.Windows.Forms.BindingSource warehouseDTOBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddWarehouse;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}

