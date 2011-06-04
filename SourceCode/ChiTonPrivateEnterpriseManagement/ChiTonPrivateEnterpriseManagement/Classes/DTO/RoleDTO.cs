using System;

/// <summary>
/// Entity for table Role
/// </summary>
///

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class RoleDTO
    {
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public long RightsValue { get; set; }
        public bool IsActive { get; set; }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(RoleDTO)) return false;
            return Equals((RoleDTO)obj);
        }


        public bool Equals(RoleDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.RoleID, RoleID);
        }

        public static bool operator ==(RoleDTO left, RoleDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoleDTO left, RoleDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
