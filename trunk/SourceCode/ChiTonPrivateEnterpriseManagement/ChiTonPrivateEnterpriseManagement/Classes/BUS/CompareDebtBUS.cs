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
    /// Business Logic layer of CompareDebt Entity
    /// </summary>
    public class CompareDebtBUS
    {
        CompareDebtDAO compareDebtDao = new CompareDebtDAO();
        public List<CompareDebtDTO> GetAll()
        {
            return compareDebtDao.GetAllCompareDebt();
        }

        //public bool DeleteCompareDebt(long CompareDebtID)
        //{
        //    return CompareDebtDAO.DeleteCompareDebt(CompareDebtID);
        //}

        public void Create(CompareDebtDTO CompareDebt)
        {
            compareDebtDao.CreateCompareDebt(CompareDebt);
        }

        //public void EditCompareDebt(long CompareDebtID, string CompareDebtName, string description, long rightsValue, bool isActive)
        //{
        //    CompareDebtDAO.UpdateCompareDebt(CompareDebtID, CompareDebtName, description, rightsValue, isActive);
        //}
    }
}
    