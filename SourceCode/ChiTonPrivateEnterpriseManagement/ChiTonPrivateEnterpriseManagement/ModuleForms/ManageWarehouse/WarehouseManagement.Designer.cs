﻿namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvWH = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.WarehouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pnlSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbbTypeSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbNameSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbStatusSearch = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hdWH = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.slcEdit = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxEdit1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbConstruction = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtWarehouseName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNameManager = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gbxEdit2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hdEdit = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnUnableEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GenMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreezeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbbTypeSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatusSearch)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbbConstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).BeginInit();
            this.gbxEdit2.Panel.SuspendLayout();
            this.gbxEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            this.cmsDGV.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.cmsGen.SuspendLayout();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 557);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(784, 5);
            this.kryptonPanel3.TabIndex = 8;
            // 
            // dgvWH
            // 
            this.dgvWH.AutoGenerateColumns = false;
            this.dgvWH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseID,
            this.WarehouseName,
            this.ManagerName,
            this.Type,
            this.ConstructionName,
            this.Address,
            this.IsActive,
            this.Description});
            this.dgvWH.DataSource = this.warehouseDTOBindingSource;
            this.dgvWH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWH.Location = new System.Drawing.Point(0, 92);
            this.dgvWH.Name = "dgvWH";
            this.dgvWH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWH.Size = new System.Drawing.Size(780, 237);
            this.dgvWH.TabIndex = 9;
            // 
            // WarehouseID
            // 
            this.WarehouseID.DataPropertyName = "WarehouseID";
            this.WarehouseID.HeaderText = "Mã Số";
            this.WarehouseID.Name = "WarehouseID";
            // 
            // WarehouseName
            // 
            this.WarehouseName.DataPropertyName = "WarehouseName";
            this.WarehouseName.HeaderText = "Tên";
            this.WarehouseName.Name = "WarehouseName";
            // 
            // ManagerName
            // 
            this.ManagerName.DataPropertyName = "ManagerName";
            this.ManagerName.HeaderText = "Người Quản Lý";
            this.ManagerName.Name = "ManagerName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại";
            this.Type.Name = "Type";
            // 
            // ConstructionName
            // 
            this.ConstructionName.DataPropertyName = "ConstructionName";
            this.ConstructionName.HeaderText = "Công Trình";
            this.ConstructionName.Name = "ConstructionName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Còn  Hoạt Động";
            this.IsActive.Name = "IsActive";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Ghi Chú";
            this.Description.Name = "Description";
            // 
            // warehouseDTOBindingSource
            // 
            this.warehouseDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WarehouseDTO);
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
            this.slcMain.Size = new System.Drawing.Size(784, 557);
            this.slcMain.SplitterDistance = 335;
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
            this.gbxLeftBot.Panel.Controls.Add(this.dgvWH);
            this.gbxLeftBot.Panel.Controls.Add(this.pnlSearch);
            this.gbxLeftBot.Panel.Controls.Add(this.hdWH);
            this.gbxLeftBot.Size = new System.Drawing.Size(784, 335);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbxSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(50, 0, 50, 5);
            this.pnlSearch.Size = new System.Drawing.Size(780, 62);
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
            this.gbxSearch.Panel.Controls.Add(this.cbbTypeSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel11);
            this.gbxSearch.Panel.Controls.Add(this.cbbNameSearch);
            this.gbxSearch.Panel.Controls.Add(this.btnSearch);
            this.gbxSearch.Panel.Controls.Add(this.cbbStatusSearch);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxSearch.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxSearch.Size = new System.Drawing.Size(680, 57);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.Values.Heading = "";
            // 
            // cbbTypeSearch
            // 
            this.cbbTypeSearch.DropDownWidth = 218;
            this.cbbTypeSearch.Location = new System.Drawing.Point(57, 17);
            this.cbbTypeSearch.Name = "cbbTypeSearch";
            this.cbbTypeSearch.Size = new System.Drawing.Size(113, 21);
            this.cbbTypeSearch.TabIndex = 7;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(18, 17);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel11.TabIndex = 8;
            this.kryptonLabel11.Values.Text = "Loại";
            // 
            // cbbNameSearch
            // 
            this.cbbNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNameSearch.DropDownWidth = 218;
            this.cbbNameSearch.Location = new System.Drawing.Point(237, 16);
            this.cbbNameSearch.Name = "cbbNameSearch";
            this.cbbNameSearch.Size = new System.Drawing.Size(129, 21);
            this.cbbNameSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(593, 2);
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
            this.cbbStatusSearch.Location = new System.Drawing.Point(447, 16);
            this.cbbStatusSearch.Name = "cbbStatusSearch";
            this.cbbStatusSearch.Size = new System.Drawing.Size(140, 21);
            this.cbbStatusSearch.TabIndex = 2;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel10.Location = new System.Drawing.Point(372, 17);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 6;
            this.kryptonLabel10.Values.Text = "Tình Trạng";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(176, 18);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Tên Kho";
            // 
            // hdWH
            // 
            this.hdWH.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnRefresh,
            this.btnAdd,
            this.btnDelete,
            this.btnDeleteAll,
            this.btnHideShowSearch});
            this.hdWH.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdWH.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdWH.Location = new System.Drawing.Point(0, 0);
            this.hdWH.Name = "hdWH";
            this.hdWH.Size = new System.Drawing.Size(780, 30);
            this.hdWH.TabIndex = 0;
            this.hdWH.Values.Description = "";
            this.hdWH.Values.Heading = "Danh Nhà Cung Cấp";
            this.hdWH.Values.Image = null;
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
            this.gbcRightBot.Size = new System.Drawing.Size(784, 217);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // slcEdit
            // 
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
            this.slcEdit.Size = new System.Drawing.Size(780, 181);
            this.slcEdit.SplitterDistance = 388;
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
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel12);
            this.gbxEdit1.Panel.Controls.Add(this.txtId);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxEdit1.Panel.Controls.Add(this.cbbConstruction);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxEdit1.Panel.Controls.Add(this.cbbType);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxEdit1.Panel.Controls.Add(this.txtWarehouseName);
            this.gbxEdit1.Panel.Controls.Add(this.txtNameManager);
            this.gbxEdit1.Size = new System.Drawing.Size(383, 176);
            this.gbxEdit1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(144)))));
            this.gbxEdit1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxEdit1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdit1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxEdit1.TabIndex = 5;
            this.gbxEdit1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(51, 14);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel12.TabIndex = 36;
            this.kryptonLabel12.Values.Text = "Mã Số";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(263, 20);
            this.txtId.TabIndex = 37;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(4, 118);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 20);
            this.kryptonLabel4.TabIndex = 31;
            this.kryptonLabel4.Values.Text = "Ngoài Quản Lý";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(41, 40);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel1.TabIndex = 28;
            this.kryptonLabel1.Values.Text = "Tên Kho";
            // 
            // cbbConstruction
            // 
            this.cbbConstruction.DropDownWidth = 218;
            this.cbbConstruction.Location = new System.Drawing.Point(102, 92);
            this.cbbConstruction.Name = "cbbConstruction";
            this.cbbConstruction.Size = new System.Drawing.Size(263, 21);
            this.cbbConstruction.TabIndex = 35;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(63, 66);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel2.TabIndex = 29;
            this.kryptonLabel2.Values.Text = "Loại";
            // 
            // cbbType
            // 
            this.cbbType.DropDownWidth = 251;
            this.cbbType.Location = new System.Drawing.Point(102, 65);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(263, 21);
            this.cbbType.TabIndex = 34;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(25, 92);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel3.TabIndex = 30;
            this.kryptonLabel3.Values.Text = "Công Trình";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(102, 39);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(263, 20);
            this.txtWarehouseName.TabIndex = 32;
            // 
            // txtNameManager
            // 
            this.txtNameManager.Location = new System.Drawing.Point(102, 119);
            this.txtNameManager.Name = "txtNameManager";
            this.txtNameManager.Size = new System.Drawing.Size(263, 20);
            this.txtNameManager.TabIndex = 33;
            // 
            // gbxEdit2
            // 
            this.gbxEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit2.Location = new System.Drawing.Point(0, 0);
            this.gbxEdit2.Name = "gbxEdit2";
            // 
            // gbxEdit2.Panel
            // 
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxEdit2.Panel.Controls.Add(this.cbbStatus);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxEdit2.Panel.Controls.Add(this.txtDescription);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxEdit2.Panel.Controls.Add(this.txtAddress);
            this.gbxEdit2.Size = new System.Drawing.Size(387, 181);
            this.gbxEdit2.TabIndex = 5;
            this.gbxEdit2.Values.Heading = "Thông Tin Thêm";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(24, 90);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel7.TabIndex = 31;
            this.kryptonLabel7.Values.Text = "Ghi Chú";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownWidth = 218;
            this.cbbStatus.Location = new System.Drawing.Point(84, 63);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(272, 21);
            this.cbbStatus.TabIndex = 34;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(29, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel5.TabIndex = 29;
            this.kryptonLabel5.Values.Text = "Địa Chỉ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(84, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(272, 45);
            this.txtDescription.TabIndex = 33;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(9, 63);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel6.TabIndex = 30;
            this.kryptonLabel6.Values.Text = "Tình Trạng";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 14);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 42);
            this.txtAddress.TabIndex = 32;
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
            this.hdEdit.Size = new System.Drawing.Size(780, 30);
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
            // 
            // btnUnableEdit
            // 
            this.btnUnableEdit.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.freeze;
            this.btnUnableEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnUnableEdit.Text = "Đóng Băng";
            this.btnUnableEdit.UniqueName = "711D4B5F7134438B489063D5667E49ED";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnSave.Text = "Lưu";
            this.btnSave.ToolTipTitle = "Lưu";
            this.btnSave.UniqueName = "6549634A1C68497476A2DADA48F6958C";
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
            // 
            // LoadAllToolStripMenuItem
            // 
            this.LoadAllToolStripMenuItem.Name = "LoadAllToolStripMenuItem";
            this.LoadAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.LoadAllToolStripMenuItem.Text = "Tải Tất Cả";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.AddToolStripMenuItem.Text = "Thêm";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteToolStripMenuItem.Text = "Xóa";
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DeleteAllToolStripMenuItem.Text = "Xóa Tất Cả";
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
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SearchToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // HideSearchToolStripMenuItem
            // 
            this.HideSearchToolStripMenuItem.Name = "HideSearchToolStripMenuItem";
            this.HideSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HideSearchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.HideSearchToolStripMenuItem.Text = "Ẩn Tìm Kiếm";
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
            // 
            // FreezeToolStripMenuItem
            // 
            this.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem";
            this.FreezeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.FreezeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.FreezeToolStripMenuItem.Text = "Đóng Băng";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SaveToolStripMenuItem.Text = "Lưu";
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.slcMain);
            this.Controls.Add(this.kryptonPanel3);
            this.Name = "WarehouseManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDTOBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbbTypeSearch)).EndInit();
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
            this.gbxEdit1.Panel.ResumeLayout(false);
            this.gbxEdit1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).EndInit();
            this.gbxEdit1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbConstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType)).EndInit();
            this.gbxEdit2.Panel.ResumeLayout(false);
            this.gbxEdit2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).EndInit();
            this.gbxEdit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            this.cmsDGV.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            this.cmsGen.ResumeLayout(false);
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.BindingSource warehouseDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWH;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbNameSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatusSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdWH;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnRefresh;
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
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbTypeSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbConstruction;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtWarehouseName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNameManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private System.Windows.Forms.ContextMenuStrip cmsDGV;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideSearchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsGen;
        private System.Windows.Forms.ToolStripMenuItem GenMoneyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreezeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

