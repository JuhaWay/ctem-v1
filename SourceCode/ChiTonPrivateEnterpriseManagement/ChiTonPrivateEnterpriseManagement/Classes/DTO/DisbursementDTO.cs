using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class DisbursementDTO
    {
        public long DisbursementID { get; set; }
        public long DisbursementProgressID { get; set; }
        public long ConstructionID { get; set; }
        public long Number { get; set; }
        public string Taker { get; set; }
        public DateTime Date { get; set; }
        public long OthersCost { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }


        public string NumberFormated { get; set; }
        public string OthersCostFormated { get; set; }
    }
}
