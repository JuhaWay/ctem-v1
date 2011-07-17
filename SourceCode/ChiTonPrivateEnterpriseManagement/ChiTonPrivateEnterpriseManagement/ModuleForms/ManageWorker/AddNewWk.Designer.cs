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
            this.ipSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipManDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbManDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.ipSalary);
            this.pnMain.Controls.Add(this.lbSalary);
            this.pnMain.Controls.Add(this.ipManDate);
            this.pnMain.Controls.Add(this.lbManDate);
            this.pnMain.Controls.Add(this.ipPosition);
            this.pnMain.Controls.Add(this.lbPosition);
            this.pnMain.Controls.Add(this.ipName);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Controls.Add(this.btSave);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(323, 260);
            this.pnMain.TabIndex = 0;
            // 
            // ipSalary
            // 
            this.ipSalary.Location = new System.Drawing.Point(122, 152);
            this.ipSalary.Name = "ipSalary";
            this.ipSalary.Size = new System.Drawing.Size(181, 22);
            this.ipSalary.TabIndex = 4;
            this.ipSalary.Leave += new System.EventHandler(this.ipSalary_Leave);
            this.ipSalary.MouseLeave += new System.EventHandler(this.ipSalary_MouseLeave);
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(13, 152);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(103, 19);
            this.lbSalary.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbSalary.TabIndex = 22;
            this.lbSalary.Values.Text = "Lương/Ngày(VND)";
            // 
            // ipManDate
            // 
            this.ipManDate.Location = new System.Drawing.Point(122, 117);
            this.ipManDate.Name = "ipManDate";
            this.ipManDate.Size = new System.Drawing.Size(181, 22);
            this.ipManDate.TabIndex = 3;
            // 
            // lbManDate
            // 
            this.lbManDate.Location = new System.Drawing.Point(34, 117);
            this.lbManDate.Name = "lbManDate";
            this.lbManDate.Size = new System.Drawing.Size(72, 19);
            this.lbManDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbManDate.TabIndex = 20;
            this.lbManDate.Values.Text = "Số ngày làm ";
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
            this.btClose.Location = new System.Drawing.Point(166, 206);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(43, 25);
            this.btClose.TabIndex = 6;
            this.btClose.Values.Text = "Đóng";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(113, 206);
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
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.pnMain);
            this.Name = "AddNewWk";
            this.ShowIcon = false;
            this.Text = "Tạo mới công nhân";
            this.Load += new System.EventHandler(this.AddNewWk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
    }
}

