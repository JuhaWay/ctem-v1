namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class AddConstruction
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
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbState = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.ipAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtStartDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipDes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbDes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonGroupBox2);
            this.pnMain.Controls.Add(this.kryptonGroupBox1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(458, 508);
            this.pnMain.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 428);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btCancel);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(434, 70);
            this.kryptonGroupBox2.TabIndex = 38;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(264, 20);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 25);
            this.btCancel.TabIndex = 10;
            this.btCancel.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btCancel.Values.Text = "Đóng";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(94, 20);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 25);
            this.btSave.TabIndex = 9;
            this.btSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbState);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbManager);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbConstructionName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipConstructionName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbAddress);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipProgressRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipAddress);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbProgressRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbStartDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtStartDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbEndDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipDes);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtEndDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbDes);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbStatus);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(434, 408);
            this.kryptonGroupBox1.TabIndex = 37;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(25, 166);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(76, 16);
            this.lbState.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbState.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.TabIndex = 27;
            this.lbState.Values.Text = "Tình trạng (*)";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 370);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "(*) trường bắt buộc";
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 286;
            this.cbManager.Location = new System.Drawing.Point(108, 52);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(282, 22);
            this.cbManager.TabIndex = 2;
            this.cbManager.Text = "chọn";
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(4, 30);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(97, 16);
            this.lbConstructionName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbConstructionName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConstructionName.TabIndex = 20;
            this.lbConstructionName.Values.Text = "Tên công trình (*)";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 58);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 16);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Text = "Người quản lý";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(107, 24);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(283, 22);
            this.ipConstructionName.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(52, 86);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 16);
            this.lbAddress.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbAddress.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Values.Text = "Địa chỉ ";
            // 
            // ipProgressRate
            // 
            this.ipProgressRate.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.ipProgressRate.Enabled = false;
            this.ipProgressRate.Location = new System.Drawing.Point(107, 188);
            this.ipProgressRate.Name = "ipProgressRate";
            this.ipProgressRate.Size = new System.Drawing.Size(283, 25);
            this.ipProgressRate.TabIndex = 7;
            this.ipProgressRate.TextChanged += new System.EventHandler(this.ipProgressRate_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Text = "%";
            this.buttonSpecAny1.UniqueName = "69B0917AC0B7485BEA9EC84F62C0EF5A";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(107, 80);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(283, 22);
            this.ipAddress.TabIndex = 3;
            // 
            // lbProgressRate
            // 
            this.lbProgressRate.Location = new System.Drawing.Point(49, 197);
            this.lbProgressRate.Name = "lbProgressRate";
            this.lbProgressRate.Size = new System.Drawing.Size(48, 16);
            this.lbProgressRate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbProgressRate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressRate.TabIndex = 32;
            this.lbProgressRate.Values.Text = "Tiến độ";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(12, 112);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(88, 16);
            this.lbStartDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStartDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.TabIndex = 24;
            this.lbStartDate.Values.Text = "Ngày khởi công ";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(107, 108);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(283, 20);
            this.dtStartDate.TabIndex = 4;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(18, 138);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(79, 16);
            this.lbEndDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbEndDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.TabIndex = 25;
            this.lbEndDate.Values.Text = "Ngày kết thúc ";
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(108, 219);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(283, 132);
            this.ipDes.TabIndex = 8;
            this.ipDes.Text = "...";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(107, 134);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(283, 20);
            this.dtEndDate.TabIndex = 5;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(55, 225);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(45, 16);
            this.lbDes.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDes.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.TabIndex = 29;
            this.lbDes.Values.Text = "Mô tả :";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 172;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới ",
            "Đang thi công ",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(107, 160);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(283, 22);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.Text = "chọn...";
            // 
            // AddConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 508);
            this.Controls.Add(this.pnMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddConstruction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tạo công trình chính";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipDes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDes;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbState;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipProgressRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProgressRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}

