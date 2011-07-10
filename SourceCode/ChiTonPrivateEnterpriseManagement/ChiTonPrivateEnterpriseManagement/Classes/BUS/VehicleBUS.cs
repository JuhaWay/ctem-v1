using System;
using System.Collections.Generic;
using System.Text;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class VehicleBUS
    {
        VehicleDAO _vehicleDAO = new VehicleDAO();
        public List<VehicleDTO> LoadAllVehicles()
        {
            return _vehicleDAO.LoadAllVehicles();
        }
        public List<VehicleDTO> searchVehicle(VehicleDTO param)
        {
            return _vehicleDAO.searchVehicle(param);
        }
        public bool CreateVehicle(VehicleDTO dto)
        {
            return _vehicleDAO.CreateVehicle(dto);
        }
        public bool UpdateVehicle(VehicleDTO dto)
        {
            return _vehicleDAO.UpdateVehicle(dto);
        }
        public bool delete(long id)
        {
            return _vehicleDAO.delete(id);
        }
    }
}
