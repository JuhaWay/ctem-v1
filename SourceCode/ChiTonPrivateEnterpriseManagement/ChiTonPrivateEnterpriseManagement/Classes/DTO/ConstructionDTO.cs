using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class ConstructionDTO
    {
        public long ConstructionID { get; set; }
        public long WarehouseID { get; set; }
        public string SubcontractorName { get; set; }
        public string ConstructionName { get; set; }
        public string Description { get; set; }
        public string ConstructionAddress { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }

        public ConstructionDTO()
        {
            ConstructionID = 0;
            ConstructionName = "";
            Description = "";
            ConstructionAddress = "";
            CreatedBy = "";
            UpdatedBy = "";
            Status = "";

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