using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    class WarehouseMaterialDTO
    {
        public long WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public long MaterialID { get; set; }
        public string MaterialName { get; set; }
        public double Quantity { get; set; }
        public string UnitCal { get; set; }
        public long AveragePrice { get; set; }
        public long TotalCost { get; set; }
        public string TotalCostFormated { get; set; }
        public string AveragePriceFormated { get; set; }
    }
}
