namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class EstimateManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btViewEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btEditEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btCreateEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btViewDetail = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvEstimate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ipEstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbEstName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbSearchCons = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbCons = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipSeacrchName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSearchName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.estimateDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.EstimateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstructionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btViewEst
            // 
            resources.ApplyResources(this.btViewEst, "btViewEst");
            this.btViewEst.Name = "btViewEst";
            this.btViewEst.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolTip1.SetToolTip(this.btViewEst, resources.GetString("btViewEst.ToolTip"));
            this.btViewEst.Values.Image = ((System.Drawing.Image)(resources.GetObject("btViewEst.Values.Image")));
            this.btViewEst.Values.Text = resources.GetString("btViewEst.Values.Text");
            this.btViewEst.Click += new System.EventHandler(this.btViewEst_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btEditEst);
            this.kryptonPanel1.Controls.Add(this.btCreateEst);
            this.kryptonPanel1.Controls.Add(this.btDelete);
            this.kryptonPanel1.Controls.Add(this.btViewEst);
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            resources.ApplyResources(this.kryptonPanel1, "kryptonPanel1");
            this.kryptonPanel1.Name = "kryptonPanel1";
            // 
            // btEditEst
            // 
            resources.ApplyResources(this.btEditEst, "btEditEst");
            this.btEditEst.Name = "btEditEst";
            this.btEditEst.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEditEst.Values.Image = ((System.Drawing.Image)(resources.GetObject("btEditEst.Values.Image")));
            this.btEditEst.Values.Text = resources.GetString("btEditEst.Values.Text");
            // 
            // btCreateEst
            // 
            resources.ApplyResources(this.btCreateEst, "btCreateEst");
            this.btCreateEst.Name = "btCreateEst";
            this.btCreateEst.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreateEst.Values.Image = ((System.Drawing.Image)(resources.GetObject("btCreateEst.Values.Image")));
            this.btCreateEst.Values.Text = resources.GetString("btCreateEst.Values.Text");
            this.btCreateEst.Click += new System.EventHandler(this.btCreateEst_Click);
            // 
            // btDelete
            // 
            resources.ApplyResources(this.btDelete, "btDelete");
            this.btDelete.Name = "btDelete";
            this.btDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Values.Image")));
            this.btDelete.Values.Text = resources.GetString("btDelete.Values.Text");
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btViewDetail});
            resources.ApplyResources(this.kryptonHeader1, "kryptonHeader1");
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Values.Description = resources.GetString("kryptonHeader1.Values.Description");
            this.kryptonHeader1.Values.Heading = resources.GetString("kryptonHeader1.Values.Heading");
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // btViewDetail
            // 
            this.btViewDetail.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.icon1;
            resources.ApplyResources(this.btViewDetail, "btViewDetail");
            this.btViewDetail.UniqueName = "36F29E5DC3BE45B37CB495AF10A75523";
            this.btViewDetail.Click += new System.EventHandler(this.btViewDetail_Click);
            // 
            // dgvEstimate
            // 
            this.dgvEstimate.AutoGenerateColumns = false;
            this.dgvEstimate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.EstimateID,
            this.ConstructionName,
            this.EstimateName,
            this.TotalCostEstimate,
            this.CreatedBy,
            this.UpdatedBy,
            this.CreatedDate,
            this.UpdatedDate});
            this.dgvEstimate.DataSource = this.estimateDTOBindingSource;
            resources.ApplyResources(this.dgvEstimate, "dgvEstimate");
            this.dgvEstimate.Name = "dgvEstimate";
            this.dgvEstimate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimate.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvEstimate.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEstimate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimate_CellContentClick);
            this.dgvEstimate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvEstimate_Scroll);
            this.dgvEstimate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstimate_MouseClick);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonHeader2);
            resources.ApplyResources(this.kryptonPanel4, "kryptonPanel4");
            this.kryptonPanel4.Name = "kryptonPanel4";
            // 
            // kryptonHeader2
            // 
            resources.ApplyResources(this.kryptonHeader2, "kryptonHeader2");
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonHeader2.Values.Description = resources.GetString("kryptonHeader2.Values.Description");
            this.kryptonHeader2.Values.Heading = resources.GetString("kryptonHeader2.Values.Heading");
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // kryptonGroupBox2
            // 
            resources.ApplyResources(this.kryptonGroupBox2, "kryptonGroupBox2");
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btSave);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ipEstName);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbEstName);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.Values.Heading = resources.GetString("kryptonGroupBox2.Values.Heading");
            // 
            // btSave
            // 
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.Name = "btSave";
            this.btSave.Values.Text = resources.GetString("btSave.Values.Text");
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ipEstName
            // 
            resources.ApplyResources(this.ipEstName, "ipEstName");
            this.ipEstName.Name = "ipEstName";
            // 
            // lbEstName
            // 
            resources.ApplyResources(this.lbEstName, "lbEstName");
            this.lbEstName.Name = "lbEstName";
            this.lbEstName.Values.Text = resources.GetString("lbEstName.Values.Text");
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.dgvEstimate);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            resources.ApplyResources(this.kryptonPanel, "kryptonPanel");
            this.kryptonPanel.Name = "kryptonPanel";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btSearch);
            this.kryptonPanel2.Controls.Add(this.cbSearchCons);
            this.kryptonPanel2.Controls.Add(this.lbCons);
            this.kryptonPanel2.Controls.Add(this.ipSeacrchName);
            this.kryptonPanel2.Controls.Add(this.lbSearchName);
            resources.ApplyResources(this.kryptonPanel2, "kryptonPanel2");
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Khaki;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            // 
            // btSearch
            // 
            resources.ApplyResources(this.btSearch, "btSearch");
            this.btSearch.Name = "btSearch";
            this.btSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.Values.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.th_search_icon_16x16;
            this.btSearch.Values.Text = resources.GetString("btSearch.Values.Text");
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbSearchCons
            // 
            this.cbSearchCons.DropDownWidth = 146;
            resources.ApplyResources(this.cbSearchCons, "cbSearchCons");
            this.cbSearchCons.Name = "cbSearchCons";
            // 
            // lbCons
            // 
            resources.ApplyResources(this.lbCons, "lbCons");
            this.lbCons.Name = "lbCons";
            this.lbCons.Values.Text = resources.GetString("lbCons.Values.Text");
            // 
            // ipSeacrchName
            // 
            resources.ApplyResources(this.ipSeacrchName, "ipSeacrchName");
            this.ipSeacrchName.Name = "ipSeacrchName";
            // 
            // lbSearchName
            // 
            resources.ApplyResources(this.lbSearchName, "lbSearchName");
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Values.Text = resources.GetString("lbSearchName.Values.Text");
            // 
            // estimateDTOBindingSource
            // 
            this.estimateDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EstimateDTO);
            // 
            // checkBox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            resources.ApplyResources(this.checkBox, "checkBox");
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            // 
            // EstimateID
            // 
            this.EstimateID.DataPropertyName = "EstimateID";
            resources.ApplyResources(this.EstimateID, "EstimateID");
            this.EstimateID.Name = "EstimateID";
            // 
            // ConstructionName
            // 
            this.ConstructionName.DataPropertyName = "ConstructionName";
            resources.ApplyResources(this.ConstructionName, "ConstructionName");
            this.ConstructionName.Name = "ConstructionName";
            // 
            // EstimateName
            // 
            this.EstimateName.DataPropertyName = "EstimateName";
            resources.ApplyResources(this.EstimateName, "EstimateName");
            this.EstimateName.Name = "EstimateName";
            // 
            // TotalCostEstimate
            // 
            this.TotalCostEstimate.DataPropertyName = "TotalCostEstimate";
            resources.ApplyResources(this.TotalCostEstimate, "TotalCostEstimate");
            this.TotalCostEstimate.Name = "TotalCostEstimate";
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            resources.ApplyResources(this.CreatedBy, "CreatedBy");
            this.CreatedBy.Name = "CreatedBy";
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            resources.ApplyResources(this.UpdatedBy, "UpdatedBy");
            this.UpdatedBy.Name = "UpdatedBy";
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            resources.ApplyResources(this.CreatedDate, "CreatedDate");
            this.CreatedDate.Name = "CreatedDate";
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.DataPropertyName = "UpdatedDate";
            resources.ApplyResources(this.UpdatedDate, "UpdatedDate");
            this.UpdatedDate.Name = "UpdatedDate";
            // 
            // EstimateManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EstimateManagement";
            this.Load += new System.EventHandler(this.EstimateManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimateDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btEditEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCreateEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewEst;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipEstName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbEstName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btViewDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbSearchCons;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbCons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSeacrchName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSearchName;
        private System.Windows.Forms.BindingSource estimateDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstructionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
    }
}