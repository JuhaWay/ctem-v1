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
    }
}
