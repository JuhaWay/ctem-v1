using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class DBInfoForm : KryptonForm
    {
        public DBInfoForm()
        {
            InitializeComponent();
            CenterToParent();
            cbxAuthentication.SelectedIndex = 0;
        }

        private void cbxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAuthentication.SelectedIndex == 1)
            {
                lblUserName.Enabled = false;
                lblPassword.Enabled = false;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                lblUserName.Enabled = true;
                lblPassword.Enabled = true;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        public static void createfile(string serverName, string authentication, string userName, string passWord, string databaseName)
        {
            const string fileName = "SQLConnection.config";
            FileStream CreateFile = File.Create(fileName);
            StreamWriter Create = new StreamWriter(CreateFile);
            Create.WriteLine("SeverName:" + serverName);
            Create.WriteLine("Authentication:" + authentication);
            Create.WriteLine("User Name:" + userName);
            Create.WriteLine("PassWord:" + passWord);
            Create.WriteLine("Database Name:" + databaseName);
            Create.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            string serverName = txtServerName.Text.Trim();
            string authentication = cbxAuthentication.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string databaseName = txtDatabase.Text.Trim();
            createfile(serverName, authentication, userName, password, databaseName);
            dbInfo.LoadInfo();
            this.Close();
        }
    }
}