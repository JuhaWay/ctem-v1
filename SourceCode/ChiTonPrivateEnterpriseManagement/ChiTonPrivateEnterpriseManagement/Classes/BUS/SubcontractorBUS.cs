﻿using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class SubcontractorBUS
    {
        private SubcontractorDao _subcontractorDao = new SubcontractorDao();
        public bool CreateSubcontractor(string subcontractorName, string subcontractorAddress, string phoneNumber)
        {
            return _subcontractorDao.CreateSubcontractor
                (subcontractorName, subcontractorAddress, phoneNumber);
        }
        public List<SubcontractorDTO> loadAllSubcontractorDTO()
        {
           return  _subcontractorDao.LoadAllSubcontractor();
        }

        public SubcontractorDTO LoadSubcontractorById(long id){
            return _subcontractorDao.LoadSubcontractorById(id);
        }

        public SubcontractorDTO LoadSubcontractorByName(String name)
        {
            return _subcontractorDao.LoadSubcontractorByName(name);

        }
    }
}