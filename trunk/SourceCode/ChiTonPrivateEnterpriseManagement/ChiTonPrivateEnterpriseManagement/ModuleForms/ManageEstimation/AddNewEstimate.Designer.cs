namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class AddNewEstimate
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbConstruction = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbConstruction = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEstName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbConstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(389, 332);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(41, 29);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btClose);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbConstruction);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbConstruction);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipEstName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbEstName);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(317, 266);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Nhập dự toán :";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(158, 140);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(58, 27);
            this.btClose.TabIndex = 9;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(90, 140);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(62, 27);
            this.btSave.TabIndex = 8;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbConstruction
            // 
            this.cbConstruction.DropDownWidth = 121;
            this.cbConstruction.Location = new System.Drawing.Point(159, 84);
            this.cbConstruction.Name = "cbConstruction";
            this.cbConstruction.Size = new System.Drawing.Size(121, 21);
            this.cbConstruction.TabIndex = 5;
            this.cbConstruction.Text = "chọn...";
            // 
            // lbConstruction
            // 
            this.lbConstruction.Location = new System.Drawing.Point(63, 84);
            this.lbConstruction.Name = "lbConstruction";
            this.lbConstruction.Size = new System.Drawing.Size(75, 20);
            this.lbConstruction.TabIndex = 4;
            this.lbConstruction.Values.Text = "Công trình :";
            // 
            // ipEstName
            // 
            this.ipEstName.Location = new System.Drawing.Point(159, 44);
            this.ipEstName.Name = "ipEstName";
            this.ipEstName.Size = new System.Drawing.Size(122, 20);
            this.ipEstName.TabIndex = 3;
            // 
            // lbEstName
            // 
            this.lbEstName.Location = new System.Drawing.Point(56, 47);
            this.lbEstName.Name = "lbEstName";
            this.lbEstName.Size = new System.Drawing.Size(83, 20);
            this.lbEstName.TabIndex = 2;
            this.lbEstName.Values.Text = "Tên dự toán :";
            // 
            // AddNewEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 332);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddNewEstimate";
            this.Text = "AddNewEstimate";
            this.Load += new System.EventHandler(this.AddNewEstimate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbConstruction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbConstruction;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbConstruction;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEstName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEstName;
    }
}

