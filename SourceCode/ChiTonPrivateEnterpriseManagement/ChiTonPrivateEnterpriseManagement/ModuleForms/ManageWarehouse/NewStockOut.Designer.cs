namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    partial class NewStockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStockOut));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.dgvStockOutDetail = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialUnitCallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbStockOutTo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbStockOutFrom = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbTypyWarehouse = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtpStockOutDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtTransportationCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbVehicle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbDriver = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbmaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.slcFinalAccInfo = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxEdit1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbxEdit2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.hdMainInfo = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.pnlNewItem = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gbxNewItem = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.hdDetailInfo = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnHideShowSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStockOutTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStockOutFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTypyWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcFinalAccInfo)).BeginInit();
            this.slcFinalAccInfo.Panel1.SuspendLayout();
            this.slcFinalAccInfo.Panel2.SuspendLayout();
            this.slcFinalAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).BeginInit();
            this.gbxEdit1.Panel.SuspendLayout();
            this.gbxEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).BeginInit();
            this.gbxEdit2.Panel.SuspendLayout();
            this.gbxEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).BeginInit();
            this.pnlNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxNewItem)).BeginInit();
            this.gbxNewItem.Panel.SuspendLayout();
            this.gbxNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockOutDetail
            // 
            this.dgvStockOutDetail.AutoGenerateColumns = false;
            this.dgvStockOutDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.materialUnitCallDataGridViewTextBoxColumn,
            this.Note});
            this.dgvStockOutDetail.DataSource = this.stockOutDetailDTOBindingSource;
            this.dgvStockOutDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockOutDetail.Location = new System.Drawing.Point(0, 178);
            this.dgvStockOutDetail.Name = "dgvStockOutDetail";
            this.dgvStockOutDetail.Size = new System.Drawing.Size(447, 251);
            this.dgvStockOutDetail.TabIndex = 27;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "Tên Vật Tư";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // materialUnitCallDataGridViewTextBoxColumn
            // 
            this.materialUnitCallDataGridViewTextBoxColumn.DataPropertyName = "MaterialUnitCall";
            this.materialUnitCallDataGridViewTextBoxColumn.HeaderText = "Đơn Vị";
            this.materialUnitCallDataGridViewTextBoxColumn.Name = "materialUnitCallDataGridViewTextBoxColumn";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            // 
            // stockOutDetailDTOBindingSource
            // 
            this.stockOutDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.StockOutDetailDTO);
            // 
            // cbbStockOutTo
            // 
            this.cbbStockOutTo.DropDownWidth = 192;
            this.cbbStockOutTo.Location = new System.Drawing.Point(113, 113);
            this.cbbStockOutTo.Name = "cbbStockOutTo";
            this.cbbStockOutTo.Size = new System.Drawing.Size(192, 22);
            this.cbbStockOutTo.TabIndex = 9;
            // 
            // cbbStockOutFrom
            // 
            this.cbbStockOutFrom.DropDownWidth = 192;
            this.cbbStockOutFrom.Location = new System.Drawing.Point(113, 88);
            this.cbbStockOutFrom.Name = "cbbStockOutFrom";
            this.cbbStockOutFrom.Size = new System.Drawing.Size(192, 22);
            this.cbbStockOutFrom.TabIndex = 8;
            // 
            // cbbTypyWarehouse
            // 
            this.cbbTypyWarehouse.DropDownWidth = 192;
            this.cbbTypyWarehouse.Location = new System.Drawing.Point(113, 63);
            this.cbbTypyWarehouse.Name = "cbbTypyWarehouse";
            this.cbbTypyWarehouse.Size = new System.Drawing.Size(192, 22);
            this.cbbTypyWarehouse.TabIndex = 7;
            // 
            // dtpStockOutDate
            // 
            this.dtpStockOutDate.Location = new System.Drawing.Point(113, 38);
            this.dtpStockOutDate.Name = "dtpStockOutDate";
            this.dtpStockOutDate.Size = new System.Drawing.Size(192, 20);
            this.dtpStockOutDate.TabIndex = 6;
            // 
            // txtTransportationCost
            // 
            this.txtTransportationCost.Location = new System.Drawing.Point(113, 138);
            this.txtTransportationCost.Name = "txtTransportationCost";
            this.txtTransportationCost.Size = new System.Drawing.Size(192, 22);
            this.txtTransportationCost.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(11, 136);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(89, 19);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Phí Vận Chuyễn";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(74, 111);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(30, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Đến";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(55, 87);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(49, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Xuất Từ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Loại Kho Xuất";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Ngày Xuất Kho";
            // 
            // cbbVehicle
            // 
            this.cbbVehicle.DropDownWidth = 192;
            this.cbbVehicle.Location = new System.Drawing.Point(118, 43);
            this.cbbVehicle.Name = "cbbVehicle";
            this.cbbVehicle.Size = new System.Drawing.Size(192, 22);
            this.cbbVehicle.TabIndex = 10;
            // 
            // cbbDriver
            // 
            this.cbbDriver.DropDownWidth = 192;
            this.cbbDriver.Location = new System.Drawing.Point(118, 19);
            this.cbbDriver.Name = "cbbDriver";
            this.cbbDriver.Size = new System.Drawing.Size(192, 22);
            this.cbbDriver.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(118, 68);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(192, 70);
            this.txtNote.TabIndex = 8;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(58, 68);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel8.TabIndex = 7;
            this.kryptonLabel8.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(19, 44);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(86, 19);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "Xe Vẫn Chuyễn";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(69, 19);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(40, 19);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "Tài Xế";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(115, 38);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(241, 22);
            this.txtQuantity.TabIndex = 26;
            // 
            // cbbmaterial
            // 
            this.cbbmaterial.DropDownWidth = 192;
            this.cbbmaterial.Location = new System.Drawing.Point(115, 13);
            this.cbbmaterial.Name = "cbbmaterial";
            this.cbbmaterial.Size = new System.Drawing.Size(241, 22);
            this.cbbmaterial.TabIndex = 25;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(47, 38);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(58, 19);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel10.TabIndex = 24;
            this.kryptonLabel10.Values.Text = "Số Lượng";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(63, 14);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(43, 19);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel9.TabIndex = 23;
            this.kryptonLabel9.Values.Text = "Vật Tư";
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.slcFinalAccInfo);
            this.slcMain.Panel1.Controls.Add(this.hdMainInfo);
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.dgvStockOutDetail);
            this.slcMain.Panel2.Controls.Add(this.pnlNewItem);
            this.slcMain.Panel2.Controls.Add(this.hdDetailInfo);
            this.slcMain.Size = new System.Drawing.Size(784, 429);
            this.slcMain.SplitterDistance = 332;
            this.slcMain.TabIndex = 28;
            // 
            // slcFinalAccInfo
            // 
            this.slcFinalAccInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcFinalAccInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcFinalAccInfo.Location = new System.Drawing.Point(0, 29);
            this.slcFinalAccInfo.Name = "slcFinalAccInfo";
            this.slcFinalAccInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slcFinalAccInfo.Panel1
            // 
            this.slcFinalAccInfo.Panel1.Controls.Add(this.gbxEdit1);
            this.slcFinalAccInfo.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.slcFinalAccInfo.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // slcFinalAccInfo.Panel2
            // 
            this.slcFinalAccInfo.Panel2.Controls.Add(this.gbxEdit2);
            this.slcFinalAccInfo.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcFinalAccInfo.Size = new System.Drawing.Size(332, 400);
            this.slcFinalAccInfo.SplitterDistance = 216;
            this.slcFinalAccInfo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcFinalAccInfo.TabIndex = 7;
            // 
            // gbxEdit1
            // 
            this.gbxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit1.Location = new System.Drawing.Point(5, 0);
            this.gbxEdit1.Name = "gbxEdit1";
            // 
            // gbxEdit1.Panel
            // 
            this.gbxEdit1.Panel.Controls.Add(this.cbbStockOutTo);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxEdit1.Panel.Controls.Add(this.cbbStockOutFrom);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxEdit1.Panel.Controls.Add(this.cbbTypyWarehouse);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxEdit1.Panel.Controls.Add(this.dtpStockOutDate);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxEdit1.Panel.Controls.Add(this.txtTransportationCost);
            this.gbxEdit1.Panel.Controls.Add(this.kryptonLabel5);
            this.gbxEdit1.Size = new System.Drawing.Size(327, 211);
            this.gbxEdit1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(144)))));
            this.gbxEdit1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxEdit1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdit1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxEdit1.TabIndex = 5;
            this.gbxEdit1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // gbxEdit2
            // 
            this.gbxEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEdit2.Location = new System.Drawing.Point(0, 0);
            this.gbxEdit2.Name = "gbxEdit2";
            // 
            // gbxEdit2.Panel
            // 
            this.gbxEdit2.Panel.Controls.Add(this.cbbVehicle);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel7);
            this.gbxEdit2.Panel.Controls.Add(this.cbbDriver);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel6);
            this.gbxEdit2.Panel.Controls.Add(this.txtNote);
            this.gbxEdit2.Panel.Controls.Add(this.kryptonLabel8);
            this.gbxEdit2.Size = new System.Drawing.Size(332, 179);
            this.gbxEdit2.TabIndex = 5;
            this.gbxEdit2.Values.Heading = "Thông Tin Thêm";
            // 
            // hdMainInfo
            // 
            this.hdMainInfo.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSave,
            this.btnClear,
            this.btnClose});
            this.hdMainInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdMainInfo.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdMainInfo.Location = new System.Drawing.Point(0, 0);
            this.hdMainInfo.Name = "hdMainInfo";
            this.hdMainInfo.Size = new System.Drawing.Size(332, 29);
            this.hdMainInfo.TabIndex = 8;
            this.hdMainInfo.Values.Description = "";
            this.hdMainInfo.Values.Heading = "Thông Tin Chi Tiết";
            this.hdMainInfo.Values.Image = null;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnSave.Text = "Lưu";
            this.btnSave.ToolTipTitle = "Lưu";
            this.btnSave.UniqueName = "6549634A1C68497476A2DADA48F6958C";
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnClear.Text = "Làm Mới";
            this.btnClear.UniqueName = "711D4B5F7134438B489063D5667E49ED";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btnClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnClose.Text = "Đóng";
            this.btnClose.UniqueName = "C645E9231765438901BDC91A1034E5D9";
            // 
            // pnlNewItem
            // 
            this.pnlNewItem.Controls.Add(this.kryptonTextBox1);
            this.pnlNewItem.Controls.Add(this.kryptonLabel11);
            this.pnlNewItem.Controls.Add(this.gbxNewItem);
            this.pnlNewItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewItem.Location = new System.Drawing.Point(0, 29);
            this.pnlNewItem.Name = "pnlNewItem";
            this.pnlNewItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.pnlNewItem.Size = new System.Drawing.Size(447, 149);
            this.pnlNewItem.TabIndex = 11;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(127, 66);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(241, 70);
            this.kryptonTextBox1.TabIndex = 28;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(67, 66);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel11.TabIndex = 27;
            this.kryptonLabel11.Values.Text = "Ghi Chú";
            // 
            // gbxNewItem
            // 
            this.gbxNewItem.CaptionOverlap = 0D;
            this.gbxNewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNewItem.Location = new System.Drawing.Point(10, 0);
            this.gbxNewItem.Name = "gbxNewItem";
            // 
            // gbxNewItem.Panel
            // 
            this.gbxNewItem.Panel.Controls.Add(this.txtQuantity);
            this.gbxNewItem.Panel.Controls.Add(this.kryptonLabel9);
            this.gbxNewItem.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxNewItem.Panel.Controls.Add(this.cbbmaterial);
            this.gbxNewItem.Size = new System.Drawing.Size(427, 144);
            this.gbxNewItem.TabIndex = 8;
            this.gbxNewItem.Values.Heading = "";
            // 
            // hdDetailInfo
            // 
            this.hdDetailInfo.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnAdd,
            this.btnDelete,
            this.btnDeleteAll,
            this.btnHideShowSearch});
            this.hdDetailInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdDetailInfo.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdDetailInfo.Location = new System.Drawing.Point(0, 0);
            this.hdDetailInfo.Name = "hdDetailInfo";
            this.hdDetailInfo.Size = new System.Drawing.Size(447, 29);
            this.hdDetailInfo.TabIndex = 13;
            this.hdDetailInfo.Values.Description = "";
            this.hdDetailInfo.Values.Heading = "Danh Nhà Cung Cấp";
            this.hdDetailInfo.Values.Image = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UniqueName = "6E177DC1660348E375BDCE591BF21FCB";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.delete1;
            this.btnDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UniqueName = "46715A2AEC0143074F81325F50887305";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.cancel;
            this.btnDeleteAll.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnDeleteAll.Text = "Xóa Tất Cả";
            this.btnDeleteAll.UniqueName = "CD7065CA8BA743FB00B53BCE567E60B8";
            // 
            // btnHideShowSearch
            // 
            this.btnHideShowSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnHideShowSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.btnHideShowSearch.UniqueName = "7CD50F96676F43E7C0B240BAD639EFD5";
            // 
            // NewStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 429);
            this.Controls.Add(this.slcMain);
            this.Name = "NewStockOut";
            this.Text = "StockOutManagement";
            this.Load += new System.EventHandler(this.NewStockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDetailDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStockOutTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStockOutFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTypyWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmaterial)).EndInit();
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel1.PerformLayout();
            this.slcMain.Panel2.ResumeLayout(false);
            this.slcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.slcFinalAccInfo.Panel1.ResumeLayout(false);
            this.slcFinalAccInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcFinalAccInfo)).EndInit();
            this.slcFinalAccInfo.ResumeLayout(false);
            this.gbxEdit1.Panel.ResumeLayout(false);
            this.gbxEdit1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit1)).EndInit();
            this.gbxEdit1.ResumeLayout(false);
            this.gbxEdit2.Panel.ResumeLayout(false);
            this.gbxEdit2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEdit2)).EndInit();
            this.gbxEdit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).EndInit();
            this.pnlNewItem.ResumeLayout(false);
            this.pnlNewItem.PerformLayout();
            this.gbxNewItem.Panel.ResumeLayout(false);
            this.gbxNewItem.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxNewItem)).EndInit();
            this.gbxNewItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.BindingSource stockOutDetailDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvStockOutDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStockOutTo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStockOutFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbTypyWarehouse;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpStockOutDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTransportationCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbVehicle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbDriver;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbmaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcFinalAccInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxEdit2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdMainInfo;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnClear;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlNewItem;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxNewItem;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdDetailInfo;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnHideShowSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialUnitCallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;

    }
}

