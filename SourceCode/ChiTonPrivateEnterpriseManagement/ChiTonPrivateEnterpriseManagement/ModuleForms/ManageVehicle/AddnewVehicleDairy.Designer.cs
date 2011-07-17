namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageVehicle
{
    partial class AddnewVehicleDairy
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
            this.dtDay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbDay = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipMaproad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbMaproad = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipDamagedCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbDamagedCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipFualCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbFualCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbDriver = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbVehicle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbDriver = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbDes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lbDes);
            this.pnMain.Controls.Add(this.dtDay);
            this.pnMain.Controls.Add(this.lbDay);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.ipMaproad);
            this.pnMain.Controls.Add(this.kryptonTextBox1);
            this.pnMain.Controls.Add(this.lbMaproad);
            this.pnMain.Controls.Add(this.ipDamagedCost);
            this.pnMain.Controls.Add(this.lbDamagedCost);
            this.pnMain.Controls.Add(this.ipFualCost);
            this.pnMain.Controls.Add(this.lbFualCost);
            this.pnMain.Controls.Add(this.cbDriver);
            this.pnMain.Controls.Add(this.cbVehicle);
            this.pnMain.Controls.Add(this.lbDriver);
            this.pnMain.Controls.Add(this.kryptonLabel2);
            this.pnMain.Controls.Add(this.cbCons);
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(302, 342);
            this.pnMain.TabIndex = 0;
            // 
            // dtDay
            // 
            this.dtDay.CustomFormat = "dd/MM/yyyy";
            this.dtDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDay.Location = new System.Drawing.Point(109, 159);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(181, 20);
            this.dtDay.TabIndex = 29;
            // 
            // lbDay
            // 
            this.lbDay.Location = new System.Drawing.Point(54, 159);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(37, 19);
            this.lbDay.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDay.TabIndex = 28;
            this.lbDay.Values.Text = "Ngày";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(167, 290);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(44, 25);
            this.btClose.TabIndex = 27;
            this.btClose.Values.Text = "Đóng";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(109, 290);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 25);
            this.btSave.TabIndex = 26;
            this.btSave.Values.Text = "Tạo";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipMaproad
            // 
            this.ipMaproad.Location = new System.Drawing.Point(109, 182);
            this.ipMaproad.Multiline = true;
            this.ipMaproad.Name = "ipMaproad";
            this.ipMaproad.Size = new System.Drawing.Size(181, 102);
            this.ipMaproad.TabIndex = 25;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(109, 162);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(139, 0);
            this.kryptonTextBox1.TabIndex = 24;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // lbMaproad
            // 
            this.lbMaproad.Location = new System.Drawing.Point(42, 182);
            this.lbMaproad.Name = "lbMaproad";
            this.lbMaproad.Size = new System.Drawing.Size(49, 19);
            this.lbMaproad.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbMaproad.TabIndex = 23;
            this.lbMaproad.Values.Text = "Lộ trình";
            // 
            // ipDamagedCost
            // 
            this.ipDamagedCost.Location = new System.Drawing.Point(109, 134);
            this.ipDamagedCost.Name = "ipDamagedCost";
            this.ipDamagedCost.Size = new System.Drawing.Size(181, 22);
            this.ipDamagedCost.TabIndex = 22;
            this.ipDamagedCost.Leave += new System.EventHandler(this.ipFualCost_Leave);
            this.ipDamagedCost.MouseLeave += new System.EventHandler(this.ipDamagedCost_MouseLeave);
            // 
            // lbDamagedCost
            // 
            this.lbDamagedCost.Location = new System.Drawing.Point(-2, 134);
            this.lbDamagedCost.Name = "lbDamagedCost";
            this.lbDamagedCost.Size = new System.Drawing.Size(96, 19);
            this.lbDamagedCost.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDamagedCost.TabIndex = 21;
            this.lbDamagedCost.Values.Text = "Chi phí hỏng hóc";
            // 
            // ipFualCost
            // 
            this.ipFualCost.Location = new System.Drawing.Point(109, 106);
            this.ipFualCost.Name = "ipFualCost";
            this.ipFualCost.Size = new System.Drawing.Size(181, 22);
            this.ipFualCost.TabIndex = 20;
            this.ipFualCost.Leave += new System.EventHandler(this.ipFualCost_Leave);
            this.ipFualCost.MouseLeave += new System.EventHandler(this.ipFualCost_MouseLeave);
            // 
            // lbFualCost
            // 
            this.lbFualCost.Location = new System.Drawing.Point(0, 109);
            this.lbFualCost.Name = "lbFualCost";
            this.lbFualCost.Size = new System.Drawing.Size(94, 19);
            this.lbFualCost.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbFualCost.TabIndex = 19;
            this.lbFualCost.Values.Text = "Chi phí xăng dầu";
            // 
            // cbDriver
            // 
            this.cbDriver.DropDownWidth = 121;
            this.cbDriver.Location = new System.Drawing.Point(109, 53);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(181, 22);
            this.cbDriver.TabIndex = 18;
            this.cbDriver.Text = "chọn...";
            // 
            // cbVehicle
            // 
            this.cbVehicle.DropDownWidth = 121;
            this.cbVehicle.Location = new System.Drawing.Point(109, 28);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(181, 22);
            this.cbVehicle.TabIndex = 17;
            this.cbVehicle.Text = "chọn...";
            // 
            // lbDriver
            // 
            this.lbDriver.Location = new System.Drawing.Point(42, 53);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(50, 19);
            this.lbDriver.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDriver.TabIndex = 16;
            this.lbDriver.Values.Text = "Tài xế(*)";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(42, 28);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(54, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.Show;
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Tên xe(*)";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 139;
            this.cbCons.Location = new System.Drawing.Point(109, 78);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(181, 22);
            this.cbCons.TabIndex = 14;
            this.cbCons.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 81);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "Công trình(*)";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(24, 323);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(107, 19);
            this.lbDes.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDes.TabIndex = 30;
            this.lbDes.Values.Text = "(*) trường bắt buộc";
            // 
            // AddnewVehicleDairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 342);
            this.Controls.Add(this.pnMain);
            this.Name = "AddnewVehicleDairy";
            this.ShowIcon = false;
            this.Text = "Tạo mới nhật ký";
            this.Load += new System.EventHandler(this.AddnewVehicleDairy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbDriver;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbVehicle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDriver;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMaproad;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipDamagedCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDamagedCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipFualCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFualCost;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipMaproad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDes;
    }
}

