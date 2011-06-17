namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class EstimateManagement
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
            this.dgvEstimate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btViewEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btEditEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btCreateEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.EstimateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvEstimate);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(913, 534);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvEstimate
            // 
            this.dgvEstimate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.EstimateID,
            this.ConstructionName,
            this.EstimateName,
            this.TotalCostEstimate,
            this.TotalCostReal,
            this.CreatedDate,
            this.UpdatedDate,
            this.CreatedBy,
            this.UpdatedBy,
            this.ConstructionID});
            this.dgvEstimate.Location = new System.Drawing.Point(0, 104);
            this.dgvEstimate.Name = "dgvEstimate";
            this.dgvEstimate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimate.Size = new System.Drawing.Size(913, 427);
            this.dgvEstimate.TabIndex = 1;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btViewEst);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btEditEst);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btCreateEst);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(913, 98);
            this.kryptonGroupBox1.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(187, 30);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 25);
            this.btDelete.TabIndex = 3;
            this.btDelete.Values.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btViewEst
            // 
            this.btViewEst.Location = new System.Drawing.Point(283, 30);
            this.btViewEst.Name = "btViewEst";
            this.btViewEst.Size = new System.Drawing.Size(78, 25);
            this.btViewEst.TabIndex = 2;
            this.btViewEst.Values.Text = "Chi tiết";
            this.btViewEst.Click += new System.EventHandler(this.btViewEst_Click);
            // 
            // btEditEst
            // 
            this.btEditEst.Location = new System.Drawing.Point(99, 30);
            this.btEditEst.Name = "btEditEst";
            this.btEditEst.Size = new System.Drawing.Size(82, 25);
            this.btEditEst.TabIndex = 1;
            this.btEditEst.Values.Text = "Sửa dự toán";
            this.btEditEst.Click += new System.EventHandler(this.btEditEst_Click);
            // 
            // btCreateEst
            // 
            this.btCreateEst.Location = new System.Drawing.Point(10, 30);
            this.btCreateEst.Name = "btCreateEst";
            this.btCreateEst.Size = new System.Drawing.Size(83, 25);
            this.btCreateEst.TabIndex = 0;
            this.btCreateEst.Values.Text = "Tạo dự toán ";
            this.btCreateEst.Click += new System.EventHandler(this.btCreateEst_Click);
            // 
            // checkBox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.HeaderText = "#";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 50;
            // 
            // EstimateID
            // 
            this.EstimateID.DataPropertyName = "EstimateID";
            this.EstimateID.HeaderText = "EstimateID";
            this.EstimateID.Name = "EstimateID";
            this.EstimateID.Visible = false;
            // 
            // ConstructionName
            // 
            this.ConstructionName.DataPropertyName = "ConstructionName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstructionName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConstructionName.HeaderText = "Tên công trình";
            this.ConstructionName.Name = "ConstructionName";
            this.ConstructionName.Width = 150;
            // 
            // EstimateName
            // 
            this.EstimateName.DataPropertyName = "EstimateName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimateName.DefaultCellStyle = dataGridViewCellStyle3;
            this.EstimateName.HeaderText = "Tên dự toán";
            this.EstimateName.Name = "EstimateName";
            // 
            // TotalCostEstimate
            // 
            this.TotalCostEstimate.DataPropertyName = "TotalCostEstimate";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lime;
            this.TotalCostEstimate.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalCostEstimate.HeaderText = "Tổng chi phí dự toán";
            this.TotalCostEstimate.Name = "TotalCostEstimate";
            this.TotalCostEstimate.Width = 120;
            // 
            // TotalCostReal
            // 
            this.TotalCostReal.DataPropertyName = "TotalCostReal";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            this.TotalCostReal.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalCostReal.HeaderText = "Tổng chi phí thực tế";
            this.TotalCostReal.Name = "TotalCostReal";
            this.TotalCostReal.Width = 120;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Ngày bắt đầu";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Width = 80;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.DataPropertyName = "UpdatedDate";
            this.UpdatedDate.HeaderText = "Ngày cập nhật";
            this.UpdatedDate.Name = "UpdatedDate";
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Tạo bởi";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 80;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            this.UpdatedBy.HeaderText = "Cập nhật bởi";
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.Width = 80;
            // 
            // ConstructionID
            // 
            this.ConstructionID.DataPropertyName = "ConstructionID";
            this.ConstructionID.HeaderText = "ConstructionID";
            this.ConstructionID.Name = "ConstructionID";
            this.ConstructionID.Visible = false;
            // 
            // EstimateManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstimateManagement";
            this.Text = "Add New Menu";
            this.Load += new System.EventHandler(this.EstimateManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btEditEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCreateEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionID;
    }
}