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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConstruction));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ipProgressRate);
            this.panel.Controls.Add(this.lbProgressRate);
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
            this.panel.Controls.Add(this.btCancel);
            this.panel.Controls.Add(this.btSave);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(608, 614);
            this.panel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel.StateCommon.Color2 = System.Drawing.Color.WhiteSmoke;
            this.panel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            this.panel.TabIndex = 0;
            // 
            // ipProgressRate
            // 
            this.ipProgressRate.Enabled = false;
            this.ipProgressRate.Location = new System.Drawing.Point(393, 193);
            this.ipProgressRate.Name = "ipProgressRate";
            this.ipProgressRate.Size = new System.Drawing.Size(172, 22);
            this.ipProgressRate.TabIndex = 33;
            // 
            // lbProgressRate
            // 
            this.lbProgressRate.Location = new System.Drawing.Point(310, 196);
            this.lbProgressRate.Name = "lbProgressRate";
            this.lbProgressRate.Size = new System.Drawing.Size(64, 19);
            this.lbProgressRate.TabIndex = 32;
            this.lbProgressRate.Values.Text = "Tiến độ(%)";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(118, 146);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(159, 20);
            this.dtStartDate.TabIndex = 31;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(118, 236);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(447, 280);
            this.ipDes.TabIndex = 30;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(65, 236);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(45, 19);
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
            this.cbStatus.Location = new System.Drawing.Point(118, 193);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(159, 22);
            this.cbStatus.TabIndex = 28;
            this.cbStatus.Text = "chọn...";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(43, 196);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(67, 19);
            this.lbState.TabIndex = 27;
            this.lbState.Values.Text = "Tình trạng :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(393, 145);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(172, 20);
            this.dtEndDate.TabIndex = 26;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(288, 146);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(86, 19);
            this.lbEndDate.TabIndex = 25;
            this.lbEndDate.Values.Text = "Ngày kết thúc :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(15, 147);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(95, 19);
            this.lbStartDate.TabIndex = 24;
            this.lbStartDate.Values.Text = "Ngày khởi công :";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(393, 72);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(172, 22);
            this.ipAddress.TabIndex = 23;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(302, 75);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(50, 19);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Values.Text = "Địa chỉ :";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(118, 75);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(159, 22);
            this.ipConstructionName.TabIndex = 21;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(21, 78);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(89, 19);
            this.lbConstructionName.TabIndex = 20;
            this.lbConstructionName.Values.Text = "Tên công trình :";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(329, 572);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(72, 25);
            this.btCancel.TabIndex = 10;
            this.btCancel.Values.Text = "Thoát";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(242, 572);
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
            this.ClientSize = new System.Drawing.Size(608, 614);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddConstruction";
            this.StateCommon.Header.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.Text = "Tạo công trình chính";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
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
    }
}

