namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class SalaryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.cmsGenerate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.dgvSalary = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.EmployeeSalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowanceFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCostFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtPayFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualIncomeFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpSearchFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpSearchTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbNameSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdAdvance = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLoadAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.slcEdit = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxEdit1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpMonth = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtActualIncome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gbxEdit2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtDebtPay = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbIsPay = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhoneCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAllowance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hdEdit = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnUnableEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.Panel.SuspendLayout();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcEdit)).BeginInit();
            this.slcEdit.Panel1.SuspendLayout();
            this.slcEdit.Panel2.SuspendLayout();
            this.slcEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).BeginInit();
            this.gbxEdit1.Panel.SuspendLayout();
            this.gbxEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).BeginInit();
            this.gbxEdit2.Panel.SuspendLayout();
            this.gbxEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsPay)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsGenerate
            // 
            this.cmsGenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsGenerate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
            this.cmsGenerate.Name = "cmsGenerate";
            this.cmsGenerate.Size = new System.Drawing.Size(170, 26);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // dgvSalary
            // 
            this.dgvSalary.AutoGenerateColumns = false;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeSalaryID,
            this.Username,
            this.Fullname,
            this.MonthFormat,
            this.SalaryFormat,
            this.AllowanceFormat,
            this.PhoneCostFormat,
            this.DebtPayFormat,
            this.ActualIncomeFormat,
            this.IsPay,
            this.Note,
            this.CreatedDate,
            this.LastUpdate});
            this.dgvSalary.DataSource = this.employeeSalaryDTOBindingSource;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.Location = new System.Drawing.Point(0, 87);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 25;
            this.dgvSalary.Size = new System.Drawing.Size(806, 188);
            this.dgvSalary.TabIndex = 12;
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            // 
            // EmployeeSalaryID
            // 
            this.EmployeeSalaryID.DataPropertyName = "EmployeeSalaryID";
            this.EmployeeSalaryID.HeaderText = "Mã Số";
            this.EmployeeSalaryID.Name = "EmployeeSalaryID";
            this.EmployeeSalaryID.Width = 70;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên Đăng Nhập";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Tên Đầy Đủ";
            this.Fullname.Name = "Fullname";
            this.Fullname.Width = 150;
            // 
            // MonthFormat
            // 
            this.MonthFormat.DataPropertyName = "MonthFormat";
            this.MonthFormat.HeaderText = "Lương Tháng";
            this.MonthFormat.Name = "MonthFormat";
            // 
            // SalaryFormat
            // 
            this.SalaryFormat.DataPropertyName = "SalaryFormat";
            this.SalaryFormat.HeaderText = "Tiền Lương";
            this.SalaryFormat.Name = "SalaryFormat";
            // 
            // AllowanceFormat
            // 
            this.AllowanceFormat.DataPropertyName = "AllowanceFormat";
            this.AllowanceFormat.HeaderText = "Phụ Cấp";
            this.AllowanceFormat.Name = "AllowanceFormat";
            // 
            // PhoneCostFormat
            // 
            this.PhoneCostFormat.DataPropertyName = "PhoneCostFormat";
            this.PhoneCostFormat.HeaderText = "Tiền Hổ Trợ (ĐT)";
            this.PhoneCostFormat.Name = "PhoneCostFormat";
            // 
            // DebtPayFormat
            // 
            this.DebtPayFormat.DataPropertyName = "DebtPayFormat";
            this.DebtPayFormat.HeaderText = "Nhân Viên Trả Nợ";
            this.DebtPayFormat.Name = "DebtPayFormat";
            // 
            // ActualIncomeFormat
            // 
            this.ActualIncomeFormat.DataPropertyName = "ActualIncomeFormat";
            this.ActualIncomeFormat.HeaderText = "Thực Lãnh";
            this.ActualIncomeFormat.Name = "ActualIncomeFormat";
            // 
            // IsPay
            // 
            this.IsPay.DataPropertyName = "IsPay";
            this.IsPay.HeaderText = "Đã Trả";
            this.IsPay.Name = "IsPay";
            this.IsPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsPay.Width = 70;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.Width = 150;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Ngày Tạo";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Width = 120;
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "Ngày Sửa";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Width = 120;
            // 
            // employeeSalaryDTOBindingSource
            // 
            this.employeeSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EmployeeSalaryDTO);
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
            this.slcMain.Size = new System.Drawing.Size(810, 526);
            this.slcMain.SplitterDistance = 281;
            this.slcMain.TabIndex = 16;
            // 
            // gbxLeftBot
            // 
            this.gbxLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLeftBot.Location = new System.Drawing.Point(0, 0);
            this.gbxLeftBot.Name = "gbxLeftBot";
            // 
            // gbxLeftBot.Panel
            // 
            this.gbxLeftBot.Panel.Controls.Add(this.dgvSalary);
            this.gbxLeftBot.Panel.Controls.Add(this.pnlSearch);
            this.gbxLeftBot.Panel.Controls.Add(this.hdAdvance);
            this.gbxLeftBot.Size = new System.Drawing.Size(810, 281);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(806, 58);
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
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchFrom);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxSearch.Panel.Controls.Add(this.dtpSearchTo);
            this.gbxSearch.Panel.Controls.Add(this.cbbNameSearch);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxSearch.Size = new System.Drawing.Size(706, 53);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.CustomFormat = "MM/yyyy";
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchFrom.Location = new System.Drawing.Point(360, 16);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(91, 20);
            this.dtpSearchFrom.TabIndex = 9;
            this.dtpSearchFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbNameSearch_KeyDown);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(297, 16);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(57, 19);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Từ Tháng";
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchTo.CustomFormat = "MM/yyyy";
            this.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchTo.Location = new System.Drawing.Point(533, 15);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(80, 20);
            this.dtpSearchTo.TabIndex = 7;
            this.dtpSearchTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbNameSearch_KeyDown);
            // 
            // cbbNameSearch
            // 
            this.cbbNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNameSearch.DropDownWidth = 218;
            this.cbbNameSearch.Location = new System.Drawing.Point(105, 14);
            this.cbbNameSearch.Name = "cbbNameSearch";
            this.cbbNameSearch.Size = new System.Drawing.Size(181, 22);
            this.cbbNameSearch.TabIndex = 1;
            this.cbbNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbNameSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(619, 2);
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
            this.kryptonLabel10.Location = new System.Drawing.Point(462, 16);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(65, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Đến Tháng";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(18, 16);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(84, 19);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Tên Nhân Viên";
            // 
            // hdAdvance
            // 
            this.hdAdvance.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnRefresh,
            this.btnLoadAll,
            this.btnAdd,
            this.btnDelete,
            this.btnDeleteAll,
            this.btnHideShowSearch});
            this.hdAdvance.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdAdvance.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdAdvance.Location = new System.Drawing.Point(0, 0);
            this.hdAdvance.Name = "hdAdvance";
            this.hdAdvance.Size = new System.Drawing.Size(806, 29);
            this.hdAdvance.TabIndex = 0;
            this.hdAdvance.Values.Description = "";
            this.hdAdvance.Values.Heading = "Bảng Lương";
            this.hdAdvance.Values.Image = null;
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
            this.btnAdd.Click += new System.EventHandler(this.btnNewSalary_Click);
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
            this.gbcRightBot.Size = new System.Drawing.Size(810, 240);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // slcEdit
            // 
            this.slcEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcEdit.Location = new System.Drawing.Point(0, 29);
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
            this.slcEdit.Size = new System.Drawing.Size(806, 205);
            this.slcEdit.SplitterDistance = 384;
            this.slcEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcEdit.TabIndex = 4;
            // 
            // gbxEdit1
            // 
            this.gbxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit1.Location = new System.Drawing.Point(5, 0);
            this.gbxEdit1.Name = "gbxEdit1";
            // 
            // gbxEdit1.Panel
            // 
            this.gbxEdit1.Panel.Controls.Add(this.txtNo);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel13);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxEdit1.Panel.Controls.Add(this.dtpMonth);
            this.gbxEdit1.Panel.Controls.Add(this.cbbEmployee);
            this.gbxEdit1.Panel.Controls.Add(this.txtActualIncome);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxEdit1.Panel.Controls.Add(this.txtSalary);
            this.gbxEdit1.Size = new System.Drawing.Size(379, 200);
            this.gbxEdit1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(144)))));
            this.gbxEdit1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxEdit1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdit1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxEdit1.TabIndex = 5;
            this.gbxEdit1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNo.Location = new System.Drawing.Point(102, 27);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(229, 22);
            this.txtNo.TabIndex = 44;
            this.txtNo.Text = "0";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(43, 30);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(42, 19);
            this.kryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel13.TabIndex = 43;
            this.kryptonLabel13.Values.Text = "Mã Số";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(46, 59);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "Tháng";
            // 
            // dtpMonth
            // 
            this.dtpMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(102, 55);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(229, 20);
            this.dtpMonth.TabIndex = 41;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbEmployee.DropDownWidth = 223;
            this.cbbEmployee.Location = new System.Drawing.Point(102, 109);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(229, 22);
            this.cbbEmployee.TabIndex = 37;
            // 
            // txtActualIncome
            // 
            this.txtActualIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualIncome.ContextMenuStrip = this.cmsGenerate;
            this.txtActualIncome.Location = new System.Drawing.Point(102, 137);
            this.txtActualIncome.Name = "txtActualIncome";
            this.txtActualIncome.Size = new System.Drawing.Size(229, 22);
            this.txtActualIncome.TabIndex = 40;
            this.txtActualIncome.Text = "0";
            this.txtActualIncome.Enter += new System.EventHandler(this.txtActualIncome_Enter);
            this.txtActualIncome.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 109);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(84, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 35;
            this.kryptonLabel1.Values.Text = "Tên Nhân Viên";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 134);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 39;
            this.kryptonLabel2.Values.Text = "Thực Lãnh";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(45, 84);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(42, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "Lương";
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalary.ContextMenuStrip = this.cmsGenerate;
            this.txtSalary.Location = new System.Drawing.Point(102, 81);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(229, 22);
            this.txtSalary.TabIndex = 38;
            this.txtSalary.Text = "0";
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // gbxEdit2
            // 
            this.gbxEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit2.Location = new System.Drawing.Point(0, 0);
            this.gbxEdit2.Name = "gbxEdit2";
            // 
            // gbxEdit2.Panel
            // 
            this.gbxEdit2.Panel.Controls.Add(this.txtDebtPay);
            this.gbxEdit2.Panel.Controls.Add(this.txtNote);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxEdit2.Panel.Controls.Add(this.cbbIsPay);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel11);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel12);
            this.gbxEdit2.Panel.Controls.Add(this.txtPhoneCost);
            this.gbxEdit2.Panel.Controls.Add(this.txtAllowance);
            this.gbxEdit2.Size = new System.Drawing.Size(417, 205);
            this.gbxEdit2.TabIndex = 5;
            this.gbxEdit2.Values.Heading = "Thông Tin Thêm";
            // 
            // txtDebtPay
            // 
            this.txtDebtPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebtPay.ContextMenuStrip = this.cmsGenerate;
            this.txtDebtPay.Location = new System.Drawing.Point(144, 59);
            this.txtDebtPay.Name = "txtDebtPay";
            this.txtDebtPay.Size = new System.Drawing.Size(243, 22);
            this.txtDebtPay.TabIndex = 41;
            this.txtDebtPay.Text = "0";
            this.txtDebtPay.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtDebtPay.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(144, 108);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(243, 66);
            this.txtNote.TabIndex = 42;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(91, 111);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel7.TabIndex = 37;
            this.kryptonLabel7.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(89, 11);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(52, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 33;
            this.kryptonLabel5.Values.Text = "Phụ Cấp";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(50, 38);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(88, 19);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.TabIndex = 34;
            this.kryptonLabel6.Values.Text = "Tiền Điện Thoại";
            // 
            // cbbIsPay
            // 
            this.cbbIsPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbIsPay.DropDownWidth = 223;
            this.cbbIsPay.Location = new System.Drawing.Point(144, 83);
            this.cbbIsPay.Name = "cbbIsPay";
            this.cbbIsPay.Size = new System.Drawing.Size(243, 22);
            this.cbbIsPay.TabIndex = 38;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(17, 63);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(124, 19);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel11.TabIndex = 35;
            this.kryptonLabel11.Values.Text = "Tiền Nhân Viên Trả Nợ";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(77, 87);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(63, 19);
            this.kryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel12.TabIndex = 36;
            this.kryptonLabel12.Values.Text = "Trạng Thái";
            // 
            // txtPhoneCost
            // 
            this.txtPhoneCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneCost.ContextMenuStrip = this.cmsGenerate;
            this.txtPhoneCost.Location = new System.Drawing.Point(144, 35);
            this.txtPhoneCost.Name = "txtPhoneCost";
            this.txtPhoneCost.Size = new System.Drawing.Size(243, 22);
            this.txtPhoneCost.TabIndex = 40;
            this.txtPhoneCost.Text = "0";
            this.txtPhoneCost.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtPhoneCost.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // txtAllowance
            // 
            this.txtAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAllowance.ContextMenuStrip = this.cmsGenerate;
            this.txtAllowance.Location = new System.Drawing.Point(144, 11);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(243, 22);
            this.txtAllowance.TabIndex = 39;
            this.txtAllowance.Text = "0";
            this.txtAllowance.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtAllowance.Leave += new System.EventHandler(this.txtSalary_Leave);
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
            this.hdEdit.Size = new System.Drawing.Size(806, 29);
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
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.sửaToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.HideSearchToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.xóaTấtCảToolStripMenuItem});
            this.cmsMain.Name = "cmsDGV";
            this.cmsMain.Size = new System.Drawing.Size(184, 202);
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
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btnNewSalary_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
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
            // SalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 526);
            this.Controls.Add(this.slcMain);
            this.Name = "SalaryManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalaryManagement_Load);
            this.cmsGenerate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).EndInit();
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).EndInit();
            this.gbcRightBot.Panel.ResumeLayout(false);
            this.gbcRightBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            this.slcEdit.Panel1.ResumeLayout(false);
            this.slcEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcEdit)).EndInit();
            this.slcEdit.ResumeLayout(false);
            this.gbxEdit1.Panel.ResumeLayout(false);
            this.gbxEdit1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).EndInit();
            this.gbxEdit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).EndInit();
            this.gbxEdit2.Panel.ResumeLayout(false);
            this.gbxEdit2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).EndInit();
            this.gbxEdit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsPay)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.BindingSource employeeSalaryDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems4;
        private System.Windows.Forms.ContextMenuStrip cmsGenerate;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpSearchTo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbNameSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdAdvance;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLoadAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnUnableEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtActualIncome;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDebtPay;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbIsPay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAllowance;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowanceFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCostFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtPayFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualIncomeFormat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
    }
}

