namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class ResetPassword
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 161);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnReset);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnClose);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cbbUsers);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(268, 137);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 40);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(102, 19);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Chọn Người Dùng";
            // 
            // cbbUsers
            // 
            this.cbbUsers.DropDownWidth = 121;
            this.cbbUsers.Location = new System.Drawing.Point(111, 37);
            this.cbbUsers.Name = "cbbUsers";
            this.cbbUsers.Size = new System.Drawing.Size(121, 22);
            this.cbbUsers.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(159, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.Values.Text = "Làm Mới Mất Khẩu";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 161);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}

