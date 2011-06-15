namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    partial class NewWarehouse
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
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbConstruction = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNameManager = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtWarehouseName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnClose);
            this.kryptonPanel.Controls.Add(this.btnSave);
            this.kryptonPanel.Controls.Add(this.cbbStatus);
            this.kryptonPanel.Controls.Add(this.cbbConstruction);
            this.kryptonPanel.Controls.Add(this.cbbType);
            this.kryptonPanel.Controls.Add(this.txtDescription);
            this.kryptonPanel.Controls.Add(this.txtAddress);
            this.kryptonPanel.Controls.Add(this.txtNameManager);
            this.kryptonPanel.Controls.Add(this.txtWarehouseName);
            this.kryptonPanel.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(460, 472);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(303, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Đóng";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 15;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownWidth = 218;
            this.cbbStatus.Location = new System.Drawing.Point(142, 278);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(251, 21);
            this.cbbStatus.TabIndex = 14;
            // 
            // cbbConstruction
            // 
            this.cbbConstruction.DropDownWidth = 218;
            this.cbbConstruction.Location = new System.Drawing.Point(142, 123);
            this.cbbConstruction.Name = "cbbConstruction";
            this.cbbConstruction.Size = new System.Drawing.Size(251, 21);
            this.cbbConstruction.TabIndex = 13;
            // 
            // cbbType
            // 
            this.cbbType.DropDownWidth = 251;
            this.cbbType.Location = new System.Drawing.Point(142, 96);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(251, 21);
            this.cbbType.TabIndex = 12;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(142, 304);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 99);
            this.txtDescription.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(142, 176);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 99);
            this.txtAddress.TabIndex = 10;
            // 
            // txtNameManager
            // 
            this.txtNameManager.Location = new System.Drawing.Point(142, 150);
            this.txtNameManager.Name = "txtNameManager";
            this.txtNameManager.Size = new System.Drawing.Size(251, 20);
            this.txtNameManager.TabIndex = 9;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(142, 70);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(251, 20);
            this.txtWarehouseName.TabIndex = 7;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(82, 304);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "Ghi Chú";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(67, 278);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "Tình Trạng";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(87, 176);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Địa Chỉ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(44, 150);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Ngoài Quản Lý";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(65, 124);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Công Trình";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(103, 98);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Loại";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(81, 72);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tên Kho";
            // 
            // NewWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "NewWarehouse";
            this.Text = "NewWarehouse";
            this.Load += new System.EventHandler(this.NewWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtWarehouseName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNameManager;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbConstruction;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
    }
}

