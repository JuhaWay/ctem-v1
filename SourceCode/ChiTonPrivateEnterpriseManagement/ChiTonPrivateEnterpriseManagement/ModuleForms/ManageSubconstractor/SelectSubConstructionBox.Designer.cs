namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageSubconstractor
{
    partial class SelectSubConstructionBox
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
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.phoneInPut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PhoneLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addressInPut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DesLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.subNameInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SubConLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.kryptonLabel1);
            this.pnMain.Controls.Add(this.phoneInPut);
            this.pnMain.Controls.Add(this.PhoneLabel);
            this.pnMain.Controls.Add(this.addressInPut);
            this.pnMain.Controls.Add(this.DesLabel);
            this.pnMain.Controls.Add(this.subNameInput);
            this.pnMain.Controls.Add(this.SubConLabel);
            this.pnMain.Controls.Add(this.addButton);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(472, 233);
            this.pnMain.StateDisabled.Color1 = System.Drawing.Color.Silver;
            this.pnMain.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 185);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 25);
            this.addButton.TabIndex = 17;
            this.addButton.Values.Text = "Thêm nhà thầu";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // phoneInPut
            // 
            this.phoneInPut.Location = new System.Drawing.Point(159, 132);
            this.phoneInPut.Name = "phoneInPut";
            this.phoneInPut.Size = new System.Drawing.Size(244, 22);
            this.phoneInPut.TabIndex = 28;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(50, 132);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(74, 16);
            this.PhoneLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.PhoneLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.TabIndex = 27;
            this.PhoneLabel.Values.Text = "Điện Thoại :";
            // 
            // addressInPut
            // 
            this.addressInPut.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addressInPut.Location = new System.Drawing.Point(159, 87);
            this.addressInPut.Multiline = true;
            this.addressInPut.Name = "addressInPut";
            this.addressInPut.Size = new System.Drawing.Size(244, 22);
            this.addressInPut.TabIndex = 23;
            // 
            // DesLabel
            // 
            this.DesLabel.Location = new System.Drawing.Point(50, 90);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(50, 16);
            this.DesLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.DesLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLabel.TabIndex = 26;
            this.DesLabel.Values.Text = "Địa chỉ:";
            // 
            // subNameInput
            // 
            this.subNameInput.Location = new System.Drawing.Point(159, 36);
            this.subNameInput.Name = "subNameInput";
            this.subNameInput.Size = new System.Drawing.Size(244, 22);
            this.subNameInput.TabIndex = 25;
            // 
            // SubConLabel
            // 
            this.SubConLabel.Location = new System.Drawing.Point(50, 39);
            this.SubConLabel.Name = "SubConLabel";
            this.SubConLabel.Size = new System.Drawing.Size(92, 16);
            this.SubConLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.SubConLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubConLabel.TabIndex = 24;
            this.SubConLabel.Values.Text = "Tên nhà thầu(*)";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 202);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 19);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 29;
            this.kryptonLabel1.Values.Text = "(*) trường bắt buộc";
            // 
            // SelectSubConstructionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 233);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSubConstructionBox";
            this.ShowIcon = false;
            this.Text = "Tạo nhà thầu phụ";
            this.Load += new System.EventHandler(this.SelectSubConstructionBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneInPut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel PhoneLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressInPut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel DesLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox subNameInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel SubConLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

