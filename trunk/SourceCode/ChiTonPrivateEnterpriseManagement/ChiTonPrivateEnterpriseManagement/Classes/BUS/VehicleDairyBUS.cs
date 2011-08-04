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
        public long CreateVehicleDairy(VehicleDairyDTO dto)
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
        public bool CreateRoadMap(RoadMapDTO dto)
        {
            return _vehicleDairyDAO.CreateRoadMap(dto);
        }
        public bool UpdateRoadMap(RoadMapDTO dto)
        {
            return _vehicleDairyDAO.UpdateRoadMap(dto);
        }
        public bool DeleteRoadMap(long id)
        {
            return _vehicleDairyDAO.deleteRoadMap(id);
        }
        public List<RoadMapDTO> getALLRoads(long id)
        {
            return _vehicleDairyDAO.getRoads(id);
        }
        public VehicleDairyDTO getByID(long ID)
        {
            return _vehicleDairyDAO.getByID(ID);
        }
        public List<VehicleDairyCostDTO> searchVehicleDairyCost(VehicleDairyCostDTO param)
        {
            return _vehicleDairyDAO.searchVehicleDairyCost(param);
        }
        public bool deleteVehicleDairyCost(long ID)
        {
             return _vehicleDairyDAO.deleteVehicleDairyCost(ID);
        }
        public long CreateVehicleDairyCost(VehicleDairyCostDTO dto)
        {
             return _vehicleDairyDAO.CreateVehicleDairyCost(dto);
        }
    }
}
