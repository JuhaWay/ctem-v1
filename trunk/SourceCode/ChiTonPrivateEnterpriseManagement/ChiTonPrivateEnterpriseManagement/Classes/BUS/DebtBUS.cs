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
        readonly DebtDAO _debtDao = new DebtDAO();

        public bool AddDebt(DebtDTO debt)
        {
            return _debtDao.CreateDebt(debt);
        }

        public bool DeleteDebt(long debtId)
        {
            return _debtDao.DeleteDebt(debtId);
        }

        public bool DeleteAll()
        {
            return _debtDao.DeleteAll();
        }

        public bool Update(DebtDTO debt)
        {
            return _debtDao.UpdateDebt(debt);
        }

        public List<DebtDTO> GetDebt(long id, string name, int status)
        {
            return _debtDao.GetDebt(id, name, status);
        }

        public List<CompareDebtDTO> GetCompareDebt(string name, DateTime fromdate, DateTime todate)
        {
            return _debtDao.GetCompareDebt(name, fromdate, todate);            
        }

        public long Create(CompareDebtDTO compareDebtDto)
        {
            return _debtDao.CreateCompareDebt(compareDebtDto);
        }

        public bool DeleteAllCompare()
        {
            return _debtDao.DeleteAllCompare();
        }

        public bool UpdateCompare(CompareDebtDTO compareDebtDto)
        {
            return _debtDao.UpdateCompare(compareDebtDto);
        }

        public bool DeleteDebtCompare(long id)
        {
            return _debtDao.DeleteCompare(id);
        }

        public List<CompareDebtDetailDTO> GetCompareDebtDetail(long _id)
        {
            return _debtDao.GetCompareDebtDetail(_id);
        }

        public bool CreateCompareDetail(CompareDebtDetailDTO detailDTO)
        {
            return _debtDao.CreateCompareDebtDetail(detailDTO);
        }

        public bool UpdateCompareDetail(CompareDebtDetailDTO detailDTO)
        {
            return _debtDao.UpdateCompareDetail(detailDTO);
        }

        public bool DeleteDebtCompareDetail(long id)
        {
            return _debtDao.DeleteCompareDetail(id);
        }
    }
}
