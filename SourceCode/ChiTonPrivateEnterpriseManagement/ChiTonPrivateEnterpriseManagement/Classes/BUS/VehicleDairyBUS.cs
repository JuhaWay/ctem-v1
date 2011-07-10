using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class VehicleDairyBUS
    {
        private VehicleDairyDAO _vehicleDairyDAO = new VehicleDairyDAO();
        public List<VehicleDairyDTO> searchVehicleDairy(VehicleDairyDTO param)
        {
            return _vehicleDairyDAO.searchVehicleDairy(param);
        }
        public bool CreateVehicleDairy(VehicleDairyDTO dto)
        {
            return _vehicleDairyDAO.CreateVehicleDairy(dto);
        }
        public bool UpdateVehicleDairy(VehicleDairyDTO dto)
        {
            return _vehicleDairyDAO.UpdateVehicleDairy(dto);
        }
        public bool delete(long id)
        {
            return _vehicleDairyDAO.delete(id);
        }
    }
}
