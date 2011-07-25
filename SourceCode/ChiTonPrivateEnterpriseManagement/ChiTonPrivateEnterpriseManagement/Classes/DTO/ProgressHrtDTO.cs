using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class ProgressHrtDTO
    {
        public long ProgressHrtID { get; set; }
        public long ConstructionID { get; set; }
        public string Editor { get; set; }
        public int Progress { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string DateFormated { get; set; }
        

    }
}
