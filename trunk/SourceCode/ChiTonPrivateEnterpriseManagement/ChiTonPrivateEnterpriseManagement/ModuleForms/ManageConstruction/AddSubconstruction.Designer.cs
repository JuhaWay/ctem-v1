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
            this.panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
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
            this.lbEst = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEst = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRealCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipRealCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbProgress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipProgressRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubconName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ipProgressRate);
            this.panel.Controls.Add(this.lbProgress);
            this.panel.Controls.Add(this.ipRealCost);
            this.panel.Controls.Add(this.lbRealCost);
            this.panel.Controls.Add(this.ipEst);
            this.panel.Controls.Add(this.lbEst);
            this.panel.Controls.Add(this.btSave);
            this.panel.Controls.Add(this.btCancel);
            this.panel.Controls.Add(this.btcreateSubcon);
            this.panel.Controls.Add(this.cbSubconName);
            this.panel.Controls.Add(this.kryptonLabel1);
            this.panel.Controls.Add(this.dtStartDate);
            this.panel.Controls.Add(this.ipDes);
            this.panel.Controls.Add(this.lbDes);
            this.panel.Controls.Add(this.cbStatus);
            this.panel.Controls.Add(this.lbState);
            this.panel.Controls.Add(this.dtEndDate);
            this.panel.Controls.Add(this.lbEndDate);
            this.panel.Controls.Add(this.lbStartDate);
            this.panel.Controls.Add(this.ipAddress);
            this.panel.Controls.Add(this.lbAddress);
            this.panel.Controls.Add(this.ipConstructionName);
            this.panel.Controls.Add(this.lbConstructionName);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(609, 548);
            this.panel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.panel.TabIndex = 0;
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
            this.btcreateSubcon.Location = new System.Drawing.Point(279, 58);
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
            this.cbSubconName.DropDownWidth = 159;
            this.cbSubconName.Location = new System.Drawing.Point(114, 58);
            this.cbSubconName.Name = "cbSubconName";
            this.cbSubconName.Size = new System.Drawing.Size(159, 22);
            this.cbSubconName.TabIndex = 38;
            this.cbSubconName.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(25, 58);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 19);
            this.kryptonLabel1.TabIndex = 37;
            this.kryptonLabel1.Values.Text = "Tên nhà thầu :";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(112, 161);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(159, 20);
            this.dtStartDate.TabIndex = 36;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(112, 290);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(461, 190);
            this.ipDes.TabIndex = 35;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(45, 290);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(45, 19);
            this.lbDes.TabIndex = 34;
            this.lbDes.Values.Text = "Mô tả :";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 172;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới ",
            "Đang thi công ",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(403, 58);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 22);
            this.cbStatus.TabIndex = 33;
            this.cbStatus.Text = "chọn...";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(322, 61);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(67, 19);
            this.lbState.TabIndex = 32;
            this.lbState.Values.Text = "Tình trạng :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(403, 162);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(172, 20);
            this.dtEndDate.TabIndex = 30;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(298, 162);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(86, 19);
            this.lbEndDate.TabIndex = 29;
            this.lbEndDate.Values.Text = "Ngày kết thúc :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(12, 161);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(95, 19);
            this.lbStartDate.TabIndex = 27;
            this.lbStartDate.Values.Text = "Ngày khởi công :";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(403, 109);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(172, 22);
            this.ipAddress.TabIndex = 26;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(334, 109);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(50, 19);
            this.lbAddress.TabIndex = 25;
            this.lbAddress.Values.Text = "Địa chỉ :";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(114, 109);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(159, 22);
            this.ipConstructionName.TabIndex = 24;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(17, 109);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(89, 19);
            this.lbConstructionName.TabIndex = 23;
            this.lbConstructionName.Values.Text = "Tên công trình :";
            // 
            // lbEst
            // 
            this.lbEst.Location = new System.Drawing.Point(25, 209);
            this.lbEst.Name = "lbEst";
            this.lbEst.Size = new System.Drawing.Size(78, 19);
            this.lbEst.TabIndex = 40;
            this.lbEst.Values.Text = "khoáng(VND)";
            // 
            // ipEst
            // 
            this.ipEst.Location = new System.Drawing.Point(112, 209);
            this.ipEst.Name = "ipEst";
            this.ipEst.Size = new System.Drawing.Size(161, 22);
            this.ipEst.TabIndex = 41;
            // 
            // lbRealCost
            // 
            this.lbRealCost.Location = new System.Drawing.Point(326, 212);
            this.lbRealCost.Name = "lbRealCost";
            this.lbRealCost.Size = new System.Drawing.Size(58, 19);
            this.lbRealCost.TabIndex = 42;
            this.lbRealCost.Values.Text = "Gỉai ngân";
            // 
            // ipRealCost
            // 
            this.ipRealCost.Location = new System.Drawing.Point(403, 212);
            this.ipRealCost.Name = "ipRealCost";
            this.ipRealCost.Size = new System.Drawing.Size(172, 22);
            this.ipRealCost.TabIndex = 43;
            // 
            // lbProgress
            // 
            this.lbProgress.Location = new System.Drawing.Point(42, 248);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(48, 19);
            this.lbProgress.TabIndex = 44;
            this.lbProgress.Values.Text = "Tiến độ";
            // 
            // ipProgressRate
            // 
            this.ipProgressRate.Location = new System.Drawing.Point(114, 248);
            this.ipProgressRate.Name = "ipProgressRate";
            this.ipProgressRate.Size = new System.Drawing.Size(161, 22);
            this.ipProgressRate.TabIndex = 45;
            // 
            // AddSubconstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubconstruction";
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Text = "Tạo công trình phụ";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubconName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
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

