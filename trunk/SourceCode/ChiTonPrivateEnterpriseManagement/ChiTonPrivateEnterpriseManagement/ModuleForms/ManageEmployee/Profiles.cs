using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class Profiles : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EmployerDTO employerDTO;
        private readonly EmployeeBUS _empBus = new EmployeeBUS();
        public Profiles()
        {
            InitializeComponent();
        }

        public Profiles(EmployerDTO _employerDTO)
        {
            InitializeComponent();
            employerDTO = _employerDTO;
            SetInitData();
        }

        private void SetInitData()
        {
            txtUsername.Text = employerDTO.Username;
            txtFullname.Text = employerDTO.Fullname;
            txtAddress.Text = employerDTO.Address;
            txtTotalDebt.Text = employerDTO.totalDebt.ToString();
            txtEmail.Text = employerDTO.Email;
            txtPhoneNumber.Text = employerDTO.PhoneNumber;
            txtCMND.Text = employerDTO.CMND;
            dtpDOB.Value = employerDTO.DOB;
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutSplipContainerNewForm(kryptonSplitContainer1);
            Global.SetLayoutSplipContainerNewForm(kryptonSplitContainer2);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox2);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox3);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnSave);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (!Global.CurrentUser.Password.Equals(DataProvider.Encrypt(txtOldPass.Text)) && !txtOldPass.Text.Equals(Constants.EMPTY_TEXT))
            {
                KryptonMessageBox.Show(Constants.PASS_NOT_MATCH, Constants.CONFIRM);
                txtOldPass.Focus();
            }
        }

        private void kryptonTextBox3_Leave(object sender, EventArgs e)
        {
            if (!txtConfirmPass.Text.Equals(txtNewPass.Text))
            {
                KryptonMessageBox.Show(Constants.NOT_CONFIRM_PASS, Constants.CONFIRM);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = DataProvider.Encrypt(txtConfirmPass.Text);
            if (txtConfirmPass.Text.Equals(Constants.EMPTY_TEXT) && txtNewPass.Text.Equals(Constants.EMPTY_TEXT))
            {
                password = Global.CurrentUser.Password;
            }
            
            string fullname = txtFullname.Text;
            string address = txtAddress.Text;
            long totalDebt = Global.ConvertMoneyToLong(txtTotalDebt.Text, ".");
            string email = txtEmail.Text;
            string CMND = txtCMND.Text;
            string DOB = dtpDOB.Text;            
            string phonenumber = txtPhoneNumber.Text;
            DateTime birthday = DateTime.ParseExact(DOB + " 00:00:00", "dd/MM/yyyy hh:mm:ss", null);            
            bool success = _empBus.UpdateEmployee(Global.CurrentUser.employeeID, username, password, fullname, address, email, CMND, DOB, Global.CurrentUser.RoleID, Global.CurrentUser.RightsValue,
                                           1, Global.CurrentUser.Note, phonenumber, totalDebt);
            if (success)
            {
                Global.CurrentUser.Password = password;
                Global.CurrentUser.Fullname = fullname;
                Global.CurrentUser.Address = address;
                Global.CurrentUser.totalDebt = totalDebt;
                Global.CurrentUser.Email = email;
                Global.CurrentUser.CMND = CMND;
                Global.CurrentUser.DOB = birthday;
                Global.CurrentUser.PhoneNumber = phonenumber;
                KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM);
                txtUsername.Focus();
            }

        }
    }
}