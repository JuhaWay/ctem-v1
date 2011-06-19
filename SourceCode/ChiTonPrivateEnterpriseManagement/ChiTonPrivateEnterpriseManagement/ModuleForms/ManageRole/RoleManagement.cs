using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRole
{
    public partial class RoleManagement: KryptonForm
    {
        RoleBUS roleBUS = new RoleBUS();
        List<RoleDTO> listRole;
        CheckBox _ckBox;
        public RoleManagement()
        {
            InitializeComponent();
        }

        private void loadRole()
        {
            listRole = roleBUS.LoadAllRole();
            dgvRole.DataSource = listRole;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadRole();
        }

        private void RoleManagementForm_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvRole);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();            
            loadRole();
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            NewRole newRole = new NewRole(listRole);
            newRole.ShowDialog();
            loadRole();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa những quyền này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = false;
                foreach (DataGridViewRow row in dgvRole.Rows)
                {
                    DataGridViewCell c = dgvRole.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strRoleID = row.Cells["RoleID"].Value.ToString();
                        long RoleID = Convert.ToInt64(strRoleID);
                        success = roleBUS.DeleteRole(RoleID);
                        if (success == false)
                        {
                            MessageBox.Show("Faile");
                        }                        
                    }
                }
                loadRole();
            }
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvRole);
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in dgvRole.Rows)
            {
                DataGridViewCell c = dgvRole.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRoleID = row.Cells["RoleID"].Value.ToString();
                    string strRightValue = row.Cells["RightsValue"].Value.ToString();
                    long RoleID = Convert.ToInt64(strRoleID);
                    long RightValue = Convert.ToInt64(strRightValue);
                    NewRole newRole = new NewRole(RoleID, RightValue, listRole);
                    newRole.ShowDialog();
                }
            }
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvRole[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvRole.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvRole[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvRole.Rows[e.RowIndex].Selected = true;
                }
            }
        }
    }
}