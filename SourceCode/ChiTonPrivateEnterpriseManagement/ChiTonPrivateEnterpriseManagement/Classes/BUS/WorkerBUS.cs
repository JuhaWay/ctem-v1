using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class WorkerBUS
    {
        private WorkerDAO _workerDAO = new WorkerDAO();
        public List<WorkerTempDTO> LoadAllWks(long id)
        {
            return _workerDAO.LoadAllWks(id);
        }
        public long CreateWks(WorkerTempDTO dto)
        {
            return _workerDAO.CreateWks(dto);
        }
        public bool updateWks(WorkerTempDTO dto)
        {
            return _workerDAO.updateWks(dto);
        }
        public bool delete(long id)
        {
            return _workerDAO.delete(id);
        }
        public bool CreateDayWorking(DayWorkingDTO dto){
            return _workerDAO.CreateDayWorking(dto);
        }
        public List<DayWorkingDTO> LoadAllDaysWorking(long id)
        {
            return _workerDAO.LoadAllDaysWorking(id);
        }
        public WorkerTempDTO LoadWorkerByID(long id)
        {
            return _workerDAO.LoadWorkerByID(id);
        }
    }
}
