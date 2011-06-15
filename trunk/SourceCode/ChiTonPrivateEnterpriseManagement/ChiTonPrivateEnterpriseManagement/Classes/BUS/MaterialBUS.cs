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

        public List<MaterialDTO> LoadALlMaterialsEstimate()
        {
            return _materialDAO.LoadAllMaterialsEstimate();
        }
    }
}
