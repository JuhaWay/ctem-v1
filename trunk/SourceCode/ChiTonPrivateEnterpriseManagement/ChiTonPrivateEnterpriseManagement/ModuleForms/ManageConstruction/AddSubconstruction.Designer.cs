namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class AddSubconstruction
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
            this.ipProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbProgress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipRealCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRealCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEst = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEst = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btcreateSubcon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbSubconName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubconName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.ipProgressRate);
            this.pnMain.Controls.Add(this.lbProgress);
            this.pnMain.Controls.Add(this.ipRealCost);
            this.pnMain.Controls.Add(this.lbRealCost);
            this.pnMain.Controls.Add(this.ipEst);
            this.pnMain.Controls.Add(this.lbEst);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.btCancel);
            this.pnMain.Controls.Add(this.btcreateSubcon);
            this.pnMain.Controls.Add(this.cbSubconName);
            this.pnMain.Controls.Add(this.kryptonLabel1);
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
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(525, 548);
            this.pnMain.TabIndex = 0;
            // 
            // ipProgressRate
            // 
            this.ipProgressRate.Location = new System.Drawing.Point(123, 282);
            this.ipProgressRate.Name = "ipProgressRate";
            this.ipProgressRate.Size = new System.Drawing.Size(359, 22);
            this.ipProgressRate.TabIndex = 45;
            // 
            // lbProgress
            // 
            this.lbProgress.Location = new System.Drawing.Point(42, 282);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(49, 16);
            this.lbProgress.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbProgress.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgress.TabIndex = 44;
            this.lbProgress.Values.Text = "Tiến độ";
            // 
            // ipRealCost
            // 
            this.ipRealCost.Location = new System.Drawing.Point(123, 254);
            this.ipRealCost.Name = "ipRealCost";
            this.ipRealCost.Size = new System.Drawing.Size(359, 22);
            this.ipRealCost.TabIndex = 43;
            this.ipRealCost.Leave += new System.EventHandler(this.ipRealCost_Leave);
            this.ipRealCost.MouseLeave += new System.EventHandler(this.ipRealCost_MouseLeave);
            // 
            // lbRealCost
            // 
            this.lbRealCost.Location = new System.Drawing.Point(23, 254);
            this.lbRealCost.Name = "lbRealCost";
            this.lbRealCost.Size = new System.Drawing.Size(61, 16);
            this.lbRealCost.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbRealCost.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealCost.TabIndex = 42;
            this.lbRealCost.Values.Text = "Gỉai ngân";
            // 
            // ipEst
            // 
            this.ipEst.Location = new System.Drawing.Point(123, 226);
            this.ipEst.Name = "ipEst";
            this.ipEst.Size = new System.Drawing.Size(357, 22);
            this.ipEst.TabIndex = 41;
            this.ipEst.Leave += new System.EventHandler(this.ipEst_Leave);
            this.ipEst.MouseLeave += new System.EventHandler(this.ipEst_MouseLeave);
            // 
            // lbEst
            // 
            this.lbEst.Location = new System.Drawing.Point(20, 226);
            this.lbEst.Name = "lbEst";
            this.lbEst.Size = new System.Drawing.Size(81, 16);
            this.lbEst.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbEst.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEst.TabIndex = 40;
            this.lbEst.Values.Text = "khoáng(VND)";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(209, 511);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(78, 25);
            this.btSave.TabIndex = 28;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(293, 511);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(72, 25);
            this.btCancel.TabIndex = 31;
            this.btCancel.Values.Text = "Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btcreateSubcon
            // 
            this.btcreateSubcon.Location = new System.Drawing.Point(443, 58);
            this.btcreateSubcon.Name = "btcreateSubcon";
            this.btcreateSubcon.Size = new System.Drawing.Size(37, 22);
            this.btcreateSubcon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btcreateSubcon.TabIndex = 39;
            this.btcreateSubcon.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btcreateSubcon.Values.Text = "+";
            this.btcreateSubcon.Click += new System.EventHandler(this.btcreateSubcon_Click);
            // 
            // cbSubconName
            // 
            this.cbSubconName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSubconName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubconName.DropDownWidth = 159;
            this.cbSubconName.Location = new System.Drawing.Point(123, 58);
            this.cbSubconName.Name = "cbSubconName";
            this.cbSubconName.Size = new System.Drawing.Size(314, 22);
            this.cbSubconName.TabIndex = 38;
            this.cbSubconName.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(25, 58);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(92, 16);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 37;
            this.kryptonLabel1.Values.Text = "Tên nhà thầu(*)";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(123, 174);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(357, 20);
            this.dtStartDate.TabIndex = 36;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(123, 310);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(359, 182);
            this.ipDes.TabIndex = 35;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(53, 310);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(39, 16);
            this.lbDes.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDes.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.TabIndex = 34;
            this.lbDes.Values.Text = "Mô tả ";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 172;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới ",
            "Đang thi công ",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(123, 90);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(359, 22);
            this.cbStatus.TabIndex = 33;
            this.cbStatus.Text = "chọn...";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(31, 93);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(79, 16);
            this.lbState.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbState.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.TabIndex = 32;
            this.lbState.Values.Text = "Tình trạng (*)";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(123, 200);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(359, 20);
            this.dtEndDate.TabIndex = 30;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(9, 200);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(82, 16);
            this.lbEndDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbEndDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.TabIndex = 29;
            this.lbEndDate.Values.Text = "Ngày kết thúc ";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(12, 174);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(91, 16);
            this.lbStartDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbStartDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.TabIndex = 27;
            this.lbStartDate.Values.Text = "Ngày khởi công ";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(123, 146);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(357, 22);
            this.ipAddress.TabIndex = 26;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(45, 146);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(46, 16);
            this.lbAddress.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbAddress.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.TabIndex = 25;
            this.lbAddress.Values.Text = "Địa chỉ ";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(123, 118);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(357, 22);
            this.ipConstructionName.TabIndex = 24;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(17, 118);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(101, 16);
            this.lbConstructionName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbConstructionName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConstructionName.TabIndex = 23;
            this.lbConstructionName.Values.Text = "Tên công trình (*)";
            // 
            // AddSubconstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(525, 548);
            this.Controls.Add(this.pnMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubconstruction";
            this.Text = "Tạo công trình phụ";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubconName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btcreateSubcon;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSubconName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEst;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEst;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRealCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRealCost;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipProgressRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbProgress;
    }
}

