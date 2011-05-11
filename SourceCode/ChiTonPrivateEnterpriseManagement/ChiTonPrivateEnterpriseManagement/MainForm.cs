using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
        }

        private void btnhdgMenuHideShow_Click(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Left;
                hdgMenu.Width = 30;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowRight;
                hdgMenu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
                tgcMain.Refresh();
            }
            else
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Top;
                hdgMenu.Width = 200;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowLeft;
                hdgMenu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            }
            
        }

        private void hdgMenu_MouseHover(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            }
        }

        private void hdgMenu_MouseLeave(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            }
        }
    }
}