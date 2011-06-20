namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class AddNewMaterial
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
            this.cbEU = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipRatio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRatio = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipRU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbParent = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbParent = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbEU)).BeginInit();
            this.cbEU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEU
            // 
            this.cbEU.Controls.Add(this.btClose);
            this.cbEU.Controls.Add(this.btSave);
            this.cbEU.Controls.Add(this.ipRatio);
            this.cbEU.Controls.Add(this.lbRatio);
            this.cbEU.Controls.Add(this.ipRU);
            this.cbEU.Controls.Add(this.lbRU);
            this.cbEU.Controls.Add(this.ipEU);
            this.cbEU.Controls.Add(this.lbEU);
            this.cbEU.Controls.Add(this.cbParent);
            this.cbEU.Controls.Add(this.lbParent);
            this.cbEU.Controls.Add(this.ipName);
            this.cbEU.Controls.Add(this.lbName);
            this.cbEU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEU.Location = new System.Drawing.Point(0, 0);
            this.cbEU.Name = "cbEU";
            this.cbEU.Size = new System.Drawing.Size(293, 279);
            this.cbEU.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(155, 232);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(48, 25);
            this.btClose.TabIndex = 11;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(102, 232);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(47, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipRatio
            // 
            this.ipRatio.Location = new System.Drawing.Point(103, 195);
            this.ipRatio.Name = "ipRatio";
            this.ipRatio.Size = new System.Drawing.Size(161, 22);
            this.ipRatio.TabIndex = 9;
            this.ipRatio.TextChanged += new System.EventHandler(this.ipRatio_TextChanged);
            // 
            // lbRatio
            // 
            this.lbRatio.Location = new System.Drawing.Point(15, 198);
            this.lbRatio.Name = "lbRatio";
            this.lbRatio.Size = new System.Drawing.Size(82, 19);
            this.lbRatio.TabIndex = 8;
            this.lbRatio.Values.Text = "Chỉ số quy đổi";
            this.lbRatio.Paint += new System.Windows.Forms.PaintEventHandler(this.lbRatio_Paint);
            // 
            // ipRU
            // 
            this.ipRU.Location = new System.Drawing.Point(102, 157);
            this.ipRU.Name = "ipRU";
            this.ipRU.Size = new System.Drawing.Size(162, 22);
            this.ipRU.TabIndex = 7;
            this.ipRU.TextChanged += new System.EventHandler(this.ipRU_TextChanged);
            // 
            // lbRU
            // 
            this.lbRU.Location = new System.Drawing.Point(3, 160);
            this.lbRU.Name = "lbRU";
            this.lbRU.Size = new System.Drawing.Size(100, 19);
            this.lbRU.TabIndex = 6;
            this.lbRU.Values.Text = "Đơn vị quyết toán";
            this.lbRU.Paint += new System.Windows.Forms.PaintEventHandler(this.lbRU_Paint);
            // 
            // ipEU
            // 
            this.ipEU.Location = new System.Drawing.Point(102, 118);
            this.ipEU.Name = "ipEU";
            this.ipEU.Size = new System.Drawing.Size(162, 22);
            this.ipEU.TabIndex = 5;
            this.ipEU.TextChanged += new System.EventHandler(this.ipEU_TextChanged);
            // 
            // lbEU
            // 
            this.lbEU.Location = new System.Drawing.Point(11, 118);
            this.lbEU.Name = "lbEU";
            this.lbEU.Size = new System.Drawing.Size(85, 19);
            this.lbEU.TabIndex = 4;
            this.lbEU.Values.Text = "Đơn vị dự toán";
            this.lbEU.Paint += new System.Windows.Forms.PaintEventHandler(this.lbEU_Paint);
            // 
            // cbParent
            // 
            this.cbParent.DropDownWidth = 162;
            this.cbParent.Location = new System.Drawing.Point(102, 78);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(162, 22);
            this.cbParent.TabIndex = 3;
            this.cbParent.Text = "chọn...";
            this.cbParent.SelectedIndexChanged += new System.EventHandler(this.cbParent_SelectedIndexChanged);
            // 
            // lbParent
            // 
            this.lbParent.Location = new System.Drawing.Point(28, 78);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(68, 19);
            this.lbParent.TabIndex = 2;
            this.lbParent.Values.Text = "Vật liệu cha";
            this.lbParent.Paint += new System.Windows.Forms.PaintEventHandler(this.lbParent_Paint);
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(102, 40);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(162, 22);
            this.ipName.TabIndex = 1;
            this.ipName.TextChanged += new System.EventHandler(this.ipName_TextChanged);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(28, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên vật liệu";
            this.lbName.Paint += new System.Windows.Forms.PaintEventHandler(this.lbName_Paint);
            // 
            // AddNewMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.cbEU);
            this.Name = "AddNewMaterial";
            this.Text = "AddNewMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.cbEU)).EndInit();
            this.cbEU.ResumeLayout(false);
            this.cbEU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel cbEU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEU;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbParent;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbParent;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEU;
    }
}

