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
            this.pnMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMethod = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMethod = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbReason = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPerson = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPerson = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonLabel4);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.dtDate);
            this.pnMain.Controls.Add(this.lbDate);
            this.pnMain.Controls.Add(this.cbMethod);
            this.pnMain.Controls.Add(this.lbMethod);
            this.pnMain.Controls.Add(this.ipReason);
            this.pnMain.Controls.Add(this.lbReason);
            this.pnMain.Controls.Add(this.ipPerson);
            this.pnMain.Controls.Add(this.lbPerson);
            this.pnMain.Controls.Add(this.ipNumber);
            this.pnMain.Controls.Add(this.lbNumber);
            this.pnMain.Controls.Add(this.cbType);
            this.pnMain.Controls.Add(this.lbType);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(345, 309);
            this.pnMain.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(194, 254);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(49, 25);
            this.btClose.TabIndex = 15;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(133, 254);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(55, 25);
            this.btSave.TabIndex = 14;
            this.btSave.Values.Text = "Tạo";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(133, 223);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(175, 20);
            this.dtDate.TabIndex = 13;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(81, 223);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 16);
            this.lbDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.TabIndex = 12;
            this.lbDate.Values.Text = "Ngày";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownWidth = 175;
            this.cbMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoảng"});
            this.cbMethod.Location = new System.Drawing.Point(133, 185);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(175, 22);
            this.cbMethod.TabIndex = 11;
            this.cbMethod.Text = "chọn...";
            // 
            // lbMethod
            // 
            this.lbMethod.Location = new System.Drawing.Point(56, 185);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(73, 16);
            this.lbMethod.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbMethod.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMethod.TabIndex = 10;
            this.lbMethod.Values.Text = "Hình thức(*)";
            // 
            // ipReason
            // 
            this.ipReason.Location = new System.Drawing.Point(133, 151);
            this.ipReason.Name = "ipReason";
            this.ipReason.Size = new System.Drawing.Size(175, 22);
            this.ipReason.TabIndex = 9;
            // 
            // lbReason
            // 
            this.lbReason.Location = new System.Drawing.Point(84, 154);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(39, 16);
            this.lbReason.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbReason.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReason.TabIndex = 8;
            this.lbReason.Values.Text = "Lý do";
            // 
            // ipPerson
            // 
            this.ipPerson.Location = new System.Drawing.Point(133, 120);
            this.ipPerson.Name = "ipPerson";
            this.ipPerson.Size = new System.Drawing.Size(175, 22);
            this.ipPerson.TabIndex = 7;
            // 
            // lbPerson
            // 
            this.lbPerson.Location = new System.Drawing.Point(70, 120);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(50, 16);
            this.lbPerson.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbPerson.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerson.TabIndex = 6;
            this.lbPerson.Values.Text = "Chi cho";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(133, 92);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(175, 22);
            this.ipNumber.TabIndex = 5;
            this.ipNumber.Leave += new System.EventHandler(this.ipNumber_Leave);
            this.ipNumber.MouseLeave += new System.EventHandler(this.ipNumber_MouseLeave);
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(32, 92);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(95, 16);
            this.lbNumber.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbNumber.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Values.Text = "Số tiền (VND)(*)";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 175;
            this.cbType.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbType.Location = new System.Drawing.Point(133, 64);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(175, 22);
            this.cbType.TabIndex = 3;
            this.cbType.Text = "chọn...";
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(84, 64);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 16);
            this.lbType.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbType.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.TabIndex = 2;
            this.lbType.Values.Text = "Loại(*)";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(133, 36);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(175, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(86, 36);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 16);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên(*)";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(47, 285);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(110, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 31;
            this.kryptonLabel4.Values.Text = "(*) trường  bắt buộc";
            // 
            // AddnewLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 309);
            this.Controls.Add(this.pnMain);
            this.Name = "AddnewLedger";
            this.ShowIcon = false;
            this.Text = "Tạo mới dử liệu";
            this.Load += new System.EventHandler(this.AddnewLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}

