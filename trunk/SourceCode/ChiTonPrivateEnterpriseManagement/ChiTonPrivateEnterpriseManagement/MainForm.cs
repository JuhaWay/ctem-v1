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
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageMenu;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRole;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee;

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
            int numRootNodes = tvwMenu.Nodes.Count;
            for (int i = 0; i < numRootNodes; i++)
            {
                tvwMenu.Nodes.Remove(tvwMenu.Nodes[0]);
            }
            LeftMenuBUS leftMenuBUS = new LeftMenuBUS();
            List<LeftMenuDTO> listMenus = new List<LeftMenuDTO>();
            listMenus = leftMenuBUS.GetMenuByRoleID(employerDTO.RoleID);
            foreach (var menuparent in listMenus)
            {
                if (menuparent.MenuParent == 0)
                {
                    string NodekeyParent = GenerateNodeKey(menuparent.MenuName);
                    tvwMenu.Nodes.Add(menuparent.MenuName).Name = NodekeyParent;
                    var ParentNode = tvwMenu.Nodes[NodekeyParent];
                    foreach (var menuchild in listMenus)
                    {
                        if (menuchild.MenuParent == menuparent.MenuID)
                        {
                            string NodekeyChild = GenerateNodeKey(menuchild.MenuName);
                            ParentNode.Nodes.Add(menuchild.MenuName).Name = NodekeyChild;
                        }
                    }
                }
            }
        }

        private string GenerateNodeKey(string MenuName)
        {
            string NodeKey = Constants.EMPTY_TEXT;
            if (MenuName.Equals(Constants.MANAGE_MENU_VN))
            {
                NodeKey = Constants.MANAGE_MENU_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_ROLE_VN))
            {
                NodeKey = Constants.MANAGE_ROLE_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_RIGHT_VN))
            {
                NodeKey = Constants.MANAGE_RIGHT_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_USER_VN))
            {
                NodeKey = Constants.MANAGE_USER_EN;
            }

            if (MenuName.Equals(Constants.MANAGE_MENU_INFO_VN))
            {
                NodeKey = Constants.MANAGE_MENU_INFO_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_ROLE_INFO_VN))
            {
                NodeKey = Constants.MANAGE_ROLE_INFO_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_RIGHT_INFO_VN))
            {
                NodeKey = Constants.MANAGE_RIGHT_INFO_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_USER_INFO_VN))
            {
                NodeKey = Constants.MANAGE_USER_INFO_EN;
            }
            if (MenuName.Equals(Constants.MANAGE_CONSTRUCTION_INFO_VN))
            {
                NodeKey = Constants.MANAGE_CONSTRUCTION_INFO_VN;
            }
            return NodeKey;
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
            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_MENU_EN].Nodes[Constants.MANAGE_MENU_INFO_EN].IsSelected)
                {
                    MenuManagement menuManagement = new MenuManagement();
                    menuManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(menuManagement);
                    menuManagement.Show();
                }
                if (tvwMenu.Nodes[Constants.MANAGE_ROLE_EN].Nodes[Constants.MANAGE_ROLE_INFO_EN].IsSelected)
                {
                    RoleManagement roleManagement = new RoleManagement(employerDTO);
                    roleManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(roleManagement);
                    roleManagement.Show();
                }
                if (tvwMenu.Nodes[Constants.MANAGE_RIGHT_EN].Nodes[Constants.MANAGE_RIGHT_INFO_EN].IsSelected)
                {
                    RightsManagement rightsManagement = new RightsManagement(employerDTO);
                    rightsManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(rightsManagement);
                    rightsManagement.Show();
                }
                if (tvwMenu.Nodes[Constants.MANAGE_CONSTRUCTION_INFO_VN].IsSelected)
                {
                    ConstructionManagement conManagement = new ConstructionManagement();
                    conManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(conManagement);
                    conManagement.Show();
                }
                if (tvwMenu.Nodes[Constants.MANAGE_USER_EN].Nodes[Constants.MANAGE_USER_INFO_EN].IsSelected)
                {
                    EmployeeManagement employeeManagement = new EmployeeManagement(employerDTO);
                    employeeManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(employeeManagement);
                    employeeManagement.Show();
                }
            }
            catch (Exception)
            {
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMenu();
        }
    }
}