using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class VehicleDTO
    {
        public long VehicleID { get; set; }
        public long ConstructionID { get; set; }
        public String ConstructionName { get; set; }
        public String WarehouseName { get; set; }
        public String ManagerName { get; set; }
        public long WarehouseID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public long ManagerID { get; set; }
        public VehicleDTO() { }
        public VehicleDTO(string name,long id)
        {
            Name = name;
            VehicleID = id;
        }
    }
}
