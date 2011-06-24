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
    /// Business Logic layer of Debt Entity
    /// </summary>
    public class DebtBUS
    {
        DebtDAO debtDAO = new DebtDAO();
        public List<DebtDTO> GetAll()
        {
            return debtDAO.GetAllDebt();
        }

        //public bool DeleteDebt(long DebtID)
        //{
        //    return DebtDAO.DeleteDebt(DebtID);
        //}

        public void AddDebt(DebtDTO debt)
        {
            debtDAO.CreateDebt(debt);
        }

        //public void EditDebt(long DebtID, string DebtName, string description, long rightsValue, bool isActive)
        //{
        //    DebtDAO.UpdateDebt(DebtID, DebtName, description, rightsValue, isActive);
        //}

        public List<CompareDebtDTO> GetAllCompareDebt()
        {
            return debtDAO.GetAllCompareDebt();
        }
    }
}
    