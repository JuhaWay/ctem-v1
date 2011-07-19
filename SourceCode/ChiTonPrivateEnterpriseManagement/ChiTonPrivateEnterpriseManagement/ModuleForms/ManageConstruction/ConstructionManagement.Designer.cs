namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class ConstructionManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructionManagement));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvCons = new AdvancedDataGridView.TreeGridView();
            this.ConstructionID = new AdvancedDataGridView.TreeGridColumn();
            this.ConstructionName = new AdvancedDataGridView.TreeGridColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubcontractorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRealCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommencementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbSearchName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbFromdate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btAddchild = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btAddSubs = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btViewEst = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHạngMụcThầuPhụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvCons);
            this.kryptonPanel.Controls.Add(this.pnlSearch);
            this.kryptonPanel.Controls.Add(this.hdDebt);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(792, 566);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvCons
            // 
            this.dgvCons.AllowUserToAddRows = false;
            this.dgvCons.AllowUserToDeleteRows = false;
            this.dgvCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConstructionID,
            this.ConstructionName,
            this.Type,
            this.SubcontractorName,
            this.Status,
            this.ProgressRate,
            this.TotalEstimateCost,
            this.TotalRealCost,
            this.ManagerName,
            this.Description,
            this.ConstructionAddress,
            this.CommencementDate,
            this.CompletionDate,
            this.ParentId,
            this.CreatedBy,
            this.CreatedDate,
            this.UpdatedBy,
            this.LastUpdated,
            this.HasEstimate});
            this.dgvCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCons.ImageList = null;
            this.dgvCons.Location = new System.Drawing.Point(0, 100);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCons.Size = new System.Drawing.Size(792, 466);
            this.dgvCons.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCons.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCons.TabIndex = 0;
            this.dgvCons.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCons_CellMouseClick);
            // 
            // ConstructionID
            // 
            this.ConstructionID.DataPropertyName = "ConstructionID";
            this.ConstructionID.DefaultNodeImage = null;
            this.ConstructionID.HeaderText = "ConstructionID";
            this.ConstructionID.Name = "ConstructionID";
            this.ConstructionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionID.Visible = false;
            // 
            // ConstructionName
            // 
            this.ConstructionName.DataPropertyName = "ConstructionName";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstructionName.DefaultCellStyle = dataGridViewCellStyle7;
            this.ConstructionName.DefaultNodeImage = null;
            this.ConstructionName.HeaderText = "Tên công trình";
            this.ConstructionName.Name = "ConstructionName";
            this.ConstructionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionName.Width = 250;
            // 
            // Type
            // 
            this.Type.HeaderText = "Loại";
            this.Type.Name = "Type";
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Width = 150;
            // 
            // SubcontractorName
            // 
            this.SubcontractorName.DataPropertyName = "SubcontractorName";
            this.SubcontractorName.HeaderText = "Nhà thầu phụ";
            this.SubcontractorName.Name = "SubcontractorName";
            this.SubcontractorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SubcontractorName.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.Name = "Status";
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProgressRate
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProgressRate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ProgressRate.HeaderText = "Tiến độ(%)";
            this.ProgressRate.Name = "ProgressRate";
            this.ProgressRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalEstimateCost
            // 
            this.TotalEstimateCost.DataPropertyName = "TotalEstimateCost";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            this.TotalEstimateCost.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalEstimateCost.HeaderText = "Tổng dự toán(VND)";
            this.TotalEstimateCost.Name = "TotalEstimateCost";
            this.TotalEstimateCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalEstimateCost.Width = 150;
            // 
            // TotalRealCost
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            this.TotalRealCost.DefaultCellStyle = dataGridViewCellStyle10;
            this.TotalRealCost.HeaderText = "Tổng giải ngân(VND)";
            this.TotalRealCost.Name = "TotalRealCost";
            this.TotalRealCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalRealCost.Width = 150;
            // 
            // ManagerName
            // 
            this.ManagerName.HeaderText = "Người quản lý";
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 150;
            // 
            // ConstructionAddress
            // 
            this.ConstructionAddress.DataPropertyName = "ConstructionAddress";
            this.ConstructionAddress.HeaderText = "Địa chỉ";
            this.ConstructionAddress.Name = "ConstructionAddress";
            this.ConstructionAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionAddress.Width = 150;
            // 
            // CommencementDate
            // 
            this.CommencementDate.DataPropertyName = "CommencementDate";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Yellow;
            this.CommencementDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.CommencementDate.HeaderText = "Ngày khởi công";
            this.CommencementDate.Name = "CommencementDate";
            this.CommencementDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CommencementDate.Width = 150;
            // 
            // CompletionDate
            // 
            this.CompletionDate.DataPropertyName = "CompletionDate";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            this.CompletionDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.CompletionDate.HeaderText = "Hạn hoàn thành";
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CompletionDate.Width = 150;
            // 
            // ParentId
            // 
            this.ParentId.DataPropertyName = "ParentID";
            this.ParentId.HeaderText = "ParentId";
            this.ParentId.Name = "ParentId";
            this.ParentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ParentId.Visible = false;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "Tạo bởi";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Ngày tạo";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreatedDate.Width = 150;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.HeaderText = "Cập nhật gần nhất";
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastUpdated
            // 
            this.LastUpdated.HeaderText = "Ngày cập nhật";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastUpdated.Width = 150;
            // 
            // HasEstimate
            // 
            this.HasEstimate.HeaderText = "HasEstimate";
            this.HasEstimate.Name = "HasEstimate";
            this.HasEstimate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HasEstimate.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(30, 0, 30, 5);
            this.pnlSearch.Size = new System.Drawing.Size(792, 71);
            this.pnlSearch.TabIndex = 11;
            // 
            // gbxSearch
            // 
            this.gbxSearch.CaptionOverlap = 0D;
            this.gbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSearch.Location = new System.Drawing.Point(30, 0);
            this.gbxSearch.Name = "gbxSearch";
            // 
            // gbxSearch.Panel
            // 
            this.gbxSearch.Panel.Controls.Add(this.cbManager);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxSearch.Panel.Controls.Add(this.dtTodate);
            this.gbxSearch.Panel.Controls.Add(this.lbTodate);
            this.gbxSearch.Panel.Controls.Add(this.lbSearchName);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.dtFromdate);
            this.gbxSearch.Panel.Controls.Add(this.ipName);
            this.gbxSearch.Panel.Controls.Add(this.lbFromdate);
            this.gbxSearch.Panel.Controls.Add(this.cbStatus);
            this.gbxSearch.Panel.Controls.Add(this.lbStatus);
            this.gbxSearch.Size = new System.Drawing.Size(732, 66);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // cbManager
            // 
            this.cbManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbManager.DropDownWidth = 133;
            this.cbManager.Location = new System.Drawing.Point(528, 18);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(133, 22);
            this.cbManager.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonLabel1.Location = new System.Drawing.Point(441, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Người quản lý";
            // 
            // dtTodate
            // 
            this.dtTodate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtTodate.CustomFormat = "dd/MM/yyyy";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(289, 33);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(146, 20);
            this.dtTodate.TabIndex = 3;
            // 
            // lbTodate
            // 
            this.lbTodate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTodate.Location = new System.Drawing.Point(222, 33);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTodate.TabIndex = 8;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // lbSearchName
            // 
            this.lbSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbSearchName.Location = new System.Drawing.Point(3, 8);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(113, 19);
            this.lbSearchName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSearchName.TabIndex = 0;
            this.lbSearchName.Values.Text = "Tên công trình chính";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.Location = new System.Drawing.Point(667, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.NavajoWhite;
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 3;
            this.btnSearch.Size = new System.Drawing.Size(52, 45);
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
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.find1;
            this.btnSearch.Values.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtFromdate
            // 
            this.dtFromdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtFromdate.CustomFormat = "dd/MM/yyyy";
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromdate.Location = new System.Drawing.Point(122, 33);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(91, 20);
            this.dtFromdate.TabIndex = 1;
            // 
            // ipName
            // 
            this.ipName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ipName.Location = new System.Drawing.Point(122, 5);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(91, 22);
            this.ipName.TabIndex = 0;
            // 
            // lbFromdate
            // 
            this.lbFromdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbFromdate.Location = new System.Drawing.Point(14, 33);
            this.lbFromdate.Name = "lbFromdate";
            this.lbFromdate.Size = new System.Drawing.Size(102, 19);
            this.lbFromdate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbFromdate.TabIndex = 6;
            this.lbFromdate.Values.Text = "Khởi công từ ngày";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbStatus.DropDownWidth = 146;
            this.cbStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Mới",
            "Đang thi công",
            "Treo",
            "Hoàn thành"});
            this.cbStatus.Location = new System.Drawing.Point(289, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(146, 22);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.Text = "chọn...";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbStatus.Location = new System.Drawing.Point(222, 8);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 19);
            this.lbStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Values.Text = "Tình trạng";
            // 
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btAdd,
            this.btAddchild,
            this.btAddSubs,
            this.btDelete,
            this.btEdit,
            this.btViewEst,
            this.btnHideShowSearch});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(792, 29);
            this.hdDebt.TabIndex = 10;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Danh Nhà Công Trình";
            this.hdDebt.Values.Image = null;
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAdd.Text = "Thêm";
            this.btAdd.UniqueName = "6E177DC1660348E375BDCE591BF21FCB";
            this.btAdd.Click += new System.EventHandler(this.btAddnew_Click);
            // 
            // btAddchild
            // 
            this.btAddchild.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
            this.btAddchild.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.project_open;
            this.btAddchild.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAddchild.Text = "Thêm Hạng Mục";
            this.btAddchild.UniqueName = "D5520BC889F44104ABA432FF3F78D9BF";
            this.btAddchild.Click += new System.EventHandler(this.btAddChild_Click);
            // 
            // btAddSubs
            // 
            this.btAddSubs.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
            this.btAddSubs.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.classic_folder_projects;
            this.btAddSubs.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAddSubs.Text = "Thêm Hạng Mục Thầu phụ";
            this.btAddSubs.UniqueName = "3CF0D129E3EF4572FE9B4651DEAEBA47";
            this.btAddSubs.Click += new System.EventHandler(this.btAddSubConstractor_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btDelete.Text = "Xóa";
            this.btDelete.UniqueName = "46715A2AEC0143074F81325F50887305";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.Edit;
            this.btEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btEdit.Text = "Sửa";
            this.btEdit.UniqueName = "86BB978534E341F645BF5498BA74D93F";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btViewEst
            // 
            this.btViewEst.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.freeze;
            this.btViewEst.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btViewEst.Text = "Dự toán";
            this.btViewEst.UniqueName = "BC9DE0D0E3444571EFA8454D9CC796EA";
            this.btViewEst.Visible = false;
            this.btViewEst.Click += new System.EventHandler(this.btViewEstimate_Click);
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            this.btnHideShowSearch.Click += new System.EventHandler(this.btHideShowSearch_Click);
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.thêmHạngMụcThầuPhụToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.HideSearchToolStripMenuItem});
            this.cmsMain.Name = "cmsDGV";
            this.cmsMain.Size = new System.Drawing.Size(254, 136);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(253, 22);
            this.toolStripMenuItem3.Text = "Thêm Hạng Mục";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btAddChild_Click);
            // 
            // thêmHạngMụcThầuPhụToolStripMenuItem
            // 
            this.thêmHạngMụcThầuPhụToolStripMenuItem.Name = "thêmHạngMụcThầuPhụToolStripMenuItem";
            this.thêmHạngMụcThầuPhụToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thêmHạngMụcThầuPhụToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.thêmHạngMụcThầuPhụToolStripMenuItem.Text = "Thêm Hạng Mục Thầu Phụ";
            this.thêmHạngMụcThầuPhụToolStripMenuItem.Click += new System.EventHandler(this.btAddSubConstractor_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.lưuToolStripMenuItem.Text = "Xóa";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.SearchToolStripMenuItem.Text = "Tìm Kiếm";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // HideSearchToolStripMenuItem
            // 
            this.HideSearchToolStripMenuItem.Name = "HideSearchToolStripMenuItem";
            this.HideSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HideSearchToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.HideSearchToolStripMenuItem.Text = "Ẩn Tìm Kiếm";
            this.HideSearchToolStripMenuItem.Click += new System.EventHandler(this.HideSearchToolStripMenuItem_Click);
            // 
            // ConstructionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.kryptonPanel);
            this.Name = "ConstructionManagement";
            this.ShowIcon = false;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Khaki;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.Text = "Quản lý công trình";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConstructionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private AdvancedDataGridView.TreeGridView dgvCons;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchName;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddchild;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddSubs;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btViewEst;
        private AdvancedDataGridView.TreeGridColumn ConstructionID;
        private AdvancedDataGridView.TreeGridColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcontractorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgressRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimateCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRealCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommencementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem thêmHạngMụcThầuPhụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
    }
}

