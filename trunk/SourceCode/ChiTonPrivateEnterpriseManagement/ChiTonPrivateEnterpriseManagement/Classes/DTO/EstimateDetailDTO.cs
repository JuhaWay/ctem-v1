using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EstimateDetailDTO
    {

        public static string TYPE_MATERIAL = "Vật liệu";
        public static string TYPE_WORKER = "Công nhân";
        public static string TYPE_MACHINE = "Máy Thi Công";
        public static string TYPE_VEHICLE = "Phương tiện";
        public static string TYPE_GENERAL = "Tổng quát";



        public long EstimateDetailID { get; set; }
        public string No { get; set; }
        public long EstimateID { get; set; }
        public long MaterialID { get; set; }
        public double QuantityEstimate { get; set; }
        public double UnitCostEstimate { get; set; }
        public double TotalCostEstimate { get; set; }
        public string MaterialName { get; set; }
        public string MaterialEstCal { get; set; }
        public long MaterialParentId { get; set; }

        public double QuantityReal { get; set; }
        public long UnitCostReal { get; set; }
        public long TotalCostReal { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }


        public string UnitCostEstimateFormated { get; set; }
        public string TotalCostEstimateFormated { get; set; }



        public static List<String> getTypes()
        {
            List<String> list = new List<string>();
            list.Add(TYPE_MATERIAL);
            list.Add(TYPE_WORKER);
            list.Add(TYPE_MACHINE);
            list.Add(TYPE_VEHICLE);
            list.Add(TYPE_GENERAL);
            return list;
        }

    }
}
