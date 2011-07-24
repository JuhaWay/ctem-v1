namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    partial class DayWorkingForm
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvWD = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dayWorkingDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayWorkingDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvWD);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(315, 287);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvWD
            // 
            this.dgvWD.AutoGenerateColumns = false;
            this.dgvWD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateFormatedDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgvWD.DataSource = this.dayWorkingDTOBindingSource;
            this.dgvWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWD.Location = new System.Drawing.Point(0, 0);
            this.dgvWD.Name = "dgvWD";
            this.dgvWD.Size = new System.Drawing.Size(315, 287);
            this.dgvWD.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvWD.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvWD.TabIndex = 24;
            // 
            // dayWorkingDTOBindingSource
            // 
            this.dayWorkingDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.DayWorkingDTO);
            // 
            // dateFormatedDataGridViewTextBoxColumn
            // 
            this.dateFormatedDataGridViewTextBoxColumn.DataPropertyName = "DateFormated";
            this.dateFormatedDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.dateFormatedDataGridViewTextBoxColumn.Name = "dateFormatedDataGridViewTextBoxColumn";
            this.dateFormatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 150;
            // 
            // DayWorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 287);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "DayWorkingForm";
            this.ShowIcon = false;
            this.Text = "Chi tiết ngày lương";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayWorkingDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dayWorkingDTOBindingSource;
    }
}

