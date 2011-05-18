// RightBUS.cs
using System.Collections.Generic;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.DAO;
using System;

namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
{
    /// <summary>
    /// Business Logic layer of User Entity
    /// </summary>
    public class RightBUS
    {
        /// <summary>
        /// Store for the name property.
        /// </summary>
        private RightDAO rightDao = new RightDAO(); // 

        public List<RightDTO> LoadAllRight()
        {
            return rightDao.LoadAllRights();
        }

        //public List<RightDTO> LoadRight(int roleType)
        //{
        //    return rightDao.LoadRights(roleType);
        //}

        public void AddRight(string rightName, bool isActive, string description, EmployerDTO employer)
        {
            throw new System.NotImplementedException();
        }

        public bool AddRight(string rightName, bool isActive, string description, EmployerDTO employer, List<RightDTO> listRights)
        {
            bool sucess = false;
            long RightID = listRights.Count + 1;
            long value = (long)Math.Pow(2, RightID);
            string CreateBy = employer.Username;
            sucess = rightDao.CreateRight(RightID, rightName, description, value, isActive, CreateBy);
            return sucess;
        }

        public bool DeleteRight(long RightID)
        {
            bool success = false;
            success = rightDao.DeleteRight(RightID);
            return success;
        }
    }
}
