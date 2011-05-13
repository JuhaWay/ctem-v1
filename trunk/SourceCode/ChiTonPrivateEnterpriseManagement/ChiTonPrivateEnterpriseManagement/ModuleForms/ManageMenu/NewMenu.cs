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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageMenu
{
    public partial class NewMenu : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        List<LeftMenuDTO> listMenus;
        public NewMenu()
        {
            InitializeComponent();
        }

        public NewMenu(List<LeftMenuDTO> _listMenus)
        {
            InitializeComponent();
            listMenus = _listMenus;
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            loadMenuParent();
            loadRole();
        }

        private void loadRole()
        {

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
    }
}