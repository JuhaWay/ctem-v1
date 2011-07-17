using System;

/// <summary>
/// Entity for table Worker
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class WorkerDTO
    {
        public long WorkerID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Position { get; set; }
        public string CMND { get; set; }
        public string Passport { get; set; }
        public DateTime DOB { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }

        public string CreatedDateFormated { get; set; }
        public string LastUpdatedFormated { get; set; }



        public WorkerDTO()
        {
            Fullname = "";
            Position = "";
            Status = "";            
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(WorkerDTO)) return false;
            return Equals((WorkerDTO)obj);
        }


        public bool Equals(WorkerDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.WorkerID, WorkerID);
        }

        public static bool operator ==(WorkerDTO left, WorkerDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WorkerDTO left, WorkerDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
