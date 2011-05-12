using System;

/// <summary>
/// Entity for table Right
/// </summary>
///

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class RightDTO
    {
        public int RightId { get; set; }
        public string RightName { get; set; }
        public string Description { get; set; }
        public long Value { get; set; }        
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string EnumAlias { get; set; }


        public RightDTO()
        {
            RightId = 0;
            RightName = "";
            Description = "";
            Value = 0;
            CreatedBy = "";
            UpdatedBy = "";
            UpdatedBy = "";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RightDTO)) return false;
            return Equals((RightDTO)obj);
        }


        public bool Equals(RightDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.RightName, RightName); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(RightDTO left, RightDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RightDTO left, RightDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
