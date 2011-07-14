using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class LedgerBUS
    {
        private LedgerDAO _ledgerDAO = new LedgerDAO();
        public List<LedgerDTO> LoadLedgers()
        {
            return _ledgerDAO.LoadLedgers();
        }
        public bool CreateLedger(LedgerDTO dto)
        {
            return _ledgerDAO.CreateLedger(dto);
        }
        public bool updateLedger(LedgerDTO dto)
        {
            return _ledgerDAO.updateLedger(dto);
        }
        public bool delete(long id)
        {
            return _ledgerDAO.delete(id);
        }
        public List<LedgerDTO> LedgerSearch(LedgerDTO param)
        {
            return _ledgerDAO.LedgerSearch(param);
        }
    }
}
