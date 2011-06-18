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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btClose);
            this.kryptonPanel.Controls.Add(this.btSave);
            this.kryptonPanel.Controls.Add(this.dtTodate);
            this.kryptonPanel.Controls.Add(this.lbTodate);
            this.kryptonPanel.Controls.Add(this.dtFromdate);
            this.kryptonPanel.Controls.Add(this.lbFromDate);
            this.kryptonPanel.Controls.Add(this.cbCons);
            this.kryptonPanel.Controls.Add(this.lbCons);
            this.kryptonPanel.Controls.Add(this.ipName);
            this.kryptonPanel.Controls.Add(this.lbName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(325, 272);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(43, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên ";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(96, 46);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(177, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(12, 94);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(63, 19);
            this.lbCons.TabIndex = 2;
            this.lbCons.Values.Text = "Công trình";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 177;
            this.cbCons.Location = new System.Drawing.Point(96, 94);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(177, 22);
            this.cbCons.TabIndex = 3;
            this.cbCons.Text = "chọn...";
            // 
            // lbFromDate
            // 
            this.lbFromDate.Location = new System.Drawing.Point(21, 137);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(50, 19);
            this.lbFromDate.TabIndex = 4;
            this.lbFromDate.Values.Text = "Từ ngày";
            // 
            // dtFromdate
            // 
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromdate.Location = new System.Drawing.Point(96, 137);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(177, 20);
            this.dtFromdate.TabIndex = 5;
            // 
            // lbTodate
            // 
            this.lbTodate.Location = new System.Drawing.Point(13, 182);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.TabIndex = 6;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // dtTodate
            // 
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTodate.Location = new System.Drawing.Point(96, 182);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(177, 20);
            this.dtTodate.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(106, 226);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 25);
            this.btSave.TabIndex = 8;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(164, 226);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(53, 25);
            this.btClose.TabIndex = 9;
            this.btClose.Values.Text = "Đóng";
            // 
            // AddNewWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 272);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddNewWS";
            this.Text = "Tổng kết";
            this.Load += new System.EventHandler(this.AddNewWS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
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
    }
}

