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
        private bool isNext;
        private bool isPre;
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
            slcMain.SplitterDistance = Width;
            loadRole();
            loadRight();
            DefineStatus();
            if (isEdit)
            {
                SetInnitValueWhenEdit();
            }
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

        private void loadRight()
        {
            listRights = new List<RightDTO>();
            listRights = rightBUS.LoadAllRight();
            foreach (RightDTO right in listRights)
            {
                clbRights.ListBox.Items.Add(right);
            }
            clbRights.ListBox.ValueMember = Constants.RIGHT_VALUEMEMBER;
            clbRights.ListBox.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            isNext = true;
            timerLayoutSLC.Enabled = true;            
        }

        private void timerLayoutSLC_Tick(object sender, EventArgs e)
        {            
            slcMain.ContainerBackStyle = PaletteBackStyle.ControlClient;            
            if (isNext)
            {
                while (slcMain.SplitterDistance > (slcMain.SplitterWidth + 1))
                {
                    slcMain.SplitterDistance -= 10;
                    Refresh();
                }
                isNext = false;
                timerLayoutSLC.Enabled = false;
            }
            if (isPre)
            {
                while (slcMain.SplitterDistance < (Width - (slcMain.SplitterWidth + 16)))
                {
                    slcMain.SplitterDistance += 10;
                    Refresh();
                }
                isPre = false;
                timerLayoutSLC.Enabled = false;
            }            
            slcMain.ContainerBackStyle = PaletteBackStyle.PanelClient;            
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            isPre = true;
            timerLayoutSLC.Enabled = true;            
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
            {
                clbRights.SetItemChecked(i, false);
            }
            RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
            List<RightDTO> listRightForRole = new List<RightDTO>();
            listRightForRole = rightBUS.GetRightByRole(selectedRole.RightsValue);
            foreach (RightDTO right in listRightForRole)
            {
                clbRights.SelectedItem = right;                
            }
        }

        private void clbRights_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbRights.ListBox.SelectedIndex;
            clbRights.SetItemChecked(index, true);
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

        private void btnFinish_Click(object sender, EventArgs e)
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
            foreach (RightDTO right in clbRights.CheckedItems)
            {
                rightsValue += right.Value;
            }
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

        private void txtTotalDebt_Enter(object sender, EventArgs e)
        {
            txtTotalDebt.Text = Constants.EMPTY_TEXT;
        }

        private void txtTotalDebt_Leave(object sender, EventArgs e)
        {
            if (txtTotalDebt.Text.Equals(Constants.EMPTY_TEXT))
            {
                txtTotalDebt.Text = "0";
            }
        }
    }
}