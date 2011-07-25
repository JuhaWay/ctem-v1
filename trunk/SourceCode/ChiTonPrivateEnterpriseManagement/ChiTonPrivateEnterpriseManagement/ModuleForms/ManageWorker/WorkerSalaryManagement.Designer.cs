using System.Windows.Forms;
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class WorkerSalaryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvWks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkersSalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OthersCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerSalaryDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbSearchCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbSearchCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipSearchName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSearchName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hdDebt = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btViewList = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbxEdit1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTask = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipOthersCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdEdit = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreezeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GenMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.workerSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).BeginInit();
            this.gbxSearch.Panel.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.Panel.SuspendLayout();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).BeginInit();
            this.gbxEdit1.Panel.SuspendLayout();
            this.gbxEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            this.cmsDGV.SuspendLayout();
            this.cmsEdit.SuspendLayout();
            this.cmsGen.SuspendLayout();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.slcMain);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(924, 573);
            this.kryptonPanel.TabIndex = 0;
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
            this.slcMain.Size = new System.Drawing.Size(924, 573);
            this.slcMain.SplitterDistance = 369;
            this.slcMain.TabIndex = 14;
            // 
            // gbxLeftBot
            // 
            this.gbxLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLeftBot.Location = new System.Drawing.Point(0, 0);
            this.gbxLeftBot.Name = "gbxLeftBot";
            // 
            // gbxLeftBot.Panel
            // 
            this.gbxLeftBot.Panel.Controls.Add(this.dgvWks);
            this.gbxLeftBot.Panel.Controls.Add(this.pnlSearch);
            this.gbxLeftBot.Panel.Controls.Add(this.hdDebt);
            this.gbxLeftBot.Size = new System.Drawing.Size(924, 369);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // dgvWks
            // 
            this.dgvWks.AutoGenerateColumns = false;
            this.dgvWks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.constructionNameDataGridViewTextBoxColumn,
            this.WorkersSalaryID,
            this.constructionIDDataGridViewTextBoxColumn,
            this.ManagerName,
            this.nameDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.OthersCost,
            this.TotalCost,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.Task,
            this.createDateDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dgvWks.DataSource = this.workerSalaryDTOBindingSource1;
            this.dgvWks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWks.Location = new System.Drawing.Point(0, 91);
            this.dgvWks.Name = "dgvWks";
            this.dgvWks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWks.Size = new System.Drawing.Size(920, 272);
            this.dgvWks.StateNormal.Background.Color1 = System.Drawing.Color.White;
            this.dgvWks.TabIndex = 0;
            this.dgvWks.SelectionChanged += new System.EventHandler(this.dgvWks_SelectionChanged);
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            this.constructionNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "Công trình";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            this.constructionNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // WorkersSalaryID
            // 
            this.WorkersSalaryID.DataPropertyName = "WorkersSalaryID";
            this.WorkersSalaryID.HeaderText = "WorkersSalaryID";
            this.WorkersSalaryID.Name = "WorkersSalaryID";
            this.WorkersSalaryID.Visible = false;
            // 
            // constructionIDDataGridViewTextBoxColumn
            // 
            this.constructionIDDataGridViewTextBoxColumn.DataPropertyName = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.HeaderText = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.Name = "constructionIDDataGridViewTextBoxColumn";
            this.constructionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ManagerName
            // 
            this.ManagerName.DataPropertyName = "ManagerName";
            this.ManagerName.HeaderText = "Quản lý";
            this.ManagerName.Name = "ManagerName";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên Bảng Công Nhật";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDateFormated";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow;
            this.fromDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "Từ ngày";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDateFormated";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            this.toDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.toDateDataGridViewTextBoxColumn.HeaderText = "Tới ngày";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            // 
            // OthersCost
            // 
            this.OthersCost.DataPropertyName = "OthersCostFormated";
            this.OthersCost.HeaderText = "Chi phí khác";
            this.OthersCost.Name = "OthersCost";
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCostFormated";
            this.TotalCost.HeaderText = "Tổng chi phí";
            this.TotalCost.Name = "TotalCost";
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalaryFormated";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.totalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "Tổng số tiền";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // Task
            // 
            this.Task.DataPropertyName = "Task";
            this.Task.HeaderText = "Công việc";
            this.Task.Name = "Task";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDateFormated";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateFormated";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            this.lastUpdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Tạo bởi";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Cập nhật bởi";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // workerSalaryDTOBindingSource1
            // 
            this.workerSalaryDTOBindingSource1.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerSalaryDTO);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 29);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(920, 62);
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
            this.gbxSearch.Panel.Controls.Add(this.kryptonDateTimePicker1);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxSearch.Panel.Controls.Add(this.cbSearchCons);
            this.gbxSearch.Panel.Controls.Add(this.lbSearchCons);
            this.gbxSearch.Panel.Controls.Add(this.ipSearchName);
            this.gbxSearch.Panel.Controls.Add(this.lbSearchName);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Size = new System.Drawing.Size(820, 57);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDateTimePicker1.CustomFormat = "MM/yyyy";
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(322, 18);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.kryptonDateTimePicker1.TabIndex = 8;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(267, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Tháng";
            // 
            // cbSearchCons
            // 
            this.cbSearchCons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchCons.DropDownWidth = 172;
            this.cbSearchCons.Location = new System.Drawing.Point(554, 16);
            this.cbSearchCons.Name = "cbSearchCons";
            this.cbSearchCons.Size = new System.Drawing.Size(172, 22);
            this.cbSearchCons.TabIndex = 2;
            this.cbSearchCons.Text = "chọn...";
            // 
            // lbSearchCons
            // 
            this.lbSearchCons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchCons.Location = new System.Drawing.Point(475, 19);
            this.lbSearchCons.Name = "lbSearchCons";
            this.lbSearchCons.Size = new System.Drawing.Size(73, 19);
            this.lbSearchCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSearchCons.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchCons.TabIndex = 6;
            this.lbSearchCons.Values.Text = "Công trình";
            // 
            // ipSearchName
            // 
            this.ipSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ipSearchName.Location = new System.Drawing.Point(145, 16);
            this.ipSearchName.Name = "ipSearchName";
            this.ipSearchName.Size = new System.Drawing.Size(116, 22);
            this.ipSearchName.TabIndex = 1;
            // 
            // lbSearchName
            // 
            this.lbSearchName.Location = new System.Drawing.Point(3, 19);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(136, 19);
            this.lbSearchName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSearchName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchName.TabIndex = 4;
            this.lbSearchName.Values.Text = "Tên Bảng Công Nhật";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(734, 3);
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
            // hdDebt
            // 
            this.hdDebt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnAdd,
            this.btnDelete,
            this.btViewList,
            this.btnHideShowSearch});
            this.hdDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDebt.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDebt.Location = new System.Drawing.Point(0, 0);
            this.hdDebt.Name = "hdDebt";
            this.hdDebt.Size = new System.Drawing.Size(920, 29);
            this.hdDebt.TabIndex = 0;
            this.hdDebt.Values.Description = "";
            this.hdDebt.Values.Heading = "Danh Sách Bảng Công Nhật";
            this.hdDebt.Values.Image = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btnAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UniqueName = "6E177DC1660348E375BDCE591BF21FCB";
            this.btnAdd.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btnDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UniqueName = "46715A2AEC0143074F81325F50887305";
            this.btnDelete.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btViewList
            // 
            this.btViewList.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.application_view_detail;
            this.btViewList.Text = "Chi tiết";
            this.btViewList.UniqueName = "11A6598E3E2A4E94CA8D48842706F5EF";
            this.btViewList.Click += new System.EventHandler(this.btViewEst_Click);
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            // 
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            // 
            // gbcRightBot.Panel
            // 
            this.gbcRightBot.Panel.Controls.Add(this.gbxEdit1);
            this.gbcRightBot.Panel.Controls.Add(this.hdEdit);
            this.gbcRightBot.Size = new System.Drawing.Size(924, 199);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // gbxEdit1
            // 
            this.gbxEdit1.CaptionOverlap = 0D;
            this.gbxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit1.Location = new System.Drawing.Point(0, 29);
            this.gbxEdit1.Name = "gbxEdit1";
            // 
            // gbxEdit1.Panel
            // 
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxEdit1.Panel.Controls.Add(this.ipTask);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxEdit1.Panel.Controls.Add(this.cbManager);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxEdit1.Panel.Controls.Add(this.ipOthersCost);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxEdit1.Panel.Controls.Add(this.dtTodate);
            this.gbxEdit1.Panel.Controls.Add(this.lbName);
            this.gbxEdit1.Panel.Controls.Add(this.ipName);
            this.gbxEdit1.Panel.Controls.Add(this.cbCons);
            this.gbxEdit1.Panel.Controls.Add(this.lbTodate);
            this.gbxEdit1.Panel.Controls.Add(this.lbCons);
            this.gbxEdit1.Panel.Controls.Add(this.dtFromdate);
            this.gbxEdit1.Panel.Controls.Add(this.lbFromDate);
            this.gbxEdit1.Size = new System.Drawing.Size(920, 164);
            this.gbxEdit1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(144)))));
            this.gbxEdit1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxEdit1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdit1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxEdit1.TabIndex = 6;
            this.gbxEdit1.Values.Heading = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 136);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(106, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 23;
            this.kryptonLabel5.Values.Text = "(*)Trương bắt buộc";
            // 
            // ipTask
            // 
            this.ipTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ipTask.Location = new System.Drawing.Point(266, 114);
            this.ipTask.Name = "ipTask";
            this.ipTask.Size = new System.Drawing.Size(177, 22);
            this.ipTask.TabIndex = 22;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonLabel4.Location = new System.Drawing.Point(184, 114);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 16);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 21;
            this.kryptonLabel4.Values.Text = "Công việc";
            // 
            // cbManager
            // 
            this.cbManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbManager.DropDownWidth = 177;
            this.cbManager.Location = new System.Drawing.Point(566, 84);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(177, 22);
            this.cbManager.TabIndex = 20;
            this.cbManager.Text = "chọn...";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonLabel3.Location = new System.Drawing.Point(482, 84);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(60, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 19;
            this.kryptonLabel3.Values.Text = "Quản lý(*)";
            // 
            // ipOthersCost
            // 
            this.ipOthersCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ipOthersCost.Location = new System.Drawing.Point(266, 87);
            this.ipOthersCost.Name = "ipOthersCost";
            this.ipOthersCost.Size = new System.Drawing.Size(177, 22);
            this.ipOthersCost.TabIndex = 18;
            this.ipOthersCost.Leave += new System.EventHandler(this.ipOthersCost_Leave);
            this.ipOthersCost.MouseLeave += new System.EventHandler(this.ipOthersCost_MouseLeave);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonLabel2.Location = new System.Drawing.Point(172, 87);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 16);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "Chi phí khác";
            // 
            // dtTodate
            // 
            this.dtTodate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtTodate.CustomFormat = "dd/MM/yyyy";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(566, 58);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(177, 20);
            this.dtTodate.TabIndex = 7;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbName.Location = new System.Drawing.Point(213, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 16);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.TabIndex = 10;
            this.lbName.Values.Text = "Tên (*)";
            // 
            // ipName
            // 
            this.ipName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ipName.Location = new System.Drawing.Point(266, 31);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(177, 22);
            this.ipName.TabIndex = 4;
            // 
            // cbCons
            // 
            this.cbCons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbCons.DropDownWidth = 177;
            this.cbCons.Location = new System.Drawing.Point(267, 59);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(177, 22);
            this.cbCons.TabIndex = 6;
            this.cbCons.Text = "chọn...";
            // 
            // lbTodate
            // 
            this.lbTodate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTodate.Location = new System.Drawing.Point(483, 59);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(59, 16);
            this.lbTodate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTodate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTodate.TabIndex = 16;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // lbCons
            // 
            this.lbCons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCons.Location = new System.Drawing.Point(183, 59);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(74, 16);
            this.lbCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbCons.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCons.TabIndex = 12;
            this.lbCons.Values.Text = "Công trình(*)";
            // 
            // dtFromdate
            // 
            this.dtFromdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtFromdate.CustomFormat = "dd/MM/yyyy";
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromdate.Location = new System.Drawing.Point(565, 34);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(177, 20);
            this.dtFromdate.TabIndex = 5;
            // 
            // lbFromDate
            // 
            this.lbFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbFromDate.Location = new System.Drawing.Point(490, 34);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(51, 16);
            this.lbFromDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbFromDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromDate.TabIndex = 14;
            this.lbFromDate.Values.Text = "Từ ngày";
            // 
            // hdEdit
            // 
            this.hdEdit.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSave});
            this.hdEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdEdit.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdEdit.Location = new System.Drawing.Point(0, 0);
            this.hdEdit.Name = "hdEdit";
            this.hdEdit.Size = new System.Drawing.Size(920, 29);
            this.hdEdit.TabIndex = 3;
            this.hdEdit.Values.Description = "";
            this.hdEdit.Values.Heading = "Thông Tin Chi Tiết";
            this.hdEdit.Values.Image = null;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnSave.Text = "Lưu thay đổi ";
            this.btnSave.ToolTipTitle = "Lưu";
            this.btnSave.UniqueName = "6549634A1C68497476A2DADA48F6958C";
            this.btnSave.Click += new System.EventHandler(this.btSave_Click);
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
            // cmsEdit
            // 
            this.cmsEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.FreezeToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(183, 70);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.EditToolStripMenuItem.Text = "Sửa";
            // 
            // FreezeToolStripMenuItem
            // 
            this.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem";
            this.FreezeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.FreezeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.FreezeToolStripMenuItem.Text = "Đóng Băng";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.SaveToolStripMenuItem.Text = "Lưu";
            // 
            // cmsGen
            // 
            this.cmsGen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenMoneyToolStripMenuItem});
            this.cmsGen.Name = "cmsGen";
            this.cmsGen.Size = new System.Drawing.Size(177, 26);
            // 
            // GenMoneyToolStripMenuItem
            // 
            this.GenMoneyToolStripMenuItem.Name = "GenMoneyToolStripMenuItem";
            this.GenMoneyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GenMoneyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.GenMoneyToolStripMenuItem.Text = "Thêm 000";
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
            this.cmsMain.Size = new System.Drawing.Size(195, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem1.Text = "Làm Mới";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem3.Text = "Thêm";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SearchToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // HideSearchToolStripMenuItem
            // 
            this.HideSearchToolStripMenuItem.Name = "HideSearchToolStripMenuItem";
            this.HideSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HideSearchToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.HideSearchToolStripMenuItem.Text = "Ẩn Tìm Kiếm";
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // workerSalaryDTOBindingSource
            // 
            this.workerSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerSalaryDTO);
            // 
            // WorkerSalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.kryptonPanel);
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.Name = "WorkerSalaryManagement";
            this.Text = "Quản lý lương công nhân";
            this.Load += new System.EventHandler(this.WorkerSalaryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.gbxSearch.Panel.ResumeLayout(false);
            this.gbxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxSearch)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).EndInit();
            this.gbcRightBot.Panel.ResumeLayout(false);
            this.gbcRightBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            this.gbxEdit1.Panel.ResumeLayout(false);
            this.gbxEdit1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).EndInit();
            this.gbxEdit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.cmsDGV.ResumeLayout(false);
            this.cmsEdit.ResumeLayout(false);
            this.cmsGen.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.BindingSource workerSalaryDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private System.Windows.Forms.BindingSource workerSalaryDTOBindingSource1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWks;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolTip toolTip;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDebt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ContextMenuStrip cmsDGV;
        private ToolStripMenuItem RefreshToolStripMenuItem;
        private ToolStripMenuItem LoadAllToolStripMenuItem;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem DeleteAllToolStripMenuItem;
        private ContextMenuStrip cmsEdit;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem FreezeToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ContextMenuStrip cmsGen;
        private ToolStripMenuItem GenMoneyToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuCheckBox kryptonContextMenuCheckBox1;
        private ContextMenuStrip cmsMain;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem lưuToolStripMenuItem;
        private ToolStripMenuItem SearchToolStripMenuItem;
        private ToolStripMenuItem HideSearchToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btViewList;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSearchCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchCons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSearchName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipOthersCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTask;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WorkersSalaryID;
        private DataGridViewTextBoxColumn constructionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ManagerName;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OthersCost;
        private DataGridViewTextBoxColumn TotalCost;
        private DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}

