using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class LoginForm : KryptonForm
    {
        EmployeeBUS EmployeeBUS = new EmployeeBUS();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployerDTO employeeDTO = new EmployerDTO();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isLogin = false;
            isLogin = EmployeeBUS.CheckLogin(username, password);
            if (isLogin)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai Password hoac mat khau");
            }
        }

        private void btnDatabaseInfo_Click(object sender, EventArgs e)
        {
            DBInfoForm dbInfoForm = new DBInfoForm();
            dbInfoForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
        }
    }
}