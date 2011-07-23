using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    class RoadMapDTO
    {
        public long RoadMapID { get; set; }
        public long VehicleDairyID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Km { get; set; }
    }
}
