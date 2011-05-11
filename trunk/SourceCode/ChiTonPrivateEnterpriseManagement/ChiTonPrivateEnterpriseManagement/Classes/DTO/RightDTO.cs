using System;

/// <summary>
/// Entity for table Right
/// </summary>
///

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class RightDTO
    {
        public int RightId { get; set; }
        public string RightName { get; set; }
        public string Description { get; set; }
        public long Value { get; set; }        
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string EnumAlias { get; set; }
    }
}
