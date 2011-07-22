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
    public partial class NewEmployee : KryptonForm
    {
        private bool isNew;
        private bool isEdit;
        private string username;
        private long employeeID;
        private List<RoleDTO> listRoles = new List<RoleDTO>();
        private List<RightDTO> listRights = new List<RightDTO>();
        private List<EmployerDTO> listEmployes = new List<EmployerDTO>();
        private RoleBUS roleBUS = new RoleBUS();
        private RightBUS rightBUS = new RightBUS();
        private  EmployeeBUS employeeBUS = new EmployeeBUS();

        public NewEmployee()
        {
            isNew = true;
            InitializeComponent();
        }

        public NewEmployee(string _username, List<EmployerDTO> _listEmployee)
        {
            isEdit = true;
            InitializeComponent();
            username = _username;
            listEmployes = _listEmployee;            
        }

        private void SetInnitValueWhenEdit()
        {
            foreach (EmployerDTO employer in listEmployes)
            {
                if (employer.Username.Equals(username))
                {
                    employeeID = employer.employeeID;
                    txtUsername.Text = employer.Username;
                    txtFullname.Text = employer.Fullname;
                    txtAddress.Text = employer.Address;
                    txtEmail.Text = employer.Email;
                    txtCMND.Text = employer.CMND;
                    txtPhoneNumber.Text = employer.PhoneNumber;
                    txtNote.Text = employer.Note;
                    for (int i = 0; i < cbbRole.Items.Count; i++)
                    {
                        RoleDTO role = (RoleDTO)cbbRole.Items[i];
                        if (role.RoleID == employer.RoleID)
                        {
                            cbbRole.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }            
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            SetLayout();
            LoadData();
            if (isEdit)
            {
                SetInnitValueWhenEdit();
                btnClear.Enabled = false;
            }
        }

        private void SetLayout()
        {
            CenterToParent();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutGroupBoxButton(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.TextBoxRequireInput(txtUsername);
            Global.TextBoxRequireInput(txtFullname);            
        }

        private void LoadData()
        {
            Global.SetDataCombobox(cbbRole, Constants.ROLE);
            Global.SetDataCombobox(cbbStatus, Constants.STATUS);
        }

        private int GenerateStatus(string strStatus)
        {
            int isActie;
            if (strStatus.Equals(Constants.ACTIVE))
            {
                isActie = Constants.ISACTIVE_TRUE;
            }
            else
            {
                isActie = Constants.ISACTIVE_FALSE;
            }
            return isActie;
        }

        private void txtTotalDebt_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalDebt);
        }

        private void txtTotalDebt_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtTotalDebt);            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var textBox = (KryptonTextBox) sender;            
            if (textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.TextBoxRequireInput(textBox);
            }
            else
            {
                Global.TextBoxRequireInputed(textBox);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool success = false;
                string username = txtUsername.Text;
                string password = DataProvider.Encrypt(Constants.DEFAULT_PASSWORD);
                string fullname = txtFullname.Text;
                string address = txtAddress.Text;
                long totalDebt = Global.ConvertMoneyToLong(txtTotalDebt.Text, Constants.SPLIP_MONEY);
                string email = txtEmail.Text;
                string CMND = txtCMND.Text;
                string DOB = dtpDOB.Text;
                RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
                long roleID = selectedRole.RoleID;
                int isActive = GenerateStatus(cbbStatus.Text);
                string phonenumber = txtPhoneNumber.Text;
                string notes = txtNote.Text;
                long rightsValue = selectedRole.RightsValue;
                if (isNew)
                {
                    success = employeeBUS.CreateEmployee(username, password, fullname, address, email, CMND, DOB, roleID, rightsValue,
                                           isActive, notes, phonenumber, totalDebt);
                }
                if (isEdit)
                {
                    success = employeeBUS.UpdateEmployee(employeeID, username, password, fullname, address, email, CMND, DOB, roleID, rightsValue,
                                           isActive, notes, phonenumber, totalDebt);
                }
                if (!success)
                {
                    MessageBox.Show("Faile");
                }
                if (success)
                {
                    if (isNew)
                    {
                        if (KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearLayout();
                            txtUsername.Focus();
                        }
                        else
                        {
                            Close();
                        }
                    }

                    if (isEdit)
                    {
                        if (KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtUsername.Focus();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
            else
            {
                string errors = "";
                foreach (string error in Global.ListError)
                {
                    errors += ("* " + error + "\n");
                }
                KryptonMessageBox.Show(errors, Constants.ALERT_ERROR);
                txtUsername.Focus();
            }
        }

        private bool ValidateInput()
        {
            Global.SetTextBoxNumberLeave(txtTotalDebt);
            Global.ListError.Clear();
            if (Global.ValidateNotEmptyText(txtUsername) && Global.ValidateNotEmptyText(txtFullname) && Global.ValidatePhoneNumber(txtPhoneNumber))
            {
                return true;
            }
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }

        private void ClearLayout()
        {
            txtUsername.Text = Constants.EMPTY_TEXT;
            txtFullname.Text = Constants.EMPTY_TEXT;
            txtEmail.Text = Constants.EMPTY_TEXT;
            txtCMND.Text = Constants.EMPTY_TEXT;
            txtAddress.Text = Constants.EMPTY_TEXT;
            txtPhoneNumber.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
            txtTotalDebt.Text = Constants.ZERO_NUMBER;
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 0;
            }
            cbbStatus.SelectedIndex = 0;
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (Global.ValidateNotEmptyText(txtPhoneNumber) && Global.ValidatePhoneNumber(txtPhoneNumber))
            {
                txtPhoneNumber.Text = Global.FomatPhoneNumber(txtPhoneNumber.Text);
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (!Global.ValidateInputNumber(txtCMND.Text))
            {
                KryptonMessageBox.Show(Constants.ERROR_INPUT_NUMBER, Constants.CONFIRM);
                string removeError = txtCMND.Text.Remove(txtCMND.Text.Length - 1);
                txtCMND.Text = removeError;                
            }
        }
    }
}