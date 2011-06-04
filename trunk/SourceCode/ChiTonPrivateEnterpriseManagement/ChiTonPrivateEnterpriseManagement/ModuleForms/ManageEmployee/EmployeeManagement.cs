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
        EmployerDTO employer;
        Global global = new Global();
        EmployeeBUS employeeBUS = new EmployeeBUS();
        List<EmployerDTO> listEmployee;
        CheckBox ckBox;
        public EmployeeManagement(EmployerDTO _employer)
        {
            employer = _employer;
            InitializeComponent();
        }

        private void loadEmployee()
        {
            listEmployee = employeeBUS.LoadAllEmployee();
            dgvEmployee.DataSource = listEmployee;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            dgvEmployee.Columns[0].Width = 25;
            dgvEmployee.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ckBox = new CheckBox();
            //Get the column header cell bounds
            Rectangle rect = this.dgvEmployee.GetCellDisplayRectangle(0, -1, true);
            ckBox.Size = new Size(18, 18);
            ckBox.BackColor = Color.Transparent;
            //Change the location of the CheckBox to make it stay on the header
            rect.Location = new Point(30, 4);
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            this.dgvEmployee.Controls.Add(ckBox);
            for (int i = 1; i < dgvEmployee.ColumnCount; i++)
            {
                dgvEmployee.Columns[i].Width = (dgvEmployee.Width - dgvEmployee.RowHeadersWidth - dgvEmployee.Columns[0].Width) / (dgvEmployee.ColumnCount - 1);
            }           
            loadEmployee();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.ShowDialog();
            loadEmployee();
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
            for (int j = 0; j < this.dgvEmployee.RowCount; j++)
            {
                DataGridViewCell c = dgvEmployee.Rows[j].Cells[0];
                c.AccessibilityObject.Value = ckBox.Checked.ToString();
                dgvEmployee[0, j].Value = this.ckBox.Checked;
                dgvEmployee.Rows[j].Selected = this.ckBox.Checked;
            }
            this.dgvEmployee.EndEdit();
            dgvEmployee.Refresh();

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                DataGridViewCell c = dgvEmployee.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strEmployeeID = row.Cells["EmployeeID"].Value.ToString();
                    string strRightValue = row.Cells["RightsValue"].Value.ToString();
                    long EmployeeID = Convert.ToInt64(strEmployeeID);
                    long RightValue = Convert.ToInt64(strRightValue);
                    //NewEmployee newEmployee = new NewEmployee(employer, EmployeeID, RightValue, listEmployee);
                    //newEmployee.ShowDialog();
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
    }
}