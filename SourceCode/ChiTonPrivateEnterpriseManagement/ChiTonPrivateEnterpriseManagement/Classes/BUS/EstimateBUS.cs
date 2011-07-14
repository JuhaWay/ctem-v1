using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class EstimateBUS
    {
        private EstimateDAO _estimateDAO = new EstimateDAO();
        public bool creatEstimate(EstimateDTO dto)

        {
            return _estimateDAO.CreateEstimate(dto);
        }

        public List<EstimateDTO> LoadAllEstimates()
        {
            return _estimateDAO.LoadAllEstimates();
        }

        public bool UpdateEstimate(long EstimateID)
        {
            return _estimateDAO.UpdateEstimate(EstimateID);
        }
        public bool DeleteEstimate(long estimateID)
        {
            return _estimateDAO.DeleteEstimate(estimateID);
        }
        public List<EstimateDTO> LoadEstimateByConstruction(long id)
        {
            return _estimateDAO.LoadEstimateByConstruction(id);
        }
        public bool UpdateNameEstimate(long EstimateID, string name)
        {
            return _estimateDAO.UpdateNameEstimate( EstimateID,  name);
        }
        public List<EstimateDTO> search(EstimateDTO dto)
        {
             return _estimateDAO.search(dto);
        }
        public bool UpdateNameForSub(EstimateDTO dto)
        {
            return _estimateDAO.UpdateNameForSub(dto);
        }
    }
}
