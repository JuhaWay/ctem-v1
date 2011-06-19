using System;

/// <summary>
/// Entity for table Employer
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EmployeeAdvanceDTO
    {
        public long AdvanceID { get; set; }
        public long EmployeeID { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public long TotalAdvance { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public EmployeeAdvanceDTO()
        {
            Username = "";
            Fullname = "";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(EmployeeAdvanceDTO)) return false;
            return Equals((EmployeeAdvanceDTO)obj);
        }


        public bool Equals(EmployerDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Username, Username); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(EmployeeAdvanceDTO left, EmployeeAdvanceDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmployeeAdvanceDTO left, EmployeeAdvanceDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
