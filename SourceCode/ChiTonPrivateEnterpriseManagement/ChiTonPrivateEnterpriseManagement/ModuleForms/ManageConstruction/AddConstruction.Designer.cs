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
            this.panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtStartDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ipDes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbDes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rdhasEstimate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdNoEstimate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbSCType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbState = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btCancel);
            this.panel.Controls.Add(this.btSave);
            this.panel.Controls.Add(this.kryptonGroupBox2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(719, 614);
            this.panel.TabIndex = 0;
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
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(19, 30);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtStartDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipDes);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbDes);
            this.kryptonGroupBox2.Panel.Controls.Add(this.rdhasEstimate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.rdNoEstimate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.cbStatus);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbSCType);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbState);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtEndDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbEndDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbStartDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipAddress);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbAddress);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipConstructionName);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbConstructionName);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(697, 536);
            this.kryptonGroupBox2.TabIndex = 7;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(178, 218);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(159, 20);
            this.dtStartDate.TabIndex = 19;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(178, 308);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(447, 188);
            this.ipDes.TabIndex = 18;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(125, 308);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(45, 19);
            this.lbDes.TabIndex = 17;
            this.lbDes.Values.Text = "Mô tả :";
            // 
            // rdhasEstimate
            // 
            this.rdhasEstimate.Location = new System.Drawing.Point(176, 76);
            this.rdhasEstimate.Name = "rdhasEstimate";
            this.rdhasEstimate.Size = new System.Drawing.Size(78, 19);
            this.rdhasEstimate.TabIndex = 5;
            this.rdhasEstimate.Values.Text = "Có dự toán";
            this.rdhasEstimate.CheckedChanged += new System.EventHandler(this.rdhasEstimate_CheckedChanged);
            // 
            // rdNoEstimate
            // 
            this.rdNoEstimate.Location = new System.Drawing.Point(269, 76);
            this.rdNoEstimate.Name = "rdNoEstimate";
            this.rdNoEstimate.Size = new System.Drawing.Size(97, 19);
            this.rdNoEstimate.TabIndex = 3;
            this.rdNoEstimate.Values.Text = "Không dự toán";
            this.rdNoEstimate.CheckedChanged += new System.EventHandler(this.rdNoEstimate_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 172;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới ",
            "Đang thi công ",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(178, 265);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(159, 22);
            this.cbStatus.TabIndex = 14;
            this.cbStatus.Text = "chọn...";
            // 
            // lbSCType
            // 
            this.lbSCType.Location = new System.Drawing.Point(79, 76);
            this.lbSCType.Name = "lbSCType";
            this.lbSCType.Size = new System.Drawing.Size(91, 19);
            this.lbSCType.TabIndex = 2;
            this.lbSCType.Values.Text = "Loại công trình :";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(103, 268);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(67, 19);
            this.lbState.TabIndex = 13;
            this.lbState.Values.Text = "Tình trạng :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(453, 217);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(172, 20);
            this.dtEndDate.TabIndex = 10;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(348, 218);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(86, 19);
            this.lbEndDate.TabIndex = 9;
            this.lbEndDate.Values.Text = "Ngày kết thúc :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(75, 219);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(95, 19);
            this.lbStartDate.TabIndex = 7;
            this.lbStartDate.Values.Text = "Ngày khởi công :";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(453, 144);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(172, 22);
            this.ipAddress.TabIndex = 6;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(362, 147);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(50, 19);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Values.Text = "Địa chỉ :";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(178, 147);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(159, 22);
            this.ipConstructionName.TabIndex = 3;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(81, 150);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(89, 19);
            this.lbConstructionName.TabIndex = 2;
            this.lbConstructionName.Values.Text = "Tên công trình :";
            // 
            // AddConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 614);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddConstruction";
            this.Text = "AddConstruction";
            this.Load += new System.EventHandler(this.AddConstruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdhasEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdNoEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSCType;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipDes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDes;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbState;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtStartDate;
    }
}

