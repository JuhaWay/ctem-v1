namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger
{
    partial class AddnewLedger
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
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPerson = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPerson = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbReason = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbMethod = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMethod = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btClose);
            this.kryptonPanel.Controls.Add(this.btSave);
            this.kryptonPanel.Controls.Add(this.dtDate);
            this.kryptonPanel.Controls.Add(this.lbDate);
            this.kryptonPanel.Controls.Add(this.cbMethod);
            this.kryptonPanel.Controls.Add(this.lbMethod);
            this.kryptonPanel.Controls.Add(this.ipReason);
            this.kryptonPanel.Controls.Add(this.lbReason);
            this.kryptonPanel.Controls.Add(this.ipPerson);
            this.kryptonPanel.Controls.Add(this.lbPerson);
            this.kryptonPanel.Controls.Add(this.ipNumber);
            this.kryptonPanel.Controls.Add(this.lbNumber);
            this.kryptonPanel.Controls.Add(this.cbType);
            this.kryptonPanel.Controls.Add(this.lbType);
            this.kryptonPanel.Controls.Add(this.ipName);
            this.kryptonPanel.Controls.Add(this.lbName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 286);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(46, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(89, 31);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(175, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(46, 59);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 19);
            this.lbType.TabIndex = 2;
            this.lbType.Values.Text = "Loại";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 175;
            this.cbType.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbType.Location = new System.Drawing.Point(89, 59);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(175, 22);
            this.cbType.TabIndex = 3;
            this.cbType.Text = "chọn...";
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(3, 84);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(78, 19);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Values.Text = "Số tiền (VND)";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(89, 87);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(175, 22);
            this.ipNumber.TabIndex = 5;
            // 
            // lbPerson
            // 
            this.lbPerson.Location = new System.Drawing.Point(26, 115);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(48, 19);
            this.lbPerson.TabIndex = 6;
            this.lbPerson.Values.Text = "Chi cho";
            // 
            // ipPerson
            // 
            this.ipPerson.Location = new System.Drawing.Point(89, 115);
            this.ipPerson.Name = "ipPerson";
            this.ipPerson.Size = new System.Drawing.Size(175, 22);
            this.ipPerson.TabIndex = 7;
            // 
            // lbReason
            // 
            this.lbReason.Location = new System.Drawing.Point(40, 149);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(37, 19);
            this.lbReason.TabIndex = 8;
            this.lbReason.Values.Text = "Lý do";
            // 
            // ipReason
            // 
            this.ipReason.Location = new System.Drawing.Point(89, 146);
            this.ipReason.Name = "ipReason";
            this.ipReason.Size = new System.Drawing.Size(175, 22);
            this.ipReason.TabIndex = 9;
            // 
            // lbMethod
            // 
            this.lbMethod.Location = new System.Drawing.Point(22, 183);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(59, 19);
            this.lbMethod.TabIndex = 10;
            this.lbMethod.Values.Text = "Hình thức";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownWidth = 175;
            this.cbMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoảng"});
            this.cbMethod.Location = new System.Drawing.Point(89, 180);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(175, 22);
            this.cbMethod.TabIndex = 11;
            this.cbMethod.Text = "chọn...";
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(37, 218);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(37, 19);
            this.lbDate.TabIndex = 12;
            this.lbDate.Values.Text = "Ngày";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(89, 218);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(175, 20);
            this.dtDate.TabIndex = 13;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(89, 249);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(55, 25);
            this.btSave.TabIndex = 14;
            this.btSave.Values.Text = "Tạo";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(150, 249);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(49, 25);
            this.btClose.TabIndex = 15;
            this.btClose.Values.Text = "Đóng";
            // 
            // AddnewLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 286);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddnewLedger";
            this.Text = "AddnewLedger";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipReason;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbReason;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPerson;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPerson;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
    }
}

