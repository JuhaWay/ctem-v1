namespace ChiTonPrivateEnterpriseManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pnlMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.pnlMainContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.bsaLogout = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.bsaProfiles = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.hdgMenu = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnhdgMenuHideShow = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdgMenu)).BeginInit();
            this.hdgMenu.Panel.SuspendLayout();
            this.hdgMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 522);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.slcMain);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1024, 522);
            this.pnlContent.TabIndex = 4;
            // 
            // slcMain
            // 
            this.slcMain.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            this.slcMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.hdgMenu);
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.pnlMainContent);
            this.slcMain.Panel2.Controls.Add(this.kryptonHeader1);
            this.slcMain.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.slcMain.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonFormClose;
            this.slcMain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.slcMain.Size = new System.Drawing.Size(1024, 522);
            this.slcMain.SplitterDistance = 221;
            this.slcMain.TabIndex = 10;
            // 
            // tvwMenu
            // 
            this.tvwMenu.BackColor = System.Drawing.Color.White;
            this.tvwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMenu.ImageIndex = 0;
            this.tvwMenu.ImageList = this.imageListMenu;
            this.tvwMenu.Location = new System.Drawing.Point(0, 0);
            this.tvwMenu.Name = "tvwMenu";
            this.tvwMenu.SelectedImageIndex = 0;
            this.tvwMenu.Size = new System.Drawing.Size(219, 499);
            this.tvwMenu.TabIndex = 0;
            this.tvwMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMenu_NodeMouseDoubleClick);
            this.tvwMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvwMenu_KeyDown);
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "folder.jpg");
            this.imageListMenu.Images.SetKeyName(1, "itemjpg.jpg");
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 27);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(798, 495);
            this.pnlMainContent.TabIndex = 19;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.bsaLogout,
            this.bsaProfiles});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(798, 27);
            this.kryptonHeader1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonHeader1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Phần Mền Quản Lý Doanh Nghiệp Chí Tôn";
            this.kryptonHeader1.Values.Image = null;
            // 
            // bsaLogout
            // 
            this.bsaLogout.Text = "Đăng Xuất";
            this.bsaLogout.UniqueName = "ADDBFA9F0E9843B85983531566F9A5E2";
            this.bsaLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bsaProfiles
            // 
            this.bsaProfiles.Text = "Usernam (Fullname)";
            this.bsaProfiles.UniqueName = "D9B5EB8A1A494B3F5D8F8DFFBF0AE881";
            this.bsaProfiles.Click += new System.EventHandler(this.txtProfiles_LinkClicked);
            // 
            // hdgMenu
            // 
            this.hdgMenu.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnhdgMenuHideShow});
            this.hdgMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdgMenu.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorOverflow;
            this.hdgMenu.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.GridHeaderColumnList;
            this.hdgMenu.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockInactive;
            this.hdgMenu.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockInactive;
            this.hdgMenu.HeaderVisibleSecondary = false;
            this.hdgMenu.Location = new System.Drawing.Point(0, 0);
            this.hdgMenu.Name = "hdgMenu";
            // 
            // hdgMenu.Panel
            // 
            this.hdgMenu.Panel.Controls.Add(this.tvwMenu);
            this.hdgMenu.Size = new System.Drawing.Size(221, 522);
            this.hdgMenu.StateCommon.Back.Color1 = System.Drawing.Color.Olive;
            this.hdgMenu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hdgMenu.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hdgMenu.StateNormal.Back.Color2 = System.Drawing.Color.Yellow;
            this.hdgMenu.TabIndex = 2;
            this.hdgMenu.ValuesPrimary.Heading = "Menu";
            this.hdgMenu.MouseLeave += new System.EventHandler(this.hdgMenu_MouseLeave);
            this.hdgMenu.MouseHover += new System.EventHandler(this.hdgMenu_MouseHover);
            // 
            // btnhdgMenuHideShow
            // 
            this.btnhdgMenuHideShow.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.btnhdgMenuHideShow.UniqueName = "9531C247F9A54D80609B91864473DF48";
            this.btnhdgMenuHideShow.Click += new System.EventHandler(this.btnhdgMenuHideShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 522);
            this.Controls.Add(this.pnlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel2.ResumeLayout(false);
            this.slcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContent)).EndInit();
            this.hdgMenu.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgMenu)).EndInit();
            this.hdgMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlMain;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlContent;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private System.Windows.Forms.TreeView tvwMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlMainContent;
        private System.Windows.Forms.ImageList imageListMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny bsaLogout;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny bsaProfiles;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgMenu;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnhdgMenuHideShow;
    }
}

