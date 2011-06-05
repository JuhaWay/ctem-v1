namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbxListSubcontractor = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.exitSubContainer = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.conbox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.subConstructionLablel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.newSubContainer = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.phoneInPut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PhoneLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addressInPut = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DesLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.subNameInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SubConLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.okeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NewSubConstructionRadio = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.exsiteSubconRadio = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitSubContainer)).BeginInit();
            this.exitSubContainer.Panel.SuspendLayout();
            this.exitSubContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSubContainer)).BeginInit();
            this.newSubContainer.Panel.SuspendLayout();
            this.newSubContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.lbxListSubcontractor);
            this.kryptonPanel.Controls.Add(this.exitSubContainer);
            this.kryptonPanel.Controls.Add(this.newSubContainer);
            this.kryptonPanel.Controls.Add(this.addButton);
            this.kryptonPanel.Controls.Add(this.okeButton);
            this.kryptonPanel.Controls.Add(this.NewSubConstructionRadio);
            this.kryptonPanel.Controls.Add(this.exsiteSubconRadio);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(472, 499);
            this.kryptonPanel.StateDisabled.Color1 = System.Drawing.Color.Silver;
            this.kryptonPanel.TabIndex = 0;
            // 
            // lbxListSubcontractor
            // 
            this.lbxListSubcontractor.Location = new System.Drawing.Point(79, 306);
            this.lbxListSubcontractor.Name = "lbxListSubcontractor";
            this.lbxListSubcontractor.Size = new System.Drawing.Size(331, 159);
            this.lbxListSubcontractor.TabIndex = 21;
            // 
            // exitSubContainer
            // 
            this.exitSubContainer.Enabled = false;
            this.exitSubContainer.Location = new System.Drawing.Point(79, 29);
            this.exitSubContainer.Name = "exitSubContainer";
            // 
            // exitSubContainer.Panel
            // 
            this.exitSubContainer.Panel.Controls.Add(this.conbox);
            this.exitSubContainer.Panel.Controls.Add(this.subConstructionLablel);
            this.exitSubContainer.Size = new System.Drawing.Size(331, 68);
            this.exitSubContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.exitSubContainer.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitSubContainer.TabIndex = 20;
            this.exitSubContainer.Values.Heading = "Nhà thầu có sẳn";
            // 
            // conbox
            // 
            this.conbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.conbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.conbox.DropDownWidth = 121;
            this.conbox.Enabled = false;
            this.conbox.Items.AddRange(new object[] {
            "aa",
            "bb",
            "cc",
            "dytry",
            "srestre",
            "igjghj",
            "we5w5r",
            "gfghgj"});
            this.conbox.Location = new System.Drawing.Point(125, 11);
            this.conbox.Name = "conbox";
            this.conbox.Size = new System.Drawing.Size(183, 22);
            this.conbox.TabIndex = 5;
            // 
            // subConstructionLablel
            // 
            this.subConstructionLablel.Location = new System.Drawing.Point(19, 14);
            this.subConstructionLablel.Name = "subConstructionLablel";
            this.subConstructionLablel.Size = new System.Drawing.Size(112, 19);
            this.subConstructionLablel.TabIndex = 4;
            this.subConstructionLablel.Values.Text = "Chọn nhà thầu phụ :";
            // 
            // newSubContainer
            // 
            this.newSubContainer.Enabled = false;
            this.newSubContainer.Location = new System.Drawing.Point(79, 103);
            this.newSubContainer.Name = "newSubContainer";
            // 
            // newSubContainer.Panel
            // 
            this.newSubContainer.Panel.Controls.Add(this.phoneInPut);
            this.newSubContainer.Panel.Controls.Add(this.PhoneLabel);
            this.newSubContainer.Panel.Controls.Add(this.addressInPut);
            this.newSubContainer.Panel.Controls.Add(this.DesLabel);
            this.newSubContainer.Panel.Controls.Add(this.subNameInput);
            this.newSubContainer.Panel.Controls.Add(this.SubConLabel);
            this.newSubContainer.Size = new System.Drawing.Size(328, 166);
            this.newSubContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.newSubContainer.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newSubContainer.TabIndex = 19;
            this.newSubContainer.Values.Heading = "Nhà thầu mới";
            // 
            // phoneInPut
            // 
            this.phoneInPut.Enabled = false;
            this.phoneInPut.Location = new System.Drawing.Point(125, 108);
            this.phoneInPut.Name = "phoneInPut";
            this.phoneInPut.Size = new System.Drawing.Size(183, 22);
            this.phoneInPut.TabIndex = 22;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(16, 108);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(69, 19);
            this.PhoneLabel.TabIndex = 21;
            this.PhoneLabel.Values.Text = "Điện Thoại :";
            // 
            // addressInPut
            // 
            this.addressInPut.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addressInPut.Enabled = false;
            this.addressInPut.Location = new System.Drawing.Point(125, 63);
            this.addressInPut.Multiline = true;
            this.addressInPut.Name = "addressInPut";
            this.addressInPut.Size = new System.Drawing.Size(183, 22);
            this.addressInPut.TabIndex = 17;
            // 
            // DesLabel
            // 
            this.DesLabel.Location = new System.Drawing.Point(16, 66);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(47, 19);
            this.DesLabel.TabIndex = 20;
            this.DesLabel.Values.Text = "Địa chỉ:";
            // 
            // subNameInput
            // 
            this.subNameInput.Enabled = false;
            this.subNameInput.Location = new System.Drawing.Point(125, 12);
            this.subNameInput.Name = "subNameInput";
            this.subNameInput.Size = new System.Drawing.Size(183, 22);
            this.subNameInput.TabIndex = 19;
            // 
            // SubConLabel
            // 
            this.SubConLabel.Location = new System.Drawing.Point(16, 15);
            this.SubConLabel.Name = "SubConLabel";
            this.SubConLabel.Size = new System.Drawing.Size(81, 19);
            this.SubConLabel.TabIndex = 18;
            this.SubConLabel.Values.Text = "Tên nhà thầu :";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(206, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 25);
            this.addButton.TabIndex = 17;
            this.addButton.Values.Text = "Thêm nhà thầu";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // okeButton
            // 
            this.okeButton.Location = new System.Drawing.Point(191, 471);
            this.okeButton.Name = "okeButton";
            this.okeButton.Size = new System.Drawing.Size(107, 25);
            this.okeButton.TabIndex = 7;
            this.okeButton.Values.Text = "Oke";
            this.okeButton.Click += new System.EventHandler(this.okeButton_Click);
            // 
            // NewSubConstructionRadio
            // 
            this.NewSubConstructionRadio.Location = new System.Drawing.Point(233, 12);
            this.NewSubConstructionRadio.Name = "NewSubConstructionRadio";
            this.NewSubConstructionRadio.Size = new System.Drawing.Size(110, 19);
            this.NewSubConstructionRadio.TabIndex = 3;
            this.NewSubConstructionRadio.Values.Text = "Tạo mới nhà thầu";
            this.NewSubConstructionRadio.CheckedChanged += new System.EventHandler(this.NewSubConstructionRadio_CheckedChanged);
            // 
            // exsiteSubconRadio
            // 
            this.exsiteSubconRadio.Location = new System.Drawing.Point(93, 12);
            this.exsiteSubconRadio.Name = "exsiteSubconRadio";
            this.exsiteSubconRadio.Size = new System.Drawing.Size(131, 19);
            this.exsiteSubconRadio.TabIndex = 2;
            this.exsiteSubconRadio.Values.Text = "Chọn nhà thầu có sẳn";
            this.exsiteSubconRadio.CheckedChanged += new System.EventHandler(this.exsiteSubconRadio_CheckedChanged);
            // 
            // SelectSubConstructionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 499);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSubConstructionBox";
            this.Text = "SelectSubConstructionBox";
            this.Load += new System.EventHandler(this.SelectSubConstructionBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.exitSubContainer.Panel.ResumeLayout(false);
            this.exitSubContainer.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitSubContainer)).EndInit();
            this.exitSubContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conbox)).EndInit();
            this.newSubContainer.Panel.ResumeLayout(false);
            this.newSubContainer.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSubContainer)).EndInit();
            this.newSubContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton okeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton NewSubConstructionRadio;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton exsiteSubconRadio;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox newSubContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneInPut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel PhoneLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressInPut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel DesLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox subNameInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel SubConLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox exitSubContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox conbox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel subConstructionLablel;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox lbxListSubcontractor;
    }
}

