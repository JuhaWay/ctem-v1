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
        public bool CreateEstimateDetail(EstimateDetailDTO dto)
        {
            return _estimateDetailDAO.CreateEstimateDetail(dto);
        }
        public bool DeleteEstimateDetail(long estimateDetailID)
        {
            return _estimateDetailDAO.DeleteEstimateDetail(estimateDetailID);
        }
        public bool UpdateEstimateDetail(EstimateDetailDTO dto)
        {
            return _estimateDetailDAO.UpdateEstimateDetail(dto);
        }
        public List<EstimateDetailDTO> search(long estimateId, long materialId)
        {
            return _estimateDetailDAO.search(estimateId, materialId);
        }
    }
}
