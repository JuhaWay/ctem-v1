namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    partial class MaterialManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipRatio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRatio = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipRU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbRU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipEU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEU = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvMaterials = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateCalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealCalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cửaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỏiĐápToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDTOBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.dgvMaterials);
            this.kryptonPanel.Controls.Add(this.menuStrip1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(840, 696);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 426);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(834, 34);
            this.kryptonPanel4.TabIndex = 6;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(834, 34);
            this.kryptonHeader2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonHeader2.TabIndex = 0;
            this.kryptonHeader2.Values.Heading = "Chi tiết";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btSave);
            this.kryptonPanel3.Controls.Add(this.ipRatio);
            this.kryptonPanel3.Controls.Add(this.lbRatio);
            this.kryptonPanel3.Controls.Add(this.ipRU);
            this.kryptonPanel3.Controls.Add(this.lbRU);
            this.kryptonPanel3.Controls.Add(this.ipEU);
            this.kryptonPanel3.Controls.Add(this.lbEU);
            this.kryptonPanel3.Controls.Add(this.ipName);
            this.kryptonPanel3.Controls.Add(this.lbName);
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 453);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(834, 229);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.kryptonPanel3.TabIndex = 5;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(383, 184);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(59, 27);
            this.btSave.TabIndex = 22;
            this.btSave.Values.Text = "Cập nhật";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipRatio
            // 
            this.ipRatio.Location = new System.Drawing.Point(385, 154);
            this.ipRatio.Name = "ipRatio";
            this.ipRatio.Size = new System.Drawing.Size(161, 20);
            this.ipRatio.TabIndex = 21;
            // 
            // lbRatio
            // 
            this.lbRatio.Location = new System.Drawing.Point(293, 154);
            this.lbRatio.Name = "lbRatio";
            this.lbRatio.Size = new System.Drawing.Size(89, 20);
            this.lbRatio.TabIndex = 20;
            this.lbRatio.Values.Text = "Chỉ số quy đổi";
            // 
            // ipRU
            // 
            this.ipRU.Location = new System.Drawing.Point(384, 109);
            this.ipRU.Name = "ipRU";
            this.ipRU.Size = new System.Drawing.Size(162, 20);
            this.ipRU.TabIndex = 19;
            // 
            // lbRU
            // 
            this.lbRU.Location = new System.Drawing.Point(278, 109);
            this.lbRU.Name = "lbRU";
            this.lbRU.Size = new System.Drawing.Size(108, 20);
            this.lbRU.TabIndex = 18;
            this.lbRU.Values.Text = "Đơn vị quyết toán";
            // 
            // ipEU
            // 
            this.ipEU.Location = new System.Drawing.Point(383, 67);
            this.ipEU.Name = "ipEU";
            this.ipEU.Size = new System.Drawing.Size(162, 20);
            this.ipEU.TabIndex = 17;
            // 
            // lbEU
            // 
            this.lbEU.Location = new System.Drawing.Point(293, 67);
            this.lbEU.Name = "lbEU";
            this.lbEU.Size = new System.Drawing.Size(92, 20);
            this.lbEU.TabIndex = 16;
            this.lbEU.Values.Text = "Đơn vị dự toán";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(383, 24);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(162, 20);
            this.ipName.TabIndex = 13;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(309, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(73, 20);
            this.lbName.TabIndex = 12;
            this.lbName.Values.Text = "Tên vật liệu";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.btAddNew);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 29);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonPanel2.Size = new System.Drawing.Size(831, 58);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonPanel2.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(63, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(54, 52);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton1.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "Delete";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(3, 3);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(54, 52);
            this.btAddNew.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btAddNew.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btAddNew.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddNew.TabIndex = 0;
            this.btAddNew.Values.Image = ((System.Drawing.Image)(resources.GetObject("btAddNew.Values.Image")));
            this.btAddNew.Values.Text = "Tạo mới";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 94);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(834, 37);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(834, 37);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Danh sách Vật liệu";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AutoGenerateColumns = false;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.MaterialID,
            this.MaterialName,
            this.MaterialParentID,
            this.EstimateCalUnit,
            this.RealCalUnit,
            this.Ratio});
            this.dgvMaterials.DataSource = this.materialDTOBindingSource;
            this.dgvMaterials.Location = new System.Drawing.Point(0, 127);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(834, 293);
            this.dgvMaterials.StateNormal.Background.Color1 = System.Drawing.Color.White;
            this.dgvMaterials.TabIndex = 0;
            this.dgvMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterials_CellContentClick);
            this.dgvMaterials.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMaterials_MouseClick);
            // 
            // checkBox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.HeaderText = "";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 50;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.Visible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Tên vật liệu";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Width = 300;
            // 
            // MaterialParentID
            // 
            this.MaterialParentID.DataPropertyName = "MaterialParentID";
            this.MaterialParentID.HeaderText = "Vật liệu cha";
            this.MaterialParentID.Name = "MaterialParentID";
            this.MaterialParentID.Visible = false;
            this.MaterialParentID.Width = 200;
            // 
            // EstimateCalUnit
            // 
            this.EstimateCalUnit.DataPropertyName = "EstimateCalUnit";
            this.EstimateCalUnit.HeaderText = "Đơn vị dự toán";
            this.EstimateCalUnit.Name = "EstimateCalUnit";
            this.EstimateCalUnit.Width = 150;
            // 
            // RealCalUnit
            // 
            this.RealCalUnit.DataPropertyName = "RealCalUnit";
            this.RealCalUnit.HeaderText = "Đơn vị quyết toán";
            this.RealCalUnit.Name = "RealCalUnit";
            this.RealCalUnit.Width = 150;
            // 
            // Ratio
            // 
            this.Ratio.DataPropertyName = "Ratio";
            this.Ratio.HeaderText = "Chỉ số quy đổi";
            this.Ratio.Name = "Ratio";
            this.Ratio.Width = 150;
            // 
            // materialDTOBindingSource
            // 
            this.materialDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.MaterialDTO);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cửaSổToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cửaSổToolStripMenuItem
            // 
            this.cửaSổToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngToolStripMenuItem});
            this.cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            this.cửaSổToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.đóngToolStripMenuItem.Text = "Đóng";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỏiĐápToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin ";
            // 
            // hỏiĐápToolStripMenuItem
            // 
            this.hỏiĐápToolStripMenuItem.Name = "hỏiĐápToolStripMenuItem";
            this.hỏiĐápToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.hỏiĐápToolStripMenuItem.Text = "Hỏi đáp";
            // 
            // MaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 696);
            this.Controls.Add(this.kryptonPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaterialManagement";
            this.Text = "MaterialManagement";
            this.Load += new System.EventHandler(this.MaterialManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDTOBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvMaterials;
        private System.Windows.Forms.BindingSource materialDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cửaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỏiĐápToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRatio;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipRU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbRU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEU;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateCalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealCalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
    }
}

