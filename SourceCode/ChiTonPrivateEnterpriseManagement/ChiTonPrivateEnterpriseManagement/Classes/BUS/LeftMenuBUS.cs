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
    }
}
