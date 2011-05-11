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
    }
}