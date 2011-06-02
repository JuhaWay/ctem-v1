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
    /// Business Logic layer of Role Entity
    /// </summary>
    public class RoleBUS
    {
        RoleDAO roleDAO = new RoleDAO();
        public List<RoleDTO> GetAll()
        {
            return roleDAO.GetAllRole();
        }

        public List<RoleDTO> GetRoleByMenuID(int menuID)
        {
            return roleDAO.GetRoleByMenuID(menuID);
        }

        public List<RoleDTO> LoadAllRole()
        {
            return roleDAO.GetAllRole();
        }

        public bool DeleteRole(long RoleID)
        {
            return roleDAO.DeleteRole(RoleID);
        }

        public void AddRole(string RoleName, string description, long rightsValue, bool isActive)
        {
            roleDAO.CreateRole(RoleName, description, rightsValue, isActive);
        }
    }
}
    