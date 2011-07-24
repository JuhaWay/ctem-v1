﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class VehicleDTO
    {

        public static string CATEGORY_VEHICLE = "Phương tiện";
        public static string CATEGORY_MACHINE = "Máy cơ";
        public static string CATEGORY_BARGE = "Xà lan";

        public long VehicleID { get; set; }
        public long ConstructionID { get; set; }
        public String ConstructionName { get; set; }
        public String WarehouseName { get; set; }
        public String ManagerName { get; set; }
        public long WarehouseID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public long ManagerID { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string DateFormated { get; set; }
        public VehicleDTO() { }
        public VehicleDTO(string name,long id)
        {
            Number = name;
            VehicleID = id;
        }
        public static List<String> getCategory()
        {
            List<string> list = new List<string>();
            list.Add(CATEGORY_VEHICLE);
            list.Add(CATEGORY_MACHINE);
            list.Add(CATEGORY_BARGE);
            return list;
        }
    }
}