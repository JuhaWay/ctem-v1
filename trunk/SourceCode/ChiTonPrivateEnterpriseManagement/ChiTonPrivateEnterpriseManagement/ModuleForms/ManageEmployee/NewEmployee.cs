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
            CenterToParent();
            SetLayout();
            loadRole();
            //loadRight();
            DefineStatus();
            if (isEdit)
            {
                SetInnitValueWhenEdit();
            }
        }

        private void SetLayout()
        {
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

        private void DefineStatus()
        {
            cbbStatus.Items.Add(Constants.ACTIVE);
            cbbStatus.Items.Add(Constants.INACTIVE);
            cbbStatus.SelectedIndex = 0;
        }

        private void loadRole()
        {
            listRoles = roleBUS.GetAll();
            foreach (var role in listRoles)
            {
                cbbRole.Items.Add(role);
            }
            cbbRole.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
            cbbRole.ValueMember = Constants.ROLE_VALUEMEMBER;            
        }

        //private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
        //    {
        //        clbRights.SetItemChecked(i, false);
        //    }
        //    RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
        //    List<RightDTO> listRightForRole = new List<RightDTO>();
        //    listRightForRole = rightBUS.GetRightByRole(selectedRole.RightsValue);
        //    foreach (RightDTO right in listRightForRole)
        //    {
        //        clbRights.SelectedItem = right;                
        //    }
        //}

        //private void clbRights_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int index = clbRights.ListBox.SelectedIndex;
        //    clbRights.SetItemChecked(index, true);
        //}

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
            Global.SetTextBoxNumberLeave(txtTotalDebt);
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
            bool success = false;
            string username = txtUsername.Text;
            string password = DataProvider.Encrypt(Constants.DEFAULT_PASSWORD);
            string fullname = txtFullname.Text;
            string address = txtAddress.Text;
            long totalDebt = Convert.ToInt64(txtTotalDebt.Text);
            string email = txtEmail.Text;
            string CMND = txtCMND.Text;
            string DOB = dtpDOB.Text;
            RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
            long roleID = selectedRole.RoleID;
            int isActive = GenerateStatus(cbbStatus.Text);
            string phonenumber = txtPhoneNumber.Text;
            string notes = txtNote.Text;
            long rightsValue = 0;
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
        }
    }
}