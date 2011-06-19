namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class NewAdvance
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
            this.txtClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTotalAdvance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.txtClose);
            this.kryptonPanel.Controls.Add(this.txtClear);
            this.kryptonPanel.Controls.Add(this.txtSave);
            this.kryptonPanel.Controls.Add(this.cbbEmployee);
            this.kryptonPanel.Controls.Add(this.txtNote);
            this.kryptonPanel.Controls.Add(this.txtReason);
            this.kryptonPanel.Controls.Add(this.txtTotalAdvance);
            this.kryptonPanel.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(444, 427);
            this.kryptonPanel.TabIndex = 0;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(342, 355);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(90, 25);
            this.txtClose.TabIndex = 11;
            this.txtClose.Values.Text = "Đóng";
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(150, 355);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(90, 25);
            this.txtClear.TabIndex = 10;
            this.txtClear.Values.Text = "Làm Mới";
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(246, 355);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(90, 25);
            this.txtSave.TabIndex = 9;
            this.txtSave.Values.Text = "Lưu";
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.DropDownWidth = 237;
            this.cbbEmployee.Location = new System.Drawing.Point(134, 77);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(237, 21);
            this.cbbEmployee.TabIndex = 8;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(134, 230);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(237, 94);
            this.txtNote.TabIndex = 7;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(134, 130);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(237, 94);
            this.txtReason.TabIndex = 6;
            // 
            // txtTotalAdvance
            // 
            this.txtTotalAdvance.Location = new System.Drawing.Point(134, 104);
            this.txtTotalAdvance.Name = "txtTotalAdvance";
            this.txtTotalAdvance.Size = new System.Drawing.Size(237, 20);
            this.txtTotalAdvance.TabIndex = 5;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(63, 228);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(75, 130);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Lý Do";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(57, 104);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Tiền Ứng";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(49, 78);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Nhân Viên";
            // 
            // NewAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 427);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "NewAdvance";
            this.Text = "NewAdvance";
            this.Load += new System.EventHandler(this.NewAdvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReason;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalAdvance;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonButton txtClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton txtClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton txtSave;
    }
}

