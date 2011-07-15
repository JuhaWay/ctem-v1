using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    class StockOutDetailDTO
    {
        public long StockOutId { get; set; }
        public long MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialUnitCall { get; set; }
        public long Quantity { get; set; }
        public string Note { get; set; }
    }
}
