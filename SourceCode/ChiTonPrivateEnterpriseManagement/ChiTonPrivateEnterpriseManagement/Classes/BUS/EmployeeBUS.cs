using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    /// <summary>
    /// Business Logic layer of Employee Entity
    /// </summary>
    public class EmployeeBUS
    {

        public static bool CheckLogin (string username, string password)
        {
            bool isLogin = false;            
            password = DataProvider.Encrypt(password);
            return isLogin;
        }
    }
}
