using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    class StockOutDetailDTO
    {
        public string StockOutId { get; set; }
        public long MaterialId { get; set; }
        public long WarehouseFromId { get; set; }
        public long WarehouseToId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnitCall { get; set; }
        public double Quantity { get; set; }
        public long Price { get; set; }
        public long TotalCost { get; set; }
        public string Note { get; set; }

        public string PriceFormat { get; set; }
        public string TotalCostFormat { get; set; }
    }
}
