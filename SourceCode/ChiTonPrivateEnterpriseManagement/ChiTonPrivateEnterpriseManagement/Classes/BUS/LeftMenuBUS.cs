using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    /// <summary>
    /// Business Logic layer of Employee Entity
    /// </summary>
    public class LeftMenuBUS
    {
        public LeftMenuDTO leftMenuDTO;
        private LeftMenuDAO leftMenuDAO = new LeftMenuDAO();

        public List<LeftMenuDTO> GetMenuByRoleID(long roleID)
        {
            List<LeftMenuDTO> listMenus = leftMenuDAO.GetMenuByRoleID(roleID);
            return listMenus;
        }

        internal List<LeftMenuDTO> LoadAllMenu()
        {
            List<LeftMenuDTO> listMenus = leftMenuDAO.GetAllMenu();
            return listMenus;
        }

        public bool AddMenu(string menuName, int menuParent, string description, List<LeftMenuDTO> listMenus, List<RoleDTO> listMenuRole)
        {
            bool success = false;
            int numChildMenu = 0;
            foreach (var menu in listMenus)
            {
                if (menu.MenuParent == menuParent)
                {
                    numChildMenu++;
                }
            }
            int menuID = menuParent * 10 + numChildMenu + 1;
            bool success_addMenu = leftMenuDAO.CreateMenu(menuID, menuName, menuParent, description);
            bool success_addMenuRole = false;
            foreach (var Role in listMenuRole)
            {
                success_addMenuRole = leftMenuDAO.CreateMenuRole(menuID, Role.RoleID);
            }
            if (success_addMenu && success_addMenuRole)
            {
                success = true;
            }
            return success;
        }

        public bool DeleteMenu(int menuID)
        {
            bool success = leftMenuDAO.DeleteMenu(menuID);
            return success;
        }

        public bool EditMenu(LeftMenuDTO currentMenu, int menuParent, string description, List<LeftMenuDTO> listMenus, List<RoleDTO> listMenuRole)
        {
            bool sucess = false;
            bool sucess_delete = DeleteMenu(currentMenu.MenuID);
            bool sucess_add = AddMenu(currentMenu.MenuName, menuParent, description, listMenus, listMenuRole);
            if (sucess_delete && sucess_add)
            {
                sucess = true;
            }
            return sucess;
        }
    }
}
