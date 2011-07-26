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
        public bool check(long mID, long eID)
        {
            return _estimateDetailDAO.check(mID, eID);
        }
        public EstimateIriDetailDTO LoadOneEstimateIriDetailByEst(long estimateId, int Type)
        {
            return _estimateDetailDAO.LoadOneEstimateIriDetailByEst(estimateId, Type);
        }

        public List<EstimateIriDetailDTO> LoadAllEstimateIriDetailsByEst(long estimateId, int Type)
        {
            return _estimateDetailDAO.LoadAllEstimateIriDetailsByEst(estimateId, Type);
        }
        public bool UpdateEstimateDetailIri(EstimateIriDetailDTO dto)
        {
            return _estimateDetailDAO.UpdateEstimateDetailIri(dto);
        }
        public bool CreateEstimateDetailIri(EstimateIriDetailDTO dto)
        {
            return _estimateDetailDAO.CreateEstimateDetailIri(dto);
        }
    }
}
