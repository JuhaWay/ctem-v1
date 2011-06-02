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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRole
{
    public partial class NewRole : KryptonForm
    {
        EmployerDTO employer;
        List<RoleDTO> listRole;
        List<RightDTO> listRights;
        long RoleID;
        long rightValue;
        RoleBUS roleBUS = new RoleBUS();
        RightBUS rightBUS = new RightBUS();
        bool isNew = false;
        bool isEdit = false;

        public NewRole(EmployerDTO _employer, List<RoleDTO> _listRole)
        {
            isNew = true;
            employer = _employer;
            listRole = _listRole;
            InitializeComponent();
        }

        public NewRole(EmployerDTO _employer, long _RoleID, long _rightValue, List<RoleDTO> _listRole)
        {
            isEdit = true;
            employer = _employer;
            RoleID = _RoleID;
            rightValue = _rightValue;
            listRole = _listRole;
            InitializeComponent();
            setInitValue();
        }

        private void setInitValue()
        {
            listRights = rightBUS.GetRightByRoleID(rightValue);
            foreach (var right in listRights)
            {
                lbxRights.Items.Add(right);
            }
            lbxRights.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
            lbxRights.ValueMember = Constants.RIGHT_VALUEMEMBER;

            foreach (var Role in listRole)
            {
                if (Role.RoleID == RoleID)
                {
                    txtRoleName.Text = Role.RoleName;
                    txtDescription.Text = Role.Description;
                    ckbisActive.Checked = Role.IsActive;                    
                    return;
                }
            }
        }

        private void NewRole_Load(object sender, EventArgs e)
        {
            CenterToParent();
            LoadRights();
        }

        private void LoadRights()
        {
            listRights = rightBUS.LoadAllRight();
            foreach (var role in listRights)
            {
                cbxRights.Items.Add(role);
            }
            cbxRights.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
            cbxRights.ValueMember = Constants.RIGHT_VALUEMEMBER;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string RoleName = txtRoleName.Text;
            string description = txtDescription.Text;
            bool isActive = ckbisActive.Checked;
            long rightsValue = 0;
            foreach (RightDTO right in lbxRights.Items)
            {
                rightsValue += right.Value;
            }
            if (isNew)
            {                
                roleBUS.AddRole(RoleName, description, rightsValue, isActive);
            }
            if (isEdit)
            {
                roleBUS.EditRole(RoleID, RoleName, description, rightsValue, isActive);
            }
            this.Close();
        }

        private void btnAddRight_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxRights.Items)
            {
                if (item.Equals(cbxRights.SelectedItem))
                {
                    MessageBox.Show("This Right was been added");
                    return;
                }
            }
            lbxRights.Items.Add(cbxRights.SelectedItem);
            lbxRights.ValueMember = Constants.RIGHT_VALUEMEMBER;
            lbxRights.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
        }
    }
}