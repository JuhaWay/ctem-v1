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
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbUnit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbUnit1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lbUnit1);
            this.pnMain.Controls.Add(this.cbType);
            this.pnMain.Controls.Add(this.lbType);
            this.pnMain.Controls.Add(this.ipTotal);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Controls.Add(this.btClose);
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
            this.pnMain.Size = new System.Drawing.Size(471, 358);
            this.pnMain.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 148;
            this.cbType.Items.AddRange(new object[] {
            "Vật liệu",
            "Khác"});
            this.cbType.Location = new System.Drawing.Point(133, 109);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(263, 22);
            this.cbType.TabIndex = 24;
            this.cbType.Text = "chọn";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(95, 112);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(33, 16);
            this.lbType.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.TabIndex = 23;
            this.lbType.Values.Text = "Loại";
            // 
            // ipTotal
            // 
            this.ipTotal.Location = new System.Drawing.Point(132, 271);
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
            this.ipName.Location = new System.Drawing.Point(132, 62);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(263, 22);
            this.ipName.TabIndex = 21;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(61, 62);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 16);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.TabIndex = 20;
            this.lbName.Values.Text = "Tên chi tiết";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(184, 321);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 25);
            this.btClose.TabIndex = 19;
            this.btClose.Values.Text = "Thoát";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(132, 321);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(46, 25);
            this.btSave.TabIndex = 18;
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
            this.lbTotalCost.Location = new System.Drawing.Point(23, 271);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(107, 16);
            this.lbTotalCost.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTotalCost.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.TabIndex = 15;
            this.lbTotalCost.Values.Text = "Tổng chi phí(VND) ";
            // 
            // ipPrice
            // 
            this.ipPrice.Enabled = false;
            this.ipPrice.Location = new System.Drawing.Point(132, 235);
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
            this.ipQuantity.Enabled = false;
            this.ipQuantity.Location = new System.Drawing.Point(132, 192);
            this.ipQuantity.Name = "ipQuantity";
            this.ipQuantity.Size = new System.Drawing.Size(263, 22);
            this.ipQuantity.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipQuantity.TabIndex = 13;
            this.ipQuantity.TextChanged += new System.EventHandler(this.ipQuantity_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Location = new System.Drawing.Point(65, 192);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(63, 16);
            this.lbQuantity.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbQuantity.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Values.Text = "Số lượng :";
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(66, 238);
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
            this.cbMaterial.Enabled = false;
            this.cbMaterial.Location = new System.Drawing.Point(132, 149);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(263, 22);
            this.cbMaterial.StateDisabled.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbMaterial.TabIndex = 10;
            this.cbMaterial.Text = "chọn...";
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // lbMaterial
            // 
            this.lbMaterial.Location = new System.Drawing.Point(32, 152);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(98, 16);
            this.lbMaterial.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbMaterial.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterial.TabIndex = 9;
            this.lbMaterial.Values.Text = "Nguyên vật liệu :";
            // 
            // lbUnit1
            // 
            this.lbUnit1.Location = new System.Drawing.Point(401, 195);
            this.lbUnit1.Name = "lbUnit1";
            this.lbUnit1.Size = new System.Drawing.Size(20, 19);
            this.lbUnit1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbUnit1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit1.TabIndex = 25;
            this.lbUnit1.Values.Text = "()";
            // 
            // AddNewEsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 358);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewEsDetail";
            this.ShowIcon = false;
            this.Text = "Tạo dự toán chi tiết";
            this.Load += new System.EventHandler(this.AddNewEsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
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
    }
}

