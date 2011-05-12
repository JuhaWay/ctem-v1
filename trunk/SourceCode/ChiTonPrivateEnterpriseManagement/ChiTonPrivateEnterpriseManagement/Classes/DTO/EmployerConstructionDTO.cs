using System;

/// <summary>
/// Entity for table EmployerConstruction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EmployerConstructionDTO
    {
        public long EmployerConstructionID { get; set; }
        public string Username { get; set; }
        public long ConstructionID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }


        public EmployerConstructionDTO()
        {
            Username = "";
            ConstructionID = 0;
            CreatedBy = "";
            UpdatedBy = "";
            EmployerConstructionID = 0;
                      
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(EmployerConstructionDTO)) return false;
            return Equals((EmployerConstructionDTO)obj);
        }


        public bool Equals(EmployerConstructionDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.EmployerConstructionID, EmployerConstructionID); 
        }

        public static bool operator ==(EmployerConstructionDTO left, EmployerConstructionDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmployerConstructionDTO left, EmployerConstructionDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}