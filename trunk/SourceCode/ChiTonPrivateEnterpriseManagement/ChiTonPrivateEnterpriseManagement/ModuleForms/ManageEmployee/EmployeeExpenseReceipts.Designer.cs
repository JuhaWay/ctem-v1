namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class EmployeeExpenseReceipts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeExpenseReceipts));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvSalary = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.EmployeeSalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salarypc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAdvanceSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarypcFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAllowanceFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtPayFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt1Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt2Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAdvanceSalaryFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualIncomeFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReceiveFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnDetail = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLoadAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvSalary);
            this.kryptonPanel.Controls.Add(this.pnlSearch);
            this.kryptonPanel.Controls.Add(this.hdAdvance);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(792, 566);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvSalary
            // 
            this.dgvSalary.AutoGenerateColumns = false;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeSalaryID,
            this.EmployeeID,
            this.Month,
            this.Salarypc,
            this.TotalAllowance,
            this.Salary,
            this.DebtPay,
            this.Debt1,
            this.Debt2,
            this.TotalAdvanceSalary,
            this.ActualIncome,
            this.DateReceive,
            this.Username,
            this.Fullname,
            this.MonthFormat,
            this.SalaryFormat,
            this.SalarypcFormat,
            this.TotalAllowanceFormat,
            this.DebtPayFormat,
            this.Debt1Format,
            this.Debt2Format,
            this.TotalAdvanceSalaryFormat,
            this.ActualIncomeFormat,
            this.DateReceiveFormat,
            this.IsPay});
            this.dgvSalary.DataSource = this.employeeSalaryDTOBindingSource;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.Location = new System.Drawing.Point(0, 87);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 25;
            this.dgvSalary.Size = new System.Drawing.Size(792, 479);
            this.dgvSalary.TabIndex = 15;
            // 
            // EmployeeSalaryID
            // 
            this.EmployeeSalaryID.DataPropertyName = "EmployeeSalaryID";
            this.EmployeeSalaryID.HeaderText = "EmployeeSalaryID";
            this.EmployeeSalaryID.Name = "EmployeeSalaryID";
            this.EmployeeSalaryID.Visible = false;
            this.EmployeeSalaryID.Width = 120;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = false;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.Visible = false;
            // 
            // Salarypc
            // 
            this.Salarypc.DataPropertyName = "Salarypc";
            this.Salarypc.HeaderText = "Salarypc";
            this.Salarypc.Name = "Salarypc";
            this.Salarypc.Visible = false;
            // 
            // TotalAllowance
            // 
            this.TotalAllowance.DataPropertyName = "TotalAllowance";
            this.TotalAllowance.HeaderText = "TotalAllowance";
            this.TotalAllowance.Name = "TotalAllowance";
            this.TotalAllowance.Visible = false;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Visible = false;
            // 
            // DebtPay
            // 
            this.DebtPay.DataPropertyName = "DebtPay";
            this.DebtPay.HeaderText = "DebtPay";
            this.DebtPay.Name = "DebtPay";
            this.DebtPay.Visible = false;
            // 
            // Debt1
            // 
            this.Debt1.DataPropertyName = "Debt1";
            this.Debt1.HeaderText = "Debt1";
            this.Debt1.Name = "Debt1";
            this.Debt1.Visible = false;
            // 
            // Debt2
            // 
            this.Debt2.DataPropertyName = "Debt2";
            this.Debt2.HeaderText = "Debt2";
            this.Debt2.Name = "Debt2";
            this.Debt2.Visible = false;
            // 
            // TotalAdvanceSalary
            // 
            this.TotalAdvanceSalary.DataPropertyName = "TotalAdvanceSalary";
            this.TotalAdvanceSalary.HeaderText = "TotalAdvanceSalary";
            this.TotalAdvanceSalary.Name = "TotalAdvanceSalary";
            this.TotalAdvanceSalary.Visible = false;
            // 
            // ActualIncome
            // 
            this.ActualIncome.DataPropertyName = "ActualIncome";
            this.ActualIncome.HeaderText = "ActualIncome";
            this.ActualIncome.Name = "ActualIncome";
            this.ActualIncome.Visible = false;
            // 
            // DateReceive
            // 
            this.DateReceive.DataPropertyName = "DateReceive";
            this.DateReceive.HeaderText = "DateReceive";
            this.DateReceive.Name = "DateReceive";
            this.DateReceive.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên Đăng Nhập";
            this.Username.Name = "Username";
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
            this.MonthFormat.HeaderText = "Tháng";
            this.MonthFormat.Name = "MonthFormat";
            this.MonthFormat.Width = 70;
            // 
            // SalaryFormat
            // 
            this.SalaryFormat.DataPropertyName = "SalaryFormat";
            this.SalaryFormat.HeaderText = "Lương Cứng";
            this.SalaryFormat.Name = "SalaryFormat";
            // 
            // SalarypcFormat
            // 
            this.SalarypcFormat.DataPropertyName = "SalarypcFormat";
            this.SalarypcFormat.HeaderText = "10% Lương";
            this.SalarypcFormat.Name = "SalarypcFormat";
            // 
            // TotalAllowanceFormat
            // 
            this.TotalAllowanceFormat.DataPropertyName = "TotalAllowanceFormat";
            this.TotalAllowanceFormat.HeaderText = "Tổng Tiền Phụ Cấp";
            this.TotalAllowanceFormat.Name = "TotalAllowanceFormat";
            this.TotalAllowanceFormat.Width = 150;
            // 
            // DebtPayFormat
            // 
            this.DebtPayFormat.DataPropertyName = "DebtPayFormat";
            this.DebtPayFormat.HeaderText = "Tiền Nợ Doanh Nghiệp";
            this.DebtPayFormat.Name = "DebtPayFormat";
            this.DebtPayFormat.Width = 150;
            // 
            // Debt1Format
            // 
            this.Debt1Format.DataPropertyName = "Debt1Format";
            this.Debt1Format.HeaderText = "Tiền Nợ Khác 1";
            this.Debt1Format.Name = "Debt1Format";
            // 
            // Debt2Format
            // 
            this.Debt2Format.DataPropertyName = "Debt2Format";
            this.Debt2Format.HeaderText = "Tiền Nợ Khác 2";
            this.Debt2Format.Name = "Debt2Format";
            // 
            // TotalAdvanceSalaryFormat
            // 
            this.TotalAdvanceSalaryFormat.DataPropertyName = "TotalAdvanceSalaryFormat";
            this.TotalAdvanceSalaryFormat.HeaderText = "Tổng Tiền Ứng Lương";
            this.TotalAdvanceSalaryFormat.Name = "TotalAdvanceSalaryFormat";
            this.TotalAdvanceSalaryFormat.Width = 150;
            // 
            // ActualIncomeFormat
            // 
            this.ActualIncomeFormat.DataPropertyName = "ActualIncomeFormat";
            this.ActualIncomeFormat.HeaderText = "Thực Lãnh";
            this.ActualIncomeFormat.Name = "ActualIncomeFormat";
            // 
            // DateReceiveFormat
            // 
            this.DateReceiveFormat.DataPropertyName = "DateReceiveFormat";
            this.DateReceiveFormat.HeaderText = "Ngày Lãnh";
            this.DateReceiveFormat.Name = "DateReceiveFormat";
            // 
            // IsPay
            // 
            this.IsPay.DataPropertyName = "IsPay";
            this.IsPay.HeaderText = "Đã Lãnh";
            this.IsPay.Name = "IsPay";
            this.IsPay.Width = 70;
            // 
            // employeeSalaryDTOBindingSource
            // 
            this.employeeSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EmployeeSalaryDTO);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(792, 58);
            this.pnlSearch.TabIndex = 14;
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
            this.gbxSearch.Size = new System.Drawing.Size(692, 53);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchFrom.CustomFormat = "MM/yyyy";
            this.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchFrom.Location = new System.Drawing.Point(346, 16);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(91, 20);
            this.dtpSearchFrom.TabIndex = 9;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel8.Location = new System.Drawing.Point(283, 16);
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
            this.dtpSearchTo.Location = new System.Drawing.Point(519, 15);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(80, 20);
            this.dtpSearchTo.TabIndex = 7;
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
            this.cbbNameSearch.Size = new System.Drawing.Size(167, 22);
            this.cbbNameSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(605, 2);
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
            this.kryptonLabel10.Location = new System.Drawing.Point(448, 16);
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
            this.btnDetail,
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
            this.hdAdvance.Size = new System.Drawing.Size(792, 29);
            this.hdAdvance.TabIndex = 13;
            this.hdAdvance.Values.Description = "";
            this.hdAdvance.Values.Heading = "Danh Dách Quản Lý Thu Chi";
            this.hdAdvance.Values.Image = null;
            // 
            // btnDetail
            // 
            this.btnDetail.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.application_view_detail;
            this.btnDetail.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDetail.Text = "Chi Tiết";
            this.btnDetail.UniqueName = "BC543F8F40854A6BABB7C31264E3F166";
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
            // EmployeeExpenseReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.kryptonPanel);
            this.Name = "EmployeeExpenseReceipts";
            this.Text = "Quản Lý Thu Chi Nhân Viên";
            this.Load += new System.EventHandler(this.EmployeeExpenseReceipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSalary;
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
        private System.Windows.Forms.BindingSource employeeSalaryDTOBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salarypc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAdvanceSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarypcFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAllowanceFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebtPayFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt1Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt2Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAdvanceSalaryFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualIncomeFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReceiveFormat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPay;
    }
}

