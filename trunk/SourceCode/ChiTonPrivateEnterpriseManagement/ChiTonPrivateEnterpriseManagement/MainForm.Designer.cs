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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.hdgMenu = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnhdgMenuHideShow = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.pnlLineLeft = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlMainContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlLineBot = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlLineMid = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlMainMenu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlLineTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlLineRight = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.hdgMenu)).BeginInit();
            this.hdgMenu.Panel.SuspendLayout();
            this.hdgMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContent)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineRight)).BeginInit();
            this.SuspendLayout();
            // 
            // hdgMenu
            // 
            this.hdgMenu.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnhdgMenuHideShow});
            this.hdgMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.hdgMenu.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorOverflow;
            this.hdgMenu.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.GridHeaderColumnList;
            this.hdgMenu.HeaderVisibleSecondary = false;
            this.hdgMenu.Location = new System.Drawing.Point(0, 0);
            this.hdgMenu.Name = "hdgMenu";
            // 
            // hdgMenu.Panel
            // 
            this.hdgMenu.Panel.Controls.Add(this.tvwMenu);
            this.hdgMenu.Size = new System.Drawing.Size(200, 562);
            this.hdgMenu.TabIndex = 1;
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
            // tvwMenu
            // 
            this.tvwMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tvwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMenu.Location = new System.Drawing.Point(0, 0);
            this.tvwMenu.Name = "tvwMenu";
            this.tvwMenu.Size = new System.Drawing.Size(198, 530);
            this.tvwMenu.TabIndex = 0;
            this.tvwMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMenu_NodeMouseDoubleClick);
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineLeft.Location = new System.Drawing.Point(200, 0);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.pnlLineLeft.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pnlLineLeft.Size = new System.Drawing.Size(5, 562);
            this.pnlLineLeft.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlLineLeft);
            this.pnlMain.Controls.Add(this.hdgMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 562);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlMainContent);
            this.pnlContent.Controls.Add(this.pnlLineBot);
            this.pnlContent.Controls.Add(this.pnlLineMid);
            this.pnlContent.Controls.Add(this.pnlMainMenu);
            this.pnlContent.Controls.Add(this.pnlLineTop);
            this.pnlContent.Controls.Add(this.pnlLineRight);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(205, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(819, 562);
            this.pnlContent.TabIndex = 4;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.kryptonDateTimePicker1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 63);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(814, 494);
            this.pnlMainContent.TabIndex = 9;
            // 
            // pnlLineBot
            // 
            this.pnlLineBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineBot.Location = new System.Drawing.Point(0, 557);
            this.pnlLineBot.Name = "pnlLineBot";
            this.pnlLineBot.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.pnlLineBot.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pnlLineBot.Size = new System.Drawing.Size(814, 5);
            this.pnlLineBot.TabIndex = 8;
            // 
            // pnlLineMid
            // 
            this.pnlLineMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineMid.Location = new System.Drawing.Point(0, 58);
            this.pnlLineMid.Name = "pnlLineMid";
            this.pnlLineMid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.pnlLineMid.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pnlLineMid.Size = new System.Drawing.Size(814, 5);
            this.pnlLineMid.TabIndex = 7;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 5);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(814, 53);
            this.pnlMainMenu.TabIndex = 6;
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.pnlLineTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pnlLineTop.Size = new System.Drawing.Size(814, 5);
            this.pnlLineTop.TabIndex = 4;
            // 
            // pnlLineRight
            // 
            this.pnlLineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLineRight.Location = new System.Drawing.Point(814, 0);
            this.pnlLineRight.Name = "pnlLineRight";
            this.pnlLineRight.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.pnlLineRight.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.pnlLineRight.Size = new System.Drawing.Size(5, 562);
            this.pnlLineRight.TabIndex = 3;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(196, 152);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(150, 21);
            this.kryptonDateTimePicker1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 562);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.hdgMenu.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdgMenu)).EndInit();
            this.hdgMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContent)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLineRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdgMenu;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnhdgMenuHideShow;
        private System.Windows.Forms.TreeView tvwMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLineLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlMain;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlContent;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLineMid;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlMainMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLineTop;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLineRight;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLineBot;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlMainContent;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}

