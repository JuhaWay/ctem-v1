namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class AddNewWS
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
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtOtherCost = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipTask = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonGroupBox2);
            this.pnMain.Controls.Add(this.kryptonGroupBox1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(415, 476);
            this.pnMain.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 385);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btClose);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(391, 79);
            this.kryptonGroupBox2.TabIndex = 12;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(47, 27);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(95, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(261, 27);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(96, 25);
            this.btClose.TabIndex = 6;
            this.btClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtReason);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtOtherCost);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbCons);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipTask);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbManager);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbCons);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbFromDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtFromdate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbTodate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtTodate);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(391, 367);
            this.kryptonGroupBox1.TabIndex = 11;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(106, 175);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(251, 63);
            this.txtReason.TabIndex = 14;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(58, 175);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(37, 19);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 13;
            this.kryptonLabel4.Values.Text = "Lý do";
            // 
            // txtOtherCost
            // 
            this.txtOtherCost.Location = new System.Drawing.Point(106, 147);
            this.txtOtherCost.Name = "txtOtherCost";
            this.txtOtherCost.Size = new System.Drawing.Size(251, 22);
            this.txtOtherCost.TabIndex = 12;
            this.txtOtherCost.Enter += new System.EventHandler(this.txtOtherCost_Enter);
            this.txtOtherCost.Leave += new System.EventHandler(this.txtOtherCost_Leave);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 147);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Chi phí khác";
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(25, 42);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(75, 19);
            this.lbCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbCons.TabIndex = 2;
            this.lbCons.Values.Text = "Công trình(*)";
            // 
            // ipTask
            // 
            this.ipTask.Location = new System.Drawing.Point(106, 244);
            this.ipTask.Multiline = true;
            this.ipTask.Name = "ipTask";
            this.ipTask.Size = new System.Drawing.Size(251, 100);
            this.ipTask.TabIndex = 10;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(54, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên (*)";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(36, 244);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Công việc";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(106, 11);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(251, 22);
            this.ipName.TabIndex = 1;
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 177;
            this.cbManager.Location = new System.Drawing.Point(106, 67);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(251, 22);
            this.cbManager.TabIndex = 8;
            this.cbManager.Text = "chọn...";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 177;
            this.cbCons.Location = new System.Drawing.Point(106, 39);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(251, 22);
            this.cbCons.TabIndex = 2;
            this.cbCons.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(37, 70);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Quản lý(*)";
            // 
            // lbFromDate
            // 
            this.lbFromDate.Location = new System.Drawing.Point(47, 96);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(50, 19);
            this.lbFromDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbFromDate.TabIndex = 4;
            this.lbFromDate.Values.Text = "Từ ngày";
            // 
            // dtFromdate
            // 
            this.dtFromdate.CustomFormat = "dd/MM/yyyy";
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromdate.Location = new System.Drawing.Point(106, 95);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(251, 20);
            this.dtFromdate.TabIndex = 3;
            // 
            // lbTodate
            // 
            this.lbTodate.Location = new System.Drawing.Point(37, 122);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTodate.TabIndex = 6;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // dtTodate
            // 
            this.dtTodate.CustomFormat = "dd/MM/yyyy";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(106, 121);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(251, 20);
            this.dtTodate.TabIndex = 4;
            // 
            // AddNewWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 476);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewWS";
            this.ShowIcon = false;
            this.Text = "Tạo Bảng lương";
            this.Load += new System.EventHandler(this.AddNewWS_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipTask;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReason;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOtherCost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}

