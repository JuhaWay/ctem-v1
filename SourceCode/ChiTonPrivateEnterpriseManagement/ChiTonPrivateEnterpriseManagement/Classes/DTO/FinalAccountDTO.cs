using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class FinalAccountDTO
    {
        public string FinalAccountID { get; set; }        
        public long ConstructionID { get; set; }
        public long WarehouseID { get; set; }
        public string ConstructionName { get; set; }
        public DateTime DateAccount { get; set; }
        public string DateAccountFormated { get; set; }
        public long DebtID { get; set; }
        public string DebtName { get; set; }
        public long TransportationCost { get; set; }
        public string TransportationCostFormated { get; set; }
        public long TotalCost  { get; set; }
        public string TotalCostFormated { get; set; }
        public long ComparationDebtID { get; set; }
        public string PersonAccount { get; set; }
        public int IsPay { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public FinalAccountDTO()
        {
            ConstructionID = 0;
            ConstructionName = "";
            CreatedBy = "";
            UpdatedBy = "";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(FinalAccountDTO)) return false;
            return Equals((FinalAccountDTO)obj);
        }

        public bool Equals(FinalAccountDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.ConstructionName, ConstructionName); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(FinalAccountDTO left, FinalAccountDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FinalAccountDTO left, FinalAccountDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
   
}