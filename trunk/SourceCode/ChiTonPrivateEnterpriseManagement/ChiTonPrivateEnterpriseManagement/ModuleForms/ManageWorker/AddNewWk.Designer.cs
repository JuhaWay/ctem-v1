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
            this.lbManDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvWD = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayWorkingDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ipSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayWorkingDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lbManDate);
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.dgvWD);
            this.pnMain.Controls.Add(this.ipSalary);
            this.pnMain.Controls.Add(this.lbSalary);
            this.pnMain.Controls.Add(this.ipPosition);
            this.pnMain.Controls.Add(this.lbPosition);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(323, 472);
            this.pnMain.TabIndex = 0;
            // 
            // lbManDate
            // 
            this.lbManDate.Location = new System.Drawing.Point(122, 156);
            this.lbManDate.Name = "lbManDate";
            this.lbManDate.Size = new System.Drawing.Size(17, 16);
            this.lbManDate.StateCommon.ShortText.Color1 = System.Drawing.Color.Lime;
            this.lbManDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManDate.TabIndex = 25;
            this.lbManDate.Values.Text = "0";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(59, 153);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "Số ngày ";
            // 
            // dgvWD
            // 
            this.dgvWD.AutoGenerateColumns = false;
            this.dgvWD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvWD.DataSource = this.dayWorkingDTOBindingSource;
            this.dgvWD.Location = new System.Drawing.Point(3, 177);
            this.dgvWD.Name = "dgvWD";
            this.dgvWD.Size = new System.Drawing.Size(317, 261);
            this.dgvWD.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWD.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWD.TabIndex = 23;
            this.dgvWD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWD_CellEndEdit);           // 
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
            // ipSalary
            // 
            this.ipSalary.Location = new System.Drawing.Point(121, 128);
            this.ipSalary.Name = "ipSalary";
            this.ipSalary.Size = new System.Drawing.Size(181, 20);
            this.ipSalary.StateCommon.Content.Color1 = System.Drawing.Color.Lime;
            this.ipSalary.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipSalary.TabIndex = 4;
            this.ipSalary.Leave += new System.EventHandler(this.ipSalary_Leave);
            this.ipSalary.MouseLeave += new System.EventHandler(this.ipSalary_MouseLeave);
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(12, 128);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(103, 19);
            this.lbSalary.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSalary.TabIndex = 22;
            this.lbSalary.Values.Text = "Lương/Ngày(VND)";
            // 
            // ipPosition
            // 
            this.ipPosition.Location = new System.Drawing.Point(122, 89);
            this.ipPosition.Name = "ipPosition";
            this.ipPosition.Size = new System.Drawing.Size(181, 22);
            this.ipPosition.TabIndex = 2;
            // 
            // lbPosition
            // 
            this.lbPosition.Location = new System.Drawing.Point(59, 92);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(34, 19);
            this.lbPosition.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbPosition.TabIndex = 18;
            this.lbPosition.Values.Text = "Vị trí";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(122, 50);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(181, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(12, 50);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 19);
            this.lbName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbName.TabIndex = 16;
            this.lbName.Values.Text = "Tên công nhân";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(174, 444);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(43, 25);
            this.btClose.TabIndex = 6;
            this.btClose.Values.Text = "Đóng";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(121, 444);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(47, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AddNewWk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 472);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewWk";
            this.ShowIcon = false;
            this.Text = "Tạo mới công nhân";
            this.Load += new System.EventHandler(this.AddNewWk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
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
    }
}

