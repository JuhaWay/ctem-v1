namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    partial class StockOutManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.dgvStockout = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.StockOutId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportationCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpSearchFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbNameSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockout
            // 
            this.dgvStockout.AutoGenerateColumns = false;
            this.dgvStockout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockOutId,
            this.DateStockOut,
            this.StockOutFrom,
            this.StockOutTo,
            this.TransportationCost,
            this.DriverName,
            this.VehicleName,
            this.NoVehicle,
            this.Note,
            this.CreatedBy,
            this.CreateDate,
            this.UpdatedBy,
            this.LastUpdate});
            this.dgvStockout.DataSource = this.stockOutDTOBindingSource;
            this.dgvStockout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockout.Location = new System.Drawing.Point(0, 87);
            this.dgvStockout.Name = "dgvStockout";
            this.dgvStockout.Size = new System.Drawing.Size(915, 396);
            this.dgvStockout.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvStockout.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvStockout.TabIndex = 8;
            // 
            // StockOutId
            // 
            this.StockOutId.DataPropertyName = "StockOutId";
            this.StockOutId.HeaderText = "Mã Số";
            this.StockOutId.Name = "StockOutId";
            this.StockOutId.Width = 70;
            // 
            // DateStockOut
            // 
            this.DateStockOut.DataPropertyName = "DateStockOut";
            this.DateStockOut.HeaderText = "Ngày Xuất Kho";
            this.DateStockOut.Name = "DateStockOut";
            // 
            // StockOutFrom
            // 
            this.StockOutFrom.DataPropertyName = "StockOutFrom";
            this.StockOutFrom.HeaderText = "Xuất Từ";
            this.StockOutFrom.Name = "StockOutFrom";
            // 
            // StockOutTo
            // 
            this.StockOutTo.DataPropertyName = "StockOutTo";
            this.StockOutTo.HeaderText = "Đến";
            this.StockOutTo.Name = "StockOutTo";
            // 
            // TransportationCost
            // 
            this.TransportationCost.DataPropertyName = "TransportationCost";
            this.TransportationCost.HeaderText = "Chi Phí Vận Chuyễn";
            this.TransportationCost.Name = "TransportationCost";
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Tài Xế";
            this.DriverName.Name = "DriverName";
            // 
            // VehicleName
            // 
            this.VehicleName.DataPropertyName = "VehicleName";
            this.VehicleName.HeaderText = "Xe";
            this.VehicleName.Name = "VehicleName";
            // 
            // NoVehicle
            // 
            this.NoVehicle.DataPropertyName = "NoVehicle";
            this.NoVehicle.HeaderText = "Biển Số";
            this.NoVehicle.Name = "NoVehicle";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Người Tạo";
            this.CreatedBy.Name = "CreatedBy";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Ngày Tạo";
            this.CreateDate.Name = "CreateDate";
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            this.UpdatedBy.HeaderText = "Người Cấp Nhật";
            this.UpdatedBy.Name = "UpdatedBy";
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "Ngày Cấp Nhật";
            this.LastUpdate.Name = "LastUpdate";
            // 
            // stockOutDTOBindingSource
            // 
            this.stockOutDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.StockOutDTO);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(915, 58);
            this.pnlSearch.TabIndex = 7;
            // 
            // gbxSearch
            // 
            this.gbxSearch.CaptionOverlap = 0D;
            this.gbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSearch.Location = new System.Drawing.Point(50, 0);
            this.gbxSearch.Name = "gbxSearch";
            // 
            // gbxSearch.Panel
            // 
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchFrom);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchTo);
            this.gbxSearch.Panel.Controls.Add(this.cbbNameSearch);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxSearch.Size = new System.Drawing.Size(815, 53);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchFrom.Location = new System.Drawing.Point(480, 15);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(103, 20);
            this.dtpSearchFrom.TabIndex = 9;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(396, 15);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(78, 19);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Ngày Xuất Từ";
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchTo.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchTo.Location = new System.Drawing.Point(628, 15);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(94, 20);
            this.dtpSearchTo.TabIndex = 7;
            // 
            // cbbNameSearch
            // 
            this.cbbNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNameSearch.DropDownWidth = 218;
            this.cbbNameSearch.Location = new System.Drawing.Point(124, 14);
            this.cbbNameSearch.Name = "cbbNameSearch";
            this.cbbNameSearch.Size = new System.Drawing.Size(268, 22);
            this.cbbNameSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(728, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 3;
            this.btnSearch.Size = new System.Drawing.Size(70, 43);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 3;
            this.btnSearch.StatePressed.Back.Color1 = System.Drawing.Color.Orange;
            this.btnSearch.StatePressed.Back.Color2 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.find1;
            this.btnSearch.Values.Text = "Tìm";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel10.Location = new System.Drawing.Point(592, 16);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(30, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Đến";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(18, 16);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(71, 19);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Xuất Từ Kho";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnRefresh,
            this.btnAdd,
            this.btnDelete,
            this.btnDeleteAll,
            this.btnHideShowSearch});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(915, 29);
            this.hdDebt.TabIndex = 6;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Danh Nhà Cung Cấp";
            this.hdDebt.Values.Image = null;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.reload;
            this.btnRefresh.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UniqueName = "4C2FCC4A6195428907A74FD31E7A9F69";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UniqueName = "6E177DC1660348E375BDCE591BF21FCB";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btnDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UniqueName = "46715A2AEC0143074F81325F50887305";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.cancel;
            this.btnDeleteAll.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDeleteAll.Text = "Xóa Tất Cả";
            this.btnDeleteAll.UniqueName = "CD7065CA8BA743FB00B53BCE567E60B8";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            this.btnHideShowSearch.Click += new System.EventHandler(this.btnHideShowSearch_Click);
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.SearchToolStripMenuItem,
            this.HideSearchToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.xóaTấtCảToolStripMenuItem});
            this.cmsMain.Name = "cmsDGV";
            this.cmsMain.Size = new System.Drawing.Size(184, 136);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem1.Text = "Làm Mới";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem3.Text = "Thêm";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.SearchToolStripMenuItem.Text = "Tìm Kiếm";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // HideSearchToolStripMenuItem
            // 
            this.HideSearchToolStripMenuItem.Name = "HideSearchToolStripMenuItem";
            this.HideSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HideSearchToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.HideSearchToolStripMenuItem.Text = "Ẩn Tìm Kiếm";
            this.HideSearchToolStripMenuItem.Click += new System.EventHandler(this.HideSearchToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            this.xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            this.xóaTấtCảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaTấtCảToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.xóaTấtCảToolStripMenuItem.Text = "Xóa Tất Cả";
            this.xóaTấtCảToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // StockOutManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 483);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.dgvStockout);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.hdDebt);
            this.Name = "StockOutManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Lịch Xuất Kho";
            this.Load += new System.EventHandler(this.StockOutManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource stockOutDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvStockout;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchTo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbNameSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportationCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảToolStripMenuItem;
    }
}

