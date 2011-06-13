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

        public bool CreateConstruction(string constructionName, string description,String constructionAddress ,
                                       DateTime commencementDate, DateTime completionDate, long totalEstimateCost,
                                        string status)
        {
            return _constructionDao.CreateConstruction(constructionName, description, constructionAddress,
                                                        commencementDate, completionDate, totalEstimateCost,
                                                        status);
        }

        public ConstructionDTO LoadConstructionById(long id)
        {
            return _constructionDao.LoadConstructionById(id);
        }
        public bool updateConstruction(long constructionID,string constructionName, string description, String constructionAddress,
                                       DateTime commencementDate, DateTime completionDate, long totalEstimateCost,
                                        string status)
        {
            return _constructionDao.UpdateConstrction(constructionID,constructionName, description, constructionAddress,
                                                        commencementDate, completionDate, totalEstimateCost,
                                                        status);
        }
        public ConstructionDTO LoadConstructionByName(string name)
        {
            return _constructionDao.LoadConstructionByName(name);
        }

        public List<ConstructionDTO> LoadAllConstructionsHaveWarehouse()
        {
            return _constructionDao.LoadAllConstructionsHaveWarehouse();
        }
    }
}
