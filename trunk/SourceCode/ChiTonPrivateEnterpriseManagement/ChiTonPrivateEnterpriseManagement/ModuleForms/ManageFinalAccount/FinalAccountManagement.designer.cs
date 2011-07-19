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
            this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAccount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbbDebt = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbNameSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.FinalAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAccountFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportationCostFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDetail = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLoadAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsDGV.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsDGV
            // 
            this.cmsDGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.LoadAllToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.DeleteAllToolStripMenuItem});
            this.cmsDGV.Name = "cmsDGV";
            this.cmsDGV.Size = new System.Drawing.Size(182, 114);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.RefreshToolStripMenuItem.Text = "Làm Mới";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LoadAllToolStripMenuItem
            // 
            this.LoadAllToolStripMenuItem.Name = "LoadAllToolStripMenuItem";
            this.LoadAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.LoadAllToolStripMenuItem.Text = "Tải Tất Cả";
            this.LoadAllToolStripMenuItem.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AddToolStripMenuItem.Text = "Thêm";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.DeleteToolStripMenuItem.Text = "Xóa";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.DeleteAllToolStripMenuItem.Text = "Xóa Tất Cả";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.SearchToolStripMenuItem,
            this.HideSearchToolStripMenuItem});
            this.cmsMain.Name = "cmsDGV";
            this.cmsMain.Size = new System.Drawing.Size(184, 92);
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
            // dgvAccount
            // 
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinalAccountID,
            this.FinalAccountName,
            this.ConstructionName,
            this.DateAccountFormated,
            this.DebtName,
            this.TransportationCostFormated,
            this.TotalCostFormated,
            this.personAccountDataGridViewTextBoxColumn,
            this.IsPay,
            this.Note,
            this.CreatedBy,
            this.CreatedDate,
            this.UpdatedBy,
            this.LastUpdated});
            this.dgvAccount.ContextMenuStrip = this.cmsDGV;
            this.dgvAccount.DataSource = this.finalAccountDTOBindingSource;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 105);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(784, 417);
            this.dgvAccount.TabIndex = 25;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Người Tạo";
            this.CreatedBy.Name = "CreatedBy";
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Ngày Tạo";
            this.CreatedDate.Name = "CreatedDate";
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            this.UpdatedBy.HeaderText = "Người Sửa";
            this.UpdatedBy.Name = "UpdatedBy";
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "LastUpdated";
            this.LastUpdated.HeaderText = "Ngày Sửa";
            this.LastUpdated.Name = "LastUpdated";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(784, 76);
            this.pnlSearch.TabIndex = 24;
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
            this.gbxSearch.Panel.Controls.Add(this.cbbDebt);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxSearch.Panel.Controls.Add(this.cbbCons);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxSearch.Panel.Controls.Add(this.txtId);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchFrom);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchTo);
            this.gbxSearch.Panel.Controls.Add(this.cbbNameSearch);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxSearch.Size = new System.Drawing.Size(684, 71);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // cbbDebt
            // 
            this.cbbDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDebt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbDebt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDebt.DropDownWidth = 218;
            this.cbbDebt.Location = new System.Drawing.Point(299, 34);
            this.cbbDebt.Name = "cbbDebt";
            this.cbbDebt.Size = new System.Drawing.Size(158, 22);
            this.cbbDebt.TabIndex = 14;
            this.cbbDebt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(214, 34);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Khách Hàng";
            // 
            // cbbCons
            // 
            this.cbbCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCons.DropDownWidth = 218;
            this.cbbCons.Location = new System.Drawing.Point(299, 11);
            this.cbbCons.Name = "cbbCons";
            this.cbbCons.Size = new System.Drawing.Size(158, 22);
            this.cbbCons.TabIndex = 12;
            this.cbbCons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(222, 11);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 13;
            this.kryptonLabel2.Values.Text = "Công Trình";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(55, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 22);
            this.txtId.TabIndex = 11;
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(21, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(26, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Mã";
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.CalendarTodayDate = new System.DateTime(2011, 7, 16, 0, 0, 0, 0);
            this.dtpSearchFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchFrom.Location = new System.Drawing.Point(497, 11);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(94, 20);
            this.dtpSearchFrom.TabIndex = 9;
            this.dtpSearchFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(468, 11);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(23, 19);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Từ";
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchTo.CalendarTodayDate = new System.DateTime(2011, 7, 16, 0, 0, 0, 0);
            this.dtpSearchTo.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchTo.Location = new System.Drawing.Point(497, 34);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(94, 20);
            this.dtpSearchTo.TabIndex = 7;
            this.dtpSearchTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // cbbNameSearch
            // 
            this.cbbNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNameSearch.DropDownWidth = 218;
            this.cbbNameSearch.Location = new System.Drawing.Point(55, 34);
            this.cbbNameSearch.Name = "cbbNameSearch";
            this.cbbNameSearch.Size = new System.Drawing.Size(153, 22);
            this.cbbNameSearch.TabIndex = 1;
            this.cbbNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(597, 11);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel10.Location = new System.Drawing.Point(461, 35);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(30, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Đến";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(19, 35);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(28, 19);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Tên";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDetail,
            this.btnRefresh,
            this.btnLoadAll,
            this.btnAdd,
            this.btnDelete,
            this.btnDeleteAll,
            this.btnHideShowSearch});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(784, 29);
            this.hdDebt.TabIndex = 23;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Lịch Mua Hàng";
            this.hdDebt.Values.Image = null;
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            this.btnHideShowSearch.Click += new System.EventHandler(this.btnHideShowSearch_Click);
            // 
            // FinalAccountID
            // 
            this.FinalAccountID.DataPropertyName = "FinalAccountID";
            this.FinalAccountID.HeaderText = "Mã Số";
            this.FinalAccountID.Name = "FinalAccountID";
            // 
            // FinalAccountName
            // 
            this.FinalAccountName.DataPropertyName = "FinalAccountName";
            this.FinalAccountName.HeaderText = "Tên";
            this.FinalAccountName.Name = "FinalAccountName";
            // 
            // ConstructionName
            // 
            this.ConstructionName.DataPropertyName = "ConstructionName";
            this.ConstructionName.HeaderText = "Công Trình";
            this.ConstructionName.Name = "ConstructionName";
            // 
            // DateAccountFormated
            // 
            this.DateAccountFormated.DataPropertyName = "DateAccountFormated";
            this.DateAccountFormated.HeaderText = "Ngày";
            this.DateAccountFormated.Name = "DateAccountFormated";
            // 
            // DebtName
            // 
            this.DebtName.DataPropertyName = "DebtName";
            this.DebtName.HeaderText = "Khách Hàng";
            this.DebtName.Name = "DebtName";
            // 
            // TransportationCostFormated
            // 
            this.TransportationCostFormated.DataPropertyName = "TransportationCostFormated";
            this.TransportationCostFormated.HeaderText = "Tiền Vận Chuyễn";
            this.TransportationCostFormated.Name = "TransportationCostFormated";
            // 
            // TotalCostFormated
            // 
            this.TotalCostFormated.DataPropertyName = "TotalCostFormated";
            this.TotalCostFormated.HeaderText = "Tổng Số Tiền";
            this.TotalCostFormated.Name = "TotalCostFormated";
            // 
            // personAccountDataGridViewTextBoxColumn
            // 
            this.personAccountDataGridViewTextBoxColumn.DataPropertyName = "PersonAccount";
            this.personAccountDataGridViewTextBoxColumn.HeaderText = "Chịu Trách Nhiệm";
            this.personAccountDataGridViewTextBoxColumn.Name = "personAccountDataGridViewTextBoxColumn";
            // 
            // IsPay
            // 
            this.IsPay.DataPropertyName = "IsPay";
            this.IsPay.HeaderText = "Đã Thanh Toán";
            this.IsPay.Name = "IsPay";
            this.IsPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            // 
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // btnDetail
            // 
            this.btnDetail.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.application_view_detail;
            this.btnDetail.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDetail.Text = "Chi Tiết";
            this.btnDetail.UniqueName = "9ED4C66AD88E43F2E6A7F88849090635";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.reload;
            this.btnRefresh.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UniqueName = "4C2FCC4A6195428907A74FD31E7A9F69";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.load_all;
            this.btnLoadAll.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnLoadAll.Text = "Tải Tất Cả";
            this.btnLoadAll.UniqueName = "BEB5C4DDF1A44429B8A9BDEDC950C4D6";
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
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
            // FinalAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.hdDebt);
            this.Name = "FinalAccountManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Mua Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinalAccountManagement_Load);
            this.cmsDGV.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmsDGV;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvAccount;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDebt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchTo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbNameSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDetail;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLoadAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAccountFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportationCostFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
    }
}

