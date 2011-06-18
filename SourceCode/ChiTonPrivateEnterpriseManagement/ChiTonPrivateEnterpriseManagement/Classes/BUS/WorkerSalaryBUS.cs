using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class WorkerSalaryBUS
    {
        private WorkSalaryDAO _workSalaryDAO = new WorkSalaryDAO();
        public bool CreateWks(WorkerSalaryDTO dto)
        { 
             return _workSalaryDAO.CreateWks(dto);
        }
        public List<WorkerSalaryDTO> LoadAllWks()
        {
            return _workSalaryDAO.LoadAllWks();
        }
        public bool UpdateWks(WorkerSalaryDTO dto)
        { 
            return _workSalaryDAO.UpdateWks(dto);
        }

    }
}
