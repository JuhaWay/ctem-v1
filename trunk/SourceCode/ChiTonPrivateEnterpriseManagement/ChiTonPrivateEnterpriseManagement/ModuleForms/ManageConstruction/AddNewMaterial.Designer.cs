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
            this.pnMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipRatio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRatio = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipRU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.ipRatio);
            this.pnMain.Controls.Add(this.lbRatio);
            this.pnMain.Controls.Add(this.ipRU);
            this.pnMain.Controls.Add(this.lbRU);
            this.pnMain.Controls.Add(this.ipEU);
            this.pnMain.Controls.Add(this.lbEU);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(293, 279);
            this.pnMain.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(155, 217);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(48, 25);
            this.btClose.TabIndex = 11;
            this.btClose.Values.Text = "Đóng";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(102, 217);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(47, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipRatio
            // 
            this.ipRatio.Location = new System.Drawing.Point(102, 180);
            this.ipRatio.Name = "ipRatio";
            this.ipRatio.Size = new System.Drawing.Size(161, 22);
            this.ipRatio.TabIndex = 9;
            // 
            // lbRatio
            // 
            this.lbRatio.Location = new System.Drawing.Point(0, 180);
            this.lbRatio.Name = "lbRatio";
            this.lbRatio.Size = new System.Drawing.Size(93, 19);
            this.lbRatio.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbRatio.TabIndex = 8;
            this.lbRatio.Values.Text = "Chỉ số quy đổi(*)";
            // 
            // ipRU
            // 
            this.ipRU.Location = new System.Drawing.Point(102, 133);
            this.ipRU.Name = "ipRU";
            this.ipRU.Size = new System.Drawing.Size(162, 22);
            this.ipRU.TabIndex = 7;
            // 
            // lbRU
            // 
            this.lbRU.Location = new System.Drawing.Point(0, 136);
            this.lbRU.Name = "lbRU";
            this.lbRU.Size = new System.Drawing.Size(111, 19);
            this.lbRU.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbRU.TabIndex = 6;
            this.lbRU.Values.Text = "Đơn vị quyết toán(*)";
            // 
            // ipEU
            // 
            this.ipEU.Location = new System.Drawing.Point(102, 81);
            this.ipEU.Name = "ipEU";
            this.ipEU.Size = new System.Drawing.Size(162, 22);
            this.ipEU.TabIndex = 5;
            // 
            // lbEU
            // 
            this.lbEU.Location = new System.Drawing.Point(3, 81);
            this.lbEU.Name = "lbEU";
            this.lbEU.Size = new System.Drawing.Size(96, 19);
            this.lbEU.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbEU.TabIndex = 4;
            this.lbEU.Values.Text = "Đơn vị dự toán(*)";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(102, 40);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(162, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(17, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên vật liệu(*)";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 257);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "(*) trường bắt buộc";
            // 
            // AddNewMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewMaterial";
            this.ShowIcon = false;
            this.Text = "Tạo vật liệu";
            this.Load += new System.EventHandler(this.AddNewMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

