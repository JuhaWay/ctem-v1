namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class AddNewWk
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
            this.lbPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbManDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvWD = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtAllowance = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayWorkingDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayWorkingDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonGroupBox2);
            this.pnMain.Controls.Add(this.kryptonGroupBox1);
            this.pnMain.Controls.Add(this.dgvWD);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(359, 532);
            this.pnMain.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 439);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btClose);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(336, 85);
            this.kryptonGroupBox2.TabIndex = 27;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(65, 31);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(95, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.save_edit;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(201, 31);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(82, 25);
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
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtReason);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtAllowance);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbPosition);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbManDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipPosition);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ipSalary);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbSalary);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(336, 221);
            this.kryptonGroupBox1.TabIndex = 26;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // lbPosition
            // 
            this.lbPosition.Location = new System.Drawing.Point(81, 63);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(34, 19);
            this.lbPosition.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbPosition.TabIndex = 18;
            this.lbPosition.Values.Text = "Vị trí";
            // 
            // lbManDate
            // 
            this.lbManDate.Location = new System.Drawing.Point(121, 180);
            this.lbManDate.Name = "lbManDate";
            this.lbManDate.Size = new System.Drawing.Size(17, 16);
            this.lbManDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbManDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManDate.TabIndex = 25;
            this.lbManDate.Values.Text = "0";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(30, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 16;
            this.lbName.Values.Text = "Tên công nhân";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(65, 177);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "Số ngày ";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(121, 32);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(181, 22);
            this.ipName.TabIndex = 1;
            // 
            // ipPosition
            // 
            this.ipPosition.Location = new System.Drawing.Point(121, 60);
            this.ipPosition.Name = "ipPosition";
            this.ipPosition.Size = new System.Drawing.Size(181, 22);
            this.ipPosition.TabIndex = 2;
            // 
            // ipSalary
            // 
            this.ipSalary.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.ipSalary.Location = new System.Drawing.Point(121, 146);
            this.ipSalary.Name = "ipSalary";
            this.ipSalary.Size = new System.Drawing.Size(181, 25);
            this.ipSalary.StateCommon.Content.Color1 = System.Drawing.Color.Lime;
            this.ipSalary.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipSalary.TabIndex = 4;
            this.ipSalary.Enter += new System.EventHandler(this.txtAllowance_Enter);
            this.ipSalary.Leave += new System.EventHandler(this.txtAllowance_Leave);
            this.ipSalary.MouseLeave += new System.EventHandler(this.ipSalary_MouseLeave);
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(42, 152);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(73, 19);
            this.lbSalary.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSalary.TabIndex = 22;
            this.lbSalary.Values.Text = "Lương/Ngày";
            // 
            // dgvWD
            // 
            this.dgvWD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWD.AutoGenerateColumns = false;
            this.dgvWD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvWD.DataSource = this.dayWorkingDTOBindingSource;
            this.dgvWD.Location = new System.Drawing.Point(12, 239);
            this.dgvWD.Name = "dgvWD";
            this.dgvWD.Size = new System.Drawing.Size(336, 194);
            this.dgvWD.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWD.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWD.TabIndex = 23;
            this.dgvWD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWD_CellEndEdit);
            // 
            // txtAllowance
            // 
            this.txtAllowance.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtAllowance.Location = new System.Drawing.Point(121, 87);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(181, 25);
            this.txtAllowance.StateCommon.Content.Color1 = System.Drawing.Color.Lime;
            this.txtAllowance.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowance.TabIndex = 26;
            this.txtAllowance.Enter += new System.EventHandler(this.txtAllowance_Enter);
            this.txtAllowance.Leave += new System.EventHandler(this.txtAllowance_Leave);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(63, 93);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(52, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Phụ Cấp";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Text = "(VND)";
            this.buttonSpecAny1.UniqueName = "BABE62BEE2554F5F5AB079E3272683F3";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Text = "(VND)";
            this.buttonSpecAny2.UniqueName = "5EDF42E2F47047F9AEB52E9FCA289405";
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Text = "(VND)";
            this.buttonSpecAny3.UniqueName = "13CFB6B778FF491A1C91887E25208A45";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(76, 121);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(39, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 29;
            this.kryptonLabel3.Values.Text = "Lý Do";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(121, 118);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(181, 22);
            this.txtReason.TabIndex = 28;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "DateFormated";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Số ngày";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 150;
            // 
            // dayWorkingDTOBindingSource
            // 
            this.dayWorkingDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DayWorkingDTO);
            // 
            // AddNewWk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 532);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewWk";
            this.ShowIcon = false;
            this.Text = "Tạo mới công nhân";
            this.Load += new System.EventHandler(this.AddNewWk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayWorkingDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWD;
        private System.Windows.Forms.BindingSource dayWorkingDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAllowance;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReason;
    }
}

