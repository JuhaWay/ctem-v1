namespace ChiTonPrivateEnterpriseManagement
{
    partial class DBInfoForm
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
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbxAuthentication = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtDatabase = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtServerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnSave);
            this.kryptonPanel.Controls.Add(this.cbxAuthentication);
            this.kryptonPanel.Controls.Add(this.txtDatabase);
            this.kryptonPanel.Controls.Add(this.txtPassword);
            this.kryptonPanel.Controls.Add(this.txtUserName);
            this.kryptonPanel.Controls.Add(this.txtServerName);
            this.kryptonPanel.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel.Controls.Add(this.lblPassword);
            this.kryptonPanel.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel.Controls.Add(this.lblUserName);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(294, 247);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxAuthentication
            // 
            this.cbxAuthentication.DropDownWidth = 171;
            this.cbxAuthentication.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.cbxAuthentication.Location = new System.Drawing.Point(106, 81);
            this.cbxAuthentication.Name = "cbxAuthentication";
            this.cbxAuthentication.Size = new System.Drawing.Size(171, 22);
            this.cbxAuthentication.TabIndex = 11;
            this.cbxAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbxAuthentication_SelectedIndexChanged);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(106, 153);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(171, 22);
            this.txtDatabase.TabIndex = 10;
            this.txtDatabase.Text = "CTEM-DB-v1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "123456";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 105);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(171, 22);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "sa";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(106, 57);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(171, 22);
            this.txtServerName.TabIndex = 6;
            this.txtServerName.Text = "10.88.39.55";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(294, 27);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = " Enter database connection details";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(13, 153);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(57, 19);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Database";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(13, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Values.Text = "Password";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 81);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(84, 19);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Authentication";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(13, 105);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Values.Text = "User Name";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 57);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 19);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Server Name";
            // 
            // DBInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 247);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBInfoForm";
            this.Text = "DBInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxAuthentication;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

