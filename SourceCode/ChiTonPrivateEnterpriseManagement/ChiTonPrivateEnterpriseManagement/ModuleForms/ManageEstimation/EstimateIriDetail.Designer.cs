namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    partial class EstimateIriDetail
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipWeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipLength = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipHoles = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbHole = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipNote = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbNote = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btClose);
            this.kryptonPanel.Controls.Add(this.btSave);
            this.kryptonPanel.Controls.Add(this.ipNote);
            this.kryptonPanel.Controls.Add(this.lbNote);
            this.kryptonPanel.Controls.Add(this.ipHoles);
            this.kryptonPanel.Controls.Add(this.lbHole);
            this.kryptonPanel.Controls.Add(this.ipLength);
            this.kryptonPanel.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel.Controls.Add(this.ipNumber);
            this.kryptonPanel.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel.Controls.Add(this.ipWeight);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(366, 219);
            this.kryptonPanel.StateCommon.Color1 = System.Drawing.SystemColors.HotTrack;
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 37);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Khối lượng(m3)";
            // 
            // ipWeight
            // 
            this.ipWeight.Location = new System.Drawing.Point(100, 34);
            this.ipWeight.Name = "ipWeight";
            this.ipWeight.Size = new System.Drawing.Size(243, 22);
            this.ipWeight.TabIndex = 1;
            // 
            // ipNumber
            // 
            this.ipNumber.Location = new System.Drawing.Point(100, 9);
            this.ipNumber.Name = "ipNumber";
            this.ipNumber.Size = new System.Drawing.Size(243, 22);
            this.ipNumber.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 19);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Target = this.kryptonLabel2;
            this.kryptonLabel2.Values.Text = "Số tiền(VND)(*)";
            // 
            // ipLength
            // 
            this.ipLength.Location = new System.Drawing.Point(100, 59);
            this.ipLength.Name = "ipLength";
            this.ipLength.Size = new System.Drawing.Size(243, 22);
            this.ipLength.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 62);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(74, 19);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Chiều dài(m)";
            // 
            // ipHoles
            // 
            this.ipHoles.Location = new System.Drawing.Point(100, 87);
            this.ipHoles.Name = "ipHoles";
            this.ipHoles.Size = new System.Drawing.Size(243, 22);
            this.ipHoles.TabIndex = 7;
            // 
            // lbHole
            // 
            this.lbHole.Location = new System.Drawing.Point(45, 90);
            this.lbHole.Name = "lbHole";
            this.lbHole.Size = new System.Drawing.Size(39, 19);
            this.lbHole.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbHole.TabIndex = 6;
            this.lbHole.Values.Text = "Số bể";
            // 
            // ipNote
            // 
            this.ipNote.Location = new System.Drawing.Point(100, 112);
            this.ipNote.Multiline = true;
            this.ipNote.Name = "ipNote";
            this.ipNote.Size = new System.Drawing.Size(243, 52);
            this.ipNote.TabIndex = 9;
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(35, 115);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(48, 19);
            this.lbNote.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbNote.TabIndex = 8;
            this.lbNote.Values.Text = "Ghi chú";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(100, 182);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(60, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(166, 182);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(60, 25);
            this.btClose.TabIndex = 11;
            this.btClose.Values.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // EstimateIriDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 219);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "EstimateIriDetail";
            this.ShowIcon = false;
            this.Text = "Dự toán thủy lợi";
            this.Load += new System.EventHandler(this.EstimateIriDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNote;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbNote;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipHoles;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbHole;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipLength;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

