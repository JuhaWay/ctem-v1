using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isLogin = false;
            isLogin = EmployeeBUS.CheckLogin(username, password);
        }
    }
}