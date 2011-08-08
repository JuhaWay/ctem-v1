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
        private DateTime _fromDate;
        private DateTime _toDate;
        private List<DayWorkingDTO> _list = new List<DayWorkingDTO>();
        public WorkerList(long id, long ConstructionID, DateTime fromDate, DateTime toDate)
        {
            _fromDate = fromDate;
            _toDate = toDate;
            _ConstructionID = ConstructionID;
            _workSalaryID = id;         
            InitializeComponent();
            CenterToScreen();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(kryptonHeader1, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvWorker);
            Global.SetLayoutPanelChildForm(kryptonPanel4);
            refresh();
        }
        public void refresh()
        {
            List<WorkerTempDTO> list = _workerBUS.LoadAllWks(_workSalaryID);
            dgvWorker.DataSource = list;
            sum(list);
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
            AddNewWk add = new AddNewWk(_workSalaryID,_fromDate,_toDate);
            add.ShowDialog();
            refresh();
            _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dgvWorker.SelectedRows)
                {
                    long ID = (dgvWorker.SelectedRows[0].DataBoundItem as WorkerTempDTO).WorkerID;
                    _workerBUS.delete(ID);
                }

                refresh();
                _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWorker.SelectedRows)
            {
                WorkerTempDTO item = row.DataBoundItem as WorkerTempDTO;
                AddNewWk add = new AddNewWk(_workSalaryID,item.WorkerID, _fromDate, _toDate);
                add.ShowDialog();
                refresh();
                _workerSalaryBUS.UpdateTotalSalary(_workSalaryID, _ConstructionID);
            }
        }

        private void dgvWorker_DoubleClick(object sender, EventArgs e)
        {
            btEdit_Click(null, null);
        }
    }
}