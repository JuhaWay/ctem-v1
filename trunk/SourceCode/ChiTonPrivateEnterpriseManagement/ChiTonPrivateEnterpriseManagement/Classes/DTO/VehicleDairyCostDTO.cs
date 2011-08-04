using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class VehicleDairyCostDTO
    {
        public static  String FUAL = "Nhiên liệu";
        public static  String VISCOSITY = "Nhớt";
        public static  String TOOL = "Dụng cụ";
        public static  String DAMAGED = "Sửa chửa";

        public long VehicleDairyCostID { get; set; }
        public long VehicleDairyID { get; set; }
        public long VehicleID { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double TotalCost { get; set; }
        public string Unit { get; set; }
        public string Taker { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }


        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }


        public string PriceFormated { get; set; }
        public string TotalCostFormated { get; set; }

        public static List<string> getTypeCost()
        {
            List<string> list = new List<string>();
            list.Add(FUAL);
            list.Add(VISCOSITY);
            list.Add(TOOL);
            list.Add(DAMAGED);
            return list;
        }

    }
}
