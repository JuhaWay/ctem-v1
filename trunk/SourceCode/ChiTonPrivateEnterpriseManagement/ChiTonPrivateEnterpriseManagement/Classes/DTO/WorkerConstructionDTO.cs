using System;

/// <summary>
/// Entity for table WorkerConstruction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class WorkerConstructionDTO
    {
        public long WorkerConstructionID { get; set; }
        public long WorkerID { get; set; }
        public long ConstructionID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}