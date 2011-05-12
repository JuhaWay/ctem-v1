using System;
using System.Collections.Generic;
using System.Text;
using FastDataAccess.DataAccess;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    class DataProvider
    {
        public static string Encrypt(string text)
        {
            var portalSecurity = new PortalSecurity();
            string key = Constants.Encryptkey;
            return portalSecurity.Encrypt(key, text);
        }

        public static string Decrypt(string text)
        {
            var portalSecurity = new PortalSecurity();
            string key = Constants.Encryptkey;
            return portalSecurity.Decrypt(key, text);
        }
    }
}
