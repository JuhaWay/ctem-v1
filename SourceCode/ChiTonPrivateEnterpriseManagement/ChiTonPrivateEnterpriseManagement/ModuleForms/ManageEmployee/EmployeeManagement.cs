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
            listEmployee = employeeBUS.LoadAllEmployee();
            dgvEmployee.DataSource = listEmployee;
        }

        private void SetLayout()
        {
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEmp, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEmployee);
            Global.SetDaulftDatagridview(dgvEmployee);
            Global.SetLayoutSplipContainer(slcMain, 2);
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            SetLayout();
            loadEmployee();
        }
        
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            //if (Global.IsAllow(Constants.CREATE_NEW_EMPLOYEE))
            //{
                NewEmployee newEmployee = new NewEmployee();
                newEmployee.ShowDialog();
                loadEmployee();
            //}
            //else
            //{
            //    KryptonMessageBox.Show(Constants.NOT_PERMISSION, Constants.CONFIRM);
            //}
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa những quyền này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = false;
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    DataGridViewCell c = dgvEmployee.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strEmployeeID = row.Cells["EmployeeID"].Value.ToString();
                        long EmployeeID = Convert.ToInt64(strEmployeeID);
                        //success = EmployeeBUS.DeleteEmployee(EmployeeID);
                        if (success == false)
                        {
                            MessageBox.Show("Faile");
                        }                        
                    }
                }
                loadEmployee();
            }
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                DataGridViewCell c = dgvEmployee.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string Username = row.Cells["Username"].Value.ToString();
                    NewEmployee newEmployee = new NewEmployee(Username, listEmployee);
                    newEmployee.ShowDialog();
                }
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvEmployee[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvEmployee.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvEmployee[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvEmployee.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}