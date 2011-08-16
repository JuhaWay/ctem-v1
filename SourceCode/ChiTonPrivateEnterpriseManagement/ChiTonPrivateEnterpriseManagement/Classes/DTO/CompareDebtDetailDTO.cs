using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class CompareDebtDetailDTO
    {
        public long DetailID { get; set; }
        public long ComparationDebtID { get; set; }
        public string RepresentationDebtName { get; set; }
        public DateTime DatePay { get; set; }
        public long Payed { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string DatePayFormat { get; set; }
        public string PayedFormat { get; set; }

        public CompareDebtDetailDTO()
        {
            DetailID = 0;
            ComparationDebtID = 0;
            Payed = 0;            
        }
    }
}
