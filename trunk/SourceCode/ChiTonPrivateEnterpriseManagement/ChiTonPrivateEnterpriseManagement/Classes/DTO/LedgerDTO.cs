using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class LedgerDTO
    {
        public long LedgerID { get; set; }
        public DateTime Date { get; set; }
        public String Method { get; set; }
        public String Type { get; set; }
        public String Person { get; set; }
        public String Reason { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
    }
}
