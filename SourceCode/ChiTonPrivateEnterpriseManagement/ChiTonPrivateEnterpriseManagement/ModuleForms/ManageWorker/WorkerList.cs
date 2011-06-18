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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddNewWk add = new AddNewWk(_workSalaryID);
            add.ShowDialog();
            dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
        }

        private void dgvWorker_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvWorker.HitTest(e.X, e.Y).RowIndex;
            tempDto = dgvWorker.Rows[currentMouseOverRow].DataBoundItem as WorkerTempDTO;
            ipName.Text = tempDto.Fullname;
            ipPosition.Text = tempDto.Position;
            ipSalary.Text = tempDto.Salary.ToString();
            ipManDate.Text = tempDto.ManDate.ToString();
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            tempDto.Fullname = ipName.Text;
            tempDto.Position = ipPosition.Text;
            tempDto.ManDate = Convert.ToInt32(ipManDate.Text);
            tempDto.Salary = Convert.ToInt64(ipSalary.Text);
            _workerBUS.updateWks(tempDto);
            KryptonMessageBox.Show("Cập nhật thành công !      ", Constants.CONFIRM);
            dgvWorker.DataSource = _workerBUS.LoadAllWks(_workSalaryID);
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
    }
}