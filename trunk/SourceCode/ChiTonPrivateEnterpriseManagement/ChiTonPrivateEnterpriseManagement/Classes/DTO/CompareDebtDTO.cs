using System;

/// <summary>
/// Entity for table Debt
/// </summary>
///

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class CompareDebtDTO
    {
        public long ComparationDebtID { get; set; }
        public long DebtID { get; set; }
        public String DebtName { get; set; }
        public string RepresentationDebtName { get; set; }
        public DateTime DateCompare { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long TotalOwe { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(CompareDebtDTO)) return false;
            return Equals((CompareDebtDTO)obj);
        }


        public bool Equals(CompareDebtDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.DebtID, DebtID);
        }

        public static bool operator ==(CompareDebtDTO left, CompareDebtDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompareDebtDTO left, CompareDebtDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
