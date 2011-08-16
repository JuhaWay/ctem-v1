using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    class StockOutDTO
    {
        public string StockOutId { get; set; }
        public DateTime DateStockOut { get; set; }
        public string StockOutFrom { get; set; }
        public long WareHourseIdFrom { get; set; }
        public string StockOutTo { get; set; }
        public long WareHourseIdTo { get; set; }
        public long DriverId { get; set; }
        public string DriverName { get; set; }
        public long TransportationCost { get; set; }
        public long NoVehicle { get; set; }
        public string VehicleName { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }        
    }
}
