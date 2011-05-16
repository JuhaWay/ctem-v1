using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRole
{
    public partial class NewRole : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        List<LeftMenuDTO> listMenus;
        List<RoleDTO> listRoles;
        LeftMenuDTO currentMenu;
        LeftMenuBUS leftMenuBUS = new LeftMenuBUS();
        RoleBUS roleBUS = new RoleBUS();
        bool isNew = false;
        bool isEdit = false;

        public NewRole()
        {
            InitializeComponent();
        }

        public NewRole(List<LeftMenuDTO> _listMenus)
        {
            InitializeComponent();
            listMenus = _listMenus;
            isNew = true;
        }

        public NewRole(List<LeftMenuDTO> _listMenus, LeftMenuDTO _currentMenu)
        {
            InitializeComponent();
            listMenus = _listMenus;
            currentMenu = _currentMenu;
            setParentMenu();
            setRole();
            txtMenuName.Text = currentMenu.MenuName;
            txtDescription.Text = currentMenu.Description;
            isEdit = true;
        }

        private void setRole()
        {
            listRoles = roleBUS.GetRoleByMenuID(currentMenu.MenuID);
            foreach (var role in listRoles)
            {
                lbxListRole.Items.Add(role);
            }
            lbxListRole.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
            lbxListRole.ValueMember = Constants.ROLE_VALUEMEMBER;
        }

        private void setParentMenu()
        {
            for (int i = 0; i < listMenus.Count; i++)
            {
                var menu = listMenus[i];
                if (menu.MenuID == currentMenu.MenuParent)
                {
                    cbbMenuParent.SelectedItem = menu;
                    i = listMenus.Count;
                }
            }
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            CenterToParent();
            loadMenuParent();
            loadRole();
        }

        private void loadRole()
        {
            listRoles = roleBUS.GetAll();
            foreach (var role in listRoles)
            {
                cbbRole.Items.Add(role);
            }
            cbbRole.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
            cbbRole.ValueMember = Constants.ROLE_VALUEMEMBER;

        }

        private void loadMenuParent()
        {
            foreach (var menuparent in listMenus)
            {
                if (menuparent.MenuParent == 0)
                {
                    cbbMenuParent.Items.Add(menuparent);
                }
            }
            cbbMenuParent.DisplayMember = Constants.MENU_PARENT_DISPLAYMEMBER;
            cbbMenuParent.ValueMember = Constants.MENU_PARENT_VALUEMEMBER;
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxListRole.Items)
            {
                if (item.Equals(cbbRole.SelectedItem))
                {
                    MessageBox.Show("This Role was been added");
                    return;
                }
            }
            lbxListRole.Items.Add(cbbRole.SelectedItem);
            lbxListRole.ValueMember = Constants.ROLE_VALUEMEMBER;
            lbxListRole.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            string menuName = txtMenuName.Text;
            LeftMenuDTO parentItem = (LeftMenuDTO)cbbMenuParent.SelectedItem;
            int menuParent = 0;
            if (parentItem != null)
            {
                menuParent = parentItem.MenuID;
                
            }
            string description = txtDescription.Text;
            List<RoleDTO> listMenuRole = new List<RoleDTO>();
            foreach (var item in lbxListRole.Items)
	        {
                listMenuRole.Add((RoleDTO)item);
	        }
            if (isNew)
            {
                success = leftMenuBUS.AddMenu(menuName, menuParent, description, listMenus, listMenuRole);
            }
            if (isEdit)
            {
                success = leftMenuBUS.EditMenu(currentMenu, menuParent, description, listMenus, listMenuRole);
            }
            if (!success)
            {
                MessageBox.Show("Faile");
            }
            this.Close();
        }
    }
}