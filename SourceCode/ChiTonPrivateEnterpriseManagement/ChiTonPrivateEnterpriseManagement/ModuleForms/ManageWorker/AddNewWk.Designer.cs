﻿namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbManDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipManDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ipPosition = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbPosition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.kryptonPanel.Controls.Add(this.ipPosition);
            this.kryptonPanel.Controls.Add(this.lbPosition);
            this.kryptonPanel.Controls.Add(this.ipSalary);
            this.kryptonPanel.Controls.Add(this.lbSalary);
            this.kryptonPanel.Controls.Add(this.ipManDate);
            this.kryptonPanel.Controls.Add(this.lbManDate);
            this.kryptonPanel.Controls.Add(this.ipName);
            this.kryptonPanel.Controls.Add(this.lbName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(323, 260);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(3, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Values.Text = "Tên công nhân";
            // 
            // ipName
            // 
            this.ipName.Location = new System.Drawing.Point(113, 28);
            this.ipName.Name = "ipName";
            this.ipName.Size = new System.Drawing.Size(181, 22);
            this.ipName.TabIndex = 1;
            // 
            // lbManDate
            // 
            this.lbManDate.Location = new System.Drawing.Point(16, 111);
            this.lbManDate.Name = "lbManDate";
            this.lbManDate.Size = new System.Drawing.Size(72, 19);
            this.lbManDate.TabIndex = 2;
            this.lbManDate.Values.Text = "Số ngày làm ";
            // 
            // ipManDate
            // 
            this.ipManDate.Location = new System.Drawing.Point(113, 111);
            this.ipManDate.Name = "ipManDate";
            this.ipManDate.Size = new System.Drawing.Size(181, 22);
            this.ipManDate.TabIndex = 3;
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(11, 162);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(73, 19);
            this.lbSalary.TabIndex = 4;
            this.lbSalary.Values.Text = "Lương/Ngày";
            // 
            // ipSalary
            // 
            this.ipSalary.Location = new System.Drawing.Point(113, 159);
            this.ipSalary.Name = "ipSalary";
            this.ipSalary.Size = new System.Drawing.Size(181, 22);
            this.ipSalary.TabIndex = 5;
            // 
            // ipPosition
            // 
            this.ipPosition.Location = new System.Drawing.Point(113, 67);
            this.ipPosition.Name = "ipPosition";
            this.ipPosition.Size = new System.Drawing.Size(181, 22);
            this.ipPosition.TabIndex = 9;
            // 
            // lbPosition
            // 
            this.lbPosition.Location = new System.Drawing.Point(50, 70);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(34, 19);
            this.lbPosition.TabIndex = 8;
            this.lbPosition.Values.Text = "Vị trí";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(113, 206);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(47, 25);
            this.btSave.TabIndex = 10;
            this.btSave.Values.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(166, 206);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(43, 25);
            this.btClose.TabIndex = 11;
            this.btClose.Values.Text = "Đóng";
            // 
            // AddNewWk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "AddNewWk";
            this.Text = "AddNewWk";
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbPosition;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbManDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbName;
    }
}

