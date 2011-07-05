using System.Windows.Forms;
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class WorkerSalaryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerSalaryManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtTodate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbTodate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtFromdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvWks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.constructionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkersSalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerSalaryDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btViewEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.workerSalaryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.dgvWks);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(924, 573);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btSave);
            this.kryptonPanel1.Controls.Add(this.dtTodate);
            this.kryptonPanel1.Controls.Add(this.lbTodate);
            this.kryptonPanel1.Controls.Add(this.dtFromdate);
            this.kryptonPanel1.Controls.Add(this.lbFromDate);
            this.kryptonPanel1.Controls.Add(this.cbCons);
            this.kryptonPanel1.Controls.Add(this.lbCons);
            this.kryptonPanel1.Controls.Add(this.ipName);
            this.kryptonPanel1.Controls.Add(this.lbName);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 331);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(924, 314);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertChecked;
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonPanel1.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(471, 201);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(62, 25);
            this.btSave.TabIndex = 18;
            this.btSave.Values.Text = "Cập nhật";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtTodate
            // 
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTodate.Location = new System.Drawing.Point(456, 163);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(177, 20);
            this.dtTodate.TabIndex = 17;
            // 
            // lbTodate
            // 
            this.lbTodate.Location = new System.Drawing.Point(373, 163);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(58, 19);
            this.lbTodate.TabIndex = 16;
            this.lbTodate.Values.Text = "Đến ngày";
            // 
            // dtFromdate
            // 
            this.dtFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromdate.Location = new System.Drawing.Point(456, 118);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(177, 20);
            this.dtFromdate.TabIndex = 15;
            // 
            // lbFromDate
            // 
            this.lbFromDate.Location = new System.Drawing.Point(381, 118);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(50, 19);
            this.lbFromDate.TabIndex = 14;
            this.lbFromDate.Values.Text = "Từ ngày";
            // 
            // cbCons
            // 
            this.cbCons.DropDownWidth = 177;
            this.cbCons.Location = new System.Drawing.Point(456, 75);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(177, 22);
            this.cbCons.TabIndex = 13;
            this.cbCons.Text = "chọn...";
            // 
            // lbCons
            // 
            this.lbCons.Location = new System.Drawing.Point(372, 75);
            this.lbCons.Name = "lbCons";
            this.lbCons.Size = new System.Drawing.Size(63, 19);
            this.lbCons.TabIndex = 12;
            this.lbCons.Values.Text = "Công trình";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(456, 27);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(177, 22);
            this.ipName.TabIndex = 11;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(403, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 19);
            this.lbName.TabIndex = 10;
            this.lbName.Values.Text = "Tên ";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 297);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(924, 34);
            this.kryptonPanel4.TabIndex = 8;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(924, 34);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Chi tiết";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // dgvWks
            // 
            this.dgvWks.AutoGenerateColumns = false;
            this.dgvWks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.constructionNameDataGridViewTextBoxColumn,
            this.WorkersSalaryID,
            this.constructionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.totalSalaryDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dgvWks.DataSource = this.workerSalaryDTOBindingSource1;
            this.dgvWks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvWks.Location = new System.Drawing.Point(0, 34);
            this.dgvWks.Name = "dgvWks";
            this.dgvWks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWks.Size = new System.Drawing.Size(924, 263);
            this.dgvWks.StateNormal.Background.Color1 = System.Drawing.Color.White;
            this.dgvWks.TabIndex = 0;
            this.dgvWks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWks_CellContentClick);
            this.dgvWks.SelectionChanged += new System.EventHandler(this.dgvWks_SelectionChanged);
            this.dgvWks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvWks_MouseClick);
            // 
            // checkBox
            // 
            this.checkBox.DataPropertyName = "isChecked";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.HeaderText = "";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 20;
            // 
            // constructionNameDataGridViewTextBoxColumn
            // 
            this.constructionNameDataGridViewTextBoxColumn.DataPropertyName = "ConstructionName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            this.constructionNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.constructionNameDataGridViewTextBoxColumn.HeaderText = "Công trình";
            this.constructionNameDataGridViewTextBoxColumn.Name = "constructionNameDataGridViewTextBoxColumn";
            this.constructionNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // WorkersSalaryID
            // 
            this.WorkersSalaryID.DataPropertyName = "WorkersSalaryID";
            this.WorkersSalaryID.HeaderText = "WorkersSalaryID";
            this.WorkersSalaryID.Name = "WorkersSalaryID";
            this.WorkersSalaryID.Visible = false;
            // 
            // constructionIDDataGridViewTextBoxColumn
            // 
            this.constructionIDDataGridViewTextBoxColumn.DataPropertyName = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.HeaderText = "ConstructionID";
            this.constructionIDDataGridViewTextBoxColumn.Name = "constructionIDDataGridViewTextBoxColumn";
            this.constructionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên Bảng lương";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            this.fromDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "Từ ngày";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            this.toDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.toDateDataGridViewTextBoxColumn.HeaderText = "Tới ngày";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.totalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "Tổng số tiền";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            this.lastUpdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Tạo bởi";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Cập nhật bởi";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            // 
            // workerSalaryDTOBindingSource1
            // 
            this.workerSalaryDTOBindingSource1.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerSalaryDTO);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btViewEst);
            this.kryptonPanel2.Controls.Add(this.btAddNew);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(924, 34);
            this.kryptonPanel2.TabIndex = 7;
            // 
            // btViewEst
            // 
            this.btViewEst.Dock = System.Windows.Forms.DockStyle.Right;
            this.btViewEst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btViewEst.Location = new System.Drawing.Point(817, 0);
            this.btViewEst.Name = "btViewEst";
            this.btViewEst.Size = new System.Drawing.Size(39, 34);
            this.btViewEst.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btViewEst.TabIndex = 9;
            this.toolTip.SetToolTip(this.btViewEst, "chi tiết danh sách bảng lương");
            this.btViewEst.Values.Image = ((System.Drawing.Image)(resources.GetObject("btViewEst.Values.Image")));
            this.btViewEst.Values.Text = "";
            this.btViewEst.Click += new System.EventHandler(this.btViewEst_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddNew.Location = new System.Drawing.Point(856, 0);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(34, 34);
            this.btAddNew.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddNew.TabIndex = 0;
            this.toolTip.SetToolTip(this.btAddNew, "Tạo mới bảng lương");
            this.btAddNew.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddNew.Values.Image")));
            this.btAddNew.Values.Text = "";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton1.Location = new System.Drawing.Point(890, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(34, 34);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.TabIndex = 1;
            this.toolTip.SetToolTip(this.kryptonButton1, "xóa bảng lương");
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(924, 34);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách Vật liệu";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // workerSalaryDTOBindingSource
            // 
            this.workerSalaryDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.WorkerSalaryDTO);
            // 
            // WorkerSalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.kryptonPanel);
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.Name = "WorkerSalaryManagement";
            this.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.Text = "Quản lý lương công nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerSalaryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerSalaryDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.BindingSource workerSalaryDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbTodate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFromdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private System.Windows.Forms.BindingSource workerSalaryDTOBindingSource1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWks;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAddNew;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewEst;
        private ToolTip toolTip;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private DataGridViewTextBoxColumn constructionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WorkersSalaryID;
        private DataGridViewTextBoxColumn constructionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}

