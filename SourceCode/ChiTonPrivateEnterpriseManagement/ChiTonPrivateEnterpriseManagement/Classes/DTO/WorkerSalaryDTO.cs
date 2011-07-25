using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class WorkerSalaryDTO
    {
        public string ConstructionName { get; set; }
        public long WorkersSalaryID { get; set; }
        public long ConstructionID { get; set; }
        public long ManagerID { get; set; }
        public string ManagerName { get; set; }

        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long TotalSalary { get; set; }
        public long OthersCost { get; set; }
        public long TotalCost { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool isChecked { get; set; }
        public string Task { get; set; }

        public string FromDateFormated { get; set; }
        public string ToDateFormated { get; set; }

        public string TotalSalaryFormated { get; set; }
        public string CreateDateFormated { get; set; }
        public string LastUpdateFormated { get; set; }
        public string OthersCostFormated { get; set; }
        public string TotalCostFormated { get; set; }
    }
}
