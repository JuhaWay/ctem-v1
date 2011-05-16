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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights
{
    public partial class RightsManagement: KryptonForm
    {
        Global global = new Global();
        List<LeftMenuDTO> listMenus;
        LeftMenuBUS leftMenuBUS = new LeftMenuBUS();
        public RightsManagement()
        {
            InitializeComponent();
        }

        private void loadMenu()
        {
            int numRootNodes = tvwMenu.Nodes.Count;
            for (int i = 0; i < numRootNodes; i++)
            {
                tvwMenu.Nodes.Remove(tvwMenu.Nodes[0]);
            }
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
            NewRight newMenu = new NewRight(listMenus);
            newMenu.ShowDialog();
            loadMenu();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMenu();
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            loadMenu();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            var currMenu = tvwMenu.SelectedNode;
            if (currMenu == null)
            {
                MessageBox.Show("Please Choose Menu To Edit");
                return;
            }
            foreach (var menu in listMenus)
            {
                if (menu.MenuName.Equals(currMenu.Text))
                {
                    NewRight newMenu = new NewRight(listMenus, menu);
                    newMenu.ShowDialog();
                    loadMenu();
                    return;
                }
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            bool success = false;
            var currNode = tvwMenu.SelectedNode;
            if (currNode == null)
            {
                MessageBox.Show("You don't choose one menu to delete", "Confirm");
                return;
            }
            
            if (MessageBox.Show("Are you sure to delete this Menu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (var menu in listMenus)
                {
                    if (menu.MenuName.Equals(currNode.Text))
                    {
                        leftMenuBUS.DeleteMenu(menu.MenuID);
                        loadMenu();
                        success = true;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
            if (!success)
            {
                MessageBox.Show("Delete Faile");
            }
        }
    }
}