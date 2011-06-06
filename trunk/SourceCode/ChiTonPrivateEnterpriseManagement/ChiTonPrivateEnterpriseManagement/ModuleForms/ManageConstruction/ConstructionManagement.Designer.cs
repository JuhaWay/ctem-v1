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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvCons = new AdvancedDataGridView.TreeGridView();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.removeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.ConstructionID = new AdvancedDataGridView.TreeGridColumn();
            this.ConstructionName = new AdvancedDataGridView.TreeGridColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommencementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvCons);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(935, 562);
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
            this.Description,
            this.ConstructionAddress,
            this.CommencementDate,
            this.CompletionDate,
            this.TotalEstimateCost});
            this.dgvCons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCons.ImageList = null;
            this.dgvCons.Location = new System.Drawing.Point(3, 96);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.Size = new System.Drawing.Size(929, 463);
            this.dgvCons.TabIndex = 2;
            this.dgvCons.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCons_CellMouseDown);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.editButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.removeButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.addButton);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(932, 87);
            this.kryptonGroupBox1.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(210, 21);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 25);
            this.editButton.TabIndex = 2;
            this.editButton.Values.Text = "Sửa công trình";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(114, 21);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 25);
            this.removeButton.TabIndex = 1;
            this.removeButton.Values.Text = "Xóa công trình";
            // 
            // addButton
            // 
            this.addButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.addButton.Location = new System.Drawing.Point(18, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 25);
            this.addButton.TabIndex = 0;
            this.addButton.Values.Text = "Tạo công trình";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.ConstructionID.DefaultNodeImage = null;
            this.ConstructionID.HeaderText = "ConstructionID";
            this.ConstructionID.Name = "ConstructionID";
            this.ConstructionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionID.Visible = false;
            // 
            // ConstructionName
            // 
            this.ConstructionName.DefaultNodeImage = null;
            this.ConstructionName.HeaderText = "Tên công trình";
            this.ConstructionName.Name = "ConstructionName";
            this.ConstructionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConstructionName.Width = 250;
            // 
            // Description
            // 
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConstructionAddress
            // 
            this.ConstructionAddress.HeaderText = "Địa chỉ";
            this.ConstructionAddress.Name = "ConstructionAddress";
            this.ConstructionAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CommencementDate
            // 
            this.CommencementDate.HeaderText = "Ngày khởi công";
            this.CommencementDate.Name = "CommencementDate";
            this.CommencementDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CompletionDate
            // 
            this.CompletionDate.HeaderText = "Hạn hoàn thành";
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalEstimateCost
            // 
            this.TotalEstimateCost.HeaderText = "Chi phí dự toán";
            this.TotalEstimateCost.Name = "TotalEstimateCost";
            this.TotalEstimateCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConstructionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "ConstructionManagement";
            this.Text = "Quản lý công trình";
            this.Load += new System.EventHandler(this.ConstructionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton removeButton;
        private AdvancedDataGridView.TreeGridView dgvCons;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private AdvancedDataGridView.TreeGridColumn ConstructionID;
        private AdvancedDataGridView.TreeGridColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommencementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimateCost;
    }
}

