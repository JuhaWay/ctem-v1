using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EstimateDTO
    {
        public string ConstructionName { get; set; }
        public long ConstructionID { get; set; }
        public long EstimateID { get; set; }
        public string EstimateName { get; set; }
        
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        
        public int Type { get; set; }


        public string CreatedDateFormated { get; set; }
        public string UpdatedDateFormated { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public long TotalCostEstimate { get; set; }
        public long TotalCostReal { get; set; }
        public string TotalCostEstimateFormated { get; set; }
        public string TotalCostRealFormated { get; set; }
    }
}
