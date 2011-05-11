using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class ConstructionDTO
    {
        public long ConstructionID { get; set; }
        public string ConstructionName { get; set; }
        public string Description { get; set; }
        public string ConstructionAddress { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }
    }
}