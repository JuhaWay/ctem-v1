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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbHouse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbHouse = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.cbStatus);
            this.kryptonPanel.Controls.Add(this.lbStatus);
            this.kryptonPanel.Controls.Add(this.btClose);
            this.kryptonPanel.Controls.Add(this.btSave);
            this.kryptonPanel.Controls.Add(this.cbHouse);
            this.kryptonPanel.Controls.Add(this.lbHouse);
            this.kryptonPanel.Controls.Add(this.cbManager);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Controls.Add(this.cbCons);
            this.kryptonPanel.Controls.Add(this.lbCons);
            this.kryptonPanel.Controls.Add(this.ipNumber);
            this.kryptonPanel.Controls.Add(this.lbNumber);
            this.kryptonPanel.Controls.Add(this.ipName);
            this.kryptonPanel.Controls.Add(this.lbName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(291, 242);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(27, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên xe";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(99, 31);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(141, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(24, 59);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(46, 19);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Values.Text = "Biển số";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(99, 59);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(141, 22);
            this.ipNumber.TabIndex = 3;
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(7, 90);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(63, 19);
            this.lbCons.TabIndex = 4;
            this.lbCons.Values.Text = "Công trình";
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 121);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 19);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Quản lý";
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
            // lbHouse
            // 
            this.lbHouse.Location = new System.Drawing.Point(12, 149);
            this.lbHouse.Name = "lbHouse";
            this.lbHouse.Size = new System.Drawing.Size(57, 19);
            this.lbHouse.TabIndex = 8;
            this.lbHouse.Values.Text = "Kho chứa";
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
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(99, 205);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Tạo";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(7, 174);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 19);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Values.Text = "Tình trạng";
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
            // AddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 242);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddNewVehicle";
            this.Text = "Tạo mới phương tiện";
            this.Load += new System.EventHandler(this.AddNewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
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
    }
}

