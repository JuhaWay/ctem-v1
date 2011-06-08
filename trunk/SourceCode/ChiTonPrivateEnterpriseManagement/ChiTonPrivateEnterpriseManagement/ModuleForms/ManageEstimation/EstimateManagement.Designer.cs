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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvEstimate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.checkBox = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btViewEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btEditEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btCreateEst = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvEstimate);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(913, 534);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvEstimate
            // 
            this.dgvEstimate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox});
            this.dgvEstimate.Location = new System.Drawing.Point(0, 104);
            this.dgvEstimate.Name = "dgvEstimate";
            this.dgvEstimate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimate.Size = new System.Drawing.Size(913, 427);
            this.dgvEstimate.TabIndex = 1;
            // 
            // checkBox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBox.FalseValue = null;
            this.checkBox.HeaderText = "Column1";
            this.checkBox.IndeterminateValue = null;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = null;
            this.checkBox.Width = 50;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btViewEst);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btEditEst);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btCreateEst);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(913, 98);
            this.kryptonGroupBox1.TabIndex = 0;
            // 
            // btViewEst
            // 
            this.btViewEst.Location = new System.Drawing.Point(196, 30);
            this.btViewEst.Name = "btViewEst";
            this.btViewEst.Size = new System.Drawing.Size(78, 25);
            this.btViewEst.TabIndex = 2;
            this.btViewEst.Values.Text = "Chi tiết";
            this.btViewEst.Click += new System.EventHandler(this.btViewEst_Click);
            // 
            // btEditEst
            // 
            this.btEditEst.Location = new System.Drawing.Point(99, 30);
            this.btEditEst.Name = "btEditEst";
            this.btEditEst.Size = new System.Drawing.Size(82, 25);
            this.btEditEst.TabIndex = 1;
            this.btEditEst.Values.Text = "Sửa dự toán";
            // 
            // btCreateEst
            // 
            this.btCreateEst.Location = new System.Drawing.Point(10, 30);
            this.btCreateEst.Name = "btCreateEst";
            this.btCreateEst.Size = new System.Drawing.Size(83, 25);
            this.btCreateEst.TabIndex = 0;
            this.btCreateEst.Values.Text = "Tạo dự toán ";
            this.btCreateEst.Click += new System.EventHandler(this.btCreateEst_Click);
            // 
            // EstimateManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 534);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstimateManagement";
            this.Text = "Add New Menu";
            this.Load += new System.EventHandler(this.EstimateManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimate)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEstimate;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn checkBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btViewEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btEditEst;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btCreateEst;
    }
}