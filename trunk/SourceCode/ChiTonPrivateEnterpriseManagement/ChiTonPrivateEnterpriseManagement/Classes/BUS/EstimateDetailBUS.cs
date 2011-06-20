using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
  
    class EstimateDetailBUS
    {

        private EstimateDetailDAO _estimateDetailDAO = new EstimateDetailDAO();
        public List<EstimateDetailDTO> LoadAllEstimateDetails(long estimateId)
        {
            return _estimateDetailDAO.LoadAllEstimateDetails(estimateId);
        }
        public bool CreateEstimateDetail(long estimateID, long materialID, long quantityEstimate,
                                       long unitCostEstimate, long totalCostEstimate)
        {
            return _estimateDetailDAO.CreateEstimateDetail(estimateID,materialID,quantityEstimate,
                                       unitCostEstimate,totalCostEstimate);
        }
        public bool DeleteEstimateDetail(long estimateDetailID)
        {
            return _estimateDetailDAO.DeleteEstimateDetail(estimateDetailID);
        }
        public bool UpdateEstimateDetail(long estimateDetailID, long materialID, long quantityEstimate,
                                       long unitCostEstimate, long totalCostEstimate)
        {
            return _estimateDetailDAO.UpdateEstimateDetail(estimateDetailID, materialID, quantityEstimate,
                                       unitCostEstimate, totalCostEstimate);
        }
    }
}
