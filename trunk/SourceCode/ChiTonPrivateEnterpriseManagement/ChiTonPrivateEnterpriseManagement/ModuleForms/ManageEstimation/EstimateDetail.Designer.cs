namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class EstimateDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateDetail));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.ipTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvEstimateDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimateDetailDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbSearchMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbSearchMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.estimateDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.dgvEstimateDetails);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(875, 660);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 402);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipTotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbType);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbType);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbUnit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTotalCost);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbMaterial);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbMaterial);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(875, 255);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // ipTotal
            // 
            this.ipTotal.Location = new System.Drawing.Point(506, 127);
            this.ipTotal.Name = "ipTotal";
            this.ipTotal.ReadOnly = true;
            this.ipTotal.Size = new System.Drawing.Size(170, 22);
            this.ipTotal.TabIndex = 29;
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 148;
            this.cbType.Items.AddRange(new object[] {
            "Vật liệu",
            "Tổng quát"});
            this.cbType.Location = new System.Drawing.Point(250, 87);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(148, 22);
            this.cbType.TabIndex = 28;
            this.cbType.Text = "chọn";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(208, 93);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 19);
            this.lbType.TabIndex = 27;
            this.lbType.Values.Text = "Loại";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(250, 59);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(148, 22);
            this.ipName.TabIndex = 26;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(179, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 19);
            this.lbName.TabIndex = 25;
            this.lbName.Values.Text = "Tên chi tiết";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(354, 217);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(82, 25);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Cập nhật";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.Enabled = false;
            this.lbUnit.Location = new System.Drawing.Point(682, 55);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(23, 23);
            this.lbUnit.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.lbUnit.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbUnit.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.TabIndex = 8;
            this.lbUnit.Values.Text = "()";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Location = new System.Drawing.Point(437, 130);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(66, 19);
            this.lbTotalCost.TabIndex = 6;
            this.lbTotalCost.Values.Text = "Tổng(VND)";
            // 
            // ipPrice
            // 
            this.ipPrice.Enabled = false;
            this.ipPrice.Location = new System.Drawing.Point(506, 90);
            this.ipPrice.Name = "ipPrice";
            this.ipPrice.Size = new System.Drawing.Size(170, 22);
            this.ipPrice.TabIndex = 5;
            this.ipPrice.TextChanged += new System.EventHandler(this.ipPrice_TextChanged);
            // 
            // ipQuantity
            // 
            this.ipQuantity.Enabled = false;
            this.ipQuantity.Location = new System.Drawing.Point(506, 56);
            this.ipQuantity.Name = "ipQuantity";
            this.ipQuantity.Size = new System.Drawing.Size(170, 22);
            this.ipQuantity.TabIndex = 4;
            this.ipQuantity.TextChanged += new System.EventHandler(this.ipQuantity_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Enabled = false;
            this.lbQuantity.Location = new System.Drawing.Point(442, 59);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(61, 19);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Values.Text = "Số lượng :";
            // 
            // lbPrice
            // 
            this.lbPrice.Enabled = false;
            this.lbPrice.Location = new System.Drawing.Point(458, 90);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(32, 19);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Values.Text = "Giá :";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownWidth = 121;
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(250, 130);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(148, 22);
            this.cbMaterial.TabIndex = 1;
            this.cbMaterial.Text = "chọn...";
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // lbMaterial
            // 
            this.lbMaterial.Enabled = false;
            this.lbMaterial.Location = new System.Drawing.Point(145, 130);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(94, 19);
            this.lbMaterial.TabIndex = 0;
            this.lbMaterial.Values.Text = "Nguyên vật liệu :";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 366);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(875, 36);
            this.kryptonPanel3.TabIndex = 7;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(875, 36);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Chi tiết";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // dgvEstimateDetails
            // 
            this.dgvEstimateDetails.AutoGenerateColumns = false;
            this.dgvEstimateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.Name,
            this.EstimateDetailID,
            this.EstimateID,
            this.MaterialID,
            this.MaterialName,
            this.QuantityEstimate,
            this.UnitCostEstimate,
            this.TotalCostEstimate});
            this.dgvEstimateDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvEstimateDetails.DataSource = this.estimateDetailDTOBindingSource1;
            this.dgvEstimateDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEstimateDetails.Location = new System.Drawing.Point(0, 73);
            this.dgvEstimateDetails.Name = "dgvEstimateDetails";
            this.dgvEstimateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimateDetails.Size = new System.Drawing.Size(875, 293);
            this.dgvEstimateDetails.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvEstimateDetails.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEstimateDetails.TabIndex = 0;
            this.dgvEstimateDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimateDetails_CellContentClick);
            this.dgvEstimateDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstimateDetails_MouseClick);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBox.Width = 50;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên chi tiết";
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // EstimateDetailID
            // 
            this.EstimateDetailID.DataPropertyName = "EstimateDetailID";
            this.EstimateDetailID.HeaderText = "EstimateDetailID";
            this.EstimateDetailID.Name = "EstimateDetailID";
            this.EstimateDetailID.Visible = false;
            // 
            // EstimateID
            // 
            this.EstimateID.DataPropertyName = "EstimateID";
            this.EstimateID.HeaderText = "EstimateID";
            this.EstimateID.Name = "EstimateID";
            this.EstimateID.Visible = false;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.Visible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Vật liệu";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Width = 200;
            // 
            // QuantityEstimate
            // 
            this.QuantityEstimate.DataPropertyName = "QuantityEstimate";
            this.QuantityEstimate.HeaderText = "Số lượng";
            this.QuantityEstimate.Name = "QuantityEstimate";
            this.QuantityEstimate.Width = 150;
            // 
            // UnitCostEstimate
            // 
            this.UnitCostEstimate.DataPropertyName = "UnitCostEstimate";
            this.UnitCostEstimate.HeaderText = "Gía";
            this.UnitCostEstimate.Name = "UnitCostEstimate";
            this.UnitCostEstimate.Width = 150;
            // 
            // TotalCostEstimate
            // 
            this.TotalCostEstimate.DataPropertyName = "TotalCostEstimate";
            this.TotalCostEstimate.HeaderText = "Tổng";
            this.TotalCostEstimate.Name = "TotalCostEstimate";
            this.TotalCostEstimate.Width = 150;
            // 
            // estimateDetailDTOBindingSource1
            // 
            this.estimateDetailDTOBindingSource1.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EstimateDetailDTO);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 45);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(875, 28);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btAdd,
            this.btDelete});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(875, 28);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // btAdd
            // 
            this.btAdd.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btAdd.Text = "Tạo";
            this.btAdd.UniqueName = "37400AF6E35B4007DCB0ABFF192DCA1A";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btDelete.Text = "Xóa";
            this.btDelete.UniqueName = "4CB676F7E80A4D624DA3AA57DFC0ED6A";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btSearch);
            this.kryptonPanel2.Controls.Add(this.cbSearchMaterial);
            this.kryptonPanel2.Controls.Add(this.lbSearchMaterial);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(875, 45);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Khaki;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.kryptonPanel2.TabIndex = 6;
            // 
            // btSearch
            // 
            this.btSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSearch.Location = new System.Drawing.Point(515, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(44, 35);
            this.btSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.TabIndex = 10;
            this.btSearch.Values.Text = "";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbSearchMaterial
            // 
            this.cbSearchMaterial.DropDownWidth = 146;
            this.cbSearchMaterial.Location = new System.Drawing.Point(346, 9);
            this.cbSearchMaterial.Name = "cbSearchMaterial";
            this.cbSearchMaterial.Size = new System.Drawing.Size(146, 22);
            this.cbSearchMaterial.TabIndex = 3;
            this.cbSearchMaterial.Text = "chọn...";
            // 
            // lbSearchMaterial
            // 
            this.lbSearchMaterial.Location = new System.Drawing.Point(279, 12);
            this.lbSearchMaterial.Name = "lbSearchMaterial";
            this.lbSearchMaterial.Size = new System.Drawing.Size(48, 19);
            this.lbSearchMaterial.TabIndex = 2;
            this.lbSearchMaterial.Values.Text = "Vật liệu";
            // 
            // estimateDetailDTOBindingSource
            // 
            this.estimateDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EstimateDetailDTO);
            // 
            // workerDTOBindingSource
            // 
            this.workerDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerDTO);
            // 
            // EstimateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 660);
            this.Controls.Add(this.kryptonPanel);
            this.Text = "EstimateDetail";
            this.Load += new System.EventHandler(this.EstimateDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEstimateDetails;
        private System.Windows.Forms.BindingSource estimateDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource workerDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btAdd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSearchMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchMaterial;
        private System.Windows.Forms.BindingSource estimateDetailDTOBindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCostEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
    }
}

