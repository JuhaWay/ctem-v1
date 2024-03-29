namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights
{
    partial class RightsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvRights = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnDeleteAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNewRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Column1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.RightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnumAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rightDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(660, 460);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.dgvRights);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 85);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(660, 375);
            this.kryptonPanel7.TabIndex = 9;
            // 
            // dgvRights
            // 
            this.dgvRights.AutoGenerateColumns = false;
            this.dgvRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.RightID,
            this.RightName,
            this.Description,
            this.Value,
            this.isActive,
            this.EnumAlias});
            this.dgvRights.DataSource = this.rightDTOBindingSource1;
            this.dgvRights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRights.Location = new System.Drawing.Point(0, 0);
            this.dgvRights.Name = "dgvRights";
            this.dgvRights.RowHeadersWidth = 25;
            this.dgvRights.Size = new System.Drawing.Size(660, 375);
            this.dgvRights.TabIndex = 0;
            this.dgvRights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRights_CellContentClick);
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 80);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonPanel6.Size = new System.Drawing.Size(660, 5);
            this.kryptonPanel6.TabIndex = 8;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 75);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(660, 5);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel4.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(660, 75);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(221, 0);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnRefresh);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(211, 75);
            this.kryptonGroupBox2.TabIndex = 7;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 27);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel3.Location = new System.Drawing.Point(216, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(5, 75);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(5, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDeleteAll);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDeleteRight);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnEditRight);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnNewRight);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(211, 75);
            this.kryptonGroupBox1.TabIndex = 5;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(151, 23);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(40, 27);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Values.Text = "Del A";
            // 
            // btnDeleteRight
            // 
            this.btnDeleteRight.Location = new System.Drawing.Point(105, 23);
            this.btnDeleteRight.Name = "btnDeleteRight";
            this.btnDeleteRight.Size = new System.Drawing.Size(40, 27);
            this.btnDeleteRight.TabIndex = 2;
            this.btnDeleteRight.Values.Text = "Del";
            this.btnDeleteRight.Click += new System.EventHandler(this.btnDeleteRight_Click);
            // 
            // btnEditRight
            // 
            this.btnEditRight.Location = new System.Drawing.Point(59, 23);
            this.btnEditRight.Name = "btnEditRight";
            this.btnEditRight.Size = new System.Drawing.Size(40, 27);
            this.btnEditRight.TabIndex = 1;
            this.btnEditRight.Values.Text = "Edit";
            this.btnEditRight.Click += new System.EventHandler(this.btnEditRight_Click);
            // 
            // btnNewRight
            // 
            this.btnNewRight.Location = new System.Drawing.Point(13, 23);
            this.btnNewRight.Name = "btnNewRight";
            this.btnNewRight.Size = new System.Drawing.Size(40, 27);
            this.btnNewRight.TabIndex = 0;
            this.btnNewRight.Values.Text = "&New";
            this.btnNewRight.Click += new System.EventHandler(this.btnNewRight_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(5, 75);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FalseValue = null;
            this.Column1.HeaderText = "";
            this.Column1.IndeterminateValue = null;
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = null;
            this.Column1.Width = 25;
            // 
            // RightID
            // 
            this.RightID.DataPropertyName = "RightID";
            this.RightID.HeaderText = "RightID";
            this.RightID.Name = "RightID";
            // 
            // RightName
            // 
            this.RightName.DataPropertyName = "RightName";
            this.RightName.HeaderText = "RightName";
            this.RightName.Name = "RightName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            // 
            // EnumAlias
            // 
            this.EnumAlias.DataPropertyName = "EnumAlias";
            this.EnumAlias.HeaderText = "EnumAlias";
            this.EnumAlias.Name = "EnumAlias";
            // 
            // rightDTOBindingSource1
            // 
            this.rightDTOBindingSource1.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RightDTO);
            // 
            // rightDTOBindingSource
            // 
            this.rightDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RightDTO);
            // 
            // RightsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "RightsManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Menu Management";
            this.TextExtra = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RightsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteRight;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditRight;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewRight;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.BindingSource rightDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvRights;
        private System.Windows.Forms.BindingSource rightDTOBindingSource1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnumAlias;
    }
}

