using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class ConstructionDTO
    {
        public  const string MAIN = "Thuộc Doanh nghiệp";
        public  const string SUB = "Nhà thầu phụ";

        public long ConstructionID { get; set; }
        public long WarehouseID { get; set; }
        public string SubcontractorName { get; set; }
        public long SubconstractorID { get; set; }
        public string ConstructionName { get; set; }
        public string Description { get; set; }
        public string ConstructionAddress { get; set; }
        public long ManagerID { get; set; }
        public string ManagerName { get; set; }


       
        public string Status { get; set; }
        public bool HasEstimate { get; set; }
        public long ParentID { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
       
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long ProgressRate { get; set; }
        public string type { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedFormated { get; set; }
        public string CreateDateFormated { get; set; }
        public DateTime CommencementDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string CommencementDateFormated { get; set; }
        public string CompletionDateFormated { get; set; }

        public long TotalRealCost { get; set; }
        public long TotalEstimateCost { get; set; }
        public long TotalMaterialCost { get; set; }
        public long TotalWorkerCost { get; set; }
        public long TotalMachineCost { get; set; }
        public long TotalCostsIncurred { get; set; }
        
        public string TotalEstimateCostFormated { get; set; }
        public string TotalRealCostFormated { get; set; }
        

        public ConstructionDTO()
        {
            ParentID = 0;
            ConstructionID = 0;
            ConstructionName = "";
            Description = "";
            ConstructionAddress = "";
            CreatedBy = "";
            UpdatedBy = "";
            Status = "";

        }

        public ConstructionDTO(string name,long id)
        {
            ConstructionID = id;
            ConstructionName = name;

        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ConstructionDTO)) return false;
            return Equals((ConstructionDTO)obj);
        }

        public bool Equals(ConstructionDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.ConstructionName, ConstructionName); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(ConstructionDTO left, ConstructionDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionDTO left, ConstructionDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }   
}