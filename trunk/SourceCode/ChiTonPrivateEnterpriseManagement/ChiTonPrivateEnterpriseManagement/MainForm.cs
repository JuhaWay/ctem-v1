using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageMenu;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        Global global = new Global();
        private EmployerDTO employerDTO;
        private EmployeeBUS employeeBUS;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(EmployerDTO _employerDTO)
        {
            this.employerDTO = _employerDTO;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            loadMenu();
        }

        private void loadMenu()
        {
            LeftMenuBUS leftMenuBUS = new LeftMenuBUS();
            List<LeftMenuDTO> listMenus = new List<LeftMenuDTO>();
            listMenus = leftMenuBUS.GetMenuByRoleID(employerDTO.RoleID);
            foreach (var menuparent in listMenus)
            {
                if (menuparent.MenuParent == 0)
                {
                    string NodekeyParent = menuparent.MenuName.Replace(" ", "-").ToUpper();
                    tvwMenu.Nodes.Add(menuparent.MenuName).Name = NodekeyParent;
                    var ParentNode = tvwMenu.Nodes[NodekeyParent];
                    foreach (var menuchild in listMenus)
                    {
                        if (menuchild.MenuParent == menuparent.MenuID)
                        {
                            string NodekeyChild = menuchild.MenuName.Replace(" ", "-").ToUpper();
                            ParentNode.Nodes.Add(menuchild.MenuName).Name = NodekeyChild;
                        }
                    }
                }
            }
        }

        private void btnhdgMenuHideShow_Click(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Left;
                hdgMenu.Width = Constants.WIDTH_MENU_HIDE;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_HIDE;
                slcMain.IsSplitterFixed = true;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowRight;
                hdgMenu.PaletteMode = PaletteMode.SparklePurple;                
            }
            else
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Top;
                hdgMenu.Width = Constants.WIDTH_MENU_SHOW;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_SHOW;
                slcMain.IsSplitterFixed = false;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowLeft;
                hdgMenu.PaletteMode = PaletteMode.Global;
            }
            
        }

        private void hdgMenu_MouseHover(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = PaletteMode.Global;
            }
        }

        private void hdgMenu_MouseLeave(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = PaletteMode.SparklePurple;
            }
        }

        private void tvwMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvwMenu.Nodes[Constants.MANAGE_MENU].Nodes[Constants.MANAGE_MENU_INFO].IsSelected)
            {
                MenuManagement menuManagement = new MenuManagement();
                menuManagement.MdiParent = this;
                pnlMainContent.Controls.Add(menuManagement);
                menuManagement.Show();
            }
            if (tvwMenu.Nodes[Constants.MANAGE_RIGHT].Nodes[Constants.MANAGE_RIGHT_INFO].IsSelected)
            {
                RightsManagement rightsManagement = new RightsManagement(employerDTO);
                rightsManagement.MdiParent = this;
                pnlMainContent.Controls.Add(rightsManagement);
                rightsManagement.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}