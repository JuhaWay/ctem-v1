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
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvDebt = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.DebtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbbNameSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbStatusSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtIdSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLoadAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.slcEdit = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreezeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxEdit1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtDebtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalOwe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmsGen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GenMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDebtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gbxEdit2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhonenumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hdEdit = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnUnableEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).BeginInit();
            this.cmsDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatusSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.Panel.SuspendLayout();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcEdit)).BeginInit();
            this.slcEdit.Panel1.SuspendLayout();
            this.slcEdit.Panel2.SuspendLayout();
            this.slcEdit.SuspendLayout();
            this.cmsEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).BeginInit();
            this.gbxEdit1.Panel.SuspendLayout();
            this.gbxEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            this.cmsGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).BeginInit();
            this.gbxEdit2.Panel.SuspendLayout();
            this.gbxEdit2.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            this.slcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.gbxLeftBot);
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.gbcRightBot);
            this.slcMain.Size = new System.Drawing.Size(825, 511);
            this.slcMain.SplitterDistance = 289;
            this.slcMain.TabIndex = 13;
            // 
            // gbxLeftBot
            // 
            this.gbxLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLeftBot.Location = new System.Drawing.Point(0, 0);
            this.gbxLeftBot.Name = "gbxLeftBot";
            // 
            // gbxLeftBot.Panel
            // 
            this.gbxLeftBot.Panel.Controls.Add(this.dgvDebt);
            this.gbxLeftBot.Panel.Controls.Add(this.pnlSearch);
            this.gbxLeftBot.Panel.Controls.Add(this.hdDebt);
            this.gbxLeftBot.Size = new System.Drawing.Size(825, 289);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // dgvDebt
            // 
            this.dgvDebt.AutoGenerateColumns = false;
            this.dgvDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DebtID,
            this.DebtName,
            this.TotalOwe,
            this.Address,
            this.PhoneNumber,
            this.IsActive,
            this.Note,
            this.createdByDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn});
            this.dgvDebt.ContextMenuStrip = this.cmsDGV;
            this.dgvDebt.DataSource = this.debtDTOBindingSource;
            this.dgvDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebt.Location = new System.Drawing.Point(0, 92);
            this.dgvDebt.Name = "dgvDebt";
            this.dgvDebt.Size = new System.Drawing.Size(821, 191);
            this.dgvDebt.TabIndex = 0;
            this.dgvDebt.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebt_CellEnter);
            this.dgvDebt.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDebt_RowHeaderMouseClick);
            // 
            // DebtID
            // 
            this.DebtID.DataPropertyName = "DebtID";
            this.DebtID.HeaderText = "Mã";
            this.DebtID.Name = "DebtID";
            this.DebtID.Width = 70;
            // 
            // DebtName
            // 
            this.DebtName.DataPropertyName = "DebtName";
            this.DebtName.HeaderText = "Tên";
            this.DebtName.Name = "DebtName";
            this.DebtName.Width = 150;
            // 
            // TotalOwe
            // 
            this.TotalOwe.DataPropertyName = "TotalOweFomated";
            this.TotalOwe.HeaderText = "Tổng Nợ (VND)";
            this.TotalOwe.Name = "TotalOwe";
            this.TotalOwe.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.Width = 200;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Điện Thoại";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 150;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Còn Liên Hệ";
            this.IsActive.Name = "IsActive";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Người Tạo";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Người Sửa";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "Ngày Sửa";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.Width = 150;
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
            this.cmsDGV.Size = new System.Drawing.Size(174, 114);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.RefreshToolStripMenuItem.Text = "Làm Mới";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LoadAllToolStripMenuItem
            // 
            this.LoadAllToolStripMenuItem.Name = "LoadAllToolStripMenuItem";
            this.LoadAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.LoadAllToolStripMenuItem.Text = "Tải Tất Cả";
            this.LoadAllToolStripMenuItem.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.AddToolStripMenuItem.Text = "Thêm";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteToolStripMenuItem.Text = "Xóa";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteAllToolStripMenuItem.Text = "Xóa Tất Cả";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // debtDTOBindingSource
            // 
            this.debtDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DebtDTO);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(821, 62);
            this.pnlSearch.TabIndex = 1;
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
            this.gbxSearch.Panel.Controls.Add(this.cbbNameSearch);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.cbbStatusSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxSearch.Panel.Controls.Add(this.txtIdSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxSearch.Size = new System.Drawing.Size(721, 57);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // cbbNameSearch
            // 
            this.cbbNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNameSearch.DropDownWidth = 218;
            this.cbbNameSearch.Location = new System.Drawing.Point(266, 16);
            this.cbbNameSearch.Name = "cbbNameSearch";
            this.cbbNameSearch.Size = new System.Drawing.Size(149, 21);
            this.cbbNameSearch.TabIndex = 1;
            this.cbbNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(634, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 3;
            this.btnSearch.Size = new System.Drawing.Size(70, 46);
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
            // cbbStatusSearch
            // 
            this.cbbStatusSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbStatusSearch.DropDownWidth = 218;
            this.cbbStatusSearch.Location = new System.Drawing.Point(496, 16);
            this.cbbStatusSearch.Name = "cbbStatusSearch";
            this.cbbStatusSearch.Size = new System.Drawing.Size(132, 21);
            this.cbbStatusSearch.TabIndex = 2;
            this.cbbStatusSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdSearch_KeyDown);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel10.Location = new System.Drawing.Point(421, 16);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Tình Trạng";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(160, 16);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Tên Khách Hàng";
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.Location = new System.Drawing.Point(65, 16);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(89, 20);
            this.txtIdSearch.TabIndex = 0;
            this.txtIdSearch.Enter += new System.EventHandler(this.txtTotalOwe_Enter);
            this.txtIdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdSearch_KeyDown);
            this.txtIdSearch.Leave += new System.EventHandler(this.txtTotalOwe_Leave);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(16, 16);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 4;
            this.kryptonLabel8.Values.Text = "Mã Số";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
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
            this.hdDebt.Size = new System.Drawing.Size(821, 30);
            this.hdDebt.TabIndex = 0;
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
            this.btnAdd.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
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
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            // 
            // gbcRightBot.Panel
            // 
            this.gbcRightBot.Panel.Controls.Add(this.slcEdit);
            this.gbcRightBot.Panel.Controls.Add(this.hdEdit);
            this.gbcRightBot.Size = new System.Drawing.Size(825, 217);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // slcEdit
            // 
            this.slcEdit.ContextMenuStrip = this.cmsEdit;
            this.slcEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcEdit.Location = new System.Drawing.Point(0, 30);
            this.slcEdit.Name = "slcEdit";
            // 
            // slcEdit.Panel1
            // 
            this.slcEdit.Panel1.Controls.Add(this.gbxEdit1);
            this.slcEdit.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.slcEdit.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // slcEdit.Panel2
            // 
            this.slcEdit.Panel2.Controls.Add(this.gbxEdit2);
            this.slcEdit.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcEdit.Size = new System.Drawing.Size(821, 181);
            this.slcEdit.SplitterDistance = 409;
            this.slcEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcEdit.TabIndex = 4;
            // 
            // cmsEdit
            // 
            this.cmsEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.FreezeToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(175, 70);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.EditToolStripMenuItem.Text = "Sửa";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FreezeToolStripMenuItem
            // 
            this.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem";
            this.FreezeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.FreezeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FreezeToolStripMenuItem.Text = "Đóng Băng";
            this.FreezeToolStripMenuItem.Click += new System.EventHandler(this.btnUnableEdit_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SaveToolStripMenuItem.Text = "Lưu";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxEdit1
            // 
            this.gbxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit1.Location = new System.Drawing.Point(5, 0);
            this.gbxEdit1.Name = "gbxEdit1";
            // 
            // gbxEdit1.Panel
            // 
            this.gbxEdit1.Panel.Controls.Add(this.txtDebtId);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxEdit1.Panel.Controls.Add(this.cbbStatus);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxEdit1.Panel.Controls.Add(this.txtTotalOwe);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxEdit1.Panel.Controls.Add(this.txtDebtName);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxEdit1.Size = new System.Drawing.Size(404, 176);
            this.gbxEdit1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(144)))));
            this.gbxEdit1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxEdit1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdit1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxEdit1.TabIndex = 5;
            this.gbxEdit1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // txtDebtId
            // 
            this.txtDebtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebtId.Location = new System.Drawing.Point(118, 16);
            this.txtDebtId.Name = "txtDebtId";
            this.txtDebtId.Size = new System.Drawing.Size(251, 20);
            this.txtDebtId.TabIndex = 0;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(65, 18);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 46;
            this.kryptonLabel4.Values.Text = "Mã Số";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbStatus.DropDownWidth = 218;
            this.cbbStatus.Location = new System.Drawing.Point(118, 94);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(251, 21);
            this.cbbStatus.TabIndex = 3;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(43, 96);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.TabIndex = 44;
            this.kryptonLabel6.Values.Text = "Tình Trạng";
            // 
            // txtTotalOwe
            // 
            this.txtTotalOwe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalOwe.ContextMenuStrip = this.cmsGen;
            this.txtTotalOwe.Location = new System.Drawing.Point(118, 68);
            this.txtTotalOwe.Name = "txtTotalOwe";
            this.txtTotalOwe.Size = new System.Drawing.Size(251, 20);
            this.txtTotalOwe.TabIndex = 2;
            this.txtTotalOwe.Enter += new System.EventHandler(this.txtTotalOwe_Enter);
            this.txtTotalOwe.Leave += new System.EventHandler(this.txtTotalOwe_Leave);
            // 
            // cmsGen
            // 
            this.cmsGen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenMoneyToolStripMenuItem});
            this.cmsGen.Name = "cmsGen";
            this.cmsGen.Size = new System.Drawing.Size(169, 26);
            // 
            // GenMoneyToolStripMenuItem
            // 
            this.GenMoneyToolStripMenuItem.Name = "GenMoneyToolStripMenuItem";
            this.GenMoneyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GenMoneyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.GenMoneyToolStripMenuItem.Text = "Thêm 000";
            this.GenMoneyToolStripMenuItem.Click += new System.EventHandler(this.GenMoneyToolStripMenuItem_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(35, 70);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 40;
            this.kryptonLabel3.Values.Text = "Nợ Hiện Tại";
            // 
            // txtDebtName
            // 
            this.txtDebtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebtName.Location = new System.Drawing.Point(118, 42);
            this.txtDebtName.Name = "txtDebtName";
            this.txtDebtName.Size = new System.Drawing.Size(251, 20);
            this.txtDebtName.TabIndex = 1;
            this.txtDebtName.TextChanged += new System.EventHandler(this.txtDebtName_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 44);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 36;
            this.kryptonLabel1.Values.Text = "Tên Khách Hàng";
            // 
            // gbxEdit2
            // 
            this.gbxEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit2.Location = new System.Drawing.Point(0, 0);
            this.gbxEdit2.Name = "gbxEdit2";
            // 
            // gbxEdit2.Panel
            // 
            this.gbxEdit2.Panel.Controls.Add(this.txtDescription);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxEdit2.Panel.Controls.Add(this.txtAddress);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxEdit2.Panel.Controls.Add(this.txtPhonenumber);
            this.gbxEdit2.Size = new System.Drawing.Size(407, 181);
            this.gbxEdit2.TabIndex = 5;
            this.gbxEdit2.Values.Heading = "Thông Tin Thêm";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(118, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 45);
            this.txtDescription.TabIndex = 2;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(58, 92);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel7.TabIndex = 44;
            this.kryptonLabel7.Values.Text = "Ghi Chú";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(118, 40);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 46);
            this.txtAddress.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(63, 40);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 40;
            this.kryptonLabel5.Values.Text = "Địa Chỉ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 14);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 37;
            this.kryptonLabel2.Values.Text = "Số Điện Thoại";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonenumber.Location = new System.Drawing.Point(118, 14);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(259, 20);
            this.txtPhonenumber.TabIndex = 0;
            this.txtPhonenumber.Leave += new System.EventHandler(this.txtPhonenumber_Leave);
            // 
            // hdEdit
            // 
            this.hdEdit.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnEdit,
            this.btnUnableEdit,
            this.btnSave});
            this.hdEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdEdit.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdEdit.Location = new System.Drawing.Point(0, 0);
            this.hdEdit.Name = "hdEdit";
            this.hdEdit.Size = new System.Drawing.Size(821, 30);
            this.hdEdit.TabIndex = 3;
            this.hdEdit.Values.Description = "";
            this.hdEdit.Values.Heading = "Thông Tin Chi Tiết";
            this.hdEdit.Values.Image = null;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.Edit;
            this.btnEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UniqueName = "C645E9231765438901BDC91A1034E5D9";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUnableEdit
            // 
            this.btnUnableEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.freeze;
            this.btnUnableEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnUnableEdit.Text = "Đóng Băng";
            this.btnUnableEdit.UniqueName = "711D4B5F7134438B489063D5667E49ED";
            this.btnUnableEdit.Click += new System.EventHandler(this.btnUnableEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnSave.Text = "Lưu";
            this.btnSave.ToolTipTitle = "Lưu";
            this.btnSave.UniqueName = "6549634A1C68497476A2DADA48F6958C";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuCheckBox1
            // 
            this.kryptonContextMenuCheckBox1.ExtraText = "";
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.lưuToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.HideSearchToolStripMenuItem});
            this.cmsMain.Name = "cmsDGV";
            this.cmsMain.Size = new System.Drawing.Size(187, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Làm Mới";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem3.Text = "Thêm";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SearchToolStripMenuItem.Text = "Tìm Kiếm";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // HideSearchToolStripMenuItem
            // 
            this.HideSearchToolStripMenuItem.Name = "HideSearchToolStripMenuItem";
            this.HideSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HideSearchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.HideSearchToolStripMenuItem.Text = "Ẩn Tìm Kiếm";
            this.HideSearchToolStripMenuItem.Click += new System.EventHandler(this.HideSearchToolStripMenuItem_Click);
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
            // DebtManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 511);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.slcMain);
            this.Name = "DebtManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DebtManagement_Load);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebt)).EndInit();
            this.cmsDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.debtDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatusSearch)).EndInit();
            this.gbcRightBot.Panel.ResumeLayout(false);
            this.gbcRightBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            this.slcEdit.Panel1.ResumeLayout(false);
            this.slcEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcEdit)).EndInit();
            this.slcEdit.ResumeLayout(false);
            this.cmsEdit.ResumeLayout(false);
            this.gbxEdit1.Panel.ResumeLayout(false);
            this.gbxEdit1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).EndInit();
            this.gbxEdit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            this.cmsGen.ResumeLayout(false);
            this.gbxEdit2.Panel.ResumeLayout(false);
            this.gbxEdit2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).EndInit();
            this.gbxEdit2.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource warehouseDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource debtDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDebt;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalOwe;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhonenumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDebtName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLoadAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnUnableEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDebtId;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox kryptonContextMenuCheckBox1;
        private System.Windows.Forms.ContextMenuStrip cmsGen;
        private System.Windows.Forms.ToolStripMenuItem GenMoneyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDGV;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreezeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatusSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbNameSearch;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
    }
}

