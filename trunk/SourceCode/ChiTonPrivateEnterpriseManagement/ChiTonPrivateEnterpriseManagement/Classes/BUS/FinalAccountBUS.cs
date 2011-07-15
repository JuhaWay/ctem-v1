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
    /// Business Logic layer of FinalAccount Entity
    /// </summary>
    public class FinalAccountBUS
    {
        readonly FinalAccountDAO finalAccountDAO = new FinalAccountDAO();
        
        public bool CreateFinalAccount(FinalAccountDTO finalAccount)
        {
            return finalAccountDAO.CreateFinalAccount(finalAccount);
        }

        public bool CreateFinalAccountDetail(FinalAccountDetailDTO finalaccountdetail)
        {
            return finalAccountDAO.CreateFinalAccountDetail(finalaccountdetail);
        }

        public List<FinalAccountDTO> GetFinalAccount(long id, string name, string consName, string debtName, DateTime fromdate, DateTime todate)
        {
            return finalAccountDAO.GetFinalAccount(id, name, consName, debtName, fromdate, todate);
        }

        public bool DeleteFinalAccount(long id)
        {
            return finalAccountDAO.DeleteFinalAccount(id);
        }

        public bool DeleteAll()
        {
            return finalAccountDAO.DeleteAll();
        }
    }
}
    