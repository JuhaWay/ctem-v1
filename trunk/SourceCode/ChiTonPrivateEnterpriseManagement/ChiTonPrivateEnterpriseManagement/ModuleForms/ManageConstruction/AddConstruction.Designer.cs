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
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtStartDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ipDes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbDes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbState = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.cbManager);
            this.pnMain.Controls.Add(this.kryptonLabel2);
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.ipProgressRate);
            this.pnMain.Controls.Add(this.lbProgressRate);
            this.pnMain.Controls.Add(this.dtStartDate);
            this.pnMain.Controls.Add(this.ipDes);
            this.pnMain.Controls.Add(this.lbDes);
            this.pnMain.Controls.Add(this.cbStatus);
            this.pnMain.Controls.Add(this.lbState);
            this.pnMain.Controls.Add(this.dtEndDate);
            this.pnMain.Controls.Add(this.lbEndDate);
            this.pnMain.Controls.Add(this.lbStartDate);
            this.pnMain.Controls.Add(this.ipAddress);
            this.pnMain.Controls.Add(this.lbAddress);
            this.pnMain.Controls.Add(this.ipConstructionName);
            this.pnMain.Controls.Add(this.lbConstructionName);
            this.pnMain.Controls.Add(this.btCancel);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(458, 498);
            this.pnMain.TabIndex = 0;
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 286;
            this.cbManager.Location = new System.Drawing.Point(115, 60);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(283, 22);
            this.cbManager.TabIndex = 36;
            this.cbManager.Text = "chọn";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(22, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 16);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Text = "Người quản lý";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 467);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "(*) trường bắt buộc";
            // 
            // ipProgressRate
            // 
            this.ipProgressRate.Enabled = false;
            this.ipProgressRate.Location = new System.Drawing.Point(116, 185);
            this.ipProgressRate.Name = "ipProgressRate";
            this.ipProgressRate.Size = new System.Drawing.Size(282, 22);
            this.ipProgressRate.TabIndex = 33;
            // 
            // lbProgressRate
            // 
            this.lbProgressRate.Location = new System.Drawing.Point(39, 185);
            this.lbProgressRate.Name = "lbProgressRate";
            this.lbProgressRate.Size = new System.Drawing.Size(68, 16);
            this.lbProgressRate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbProgressRate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressRate.TabIndex = 32;
            this.lbProgressRate.Values.Text = "Tiến độ(%)";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(115, 122);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(283, 20);
            this.dtStartDate.TabIndex = 31;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(114, 261);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(283, 180);
            this.ipDes.TabIndex = 30;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(62, 261);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(46, 16);
            this.lbDes.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDes.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbStatus.Location = new System.Drawing.Point(115, 222);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(159, 22);
            this.cbStatus.TabIndex = 28;
            this.cbStatus.Text = "chọn...";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(28, 228);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(79, 16);
            this.lbState.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbState.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.TabIndex = 27;
            this.lbState.Values.Text = "Tình trạng (*)";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(114, 153);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(283, 20);
            this.dtEndDate.TabIndex = 26;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(18, 153);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(82, 16);
            this.lbEndDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbEndDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.TabIndex = 25;
            this.lbEndDate.Values.Text = "Ngày kết thúc ";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(12, 123);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(91, 16);
            this.lbStartDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStartDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.TabIndex = 24;
            this.lbStartDate.Values.Text = "Ngày khởi công ";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(114, 88);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(284, 22);
            this.ipAddress.TabIndex = 23;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(55, 88);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(46, 16);
            this.lbAddress.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbAddress.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Values.Text = "Địa chỉ ";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(114, 27);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(283, 22);
            this.ipConstructionName.TabIndex = 21;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(11, 27);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(101, 16);
            this.lbConstructionName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbConstructionName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConstructionName.TabIndex = 20;
            this.lbConstructionName.Values.Text = "Tên công trình (*)";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(320, 443);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(72, 25);
            this.btCancel.TabIndex = 10;
            this.btCancel.Values.Text = "Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(233, 443);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(78, 25);
            this.btSave.TabIndex = 9;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AddConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 498);
            this.Controls.Add(this.pnMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddConstruction";
            this.ShowIcon = false;
            this.Text = "Tạo công trình chính";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
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
    }
}

