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
            this.dtDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonGroupBox2);
            this.pnMain.Controls.Add(this.kryptonGroupBox1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(391, 412);
            this.pnMain.TabIndex = 0;
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(108, 225);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(230, 20);
            this.dtDate.TabIndex = 17;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(25, 226);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(73, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 16;
            this.kryptonLabel4.Values.Text = "Ngày mua(*)";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownWidth = 141;
            this.cbCategory.Location = new System.Drawing.Point(108, 26);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(230, 22);
            this.cbCategory.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(23, 29);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Chức năng(*)";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(246, 263);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(109, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "(*) Trường bắt buộc";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 141;
            this.cbStatus.Items.AddRange(new object[] {
            "rảnh rổi",
            "bận",
            "bảo trì"});
            this.cbStatus.Location = new System.Drawing.Point(108, 197);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(230, 22);
            this.cbStatus.TabIndex = 7;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(25, 200);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(73, 19);
            this.lbStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Values.Text = "Tình trạng(*)";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(207, 23);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 25);
            this.btClose.TabIndex = 9;
            this.btClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(53, 23);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 25);
            this.btSave.TabIndex = 8;
            this.btSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbHouse
            // 
            this.cbHouse.DropDownWidth = 141;
            this.cbHouse.Location = new System.Drawing.Point(107, 141);
            this.cbHouse.Name = "cbHouse";
            this.cbHouse.Size = new System.Drawing.Size(230, 22);
            this.cbHouse.TabIndex = 5;
            // 
            // lbHouse
            // 
            this.lbHouse.Location = new System.Drawing.Point(29, 144);
            this.lbHouse.Name = "lbHouse";
            this.lbHouse.Size = new System.Drawing.Size(69, 19);
            this.lbHouse.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbHouse.TabIndex = 8;
            this.lbHouse.Values.Text = "Kho chứa(*)";
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 141;
            this.cbManager.Location = new System.Drawing.Point(107, 169);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(230, 22);
            this.cbManager.TabIndex = 6;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(38, 175);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Quản lý(*)";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 141;
            this.cbCons.Location = new System.Drawing.Point(108, 110);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(230, 22);
            this.cbCons.TabIndex = 4;
            this.cbCons.SelectedIndexChanged += new System.EventHandler(this.cbCons_SelectedIndexChanged);
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(35, 113);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(63, 19);
            this.lbCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbCons.TabIndex = 4;
            this.lbCons.Values.Text = "Công trình";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(107, 82);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(230, 22);
            this.ipNumber.TabIndex = 2;
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(40, 85);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(58, 19);
            this.lbNumber.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Values.Text = "Biển số(*)";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(108, 54);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(230, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(53, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Loại (*)";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbCategory);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbNumber);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipNumber);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbCons);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbStatus);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbCons);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbStatus);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbManager);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbHouse);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbHouse);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(367, 301);
            this.kryptonGroupBox1.TabIndex = 18;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 324);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btClose);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(367, 76);
            this.kryptonGroupBox2.TabIndex = 19;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // AddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 412);
            this.Controls.Add(this.pnMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewVehicle";
            this.ShowIcon = false;
            this.Text = "Tạo mới phương tiện";
            this.Load += new System.EventHandler(this.AddNewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
    }
}

