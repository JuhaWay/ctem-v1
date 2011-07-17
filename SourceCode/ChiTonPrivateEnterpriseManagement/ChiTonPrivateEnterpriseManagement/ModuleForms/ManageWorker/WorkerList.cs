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
        private long _ConstructionID;
        public WorkerList(long id, long ConstructionID)
        {
            _ConstructionID = ConstructionID;
            _workSalaryID = id;         
            InitializeComponent();
            CenterToScreen();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            List<WorkerTempDTO> list = _workerBUS.LoadAllWks(_workSalaryID);
            dgvWorker.DataSource = list;
            sum(list);
            loadDetailValues(0);
        }

        public void sum(List<WorkerTempDTO> list)
        {
            long total = 0;
            foreach (WorkerTempDTO item in list)
            {
                total += item.TotalSalary;
            }
            ipSummary.Text = Global.ConvertLongToMoney(total, Global.SEP);
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
            ipSalary.Text = tempDto.SalaryFormated;
            ipManDate.Text = tempDto.ManDate.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tempDto != null)
            {
                if (!validate()) return;
                tempDto.Fullname = ipName.Text;
                tempDto.Position = ipPosition.Text;
                tempDto.ManDate = Convert.ToDouble(ipManDate.Text);
                tempDto.Salary = Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP);
                tempDto.TotalSalary = (long)(tempDto.ManDate * tempDto.Salary);
                _workerBUS.updateWks(tempDto);
                KryptonMessageBox.Show("Cập nhật thành công !      ", Constants.CONFIRM);
                refresh();
                _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
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

     

        private void btAddNew_Click(object sender, EventArgs e)
        {
            addNew();
        }
        private void addNew()
        {
            AddNewWk add = new AddNewWk(_workSalaryID);
            add.ShowDialog();
            refresh();
            _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
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

                refresh();
                _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
            }
        }

        private void ipSalary_Leave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }

        private void ipSalary_MouseLeave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }
    }
}