using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class MaterialDTO
    {
        public long MaterialID { get; set; }
        public string MaterialName { get; set; }
        public long MaterialParentID { get; set; }
        public string EstimateCalUnit { get; set; }
        public string RealCalUnit { get; set; }
        public float Ratio { get; set; }
    }
}
