using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EstimateIriDetailDTO
    {
        public static int TYPE_EST = 0;
        public static int TYPE_REAL = 1;

        public long EstimateIriDetailID { get; set; }
        public long EstimateID	{get;set;}
	    public long TotalCost {get;set;}
	    public double Weight{get;set;}
        public double Length { get; set; }
	    public long Containers{get;set;}
        public string Note  {get;set;}

        public int Progress { get; set; }
        public DateTime Date { get; set; }
        public string Reporter { get; set; }
        public int Type { get; set; }
    }
}
