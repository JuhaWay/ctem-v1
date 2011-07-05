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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class WorkerList : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private WorkerBUS _workerBUS = new WorkerBUS();
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        private WorkerTempDTO tempDto = new WorkerTempDTO();
        private long _workSalaryID ;
        public WorkerList(long id)
        {
            _workSalaryID = id;
            CenterToParent();
            InitializeComponent();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
            loadDetailValues(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                addNew();

        }

        private void dgvWorker_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvWorker.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
            
            
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvWorker.Rows.Count == 0)
            {
                tempDto = null;
                ipName.Text = "";
                ipPosition.Text = "";
                ipSalary.Text = "";
                ipManDate.Text = "";
                return;
            }
            tempDto = dgvWorker.Rows[currentMouseOverRow].DataBoundItem as WorkerTempDTO;
            ipName.Text = tempDto.Fullname;
            ipPosition.Text = tempDto.Position;
            ipSalary.Text = tempDto.Salary.ToString();
            ipManDate.Text = tempDto.ManDate.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tempDto != null)
            {
                if (!validate()) return;
                tempDto.Fullname = ipName.Text;
                tempDto.Position = ipPosition.Text;
                tempDto.ManDate = Convert.ToInt32(ipManDate.Text);
                tempDto.Salary = Convert.ToInt64(ipSalary.Text);
                tempDto.TotalSalary = tempDto.ManDate * tempDto.Salary;
                _workerBUS.updateWks(tempDto);
                KryptonMessageBox.Show("Cập nhật thành công !      ", Constants.CONFIRM);
                dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
            }
            else
            {
                KryptonMessageBox.Show(" ko tồn tại công nhân  !      ", Constants.CONFIRM);
            }
        }
        private Boolean validate()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng nhập tên !");
                return false;
            }
            else if (ipPosition.Text.Trim().Equals(""))
            {
                MessageBox.Show("vui lòng nhập vị trí !");
                return false;
            }
            else if (!Global.ValidateIntNumber(ipManDate.Text))
                return false;
            else if (!Global.ValidateLongNumber(ipSalary.Text))
                return false;

            return true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWorker.Rows)
            {
                DataGridViewCell c = dgvWorker.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    MessageBox.Show("");
                }
            }
        }

        private void dgvWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvWorker.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvWorker[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvWorker.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvWorker[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvWorker.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            addNew();
        }
        private void addNew()
        {
            AddNewWk add = new AddNewWk(_workSalaryID);
            add.ShowDialog();
            dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
            loadDetailValues(0);
            _workerSalaryBUS.UpdateTotalSalary(_workSalaryID);
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa công nhân ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dgvWorker.Rows)
                {
                    DataGridViewCell c = dgvWorker.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strRightID = row.Cells["workerID"].Value.ToString();
                        long ConstructionID = Convert.ToInt64(strRightID);
                        _workerBUS.delete(ConstructionID);
                    }
                }
                
                dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
                loadDetailValues(0);
            }
        }
    }
}