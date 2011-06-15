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
        FinalAccountDAO finalAccountDAO = new FinalAccountDAO();
        
        public bool CreateFinalAccount(FinalAccountDTO finalAccount)
        {
            return finalAccountDAO.CreateFinalAccount(finalAccount);
        }

        public bool CreateFinalAccountDetail(FinalAccountDetailDTO finalaccountdetail)
        {
            return finalAccountDAO.CreateFinalAccountDetail(finalaccountdetail);
        }

        public List<FinalAccountDTO> GetAll()
        {
            return finalAccountDAO.GetAll();            
        }
    }
}
    