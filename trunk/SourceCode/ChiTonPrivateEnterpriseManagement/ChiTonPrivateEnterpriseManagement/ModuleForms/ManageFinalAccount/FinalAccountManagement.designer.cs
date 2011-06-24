namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    partial class FinalAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalAccountManagement));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.scBot = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gbxLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvLeftBot = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gbcRightBot = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finalAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAccountDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.removeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).BeginInit();
            this.scBot.Panel1.SuspendLayout();
            this.scBot.Panel2.SuspendLayout();
            this.scBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).BeginInit();
            this.gbxLeftBot.Panel.SuspendLayout();
            this.gbxLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).BeginInit();
            this.gbcRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel6.Location = new System.Drawing.Point(779, 59);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(5, 503);
            this.kryptonPanel6.TabIndex = 6;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 59);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(5, 503);
            this.kryptonPanel2.TabIndex = 7;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(5, 557);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(774, 5);
            this.kryptonPanel3.TabIndex = 8;
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.scBot);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(5, 59);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(774, 498);
            this.kryptonPanel.TabIndex = 9;
            // 
            // scBot
            // 
            this.scBot.Cursor = System.Windows.Forms.Cursors.Default;
            this.scBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBot.Location = new System.Drawing.Point(0, 3);
            this.scBot.Name = "scBot";
            // 
            // scBot.Panel1
            // 
            this.scBot.Panel1.Controls.Add(this.gbxLeftBot);
            // 
            // scBot.Panel2
            // 
            this.scBot.Panel2.Controls.Add(this.gbcRightBot);
            this.scBot.Size = new System.Drawing.Size(774, 495);
            this.scBot.SplitterDistance = 744;
            this.scBot.TabIndex = 8;
            // 
            // gbxLeftBot
            // 
            this.gbxLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLeftBot.Location = new System.Drawing.Point(0, 0);
            this.gbxLeftBot.Name = "gbxLeftBot";
            // 
            // gbxLeftBot.Panel
            // 
            this.gbxLeftBot.Panel.Controls.Add(this.dgvLeftBot);
            this.gbxLeftBot.Panel.Controls.Add(this.kryptonHeader1);
            this.gbxLeftBot.Size = new System.Drawing.Size(744, 495);
            this.gbxLeftBot.TabIndex = 0;
            this.gbxLeftBot.Values.Heading = "";
            // 
            // dgvLeftBot
            // 
            this.dgvLeftBot.AutoGenerateColumns = false;
            this.dgvLeftBot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.finalAccountIDDataGridViewTextBoxColumn,
            this.finalAccountNameDataGridViewTextBoxColumn,
            this.constructionNameDataGridViewTextBoxColumn,
            this.dateAccountDataGridViewTextBoxColumn,
            this.debtNameDataGridViewTextBoxColumn,
            this.transportationCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.personAccountDataGridViewTextBoxColumn,
            this.isPayDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvLeftBot.DataSource = this.finalAccountDTOBindingSource;
            this.dgvLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeftBot.Location = new System.Drawing.Point(0, 23);
            this.dgvLeftBot.Name = "dgvLeftBot";
            this.dgvLeftBot.Size = new System.Drawing.Size(740, 466);
            this.dgvLeftBot.TabIndex = 0;
            // 
            // gbcRightBot
            // 
            this.gbcRightBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbcRightBot.Location = new System.Drawing.Point(0, 0);
            this.gbcRightBot.Name = "gbcRightBot";
            this.gbcRightBot.Size = new System.Drawing.Size(25, 495);
            this.gbcRightBot.TabIndex = 1;
            this.gbcRightBot.Values.Heading = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(774, 3);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // finalAccountIDDataGridViewTextBoxColumn
            // 
            this.finalAccountIDDataGridViewTextBoxColumn.DataPropertyName = "FinalAccountID";
            this.finalAccountIDDataGridViewTextBoxColumn.HeaderText = "Mã Số";
            this.finalAccountIDDataGridViewTextBoxColumn.Name = "finalAccountIDDataGridViewTextBoxColumn";
            // 
            // finalAccountNameDataGridViewTextBoxColumn
            // 
            this.finalAccountNameDataGridViewTextBoxColumn.DataPropertyName = "FinalAccountName";
            this.finalAccountNameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.finalAccountNameDataGridViewTextBoxColumn.Name = "finalAccountNameDataGridViewTextBoxColumn";
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "Công Trình";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            // 
            // dateAccountDataGridViewTextBoxColumn
            // 
            this.dateAccountDataGridViewTextBoxColumn.DataPropertyName = "DateAccount";
            this.dateAccountDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateAccountDataGridViewTextBoxColumn.Name = "dateAccountDataGridViewTextBoxColumn";
            // 
            // debtNameDataGridViewTextBoxColumn
            // 
            this.debtNameDataGridViewTextBoxColumn.DataPropertyName = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.debtNameDataGridViewTextBoxColumn.Name = "debtNameDataGridViewTextBoxColumn";
            // 
            // transportationCostDataGridViewTextBoxColumn
            // 
            this.transportationCostDataGridViewTextBoxColumn.DataPropertyName = "TransportationCost";
            this.transportationCostDataGridViewTextBoxColumn.HeaderText = "Tiền Vận Chuyễn";
            this.transportationCostDataGridViewTextBoxColumn.Name = "transportationCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Tổng Số Tiền";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // personAccountDataGridViewTextBoxColumn
            // 
            this.personAccountDataGridViewTextBoxColumn.DataPropertyName = "PersonAccount";
            this.personAccountDataGridViewTextBoxColumn.HeaderText = "Chịu Trách Nhiệm";
            this.personAccountDataGridViewTextBoxColumn.Name = "personAccountDataGridViewTextBoxColumn";
            // 
            // isPayDataGridViewTextBoxColumn
            // 
            this.isPayDataGridViewTextBoxColumn.DataPropertyName = "IsPay";
            this.isPayDataGridViewTextBoxColumn.HeaderText = "Đã Thanh Toán";
            this.isPayDataGridViewTextBoxColumn.Name = "isPayDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // finalAccountDTOBindingSource
            // 
            this.finalAccountDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDTO);
            // 
            // finalAccountDetailDTOBindingSource
            // 
            this.finalAccountDetailDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.FinalAccountDetailDTO);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCustom1;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.removeButton);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btEdit);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btCreate);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(784, 59);
            this.kryptonGroupBox1.TabIndex = 17;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(264, 4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(82, 46);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton1.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "Chi Tiết";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(180, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(78, 46);
            this.removeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.removeButton.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.removeButton.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.removeButton.TabIndex = 5;
            this.removeButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Values.Image")));
            this.removeButton.Values.Text = "Xóa Lịch Đọ Sổ";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(92, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(82, 46);
            this.btEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEdit.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btEdit.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btEdit.TabIndex = 4;
            this.btEdit.Values.Image = ((System.Drawing.Image)(resources.GetObject("btEditEst.Values.Image")));
            this.btEdit.Values.Text = "Sửa Lịch Đọ Sổ";
            // 
            // btCreate
            // 
            this.btCreate.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btCreate.Location = new System.Drawing.Point(5, 3);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(81, 46);
            this.btCreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreate.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btCreate.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btCreate.TabIndex = 3;
            this.btCreate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btCreateEst.Values.Image")));
            this.btCreate.Values.Text = "Tạo Lịch Đọ Sổ";
            this.btCreate.Click += new System.EventHandler(this.btnAddFinalAccount_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(740, 23);
            this.kryptonHeader1.TabIndex = 18;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh Sách Quyết Toán";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // FinalAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel6);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "FinalAccountManagement";
            this.ShowIcon = false;
            this.Text = "Quản Lý Quyết Toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinalAccountManagement_Load);
            this.SizeChanged += new System.EventHandler(this.FinalAccountManagement_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.scBot.Panel1.ResumeLayout(false);
            this.scBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBot)).EndInit();
            this.scBot.ResumeLayout(false);
            this.gbxLeftBot.Panel.ResumeLayout(false);
            this.gbxLeftBot.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxLeftBot)).EndInit();
            this.gbxLeftBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcRightBot)).EndInit();
            this.gbcRightBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAccountDetailDTOBindingSource)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer scBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbxLeftBot;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbcRightBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.BindingSource finalAccountDetailDTOBindingSource;
        private System.Windows.Forms.BindingSource finalAccountDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLeftBot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton removeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}

