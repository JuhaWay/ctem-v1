using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class WarehouseDTO
    {
        public long WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public long ConstructionID { get; set; }
        public string ConstructionName { get; set; }
        public string ManagerName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int IsActive { get; set; }

        public WarehouseDTO()
        {
            WarehouseID = 0;
            ConstructionID = 0;
        }
        public WarehouseDTO(long id, string name)
        {
            WarehouseID = id;
            WarehouseName = name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(WarehouseDTO)) return false;
            return Equals((WarehouseDTO)obj);
        }

        public bool Equals(WarehouseDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.ConstructionID, ConstructionID); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(WarehouseDTO left, WarehouseDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WarehouseDTO left, WarehouseDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
   
}