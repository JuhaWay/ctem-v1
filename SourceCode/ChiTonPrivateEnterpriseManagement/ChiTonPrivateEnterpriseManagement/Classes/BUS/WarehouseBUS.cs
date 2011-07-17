using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class WarehouseBUS
    {
        private WarehouseDAO warehouseDao = new WarehouseDAO();
        public List<WarehouseDTO> LoadWarehouses(string name, string type, int status)
        {
            return warehouseDao.LoadWarehouses(name, type, status);
        }     

        public bool CreateWarehouse(WarehouseDTO warehouse)
        {
            return warehouseDao.CreateWarehouse(warehouse);
        }

        public bool DeleteWarehouse(long id)
        {
            return warehouseDao.DeleteWarehouse(id);
        }

        public bool DeleteAllWarehouse()
        {
            return warehouseDao.DeleteAllWarehouse();
        }

        public WarehouseMaterialDTO FindMateriral(long warehouseID, long materialId)
        {
            return warehouseDao.FinMaterial(warehouseID, materialId);
        }

        public bool UpdateWarehouseItem(WarehouseMaterialDTO materialWH)
        {
            return warehouseDao.UpdateWarehouseItem(materialWH);
        }

        public bool CreateWarehouseItem(WarehouseMaterialDTO materialWH)
        {
            return warehouseDao.CreateWarehouseItem(materialWH);
        }

        public bool UpdateWarehouse(WarehouseDTO warehouse)
        {
            return warehouseDao.UpdateWarehouse(warehouse);
        }

        public List<WarehouseMaterialDTO> GetWarehouseDetail(string whname, string materialname)
        {
            return warehouseDao.GetWarehouseDetail(whname, materialname);
        }
    }
}
