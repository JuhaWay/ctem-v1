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
            this.cbParent = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbParent = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbState = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbTotalCost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtEndDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbConstructionName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnSubcons = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rdhasEstimate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdSubcon = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdNoEstimate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lbSCType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbSubcon = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbSubcon = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btCreateSubcon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSubcons)).BeginInit();
            this.pnSubcons.Panel.SuspendLayout();
            this.pnSubcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSubcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btCancel);
            this.panel.Controls.Add(this.btSave);
            this.panel.Controls.Add(this.kryptonGroupBox2);
            this.panel.Controls.Add(this.pnSubcons);
            this.panel.Controls.Add(this.rdhasEstimate);
            this.panel.Controls.Add(this.rdSubcon);
            this.panel.Controls.Add(this.rdNoEstimate);
            this.panel.Controls.Add(this.lbSCType);
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
            this.kryptonGroupBox2.Location = new System.Drawing.Point(19, 135);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtStartDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipDes);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbDes);
            this.kryptonGroupBox2.Panel.Controls.Add(this.cbParent);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbParent);
            this.kryptonGroupBox2.Panel.Controls.Add(this.cbStatus);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbState);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipTotalCost);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbTotalCost);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtEndDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbEndDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbStartDate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipAddress);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbAddress);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipConstructionName);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbConstructionName);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(697, 431);
            this.kryptonGroupBox2.TabIndex = 7;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(178, 55);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(159, 18);
            this.dtStartDate.TabIndex = 19;
            // 
            // ipDes
            // 
            this.ipDes.Location = new System.Drawing.Point(178, 204);
            this.ipDes.Multiline = true;
            this.ipDes.Name = "ipDes";
            this.ipDes.Size = new System.Drawing.Size(447, 188);
            this.ipDes.TabIndex = 18;
            this.ipDes.Text = "...";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(60, 200);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(45, 16);
            this.lbDes.TabIndex = 17;
            this.lbDes.Values.Text = "Mô tả :";
            // 
            // cbParent
            // 
            this.cbParent.DropDownWidth = 159;
            this.cbParent.Location = new System.Drawing.Point(178, 150);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(159, 20);
            this.cbParent.TabIndex = 16;
            this.cbParent.Text = "chọn...";
            // 
            // lbParent
            // 
            this.lbParent.Location = new System.Drawing.Point(60, 150);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(90, 16);
            this.lbParent.TabIndex = 15;
            this.lbParent.Values.Text = "Công trình cha :";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 172;
            this.cbStatus.Items.AddRange(new object[] {
            "Mới ",
            "Đang thi công ",
            "Treo"});
            this.cbStatus.Location = new System.Drawing.Point(453, 105);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 20);
            this.cbStatus.TabIndex = 14;
            this.cbStatus.Text = "chọn...";
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(348, 108);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(67, 16);
            this.lbState.TabIndex = 13;
            this.lbState.Values.Text = "Tình trạng :";
            // 
            // ipTotalCost
            // 
            this.ipTotalCost.Location = new System.Drawing.Point(178, 108);
            this.ipTotalCost.Name = "ipTotalCost";
            this.ipTotalCost.Size = new System.Drawing.Size(159, 20);
            this.ipTotalCost.TabIndex = 12;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Location = new System.Drawing.Point(60, 111);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(92, 16);
            this.lbTotalCost.TabIndex = 11;
            this.lbTotalCost.Values.Text = "Chi phí dự toán :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(453, 56);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(172, 18);
            this.dtEndDate.TabIndex = 10;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(343, 56);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(85, 16);
            this.lbEndDate.TabIndex = 9;
            this.lbEndDate.Values.Text = "Ngày kết thúc :";
            // 
            // lbStartDate
            // 
            this.lbStartDate.Location = new System.Drawing.Point(60, 57);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(94, 16);
            this.lbStartDate.TabIndex = 7;
            this.lbStartDate.Values.Text = "Ngày khởi công :";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(453, 3);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(172, 20);
            this.ipAddress.TabIndex = 6;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(348, 6);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 16);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Values.Text = "Địa chỉ :";
            // 
            // ipConstructionName
            // 
            this.ipConstructionName.Location = new System.Drawing.Point(178, 3);
            this.ipConstructionName.Name = "ipConstructionName";
            this.ipConstructionName.Size = new System.Drawing.Size(159, 20);
            this.ipConstructionName.TabIndex = 3;
            // 
            // lbConstructionName
            // 
            this.lbConstructionName.Location = new System.Drawing.Point(66, 3);
            this.lbConstructionName.Name = "lbConstructionName";
            this.lbConstructionName.Size = new System.Drawing.Size(89, 16);
            this.lbConstructionName.TabIndex = 2;
            this.lbConstructionName.Values.Text = "Tên công trình :";
            // 
            // pnSubcons
            // 
            this.pnSubcons.Enabled = false;
            this.pnSubcons.Location = new System.Drawing.Point(19, 58);
            this.pnSubcons.Name = "pnSubcons";
            // 
            // pnSubcons.Panel
            // 
            this.pnSubcons.Panel.Controls.Add(this.btCreateSubcon);
            this.pnSubcons.Panel.Controls.Add(this.lbSubcon);
            this.pnSubcons.Panel.Controls.Add(this.cbSubcon);
            this.pnSubcons.Size = new System.Drawing.Size(697, 71);
            this.pnSubcons.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.pnSubcons.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pnSubcons.TabIndex = 6;
            this.pnSubcons.Values.Heading = "Nhà thầu phụ";
            // 
            // rdhasEstimate
            // 
            this.rdhasEstimate.Location = new System.Drawing.Point(211, 12);
            this.rdhasEstimate.Name = "rdhasEstimate";
            this.rdhasEstimate.Size = new System.Drawing.Size(77, 16);
            this.rdhasEstimate.TabIndex = 5;
            this.rdhasEstimate.Values.Text = "Có dự toán";
            this.rdhasEstimate.CheckedChanged += new System.EventHandler(this.rdhasEstimate_CheckedChanged);
            // 
            // rdSubcon
            // 
            this.rdSubcon.Location = new System.Drawing.Point(114, 12);
            this.rdSubcon.Name = "rdSubcon";
            this.rdSubcon.Size = new System.Drawing.Size(90, 16);
            this.rdSubcon.TabIndex = 4;
            this.rdSubcon.Values.Text = "Nhà thầu phụ";
            this.rdSubcon.CheckedChanged += new System.EventHandler(this.rdSubcon_CheckedChanged);
            // 
            // rdNoEstimate
            // 
            this.rdNoEstimate.Location = new System.Drawing.Point(295, 12);
            this.rdNoEstimate.Name = "rdNoEstimate";
            this.rdNoEstimate.Size = new System.Drawing.Size(96, 16);
            this.rdNoEstimate.TabIndex = 3;
            this.rdNoEstimate.Values.Text = "Không dự toán";
            this.rdNoEstimate.CheckedChanged += new System.EventHandler(this.rdNoEstimate_CheckedChanged);
            // 
            // lbSCType
            // 
            this.lbSCType.Location = new System.Drawing.Point(19, 12);
            this.lbSCType.Name = "lbSCType";
            this.lbSCType.Size = new System.Drawing.Size(90, 16);
            this.lbSCType.TabIndex = 2;
            this.lbSCType.Values.Text = "Loại công trình :";
            // 
            // cbSubcon
            // 
            this.cbSubcon.DropDownWidth = 121;
            this.cbSubcon.Location = new System.Drawing.Point(234, 14);
            this.cbSubcon.Name = "cbSubcon";
            this.cbSubcon.Size = new System.Drawing.Size(121, 20);
            this.cbSubcon.TabIndex = 0;
            this.cbSubcon.Text = "chọn...";
            // 
            // lbSubcon
            // 
            this.lbSubcon.Location = new System.Drawing.Point(133, 18);
            this.lbSubcon.Name = "lbSubcon";
            this.lbSubcon.Size = new System.Drawing.Size(83, 16);
            this.lbSubcon.TabIndex = 1;
            this.lbSubcon.Values.Text = "Tên nhà thầu :";
            // 
            // btCreateSubcon
            // 
            this.btCreateSubcon.Location = new System.Drawing.Point(361, 14);
            this.btCreateSubcon.Name = "btCreateSubcon";
            this.btCreateSubcon.Size = new System.Drawing.Size(67, 20);
            this.btCreateSubcon.TabIndex = 2;
            this.btCreateSubcon.Values.Text = "Tạo mới";
            this.btCreateSubcon.Click += new System.EventHandler(this.btCreateSubcon_Click);
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
            this.panel.PerformLayout();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.pnSubcons.Panel.ResumeLayout(false);
            this.pnSubcons.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnSubcons)).EndInit();
            this.pnSubcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSubcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdhasEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdSubcon;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdNoEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSCType;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbConstructionName;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox pnSubcons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipDes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDes;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbParent;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbParent;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbState;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTotalCost;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCreateSubcon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSubcon;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSubcon;
    }
}

