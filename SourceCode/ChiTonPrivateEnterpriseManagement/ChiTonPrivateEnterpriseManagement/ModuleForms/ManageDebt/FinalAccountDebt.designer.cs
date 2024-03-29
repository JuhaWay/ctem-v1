﻿namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    partial class FinalAccountDebt
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
            this.FinalAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAccountFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TransportationCostFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostFormated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbbDebtSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLoadAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.hdEdit = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnUnableEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsDGV.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDebtSearch)).BeginInit();
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
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AddToolStripMenuItem.Text = "Thêm";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.DeleteToolStripMenuItem.Text = "Xóa";
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.DeleteAllToolStripMenuItem.Text = "Xóa Tất Cả";
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
            this.ConstructionName,
            this.DateAccountFormated,
            this.DebtName,
            this.IsPay,
            this.TransportationCostFormated,
            this.TotalCostFormated,
            this.personAccountDataGridViewTextBoxColumn,
            this.Note,
            this.CreatedBy,
            this.CreatedDate,
            this.UpdatedBy,
            this.LastUpdated});
            this.dgvAccount.ContextMenuStrip = this.cmsDGV;
            this.dgvAccount.DataSource = this.finalAccountDTOBindingSource;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 89);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(784, 404);
            this.dgvAccount.TabIndex = 25;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // FinalAccountID
            // 
            this.FinalAccountID.DataPropertyName = "FinalAccountID";
            this.FinalAccountID.HeaderText = "Mã Số";
            this.FinalAccountID.Name = "FinalAccountID";
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
            // IsPay
            // 
            this.IsPay.DataPropertyName = "IsPay";
            this.IsPay.HeaderText = "Đã Thanh Toán";
            this.IsPay.Name = "IsPay";
            this.IsPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(784, 60);
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
            this.gbxSearch.Panel.Controls.Add(this.cbbDebtSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchFrom);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchTo);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Size = new System.Drawing.Size(684, 55);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // cbbDebtSearch
            // 
            this.cbbDebtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDebtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbDebtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDebtSearch.DropDownWidth = 218;
            this.cbbDebtSearch.Location = new System.Drawing.Point(101, 11);
            this.cbbDebtSearch.Name = "cbbDebtSearch";
            this.cbbDebtSearch.Size = new System.Drawing.Size(176, 22);
            this.cbbDebtSearch.TabIndex = 14;
            this.cbbDebtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 14);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Khách Hàng";
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.CalendarTodayDate = new System.DateTime(2011, 7, 16, 0, 0, 0, 0);
            this.dtpSearchFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchFrom.Location = new System.Drawing.Point(333, 13);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(98, 20);
            this.dtpSearchFrom.TabIndex = 9;
            this.dtpSearchFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(304, 13);
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
            this.dtpSearchTo.Location = new System.Drawing.Point(494, 13);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(98, 20);
            this.dtpSearchTo.TabIndex = 7;
            this.dtpSearchTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(605, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 3;
            this.btnSearch.Size = new System.Drawing.Size(62, 41);
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
            this.kryptonLabel10.Location = new System.Drawing.Point(458, 14);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(30, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Đến";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnRefresh,
            this.btnLoadAll,
            this.btnHideShowSearch});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(784, 29);
            this.hdDebt.TabIndex = 23;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Danh Sách Mua Hàng";
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
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            this.btnHideShowSearch.Click += new System.EventHandler(this.btnHideShowSearch_Click);
            // 
            // hdEdit
            // 
            this.hdEdit.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnUnableEdit});
            this.hdEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hdEdit.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdEdit.Location = new System.Drawing.Point(0, 493);
            this.hdEdit.Name = "hdEdit";
            this.hdEdit.Size = new System.Drawing.Size(784, 29);
            this.hdEdit.TabIndex = 3;
            this.hdEdit.Values.Description = "";
            this.hdEdit.Values.Heading = "Cập Nhật Tình Trạng";
            this.hdEdit.Values.Image = null;
            // 
            // btnUnableEdit
            // 
            this.btnUnableEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.right;
            this.btnUnableEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnUnableEdit.Text = "Bước Tiếp Theo";
            this.btnUnableEdit.UniqueName = "711D4B5F7134438B489063D5667E49ED";
            this.btnUnableEdit.Click += new System.EventHandler(this.btnUnableEdit_Click);
            // 
            // FinalAccountDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.hdDebt);
            this.Controls.Add(this.hdEdit);
            this.Name = "FinalAccountDebt";
            this.ShowIcon = false;
            this.Text = "Bảng Công Nợ";
            this.Load += new System.EventHandler(this.FinalAccountManagement_Load);
            this.cmsDGV.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbDebtSearch)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDebtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchTo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLoadAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnUnableEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAccountFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportationCostFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostFormated;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
    }
}

