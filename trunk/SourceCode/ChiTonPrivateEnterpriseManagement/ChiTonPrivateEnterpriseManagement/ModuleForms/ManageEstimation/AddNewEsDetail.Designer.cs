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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCostNum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btClose);
            this.kryptonPanel.Controls.Add(this.btSave);
            this.kryptonPanel.Controls.Add(this.lbUnit);
            this.kryptonPanel.Controls.Add(this.lbTotalCostNum);
            this.kryptonPanel.Controls.Add(this.lbTotalCost);
            this.kryptonPanel.Controls.Add(this.ipPrice);
            this.kryptonPanel.Controls.Add(this.ipQuantity);
            this.kryptonPanel.Controls.Add(this.lbQuantity);
            this.kryptonPanel.Controls.Add(this.lbPrice);
            this.kryptonPanel.Controls.Add(this.cbMaterial);
            this.kryptonPanel.Controls.Add(this.lbMaterial);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(312, 253);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbUnit
            // 
            this.lbUnit.Location = new System.Drawing.Point(511, 16);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(6, 2);
            this.lbUnit.TabIndex = 17;
            this.lbUnit.Values.Text = "";
            // 
            // lbTotalCostNum
            // 
            this.lbTotalCostNum.Location = new System.Drawing.Point(128, 168);
            this.lbTotalCostNum.Name = "lbTotalCostNum";
            this.lbTotalCostNum.Size = new System.Drawing.Size(45, 19);
            this.lbTotalCostNum.TabIndex = 16;
            this.lbTotalCostNum.Values.ExtraText = "VND";
            this.lbTotalCostNum.Values.Text = "0";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Location = new System.Drawing.Point(8, 168);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(114, 19);
            this.lbTotalCost.TabIndex = 15;
            this.lbTotalCost.Values.Text = "Tổng chi phí dự toán ";
            // 
            // ipPrice
            // 
            this.ipPrice.Location = new System.Drawing.Point(128, 128);
            this.ipPrice.Name = "ipPrice";
            this.ipPrice.Size = new System.Drawing.Size(148, 22);
            this.ipPrice.TabIndex = 14;
            this.ipPrice.TextChanged += new System.EventHandler(this.ipPrice_TextChanged);
            // 
            // ipQuantity
            // 
            this.ipQuantity.Location = new System.Drawing.Point(128, 78);
            this.ipQuantity.Name = "ipQuantity";
            this.ipQuantity.Size = new System.Drawing.Size(148, 22);
            this.ipQuantity.TabIndex = 13;
            this.ipQuantity.TextChanged += new System.EventHandler(this.ipQuantity_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Location = new System.Drawing.Point(61, 81);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(61, 19);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Values.Text = "Số lượng :";
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(90, 131);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(32, 19);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Values.Text = "Giá :";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownWidth = 121;
            this.cbMaterial.Location = new System.Drawing.Point(128, 37);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(148, 22);
            this.cbMaterial.TabIndex = 10;
            this.cbMaterial.Text = "chọn...";
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // lbMaterial
            // 
            this.lbMaterial.Location = new System.Drawing.Point(28, 40);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(94, 19);
            this.lbMaterial.TabIndex = 9;
            this.lbMaterial.Values.Text = "Nguyên vật liệu :";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(90, 216);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(46, 25);
            this.btSave.TabIndex = 18;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(142, 216);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 25);
            this.btClose.TabIndex = 19;
            this.btClose.Values.Text = "Thoát";
            // 
            // AddNewEsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 253);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddNewEsDetail";
            this.Text = "AddNewEsDetail";
            this.Load += new System.EventHandler(this.AddNewEsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCostNum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaterial;
    }
}

