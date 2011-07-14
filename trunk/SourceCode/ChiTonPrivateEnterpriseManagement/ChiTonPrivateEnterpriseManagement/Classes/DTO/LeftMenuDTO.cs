using System;

/// <summary>
/// Entity for table Construction
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class LeftMenuDTO
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public int MenuParent { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != typeof(LeftMenuDTO)) return false;
        //    return Equals((LeftMenuDTO)obj);
        //}

        //public bool Equals(LeftMenuDTO other)
        //{
        //    if (ReferenceEquals(null, other)) return false;
        //    if (ReferenceEquals(this, other)) return true;
        //    return Equals(other.MenuID, MenuID);
        //}

        //public static bool operator ==(LeftMenuDTO left, LeftMenuDTO right)
        //{
        //    return Equals(left, right);
        //}

        //public static bool operator !=(LeftMenuDTO left, LeftMenuDTO right)
        //{
        //    return !Equals(left, right);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

    }
   
}