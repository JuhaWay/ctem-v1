using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    class WarehouseBUS
    {
        private WarehouseDAO warehouseDao = new WarehouseDAO();
        public List<WarehouseDTO> LoadWarehouses(string type)
        {
            return warehouseDao.LoadWarehouses(type);
        }     

        public bool CreateWarehouse(WarehouseDTO warehouse)
        {
            return warehouseDao.CreateWarehouse(warehouse);
        }
    }
}
