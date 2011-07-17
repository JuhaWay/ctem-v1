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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class EmployeeManagement: KryptonForm
    {
        EmployeeBUS employeeBUS = new EmployeeBUS();
        List<EmployerDTO> listEmployee;
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void loadEmployee()
        {
            string roleName = cbbRole.Text;
            if (roleName.Equals(Constants.ALL))
            {
                roleName = Constants.EMPTY_TEXT;
            }
            string username = txtNameSearch.Text;
            string fullname = txtFullname.Text;
            int status;
            if (cbbStatusSearch.Text.Equals(Constants.ACTIVE))
            {
                status = 1;
            }
            else if (cbbStatusSearch.Text.Equals(Constants.INACTIVE))
            {
                status = 0;
            }
            else
            {
                status = -1;
            }
            listEmployee = employeeBUS.LoadEmployee(username, fullname, roleName, status);
            dgvEmployee.DataSource = listEmployee;
        }

        private void RefreshData()
        {
            txtFullname.Text = Constants.EMPTY_TEXT;
            txtNameSearch.Text = Constants.EMPTY_TEXT;
            cbbStatusSearch.SelectedIndex = 1;
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 0;
            }
            loadEmployee();
        }

        private void SetLayout()
        {
            pnlSearch.Height = 82;
            gbxSearch.Height = 78;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEmp, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEmployee);
            Global.SetDaulftDatagridview(dgvEmployee);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);            
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetDataCombobox(cbbRole, Constants.ROLE_SEARCH);
            Global.SetDataCombobox(cbbStatusSearch, Constants.STATUS_SEARCH);
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }
        
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            if (Global.IsAllow(Constants.CREATE_NEW_EMPLOYEE))
            {
                NewEmployee newEmployee = new NewEmployee();
                newEmployee.ShowDialog();
                RefreshData();
            }
            else
            {
                KryptonMessageBox.Show(Constants.NOT_PERMISSION, Constants.CONFIRM);
            }
        }


        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployee.SelectedRows[0];
            string Username = row.Cells["Username"].Value.ToString();
            NewEmployee newEmployee = new NewEmployee(Username, listEmployee);
            newEmployee.ShowDialog();
            RefreshData();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtFullname.Text = Constants.EMPTY_TEXT;
            txtNameSearch.Text = Constants.EMPTY_TEXT;
            cbbStatusSearch.SelectedIndex = 0;
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 0;
            }
            loadEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                {
                    string username = row.Cells["Username"].Value.ToString();
                    success = employeeBUS.DeleteEmp(username);

                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = employeeBUS.DeleteAllEmp();
                if (success)
                {
                    KryptonMessageBox.Show(Constants.DELETE_SUCESS);
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR);
                }
            }
            RefreshData();
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 82, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 82, 2, 4, true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow r = dgvEmployee.Rows[e.RowIndex];
                string Username = r.Cells["Username"].Value.ToString();
                NewEmployee newEmployee = new NewEmployee(Username, listEmployee);
                newEmployee.ShowDialog();
                RefreshData();
            }
        }

        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvEmployee.SelectedRows[0];
            string Username = r.Cells["Username"].Value.ToString();
            Authorization authorization = new Authorization(Username, listEmployee);
            authorization.ShowDialog();
            RefreshData();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
            txtNameSearch.Focus();
        }

        private void HideSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            dgvEmployee.Focus();
        }
    }
}