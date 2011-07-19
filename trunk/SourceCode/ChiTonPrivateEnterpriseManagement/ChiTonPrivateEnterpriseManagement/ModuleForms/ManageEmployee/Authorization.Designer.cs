namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class Authorization
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.clbRights = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.pnlButton = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxButton = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlmain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbxMain = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).BeginInit();
            this.gbxButton.Panel.SuspendLayout();
            this.gbxButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlmain)).BeginInit();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxMain)).BeginInit();
            this.gbxMain.Panel.SuspendLayout();
            this.gbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phân Quyền";
            // 
            // cbbRole
            // 
            this.cbbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRole.DisplayMember = "RoleID";
            this.cbbRole.DropDownWidth = 271;
            this.cbbRole.Location = new System.Drawing.Point(137, 11);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(186, 22);
            this.cbbRole.TabIndex = 30;
            this.cbbRole.ValueMember = "RoleID";
            this.cbbRole.SelectedIndexChanged += new System.EventHandler(this.cbbRole_SelectedIndexChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(43, 11);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(82, 19);
            this.kryptonLabel10.TabIndex = 29;
            this.kryptonLabel10.Values.Text = "Chọn Chức Vụ";
            // 
            // clbRights
            // 
            this.clbRights.CheckOnClick = true;
            this.clbRights.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.clbRights.Location = new System.Drawing.Point(28, 35);
            this.clbRights.Name = "clbRights";
            this.clbRights.Size = new System.Drawing.Size(315, 234);
            this.clbRights.TabIndex = 28;
            this.clbRights.SelectedIndexChanged += new System.EventHandler(this.clbRights_SelectedIndexChanged);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.gbxButton);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 352);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(466, 92);
            this.pnlButton.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.pnlButton.TabIndex = 41;
            // 
            // gbxButton
            // 
            this.gbxButton.CaptionOverlap = 0D;
            this.gbxButton.Location = new System.Drawing.Point(42, 9);
            this.gbxButton.Name = "gbxButton";
            // 
            // gbxButton.Panel
            // 
            this.gbxButton.Panel.Controls.Add(this.btnClose);
            this.gbxButton.Panel.Controls.Add(this.btnSave);
            this.gbxButton.Size = new System.Drawing.Size(379, 72);
            this.gbxButton.TabIndex = 0;
            this.gbxButton.Values.Heading = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.close_box_red;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.gbxMain);
            this.pnlmain.Controls.Add(this.label2);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(466, 352);
            this.pnlmain.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(223)))));
            this.pnlmain.TabIndex = 42;
            // 
            // gbxMain
            // 
            this.gbxMain.CaptionOverlap = 0D;
            this.gbxMain.Location = new System.Drawing.Point(42, 56);
            this.gbxMain.Name = "gbxMain";
            // 
            // gbxMain.Panel
            // 
            this.gbxMain.Panel.Controls.Add(this.clbRights);
            this.gbxMain.Panel.Controls.Add(this.cbbRole);
            this.gbxMain.Panel.Controls.Add(this.kryptonLabel10);
            this.gbxMain.Size = new System.Drawing.Size(379, 290);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.Values.Heading = "";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 444);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnlButton);
            this.Name = "Authorization";
            this.Text = "Phân Quyền";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.gbxButton.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxButton)).EndInit();
            this.gbxButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlmain)).EndInit();
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            this.gbxMain.Panel.ResumeLayout(false);
            this.gbxMain.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxMain)).EndInit();
            this.gbxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbRole;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox clbRights;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlmain;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxMain;
    }
}

