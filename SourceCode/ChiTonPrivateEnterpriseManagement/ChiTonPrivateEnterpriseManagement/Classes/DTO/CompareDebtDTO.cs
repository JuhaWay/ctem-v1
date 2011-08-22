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
        public long TotalNewOwe { get; set; }
        public long TotalOldOwe { get; set; }
        public long TotalPayed { get; set; }
        public long Con { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string TotalOweFormat { get; set; }
        public string TotalNewOweFormat { get; set; }
        public string TotalOldOweFormat { get; set; }
        public string ConFormat { get; set; }
        public string TotalPayedFormat { get; set; }
        public string DateCompareFormated { get; set; }
        public string FromDateFormated { get; set; }
        public string ToDateFormated { get; set; }

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