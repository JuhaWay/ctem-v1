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
        long RoleID;
        RoleBUS RoleBUS = new RoleBUS();
        bool isNew = false;
        bool isEdit = false;

        public NewRole(EmployerDTO _employer, List<RoleDTO> _listRole)
        {
            isNew = true;
            employer = _employer;
            listRole = _listRole;
            InitializeComponent();
        }

        public NewRole(EmployerDTO _employer, long _RoleID, List<RoleDTO> _listRole)
        {
            isEdit = true;
            employer = _employer;
            RoleID = _RoleID;
            listRole = _listRole;
            InitializeComponent();
            setInitValue();
        }

        private void setInitValue()
        {
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                string RoleName = txtRoleName.Text;
                string description = txtDescription.Text;
                bool isActive = ckbisActive.Checked;
                //RoleBUS.AddRole(RoleName, isActive, description, listRole);
            }
            if (isEdit)
            {
                string RoleName = txtRoleName.Text;
                string description = txtDescription.Text;
                bool isActive = ckbisActive.Checked;
                //RoleBUS.EditRole(RoleID, RoleName, isActive, description, employer, listRole);
            }
            this.Close();
        }
    }
}