using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageMenu
{
    public partial class MenuManagement: ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        Global global = new Global();
        List<LeftMenuDTO> listMenus;
        public MenuManagement()
        {
            InitializeComponent();
        }

        private void CommonForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
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
            listMenus  = new List<LeftMenuDTO>();
            listMenus = leftMenuBUS.LoadAllMenu();
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

        private void btnNewMenu_Click(object sender, EventArgs e)
        {
            NewMenu newMenu = new NewMenu(listMenus);
            newMenu.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMenu();
        }
    }
}