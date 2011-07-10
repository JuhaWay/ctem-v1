namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger
{
    partial class LedgerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedgerManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbMethod = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbMethod = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipReason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbReason = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPerson = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPerson = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvLedger = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ledgerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipSearchNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipSearchName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbSearchCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkbox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.LedgerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.dgvLedger);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(766, 615);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 371);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonPanel3);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(766, 257);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonGroupBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.TabIndex = 13;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btSave);
            this.kryptonPanel3.Controls.Add(this.dtDate);
            this.kryptonPanel3.Controls.Add(this.lbDate);
            this.kryptonPanel3.Controls.Add(this.cbMethod);
            this.kryptonPanel3.Controls.Add(this.lbMethod);
            this.kryptonPanel3.Controls.Add(this.ipReason);
            this.kryptonPanel3.Controls.Add(this.lbReason);
            this.kryptonPanel3.Controls.Add(this.ipPerson);
            this.kryptonPanel3.Controls.Add(this.lbPerson);
            this.kryptonPanel3.Controls.Add(this.ipNumber);
            this.kryptonPanel3.Controls.Add(this.lbNumber);
            this.kryptonPanel3.Controls.Add(this.cbType);
            this.kryptonPanel3.Controls.Add(this.lbType);
            this.kryptonPanel3.Controls.Add(this.ipName);
            this.kryptonPanel3.Controls.Add(this.lbName);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(762, 251);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.Khaki;
            this.kryptonPanel3.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.kryptonPanel3.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(368, 193);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(55, 25);
            this.btSave.TabIndex = 30;
            this.btSave.Values.Text = "Cập nhật";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(290, 151);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(175, 20);
            this.dtDate.TabIndex = 29;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(242, 152);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(37, 19);
            this.lbDate.TabIndex = 28;
            this.lbDate.Values.Text = "Ngày";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownWidth = 175;
            this.cbMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoảng"});
            this.cbMethod.Location = new System.Drawing.Point(531, 107);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(175, 22);
            this.cbMethod.TabIndex = 27;
            this.cbMethod.Text = "chọn...";
            // 
            // lbMethod
            // 
            this.lbMethod.Location = new System.Drawing.Point(471, 110);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(59, 19);
            this.lbMethod.TabIndex = 26;
            this.lbMethod.Values.Text = "Hình thức";
            // 
            // ipReason
            // 
            this.ipReason.Location = new System.Drawing.Point(290, 110);
            this.ipReason.Name = "ipReason";
            this.ipReason.Size = new System.Drawing.Size(175, 22);
            this.ipReason.TabIndex = 25;
            // 
            // lbReason
            // 
            this.lbReason.Location = new System.Drawing.Point(242, 110);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(37, 19);
            this.lbReason.TabIndex = 24;
            this.lbReason.Values.Text = "Lý do";
            // 
            // ipPerson
            // 
            this.ipPerson.Location = new System.Drawing.Point(531, 71);
            this.ipPerson.Name = "ipPerson";
            this.ipPerson.Size = new System.Drawing.Size(175, 22);
            this.ipPerson.TabIndex = 23;
            // 
            // lbPerson
            // 
            this.lbPerson.Location = new System.Drawing.Point(471, 71);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(48, 19);
            this.lbPerson.TabIndex = 22;
            this.lbPerson.Values.Text = "Chi cho";
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(290, 71);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(175, 22);
            this.ipNumber.TabIndex = 21;
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(210, 74);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(78, 19);
            this.lbNumber.TabIndex = 20;
            this.lbNumber.Values.Text = "Số tiền (VND)";
            // 
            // cbType
            // 
            this.cbType.DropDownWidth = 175;
            this.cbType.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbType.Location = new System.Drawing.Point(531, 28);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(175, 22);
            this.cbType.TabIndex = 19;
            this.cbType.Text = "chọn...";
            // 
            // lbType
            // 
            this.lbType.Location = new System.Drawing.Point(488, 31);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 19);
            this.lbType.TabIndex = 18;
            this.lbType.Values.Text = "Loại";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(290, 31);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(175, 22);
            this.ipName.TabIndex = 17;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(251, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 19);
            this.lbName.TabIndex = 16;
            this.lbName.Values.Text = "Tên";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 337);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(766, 34);
            this.kryptonPanel2.TabIndex = 12;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(766, 34);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Chi tiết";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // dgvLedger
            // 
            this.dgvLedger.AutoGenerateColumns = false;
            this.dgvLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.LedgerID,
            this.Name,
            this.Type,
            this.Number,
            this.Person,
            this.Reason,
            this.Method,
            this.Date});
            this.dgvLedger.DataSource = this.ledgerDTOBindingSource;
            this.dgvLedger.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLedger.Location = new System.Drawing.Point(0, 75);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedger.Size = new System.Drawing.Size(766, 262);
            this.dgvLedger.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvLedger.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvLedger.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCenter;
            this.dgvLedger.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLedger.TabIndex = 11;
            this.dgvLedger.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLedger_MouseClick);
            // 
            // ledgerDTOBindingSource
            // 
            this.ledgerDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.LedgerDTO);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btAddNew);
            this.kryptonPanel4.Controls.Add(this.btDelete);
            this.kryptonPanel4.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 41);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(766, 34);
            this.kryptonPanel4.TabIndex = 10;
            // 
            // btAddNew
            // 
            this.btAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddNew.Location = new System.Drawing.Point(698, 0);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(34, 34);
            this.btAddNew.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddNew.TabIndex = 12;
            this.btAddNew.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddNew.Values.Image")));
            this.btAddNew.Values.Text = "";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDelete.Location = new System.Drawing.Point(732, 0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(34, 34);
            this.btDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDelete.TabIndex = 13;
            this.btDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Values.Image")));
            this.btDelete.Values.Text = "";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(766, 34);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Danh sách";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.btSearch);
            this.kryptonPanel1.Controls.Add(this.ipSearchNumber);
            this.kryptonPanel1.Controls.Add(this.ipSearchName);
            this.kryptonPanel1.Controls.Add(this.cbSearchCons);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(766, 41);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassNormalSimple;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(191, 13);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 19);
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "Biển số";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 19);
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Tên xe";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(644, 6);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(44, 32);
            this.btSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.TabIndex = 8;
            this.btSearch.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.th_search_icon_16x16;
            this.btSearch.Values.Text = "";
            // 
            // ipSearchNumber
            // 
            this.ipSearchNumber.Location = new System.Drawing.Point(253, 12);
            this.ipSearchNumber.Name = "ipSearchNumber";
            this.ipSearchNumber.Size = new System.Drawing.Size(145, 22);
            this.ipSearchNumber.TabIndex = 7;
            // 
            // ipSearchName
            // 
            this.ipSearchName.Location = new System.Drawing.Point(65, 12);
            this.ipSearchName.Name = "ipSearchName";
            this.ipSearchName.Size = new System.Drawing.Size(120, 22);
            this.ipSearchName.TabIndex = 6;
            // 
            // cbSearchCons
            // 
            this.cbSearchCons.DropDownWidth = 139;
            this.cbSearchCons.Location = new System.Drawing.Point(473, 12);
            this.cbSearchCons.Name = "cbSearchCons";
            this.cbSearchCons.Size = new System.Drawing.Size(139, 22);
            this.cbSearchCons.TabIndex = 5;
            this.cbSearchCons.Text = "chọn...";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(404, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(63, 19);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Công trình";
            // 
            // checkbox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkbox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkbox.FalseValue = null;
            this.checkbox.HeaderText = "";
            this.checkbox.IndeterminateValue = null;
            this.checkbox.Name = "checkbox";
            this.checkbox.TrueValue = null;
            this.checkbox.Width = 50;
            // 
            // LedgerID
            // 
            this.LedgerID.DataPropertyName = "LedgerID";
            this.LedgerID.HeaderText = "LedgerID";
            this.LedgerID.Name = "LedgerID";
            this.LedgerID.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên";
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại";
            this.Type.Name = "Type";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số tiền";
            this.Number.Name = "Number";
            // 
            // Person
            // 
            this.Person.DataPropertyName = "Person";
            this.Person.HeaderText = "chi cho ai";
            this.Person.Name = "Person";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "lí do";
            this.Reason.Name = "Reason";
            // 
            // Method
            // 
            this.Method.DataPropertyName = "Method";
            this.Method.HeaderText = "cách thức";
            this.Method.Name = "Method";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày chi";
            this.Date.Name = "Date";
            // 
            // LedgerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 615);
            this.Controls.Add(this.kryptonPanel);
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.Text = "LedgerManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LedgerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSearchNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSearchName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSearchCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLedger;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.BindingSource ledgerDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbMethod;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipReason;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbReason;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPerson;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPerson;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

