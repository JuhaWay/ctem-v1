using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class WorkerTempDTO
    {
        public long WorkerID { get; set; }
        public string Fullname { get; set; }
        public long WorkersSalaryID { get; set; }
        public double ManDate { get; set; }
        public long Salary { get; set; }
        public long Allowance { get; set; }
        public string Reason { get; set; }
        public long TotalSalary { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool isChecked { get; set; }


        public string CreatedDateFormated { get; set; }
        public string LastUpdatedFormated { get; set; }
        public string SalaryFormated { get; set; }
        public string AllowanceFomated { get; set; }
        public string TotalSalaryFormated { get; set; }
    }
}
