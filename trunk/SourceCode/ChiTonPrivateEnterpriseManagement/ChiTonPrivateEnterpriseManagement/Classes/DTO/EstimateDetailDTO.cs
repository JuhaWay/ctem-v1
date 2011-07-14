using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EstimateDetailDTO
    {
        public long EstimateDetailID { get; set; }
        public long EstimateID { get; set; }
        public long MaterialID { get; set; }
        public int QuantityEstimate { get; set; }
        public long UnitCostEstimate { get; set; }
        public long TotalCostEstimate { get; set; }
        public string MaterialName { get; set; }

        public int QuantityReal { get; set; }
        public long UnitCostReal { get; set; }
        public long TotalCostReal { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }


    }
}
