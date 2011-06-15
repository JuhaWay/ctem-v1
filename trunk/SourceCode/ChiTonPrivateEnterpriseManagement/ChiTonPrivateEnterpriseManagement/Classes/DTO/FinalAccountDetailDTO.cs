using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class FinalAccountDetailDTO
    {
        public long FinalAccountDetailID { get; set; }
        public long FinalAccountID { get; set; }
        public long MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string RealCalUnit { get; set; }
        public float Quantity { get; set; }
        public long UnitCost { get; set; }
        public long TotalCost { get; set; }
        public string Note { get; set; }

        public FinalAccountDetailDTO()
        {
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FinalAccountDetailDTO)) return false;
            return Equals((FinalAccountDetailDTO)obj);
        }

        public bool Equals(FinalAccountDetailDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.FinalAccountDetailID, FinalAccountDetailID  ); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(FinalAccountDetailDTO left, FinalAccountDetailDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FinalAccountDetailDTO left, FinalAccountDetailDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
   
}