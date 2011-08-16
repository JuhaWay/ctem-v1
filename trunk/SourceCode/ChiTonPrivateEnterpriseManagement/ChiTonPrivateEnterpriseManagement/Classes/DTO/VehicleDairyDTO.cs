using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class VehicleDairyDTO
    {
        public long VehicleDairyID { get; set; }
        public long VehicleID { get; set; }
        public String VehicleName { get; set; }
        public String VehicleNumber { get; set; }
        public long ConstructionID { get; set; }
        public String ConstructionName { get; set; }
        public String RoadMap { get; set; }
        public String DriverName { get; set; }
        public long FualCost { get; set; }
        public long DamagedCost { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ?isPaid { get; set; }
        public long DriverID { get; set; }
        public string Category { get; set; }
        public string Reason { get; set; }
        public long Totalcost { get; set; }
        public string FualCostFormated { get; set; }
        public string DamagedCostFormated { get; set; }
        public string DateFormated { get; set; }
        public string TotalcostFormated { get; set; }
        public string Task { get; set; }
        public long ManagerID { get; set; }
        public string Taker { get; set; }


        public long DebtID { get; set; }
        public long WarehouseID { get; set; }


    }
}
