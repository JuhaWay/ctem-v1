using System;

/// <summary>
/// Entity for table Employer
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EmployerDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Position { get; set; }
        public long RightsValue { get; set; }
        public string CMND { get; set; }
        public string Passport { get; set; }
        public DateTime DOB { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }

        public EmployerDTO()
        {
            Username = "";
            Password = "";
            Fullname = "";
            Position = "";
            RightsValue = 0;
            Status = "";            
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(EmployerDTO)) return false;
            return Equals((EmployerDTO)obj);
        }


        public bool Equals(EmployerDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Username, Username); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(EmployerDTO left, EmployerDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmployerDTO left, EmployerDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
