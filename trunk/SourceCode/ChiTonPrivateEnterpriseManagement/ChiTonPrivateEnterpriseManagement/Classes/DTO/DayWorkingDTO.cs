using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class DayWorkingDTO
    {
        public long WorkerID { get; set; }
        public DateTime Date { get; set; }
        public string DateFormated { get; set; }
        public double Value { get; set; }
    }
}
