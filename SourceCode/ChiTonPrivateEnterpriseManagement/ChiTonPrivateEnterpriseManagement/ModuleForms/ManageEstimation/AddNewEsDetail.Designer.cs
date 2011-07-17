namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class AddNewEsDetail
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
            this.pnMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbUnit1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvEst = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityEstimateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimateDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsmain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).BeginInit();
            this.cmsmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dgvEst);
            this.pnMain.Controls.Add(this.lbUnit1);
            this.pnMain.Controls.Add(this.cbType);
            this.pnMain.Controls.Add(this.lbType);
            this.pnMain.Controls.Add(this.ipTotal);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.lbUnit);
            this.pnMain.Controls.Add(this.lbTotalCost);
            this.pnMain.Controls.Add(this.ipPrice);
            this.pnMain.Controls.Add(this.ipQuantity);
            this.pnMain.Controls.Add(this.lbQuantity);
            this.pnMain.Controls.Add(this.lbPrice);
            this.pnMain.Controls.Add(this.cbMaterial);
            this.pnMain.Controls.Add(this.lbMaterial);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(791, 491);
            this.pnMain.TabIndex = 0;
            // 
            // lbUnit1
            // 
            this.lbUnit1.Location = new System.Drawing.Point(379, 103);
            this.lbUnit1.Name = "lbUnit1";
            this.lbUnit1.Size = new System.Drawing.Size(20, 19);
            this.lbUnit1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbUnit1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit1.TabIndex = 25;
            this.lbUnit1.Values.Text = "()";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 148;
            this.cbType.Items.AddRange(new object[] {
            "Vật liệu",
            "Khác"});
            this.cbType.Location = new System.Drawing.Point(111, 30);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(263, 22);
            this.cbType.TabIndex = 24;
            this.cbType.Text = "chọn";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(73, 33);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(33, 16);
            this.lbType.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.TabIndex = 23;
            this.lbType.Values.Text = "Loại";
            // 
            // ipTotal
            // 
            this.ipTotal.Location = new System.Drawing.Point(490, 66);
            this.ipTotal.Name = "ipTotal";
            this.ipTotal.ReadOnly = true;
            this.ipTotal.Size = new System.Drawing.Size(263, 20);
            this.ipTotal.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.ipTotal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTotal.TabIndex = 22;
            this.ipTotal.Leave += new System.EventHandler(this.ipTotal_Leave);
            this.ipTotal.MouseLeave += new System.EventHandler(this.ipTotal_MouseLeave);
            // 
            // ipName
            // 
            this.ipName.Enabled = false;
            this.ipName.Location = new System.Drawing.Point(489, 100);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(263, 22);
            this.ipName.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipName.TabIndex = 21;
            // 
            // lbName
            // 
            this.lbName.Enabled = false;
            this.lbName.Location = new System.Drawing.Point(418, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 16);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.TabIndex = 20;
            this.lbName.Values.Text = "Chi tiết";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(379, 155);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 25);
            this.btSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSave.TabIndex = 18;
            this.btSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.Location = new System.Drawing.Point(511, 16);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(6, 2);
            this.lbUnit.TabIndex = 17;
            this.lbUnit.Values.Text = "";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Location = new System.Drawing.Point(381, 66);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(107, 16);
            this.lbTotalCost.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTotalCost.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.TabIndex = 15;
            this.lbTotalCost.Values.Text = "Tổng chi phí(VND) ";
            // 
            // ipPrice
            // 
            this.ipPrice.Location = new System.Drawing.Point(490, 30);
            this.ipPrice.Name = "ipPrice";
            this.ipPrice.Size = new System.Drawing.Size(263, 22);
            this.ipPrice.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipPrice.TabIndex = 14;
            this.ipPrice.TextChanged += new System.EventHandler(this.ipPrice_TextChanged);
            this.ipPrice.Leave += new System.EventHandler(this.ipPrice_Leave);
            this.ipPrice.MouseLeave += new System.EventHandler(this.ipPrice_MouseLeave);
            // 
            // ipQuantity
            // 
            this.ipQuantity.Location = new System.Drawing.Point(110, 100);
            this.ipQuantity.Name = "ipQuantity";
            this.ipQuantity.Size = new System.Drawing.Size(263, 22);
            this.ipQuantity.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipQuantity.TabIndex = 13;
            this.ipQuantity.TextChanged += new System.EventHandler(this.ipQuantity_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Location = new System.Drawing.Point(43, 100);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(63, 16);
            this.lbQuantity.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbQuantity.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Values.Text = "Số lượng :";
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(424, 33);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(64, 16);
            this.lbPrice.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbPrice.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Values.Text = "Giá (VND)";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownWidth = 121;
            this.cbMaterial.Location = new System.Drawing.Point(112, 63);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(263, 22);
            this.cbMaterial.StateDisabled.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbMaterial.TabIndex = 10;
            this.cbMaterial.Text = "chọn...";
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // lbMaterial
            // 
            this.lbMaterial.Location = new System.Drawing.Point(12, 66);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(98, 16);
            this.lbMaterial.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbMaterial.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterial.TabIndex = 9;
            this.lbMaterial.Values.Text = "Nguyên vật liệu :";
            // 
            // dgvEst
            // 
            this.dgvEst.AutoGenerateColumns = false;
            this.dgvEst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityEstimateDataGridViewTextBoxColumn,
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn,
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn});
            this.dgvEst.DataSource = this.estimateDetailDTOBindingSource;
            this.dgvEst.Location = new System.Drawing.Point(3, 186);
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.Size = new System.Drawing.Size(785, 305);
            this.dgvEst.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvEst.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEst.TabIndex = 26;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "Vật liệu";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Chi tiết";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityEstimateDataGridViewTextBoxColumn
            // 
            this.quantityEstimateDataGridViewTextBoxColumn.DataPropertyName = "QuantityEstimate";
            this.quantityEstimateDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityEstimateDataGridViewTextBoxColumn.Name = "quantityEstimateDataGridViewTextBoxColumn";
            this.quantityEstimateDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitCostEstimateFormatedDataGridViewTextBoxColumn
            // 
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn.DataPropertyName = "UnitCostEstimateFormated";
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn.HeaderText = "Gía(VND)";
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn.Name = "unitCostEstimateFormatedDataGridViewTextBoxColumn";
            this.unitCostEstimateFormatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalCostEstimateFormatedDataGridViewTextBoxColumn
            // 
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn.DataPropertyName = "TotalCostEstimateFormated";
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn.HeaderText = "Tổng số tiền(VND)";
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn.Name = "totalCostEstimateFormatedDataGridViewTextBoxColumn";
            this.totalCostEstimateFormatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // estimateDetailDTOBindingSource
            // 
            this.estimateDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EstimateDetailDTO);
            // 
            // cmsmain
            // 
            this.cmsmain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmsmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem});
            this.cmsmain.Name = "cmsmain";
            this.cmsmain.Size = new System.Drawing.Size(140, 26);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.SaveToolStripMenuItem.Text = "Lưu";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AddNewEsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 491);
            this.ContextMenuStrip = this.cmsmain;
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewEsDetail";
            this.ShowIcon = false;
            this.Text = "Tạo dự toán chi tiết";
            this.Load += new System.EventHandler(this.AddNewEsDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewEsDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDetailDTOBindingSource)).EndInit();
            this.cmsmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEst;
        private System.Windows.Forms.BindingSource estimateDetailDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityEstimateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostEstimateFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostEstimateFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsmain;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

