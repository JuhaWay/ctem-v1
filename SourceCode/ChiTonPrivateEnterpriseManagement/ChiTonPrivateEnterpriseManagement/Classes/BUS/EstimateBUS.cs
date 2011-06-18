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
        public bool creatEstimate(long ConstructionID, string EstimateName, long TotalCostEstimate,
                                       long TotalCostReal, DateTime CreatedDate, DateTime UpdatedDate,
                                       string CreatedBy, string UpdatedBy)

        {
            return _estimateDAO.CreateEstimate(ConstructionID, EstimateName, TotalCostEstimate,
                                                TotalCostReal, CreatedDate, UpdatedDate,
                                                CreatedBy, UpdatedBy);
        }

        public List<EstimateDTO> LoadAllEstimates()
        {
            return _estimateDAO.LoadAllEstimates();
        }

        public bool UpdateEstimate(long EstimateID, long TotalCostEstimate)
        {
            return _estimateDAO.UpdateEstimate(EstimateID, TotalCostEstimate);
        }
        public bool DeleteEstimate(long estimateID)
        {
            return _estimateDAO.DeleteEstimate(estimateID);
        } 
    }
}
