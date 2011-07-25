using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class ConstructionBus
    {
        private ConstructionDao _constructionDao = new ConstructionDao();
        public List<ConstructionDTO> LoadAllConstructions()
        {
            return _constructionDao.LoadAllConstructions();
        }

        public long CreateConstruction(ConstructionDTO dto)
        {
            return _constructionDao.CreateConstruction(dto);
        }

        public ConstructionDTO LoadConstructionById(long id)
        {
            return _constructionDao.LoadConstructionById(id);
        }
        public bool updateConstruction(ConstructionDTO dto)
        {
            return _constructionDao.UpdateConstruction(dto);
        }

        public List<ConstructionDTO> LoadChildenById(long parentID)
        {
            return _constructionDao.LoadChildenById(parentID);
        }

        public bool DeleteConstruction(long ConstructionID )
        {
            return _constructionDao.DeleteConstruction(ConstructionID);
        }

        public bool UpdateConstructionTotalEstimateCost(long ConstructionID, long TotalEstimateCost)
        {
            return _constructionDao.UpdateConstructionTotalEstimateCost(ConstructionID, TotalEstimateCost);
        }

        public List<ConstructionDTO> LoadAllConstructionsHaveWarehouse()
        {
            return _constructionDao.LoadAllConstructionsHaveWarehouse();
        }
        public List<ConstructionDTO> SearchConstructions(ConstructionDTO param)
        {
            return _constructionDao.SearchConstructions(param);
        }
        public bool UpdateConstructionTotal(long ConstructionID)
        {
            return _constructionDao.UpdateConstructionTotal(ConstructionID);
        }

        public List<ConstructionDTO> LoadAllConstructionsParentAndChild()
        {
            return _constructionDao.GetAllConstructionParentandChildren();
        }

        public ConstructionDTO LoadConstructionReportByName(string consName)
        {
            return _constructionDao.LoadConstructionReportByName(consName);
        }
        public bool CreateDisbursementProgress(PayDTO dto)
        {
            return _constructionDao.CreateDisbursementProgress(dto);
        }
        public List<PayDTO> LoadAllDisbursementProgress(long id, int type)
        {
            return _constructionDao.LoadAllDisbursementProgress(id, type);
        }
        public List<ProgressHrtDTO> LoadAllProgressHtr(long id)
        {
            return _constructionDao.LoadAllProgressHtr(id);
        }
        public bool CreateProgressHrt(ProgressHrtDTO dto)
        {
            return _constructionDao.CreateProgressHrt(dto);
        }
        public PayDTO LoadAllDisbursementProgress(long id)
        {
            return _constructionDao.LoadAllDisbursementProgress(id);
        }
        public List<DisbursementDTO> LoadAllDisbursement(long id,long conID)
        {
            return _constructionDao.LoadAllDisbursement(id, conID);
        }
        public bool CreateDisbursement(DisbursementDTO dto)
        {
            return _constructionDao.CreateDisbursement(dto);
        }
        public bool UpdateDisbursement(DisbursementDTO dto)
        {
            return _constructionDao.UpdateDisbursement(dto);
        }
        internal bool DeleteDisbursement(long id, long conID)
        {
            return _constructionDao.DeleteDisbursement(id, conID);
        }
    }

}
