using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class PayDTO
    {
        public long ConstructionID { get; set; }
        public long DisbursementProgressID { get; set; }
        public string State { get; set; }
        public int Rate { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public long Number { get; set; }
        public string NumberFormated { get; set; }
        public string Note { get; set; }
        public string StartFormated { get; set; }
        public string EndFormated { get; set; }
        public int Type { get; set; }
        public PayDTO() { }
        public PayDTO(string state,long id)
        {
            this.State = state;
            this.DisbursementProgressID = id;
        }
    }
}
