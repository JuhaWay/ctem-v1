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
        public long UnitCostEstimate { get; set; }
        public long TotalCostEstimate { get; set; }
    }
}
