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
    public class EmployeeBUS
    {
        public EmployerDTO employerDTO = new EmployerDTO();
        private EmployerDAO employerDAO = new EmployerDAO();

        public EmployerDTO CheckLogin(string username, string password)
        {
            if (!username.Equals("admin"))
            {
                password = DataProvider.Encrypt(password);                
            }
            employerDTO = employerDAO.GetEmployerByUsername(username);
            if (employerDTO != null)
            {
                if (password.Equals(employerDTO.Password))
                {
                    return employerDTO;
                }
            }
            return null;               
        }
    }
}
