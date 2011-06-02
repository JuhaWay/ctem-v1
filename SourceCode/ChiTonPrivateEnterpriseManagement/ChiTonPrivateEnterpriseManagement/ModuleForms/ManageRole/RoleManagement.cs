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
        EmployerDTO employer;
        Global global = new Global();
        RoleBUS roleBUS = new RoleBUS();
        List<RoleDTO> listRole;
        CheckBox ckBox;
        public RoleManagement(EmployerDTO _employer)
        {
            employer = _employer;
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
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            dgvRole.Columns[0].Width = 25;
            dgvRole.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRole.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ckBox = new CheckBox();
            //Get the column header cell bounds
            Rectangle rect = this.dgvRole.GetCellDisplayRectangle(0, -1, true);
            ckBox.Size = new Size(18, 18);
            ckBox.BackColor = Color.Transparent;
            //Change the location of the CheckBox to make it stay on the header
            rect.Location = new Point(30, 4);
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            //Add the CheckBox into the DataGridView
            this.dgvRole.Controls.Add(ckBox);
            for (int i = 1; i < dgvRole.ColumnCount; i++)
            {
                dgvRole.Columns[i].Width = (dgvRole.Width - dgvRole.RowHeadersWidth - dgvRole.Columns[0].Width) / (dgvRole.ColumnCount - 1);
                //dgvRole.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvRole.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }           
            loadRole();
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            NewRole newRole = new NewRole(employer, listRole);
            newRole.ShowDialog();
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
                        else
                        {
                            loadRole();
                        }
                    }
                }
            }
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < this.dgvRole.RowCount; j++)
            {
                DataGridViewCell c = dgvRole.Rows[j].Cells[0];
                c.AccessibilityObject.Value = ckBox.Checked.ToString();
                dgvRole[0, j].Value = this.ckBox.Checked;
                dgvRole.Rows[j].Selected = this.ckBox.Checked;
            }
            this.dgvRole.EndEdit();
            dgvRole.Refresh();

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
                    NewRole newRole = new NewRole(employer, RoleID, RightValue, listRole);
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