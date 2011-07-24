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
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbManager = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.cbManager);
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Controls.Add(this.dtTodate);
            this.pnMain.Controls.Add(this.lbTodate);
            this.pnMain.Controls.Add(this.dtFromdate);
            this.pnMain.Controls.Add(this.lbFromDate);
            this.pnMain.Controls.Add(this.cbCons);
            this.pnMain.Controls.Add(this.lbCons);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(290, 250);
            this.pnMain.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(164, 208);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(53, 25);
            this.btClose.TabIndex = 6;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(106, 208);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtTodate
            // 
            this.dtTodate.CustomFormat = "dd/MM/yyyy";
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTodate.Location = new System.Drawing.Point(96, 156);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(177, 20);
            this.dtTodate.TabIndex = 4;
            // 
            // lbTodate
            // 
            this.lbTodate.Location = new System.Drawing.Point(19, 156);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbTodate.TabIndex = 6;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // dtFromdate
            // 
            this.dtFromdate.CustomFormat = "dd/MM/yyyy";
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromdate.Location = new System.Drawing.Point(96, 130);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(177, 20);
            this.dtFromdate.TabIndex = 3;
            // 
            // lbFromDate
            // 
            this.lbFromDate.Location = new System.Drawing.Point(27, 132);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(50, 19);
            this.lbFromDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbFromDate.TabIndex = 4;
            this.lbFromDate.Values.Text = "Từ ngày";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 177;
            this.cbCons.Location = new System.Drawing.Point(96, 74);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(177, 22);
            this.cbCons.TabIndex = 2;
            this.cbCons.Text = "chọn...";
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(13, 77);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(75, 19);
            this.lbCons.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbCons.TabIndex = 2;
            this.lbCons.Values.Text = "Công trình(*)";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(96, 46);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(177, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(43, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên (*)";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(27, 102);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Quản lý(*)";
            // 
            // cbManager
            // 
            this.cbManager.DropDownWidth = 177;
            this.cbManager.Location = new System.Drawing.Point(96, 102);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(177, 22);
            this.cbManager.TabIndex = 8;
            this.cbManager.Text = "chọn...";
            // 
            // AddNewWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 250);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewWS";
            this.ShowIcon = false;
            this.Text = "Tạo Bảng lương";
            this.Load += new System.EventHandler(this.AddNewWS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbManager)).EndInit();
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
    }
}

