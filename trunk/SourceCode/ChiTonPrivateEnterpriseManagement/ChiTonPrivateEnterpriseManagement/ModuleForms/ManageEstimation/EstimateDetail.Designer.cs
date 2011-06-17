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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvEstimateDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCostNum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonButton1);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(875, 522);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(389, 120);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(82, 25);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Tạo";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(3, 151);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btDelete);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btEdit);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvEstimateDetails);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(872, 371);
            this.kryptonGroupBox2.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(54, 7);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(35, 25);
            this.btDelete.TabIndex = 2;
            this.btDelete.Values.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(7, 7);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(41, 25);
            this.btEdit.TabIndex = 1;
            this.btEdit.Values.Text = "Sửa";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            this.Status,
            this.noteDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvEstimateDetails.DataSource = this.estimateDetailDTOBindingSource;
            this.dgvEstimateDetails.Location = new System.Drawing.Point(5, 38);
            this.dgvEstimateDetails.Name = "dgvEstimateDetails";
            this.dgvEstimateDetails.Size = new System.Drawing.Size(860, 300);
            this.dgvEstimateDetails.TabIndex = 0;
            this.dgvEstimateDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimateDetails_CellContentClick);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbUnit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTotalCostNum);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTotalCost);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbQuantity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbPrice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbMaterial);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbMaterial);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(872, 111);
            this.kryptonGroupBox1.TabIndex = 0;
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
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // EstimateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "EstimateDetail";
            this.Text = "EstimateDetail";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateDetails)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEstimateDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCostNum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btEdit;
        private System.Windows.Forms.BindingSource estimateDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource workerDTOBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

