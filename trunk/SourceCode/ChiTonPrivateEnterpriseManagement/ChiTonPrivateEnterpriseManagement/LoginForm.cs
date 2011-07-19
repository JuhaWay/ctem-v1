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
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class LoginForm : KryptonForm
    {
        EmployeeBUS EmployeeBUS = new EmployeeBUS();
        RightBUS rightBUS = new RightBUS();
        private EmployerDTO _currentUser;
        public static bool IsLogout;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Equals(Constants.EMPTY_TEXT) || password.Equals(Constants.EMPTY_TEXT))
            {
                MessageBox.Show(Constants.VALIDATE_USERNAME_PASSWORD , Constants.CONFIRM);
                txtUsername.Focus();
                return;
            }

            if (username.Equals(Constants.USERNAME_MANAGE_DB))
            {
                if (DataProvider.Encrypt(password).Equals(Constants.PASSWORD_DATABASE))
                {
                    DBInfoForm dbInfoForm = new DBInfoForm();
                    dbInfoForm.ShowDialog();
                    txtUsername.Text = Constants.EMPTY_TEXT;
                    txtPassword.Text = Constants.EMPTY_TEXT;
                    return;
                }                
            }
            _currentUser = EmployeeBUS.CheckLogin(username, password);
            if (_currentUser != null)
            {
                Global.CurrentUser = _currentUser;
                Global.Rights = rightBUS.LoadAllRight();
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                if (IsLogout)
                {
                    Show();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show(Constants.INVALID_USERNAME_PASSWORD, Constants.CONFIRM);
                txtUsername.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            Global.SetLayoutButton(btnLogin);
            Global.SetLayoutButton(btnExit);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Focused)
            {
                if (txtUsername.Text.Equals(Constants.EMPTY_TEXT))
                {
                    MessageBox.Show(Constants.VALIDATE_USERNAME, Constants.CONFIRM);
                    txtUsername.Focus();
                }
            }          
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (btnLogin.Focused)
            {
                if (txtPassword.Text.Equals(Constants.EMPTY_TEXT))
                {
                    MessageBox.Show(Constants.VALIDATE_PASSWORD, Constants.CONFIRM);
                    txtPassword.Focus();
                }
            }
        }
    }
}