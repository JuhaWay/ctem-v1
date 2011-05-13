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
        private EmployerDTO employerDTO;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Chua nhap thong tin");
            }
            employerDTO = EmployeeBUS.CheckLogin(username, password);
            if (employerDTO != null)
            {
                MainForm mainForm = new MainForm(employerDTO);
                mainForm.Show();
                this.Hide();
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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
        }
    }
}