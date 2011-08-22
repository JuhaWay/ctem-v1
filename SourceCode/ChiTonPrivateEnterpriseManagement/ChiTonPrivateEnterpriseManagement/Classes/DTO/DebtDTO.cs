using System;

/// <summary>
/// Entity for table Debt
/// </summary>
///

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class DebtDTO
    {
        public long DebtID { get; set; }
        public string DebtName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public long TotalOwe { get; set; }
        public string TotalOweFomated { get; set; }
        public string OldOweFormated { get; set; }
        public string NewestOweFormated { get; set; }
        public int IsActive { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(DebtDTO)) return false;
            return Equals((DebtDTO)obj);
        }


        public bool Equals(DebtDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.DebtID, DebtID);
        }

        public static bool operator ==(DebtDTO left, DebtDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DebtDTO left, DebtDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
