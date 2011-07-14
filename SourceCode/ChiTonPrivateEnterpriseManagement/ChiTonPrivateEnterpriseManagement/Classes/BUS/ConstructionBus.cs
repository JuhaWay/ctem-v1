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
    }
}
