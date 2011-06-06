﻿using System.Collections.Generic;
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

    }
}