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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvEstimateDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCostNum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cửaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimateDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.EstimateDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCostReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvEstimateDetails);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Controls.Add(this.menuStrip1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(875, 522);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvEstimateDetails
            // 
            this.dgvEstimateDetails.AutoGenerateColumns = false;
            this.dgvEstimateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.EstimateDetailID,
            this.EstimateID,
            this.MaterialID,
            this.MaterialName,
            this.QuantityEstimate,
            this.UnitCostEstimate,
            this.TotalCostEstimate,
            this.QuantityReal,
            this.UnitCostReal,
            this.TotalCostReal,
            this.Note,
            this.Status});
            this.dgvEstimateDetails.DataSource = this.estimateDetailDTOBindingSource;
            this.dgvEstimateDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEstimateDetails.Location = new System.Drawing.Point(0, 103);
            this.dgvEstimateDetails.Name = "dgvEstimateDetails";
            this.dgvEstimateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimateDetails.Size = new System.Drawing.Size(875, 214);
            this.dgvEstimateDetails.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvEstimateDetails.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEstimateDetails.TabIndex = 0;
            this.dgvEstimateDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimateDetails_CellContentClick);
            this.dgvEstimateDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstimateDetails_MouseClick);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 69);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(875, 34);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(875, 34);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách Vật liệu";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 24);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btAdd);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btDelete);
            this.kryptonGroupBox2.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox2_Panel_Paint);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(875, 45);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonGroupBox2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.kryptonGroupBox2.TabIndex = 4;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(7, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(53, 33);
            this.btAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.TabIndex = 1;
            this.btAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Values.Image")));
            this.btAdd.Values.Text = "Tạo";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(66, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(50, 33);
            this.btDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDelete.TabIndex = 2;
            this.btDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Values.Image")));
            this.btDelete.Values.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 323);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbUnit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTotalCostNum);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTotalCost);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbMaterial);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbMaterial);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(872, 199);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(352, 108);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(82, 25);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Cập nhật";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.Location = new System.Drawing.Point(490, 20);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(6, 2);
            this.lbUnit.TabIndex = 8;
            this.lbUnit.Values.Text = "";
            // 
            // lbTotalCostNum
            // 
            this.lbTotalCostNum.Location = new System.Drawing.Point(389, 57);
            this.lbTotalCostNum.Name = "lbTotalCostNum";
            this.lbTotalCostNum.Size = new System.Drawing.Size(45, 19);
            this.lbTotalCostNum.TabIndex = 7;
            this.lbTotalCostNum.Values.ExtraText = "VND";
            this.lbTotalCostNum.Values.Text = "0";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Location = new System.Drawing.Point(264, 57);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(120, 19);
            this.lbTotalCost.TabIndex = 6;
            this.lbTotalCost.Values.Text = "Tổng chi phí dự toán :";
            // 
            // ipPrice
            // 
            this.ipPrice.Location = new System.Drawing.Point(622, 16);
            this.ipPrice.Name = "ipPrice";
            this.ipPrice.Size = new System.Drawing.Size(100, 22);
            this.ipPrice.TabIndex = 5;
            this.ipPrice.TextChanged += new System.EventHandler(this.ipPrice_TextChanged);
            // 
            // ipQuantity
            // 
            this.ipQuantity.Location = new System.Drawing.Point(384, 16);
            this.ipQuantity.Name = "ipQuantity";
            this.ipQuantity.Size = new System.Drawing.Size(100, 22);
            this.ipQuantity.TabIndex = 4;
            this.ipQuantity.TextChanged += new System.EventHandler(this.ipQuantity_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Location = new System.Drawing.Point(303, 20);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(61, 19);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Values.Text = "Số lượng :";
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(558, 16);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(32, 19);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Values.Text = "Giá :";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownWidth = 121;
            this.cbMaterial.Location = new System.Drawing.Point(107, 16);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 22);
            this.cbMaterial.TabIndex = 1;
            this.cbMaterial.Text = "chọn...";
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // lbMaterial
            // 
            this.lbMaterial.Location = new System.Drawing.Point(7, 16);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(94, 19);
            this.lbMaterial.TabIndex = 0;
            this.lbMaterial.Values.Text = "Nguyên vật liệu :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cửaSổToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cửaSổToolStripMenuItem
            // 
            this.cửaSổToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            this.cửaSổToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // estimateDetailDTOBindingSource
            // 
            this.estimateDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EstimateDetailDTO);
            // 
            // workerDTOBindingSource
            // 
            this.workerDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerDTO);
            // 
            // checkBox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.HeaderText = "";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 25;
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
            // 
            // QuantityEstimate
            // 
            this.QuantityEstimate.DataPropertyName = "QuantityEstimate";
            this.QuantityEstimate.HeaderText = "Số lượng dự toán";
            this.QuantityEstimate.Name = "QuantityEstimate";
            // 
            // UnitCostEstimate
            // 
            this.UnitCostEstimate.DataPropertyName = "UnitCostEstimate";
            this.UnitCostEstimate.HeaderText = "Gía dự toán";
            this.UnitCostEstimate.Name = "UnitCostEstimate";
            // 
            // TotalCostEstimate
            // 
            this.TotalCostEstimate.DataPropertyName = "TotalCostEstimate";
            this.TotalCostEstimate.HeaderText = "Tổng chi phí";
            this.TotalCostEstimate.Name = "TotalCostEstimate";
            // 
            // QuantityReal
            // 
            this.QuantityReal.DataPropertyName = "QuantityReal";
            this.QuantityReal.HeaderText = "Số lượng thực tế";
            this.QuantityReal.Name = "QuantityReal";
            // 
            // UnitCostReal
            // 
            this.UnitCostReal.DataPropertyName = "UnitCostReal";
            this.UnitCostReal.HeaderText = "Đơn vị thực tế";
            this.UnitCostReal.Name = "UnitCostReal";
            // 
            // TotalCostReal
            // 
            this.TotalCostReal.DataPropertyName = "TotalCostReal";
            this.TotalCostReal.HeaderText = "Tổng chi phí thực tế";
            this.TotalCostReal.Name = "TotalCostReal";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // EstimateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.kryptonPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EstimateDetail";
            this.Text = "EstimateDetail";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAdd;
        private System.Windows.Forms.BindingSource estimateDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource workerDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCostNum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cửaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCostEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCostReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

