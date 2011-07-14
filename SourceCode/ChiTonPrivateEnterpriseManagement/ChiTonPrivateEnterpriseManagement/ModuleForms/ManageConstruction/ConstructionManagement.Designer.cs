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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructionManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvCons = new AdvancedDataGridView.TreeGridView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btViewProgress = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btViewReal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAddnew = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btAddChild = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btAddSubConstractor = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btViewEstimate = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbFromdate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSearchName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.ConstructionID = new AdvancedDataGridView.TreeGridColumn();
            this.ConstructionName = new AdvancedDataGridView.TreeGridColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRealCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubcontractorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvCons);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(935, 680);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvCons
            // 
            this.dgvCons.AllowUserToAddRows = false;
            this.dgvCons.AllowUserToDeleteRows = false;
            this.dgvCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.ConstructionID,
            this.ConstructionName,
            this.Status,
            this.ProgressRate,
            this.TotalEstimateCost,
            this.TotalRealCost,
            this.Type,
            this.SubcontractorName,
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
            this.dgvCons.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCons.ImageList = null;
            this.dgvCons.Location = new System.Drawing.Point(0, 117);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCons.Size = new System.Drawing.Size(935, 554);
            this.dgvCons.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCons.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCons.TabIndex = 2;
            this.dgvCons.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCons_CellMouseDown);
            this.dgvCons.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvCons_Scroll);
            this.dgvCons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCons_MouseClick);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btViewProgress);
            this.kryptonPanel2.Controls.Add(this.btViewReal);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 85);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(935, 32);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // btViewProgress
            // 
            this.btViewProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.btViewProgress.Location = new System.Drawing.Point(46, 0);
            this.btViewProgress.Name = "btViewProgress";
            this.btViewProgress.Size = new System.Drawing.Size(46, 32);
            this.btViewProgress.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btViewProgress.TabIndex = 9;
            this.btViewProgress.Values.Text = "";
            this.btViewProgress.Click += new System.EventHandler(this.btViewProgress_Click);
            // 
            // btViewReal
            // 
            this.btViewReal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btViewReal.Location = new System.Drawing.Point(0, 0);
            this.btViewReal.Name = "btViewReal";
            this.btViewReal.Size = new System.Drawing.Size(46, 32);
            this.btViewReal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btViewReal.TabIndex = 8;
            this.btViewReal.Values.Text = "";
            this.btViewReal.Click += new System.EventHandler(this.btViewReal_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.AllowButtonSpecToolTips = true;
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btAddnew,
            this.btAddChild,
            this.btAddSubConstractor,
            this.btEdit,
            this.btDelete,
            this.btViewEstimate});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(935, 32);
            this.kryptonHeader1.StateCommon.Back.Color1 = System.Drawing.Color.Khaki;
            this.kryptonHeader1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonHeader1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // btAddnew
            // 
            this.btAddnew.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btAddnew.ToolTipBody = "Tạo mới công trình ";
            this.btAddnew.UniqueName = "DF8EF9947C9E47A860A0CE8AAD6E1417";
            this.btAddnew.Click += new System.EventHandler(this.btAddnew_Click);
            // 
            // btAddChild
            // 
            this.btAddChild.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
            this.btAddChild.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAddChild.ToolTipBody = "Tạo công trình con";
            this.btAddChild.UniqueName = "0EC9802AEBD943DEF4BDB4BF134DAF86";
            this.btAddChild.Click += new System.EventHandler(this.btAddChild_Click);
            // 
            // btAddSubConstractor
            // 
            this.btAddSubConstractor.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
            this.btAddSubConstractor.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAddSubConstractor.ToolTipBody = "Tạo công trình phụ";
            this.btAddSubConstractor.UniqueName = "1B14F718FF6A4A76DE8E06FCA97BBA72";
            this.btAddSubConstractor.Click += new System.EventHandler(this.btAddSubConstractor_Click);
            // 
            // btEdit
            // 
            this.btEdit.ToolTipBody = "Sửa công trình";
            this.btEdit.UniqueName = "34C9769A3CA44D3967B2D4C8AEC73EAB";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btDelete.ToolTipBody = "Xóa công trình";
            this.btDelete.UniqueName = "406FE902D4254C673BBA86D6505DEF19";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btViewEstimate
            // 
            this.btViewEstimate.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btViewEstimate.ToolTipBody = "Xem dự toán";
            this.btViewEstimate.UniqueName = "C911E6C3F45C46C34F96B513E57D6C3A";
            this.btViewEstimate.Click += new System.EventHandler(this.btViewEstimate_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btSearch);
            this.kryptonPanel1.Controls.Add(this.dtTodate);
            this.kryptonPanel1.Controls.Add(this.lbTodate);
            this.kryptonPanel1.Controls.Add(this.dtFromdate);
            this.kryptonPanel1.Controls.Add(this.lbFromdate);
            this.kryptonPanel1.Controls.Add(this.cbStatus);
            this.kryptonPanel1.Controls.Add(this.lbStatus);
            this.kryptonPanel1.Controls.Add(this.ipName);
            this.kryptonPanel1.Controls.Add(this.lbSearchName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(935, 85);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Khaki;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.kryptonPanel1.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(544, 34);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(44, 35);
            this.btSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.TabIndex = 10;
            this.btSearch.Values.Text = "";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtTodate
            // 
            this.dtTodate.CustomFormat = "dd/MM/yyyy";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(380, 49);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(146, 20);
            this.dtTodate.TabIndex = 9;
            // 
            // lbTodate
            // 
            this.lbTodate.Location = new System.Drawing.Point(313, 49);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.TabIndex = 8;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // dtFromdate
            // 
            this.dtFromdate.CustomFormat = "dd/MM/yyyy";
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromdate.Location = new System.Drawing.Point(157, 48);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(150, 20);
            this.dtFromdate.TabIndex = 7;
            // 
            // lbFromdate
            // 
            this.lbFromdate.Location = new System.Drawing.Point(101, 48);
            this.lbFromdate.Name = "lbFromdate";
            this.lbFromdate.Size = new System.Drawing.Size(50, 19);
            this.lbFromdate.TabIndex = 6;
            this.lbFromdate.Values.Text = "Từ ngày";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 146;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới",
            "Đang thi công",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(380, 20);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(146, 22);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Text = "chọn...";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(313, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 19);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Values.Text = "Tình trạng";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(157, 20);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(150, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbSearchName
            // 
            this.lbSearchName.Location = new System.Drawing.Point(68, 23);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(83, 19);
            this.lbSearchName.TabIndex = 0;
            this.lbSearchName.Values.Text = "Tên công trình";
            // 
            // checkBox
            // 
            this.checkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.FillWeight = 51.53443F;
            this.checkBox.HeaderText = "";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.MinimumWidth = 25;
            this.checkBox.Name = "checkBox";
            this.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 25;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstructionName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConstructionName.DefaultNodeImage = null;
            this.ConstructionName.HeaderText = "Tên công trình";
            this.ConstructionName.Name = "ConstructionName";
            this.ConstructionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionName.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.Name = "Status";
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProgressRate
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProgressRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProgressRate.HeaderText = "Tiến độ(%)";
            this.ProgressRate.Name = "ProgressRate";
            this.ProgressRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalEstimateCost
            // 
            this.TotalEstimateCost.DataPropertyName = "TotalEstimateCost";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.TotalEstimateCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalEstimateCost.HeaderText = "Tổng dự toán(VND)";
            this.TotalEstimateCost.Name = "TotalEstimateCost";
            this.TotalEstimateCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalEstimateCost.Width = 150;
            // 
            // TotalRealCost
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.TotalRealCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalRealCost.HeaderText = "Tổng giải ngân(VND)";
            this.TotalRealCost.Name = "TotalRealCost";
            this.TotalRealCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow;
            this.CommencementDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.CommencementDate.HeaderText = "Ngày khởi công";
            this.CommencementDate.Name = "CommencementDate";
            this.CommencementDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CommencementDate.Width = 150;
            // 
            // CompletionDate
            // 
            this.CompletionDate.DataPropertyName = "CompletionDate";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            this.CompletionDate.DefaultCellStyle = dataGridViewCellStyle7;
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
            // ConstructionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(935, 680);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "ConstructionManagement";
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Khaki;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.Text = "Quản lý công trình";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConstructionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private AdvancedDataGridView.TreeGridView dgvCons;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewReal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewProgress;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddnew;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddChild;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAddSubConstractor;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btViewEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private AdvancedDataGridView.TreeGridColumn ConstructionID;
        private AdvancedDataGridView.TreeGridColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgressRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimateCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRealCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcontractorName;
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
    }
}

