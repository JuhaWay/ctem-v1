//// RightBUS.cs
//using System.Collections.Generic;

//namespace ChiTonPrivateEnterpriseManagement.Classes.BUS
//{
//    /// <summary>
//    /// Business Logic layer of User Entity
//    /// </summary>
//    public class RightBUS
//    {
//        /// <summary>
//        /// Store for the name property.
//        /// </summary>
//        private readonly RightDAO rightDao = new RightDAO(); // 
//        SmartSessionPage ss = new SmartSessionPage(); // 

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        public List<RightDTO> LoadRight()
//        {
//            return rightDao.LoadRights(ss.CurrentUser.Username);
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="roleType"></param>
//        /// <returns></returns>
//        public List<RightDTO> LoadRight(int roleType)
//        {
//            return rightDao.LoadRights(roleType);
//        }
//    }
//}
