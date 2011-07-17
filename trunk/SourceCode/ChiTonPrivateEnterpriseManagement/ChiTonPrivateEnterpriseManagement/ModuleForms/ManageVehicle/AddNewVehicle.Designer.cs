namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageVehicle
{
    partial class AddNewVehicle
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
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbHouse = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbHouse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonLabel2);
            this.pnMain.Controls.Add(this.cbStatus);
            this.pnMain.Controls.Add(this.lbStatus);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.cbHouse);
            this.pnMain.Controls.Add(this.lbHouse);
            this.pnMain.Controls.Add(this.cbManager);
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.cbCons);
            this.pnMain.Controls.Add(this.lbCons);
            this.pnMain.Controls.Add(this.ipNumber);
            this.pnMain.Controls.Add(this.lbNumber);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(291, 275);
            this.pnMain.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 244);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(107, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "(*) trường bắt buộc";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 141;
            this.cbStatus.Items.AddRange(new object[] {
            "rảnh rổi",
            "bận",
            "bảo trì"});
            this.cbStatus.Location = new System.Drawing.Point(99, 177);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(141, 22);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.Text = "chọn...";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(7, 174);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(73, 19);
            this.lbStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Values.Text = "Tình trạng(*)";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(157, 205);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(44, 25);
            this.btClose.TabIndex = 11;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(99, 205);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Tạo";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbHouse
            // 
            this.cbHouse.DropDownWidth = 141;
            this.cbHouse.Location = new System.Drawing.Point(99, 146);
            this.cbHouse.Name = "cbHouse";
            this.cbHouse.Size = new System.Drawing.Size(141, 22);
            this.cbHouse.TabIndex = 9;
            this.cbHouse.Text = "chọn...";
            // 
            // lbHouse
            // 
            this.lbHouse.Location = new System.Drawing.Point(12, 149);
            this.lbHouse.Name = "lbHouse";
            this.lbHouse.Size = new System.Drawing.Size(69, 19);
            this.lbHouse.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbHouse.TabIndex = 8;
            this.lbHouse.Values.Text = "Kho chứa(*)";
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 141;
            this.cbManager.Location = new System.Drawing.Point(99, 118);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(141, 22);
            this.cbManager.TabIndex = 7;
            this.cbManager.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 121);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Quản lý(*)";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 141;
            this.cbCons.Location = new System.Drawing.Point(99, 90);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(141, 22);
            this.cbCons.TabIndex = 5;
            this.cbCons.Text = "Chọn...";
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(7, 90);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(75, 19);
            this.lbCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbCons.TabIndex = 4;
            this.lbCons.Values.Text = "Công trình(*)";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(99, 59);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(141, 22);
            this.ipNumber.TabIndex = 3;
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(24, 59);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(58, 19);
            this.lbNumber.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Values.Text = "Biển số(*)";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(99, 31);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(141, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(27, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên xe(*)";
            // 
            // AddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 275);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewVehicle";
            this.ShowIcon = false;
            this.Text = "Tạo mới phương tiện";
            this.Load += new System.EventHandler(this.AddNewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbHouse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbHouse;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}

