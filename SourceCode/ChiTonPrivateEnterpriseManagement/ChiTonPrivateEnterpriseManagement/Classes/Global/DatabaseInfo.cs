using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ChiTonPrivateEnterpriseManagement.Classes.Modules
{
    class DatabaseInfo
    {
        public static string ConnectionString = "";

        public void LoadInfo()
        {
            DBInfoForm dbInfoForm;
            string serverName;
            string authentication;
            string userName;
            string passWord;
            string databaseName;

            FileStream objFile = new FileStream("SQLConnection.config", FileMode.OpenOrCreate, FileAccess.ReadWrite);            
            StreamReader Open = new StreamReader(objFile);

            try
            {
                serverName = Open.ReadLine().ToString();
                serverName = serverName.Substring(serverName.IndexOf(":") + 1);

                authentication = Open.ReadLine().ToString();
                authentication = authentication.Substring(authentication.IndexOf(":") + 1);

                userName = Open.ReadLine().ToString();
                userName = userName.Substring(userName.IndexOf(":") + 1);

                passWord = Open.ReadLine().ToString();
                passWord = passWord.Substring(passWord.IndexOf(":") + 1);

                databaseName = Open.ReadLine().ToString();
                databaseName = databaseName.Substring(databaseName.IndexOf(":") + 1);

                if (authentication.Equals("SQL Server Authentication"))
                {
                    ConnectionString = @"Data Source=" + serverName + "; uid=" +
                    userName + ";pwd=" + passWord + ";Initial Catalog=" + databaseName + "";
                }
                else
                {
                    ConnectionString = @"Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=True";
                }
                Open.Close();
            }
            catch
            {
                Open.Close();
                MessageBox.Show("Do not configure SQL connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbInfoForm = new DBInfoForm();
                dbInfoForm.ShowDialog();
            }
        }
    }
}
