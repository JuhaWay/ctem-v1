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
            this.cbbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTotalAdvance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxAdd1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbxAdd2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pnlButton = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxButton = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd1)).BeginInit();
            this.gbxAdd1.Panel.SuspendLayout();
            this.gbxAdd1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd2)).BeginInit();
            this.gbxAdd2.Panel.SuspendLayout();
            this.gbxAdd2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).BeginInit();
            this.gbxButton.Panel.SuspendLayout();
            this.gbxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.DropDownWidth = 237;
            this.cbbEmployee.Location = new System.Drawing.Point(114, 25);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(285, 21);
            this.cbbEmployee.TabIndex = 16;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(119, 10);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(285, 94);
            this.txtNote.TabIndex = 15;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(114, 78);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(285, 94);
            this.txtReason.TabIndex = 14;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // txtTotalAdvance
            // 
            this.txtTotalAdvance.Location = new System.Drawing.Point(114, 52);
            this.txtTotalAdvance.Name = "txtTotalAdvance";
            this.txtTotalAdvance.Size = new System.Drawing.Size(285, 20);
            this.txtTotalAdvance.TabIndex = 13;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(48, 8);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(55, 78);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Lý Do";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(37, 52);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Tiền Ứng";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(29, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Nhân Viên";
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            this.slcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.gbxAdd1);
            this.slcMain.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.slcMain.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.gbxAdd2);
            this.slcMain.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcMain.Size = new System.Drawing.Size(441, 353);
            this.slcMain.SplitterDistance = 211;
            this.slcMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.slcMain.TabIndex = 39;
            // 
            // gbxAdd1
            // 
            this.gbxAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd1.Location = new System.Drawing.Point(5, 0);
            this.gbxAdd1.Name = "gbxAdd1";
            // 
            // gbxAdd1.Panel
            // 
            this.gbxAdd1.Panel.Controls.Add(this.txtReason);
            this.gbxAdd1.Panel.Controls.Add(this.cbbEmployee);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel1);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel2);
            this.gbxAdd1.Panel.Controls.Add(this.kryptonLabel3);
            this.gbxAdd1.Panel.Controls.Add(this.txtTotalAdvance);
            this.gbxAdd1.Size = new System.Drawing.Size(436, 206);
            this.gbxAdd1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.gbxAdd1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.gbxAdd1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gbxAdd1.TabIndex = 5;
            this.gbxAdd1.Values.Heading = "Thông Tin Bắt Buộc";
            // 
            // gbxAdd2
            // 
            this.gbxAdd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAdd2.Location = new System.Drawing.Point(0, 0);
            this.gbxAdd2.Name = "gbxAdd2";
            // 
            // gbxAdd2.Panel
            // 
            this.gbxAdd2.Panel.Controls.Add(this.txtNote);
            this.gbxAdd2.Panel.Controls.Add(this.kryptonLabel4);
            this.gbxAdd2.Size = new System.Drawing.Size(441, 137);
            this.gbxAdd2.TabIndex = 5;
            this.gbxAdd2.Values.Heading = "Thông Tin Thêm";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.gbxButton);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 353);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(441, 99);
            this.pnlButton.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.pnlButton.TabIndex = 40;
            // 
            // gbxButton
            // 
            this.gbxButton.CaptionOverlap = 0D;
            this.gbxButton.Location = new System.Drawing.Point(42, 10);
            this.gbxButton.Name = "gbxButton";
            // 
            // gbxButton.Panel
            // 
            this.gbxButton.Panel.Controls.Add(this.btnClear);
            this.gbxButton.Panel.Controls.Add(this.btnClose);
            this.gbxButton.Panel.Controls.Add(this.btnSave);
            this.gbxButton.Size = new System.Drawing.Size(379, 78);
            this.gbxButton.TabIndex = 0;
            this.gbxButton.Values.Heading = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.edit_clear;
            this.btnClear.Values.Text = "Làm Mới";
            this.btnClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // NewAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 452);
            this.Controls.Add(this.slcMain);
            this.Controls.Add(this.pnlButton);
            this.Name = "NewAdvance";
            this.Text = "NewAdvance";
            this.Load += new System.EventHandler(this.NewAdvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbEmployee)).EndInit();
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            this.gbxAdd1.Panel.ResumeLayout(false);
            this.gbxAdd1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd1)).EndInit();
            this.gbxAdd1.ResumeLayout(false);
            this.gbxAdd2.Panel.ResumeLayout(false);
            this.gbxAdd2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAdd2)).EndInit();
            this.gbxAdd2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.gbxButton.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).EndInit();
            this.gbxButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReason;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalAdvance;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxAdd1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxAdd2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
    }
}

