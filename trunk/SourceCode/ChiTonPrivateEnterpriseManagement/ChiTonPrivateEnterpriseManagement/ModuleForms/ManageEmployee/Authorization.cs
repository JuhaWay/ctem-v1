using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class Authorization : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private string _username;
        private List<EmployerDTO> _listEmp;
        private List<RightDTO> _listRight;
        private EmployerDTO _emp;
        private RoleDTO _role;
        private readonly RightBUS _rightBus = new RightBUS();
        public Authorization(string username, List<EmployerDTO> listEmployee)
        {
            InitializeComponent();
            _username = username;
            _listEmp = listEmployee;
            for (int i = 0; i < _listEmp.Count; i++)
            {
                EmployerDTO emp = _listEmp[i];
                if (emp.Username.Equals(_username))
                {
                    _emp = emp;
                    i = _listEmp.Count;
                }
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            Setlayout();
            SetData();
        }

        private void Setlayout()
        {
            CenterToScreen();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnlmain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxMain);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnSave);
            Global.SetDataCombobox(cbbRole, Constants.ROLE);
        }

        private void SetData()
        {
            _listRight = _rightBus.LoadAllRight();
            foreach (RightDTO right in _listRight)
            {
                clbRights.ListBox.Items.Add(right);
                clbRights.ListBox.ValueMember = Constants.RIGHT_VALUEMEMBER;
                clbRights.ListBox.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
            }            

            for (int i = 0; i < cbbRole.Items.Count; i++)
            {
                RoleDTO role = cbbRole.Items[i] as RoleDTO;
                if(role.RoleID.Equals(_emp.RoleID))
                {
                    _role = role;
                    cbbRole.SelectedIndex = i;
                    i = cbbRole.Items.Count;
                }
            }

            for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
            {
                clbRights.SetItemChecked(i, false);
            }
            List<RightDTO> listRightForUser = new List<RightDTO>();
            listRightForUser = _rightBus.GetRightByRole(_emp.RightsValue);
            foreach (RightDTO right in listRightForUser)
            {
                clbRights.SelectedItem = right;
            }
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
            {
                clbRights.SetItemChecked(i, false);
            }
            RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
            List<RightDTO> listRightForRole = new List<RightDTO>();
            listRightForRole = _rightBus.GetRightByRole(selectedRole.RightsValue);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long rightValue = 0;
            long roleId = Global.GetDataCombobox(cbbRole, Constants.ROLE);
            for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
            {
                RightDTO right = clbRights.ListBox.Items[i] as RightDTO;
                if (clbRights.CheckedItems.IndexOf(right) == i)
                {
                    rightValue += right.Value;
                }
            }
            EmployeeBUS empBus = new EmployeeBUS();
            bool success = empBus.UpdateEmployeeRight(_emp.employeeID, roleId, rightValue);
            if (success)
            {
                KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM);
            }
            else
            {
                KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
            }
        }
    }
}