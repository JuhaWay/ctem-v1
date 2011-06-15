using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class WarehouseBUS
    {
        private WarehouseDAO warehouseDao = new WarehouseDAO();
        public List<WarehouseDTO> LoadAllWarehouses()
        {
            return warehouseDao.LoadAllWarehouses();
        }

        public List<WarehouseDTO> LoadAllMainWarehouses()
        {
            return warehouseDao.LoadAllMainWarehouses();
        }

        public bool CreateWarehouse(WarehouseDTO warehouse)
        {
            return warehouseDao.CreateWarehouse(warehouse);
        }
    }
}
