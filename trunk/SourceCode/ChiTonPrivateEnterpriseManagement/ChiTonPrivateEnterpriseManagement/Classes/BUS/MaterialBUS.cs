using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class MaterialBUS
    {
        private MaterialDAO _materialDAO = new MaterialDAO();
        public List<MaterialDTO> LoadAllMaterials()
        {
            return _materialDAO.LoadAllMaterials();
        }

        public List<EstimateDetailDTO> LoadALlMaterialsEstimate(long consId)
        {
            return _materialDAO.LoadAllMaterialsEstimate(consId);
        }
        public bool CreateMaterials(MaterialDTO dto)
        {
            return _materialDAO.CreateMaterials(dto);
        }
        public bool UpdateMaterials(MaterialDTO dto)
        {
            return _materialDAO.UpdateMaterials(dto);
        }
        public bool deleteMaterials(long id)
        {
            return _materialDAO.deleteMaterials(id);
        }
        public List<MaterialDTO> search(string name)
        {
            return _materialDAO.search(name);
        }

        public List<MaterialDTO> LoadMaterialByWarehouseId(long warehousId)
        {
            return _materialDAO.LoadMaterialbyWarehouseId(warehousId);
        }
    }
}
