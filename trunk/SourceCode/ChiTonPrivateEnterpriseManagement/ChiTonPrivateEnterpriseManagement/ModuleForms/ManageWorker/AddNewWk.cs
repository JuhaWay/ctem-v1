using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class AddNewWk : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private WorkerBUS _workerBUS = new WorkerBUS();
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private long _WksID;
        private long _WkID;
        private DateTime _fromDate;
        private DateTime _toDate;
        private long _ohtersCost;
        WorkerTempDTO dtoTemp = new WorkerTempDTO();
        private List<DayWorkingDTO> list = new List<DayWorkingDTO>();
        private Double manDate = 0;
        public AddNewWk(long id,DateTime fromDate,DateTime toDate,long otherCost)
        {
            _WksID = id;
            _fromDate = fromDate;
            _toDate = toDate;
            _ohtersCost = otherCost;
            InitializeComponent();
            CenterToParent();
        }

        public AddNewWk(long id, long WkID, DateTime fromDate, DateTime toDate, long otherCost)
        {
            _WksID = id;
            _WkID = WkID;
            _fromDate = fromDate;
            _toDate = toDate;
            _ohtersCost = otherCost;
            InitializeComponent();
            CenterToParent();
            
        }
        private void AddNewWk_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetDaulftDatagridview(dgvWD);
            dgvWD.ReadOnly = false;
            if (_WkID == 0)
            {
                list = getDates(_fromDate, _toDate);
            }
            else
            {
                loadUPdate();
                list = _workerBUS.LoadAllDaysWorking(_WkID);
                
            }
            dgvWD.DataSource = list;

        }


        public void loadUPdate(){
            dtoTemp = _workerBUS.LoadWorkerByID(_WkID);
            ipName.Text = dtoTemp.Fullname;
            ipPosition.Text = dtoTemp.Position;
            ipSalary.Text = dtoTemp.SalaryFormated;
            lbManDate.Text = dtoTemp.ManDate.ToString();
            txtAllowance.Text = dtoTemp.AllowanceFomated;
            txtReason.Text = dtoTemp.Reason;
            manDate = dtoTemp.ManDate;
        }


        public List<DayWorkingDTO> getDates(DateTime fromDate, DateTime toDate)
        {
            List<DayWorkingDTO> list = new List<DayWorkingDTO>();
            DayWorkingDTO dto = new DayWorkingDTO();
            DateTime currentDate = fromDate.Date;
            while(currentDate<=toDate.Date){
                dto = new DayWorkingDTO();
                dto.Date = currentDate;
                dto.DateFormated = dto.Date.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                dto.Value = 0;
                list.Add(dto);
                currentDate = currentDate.AddDays(1);
            }
            return list;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (_WkID == 0)
            {
                if (!validate()) return;
                WorkerTempDTO dto = new WorkerTempDTO();
                dto.WorkersSalaryID = _WksID;
                dto.Fullname = ipName.Text;
                dto.Position = ipPosition.Text;
                dto.Salary = Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP);
                dto.Allowance = Global.ConvertMoneyToLong(txtAllowance.Text, Constants.SPLIP_MONEY);
                dto.Reason = txtReason.Text;
                dto.ManDate = manDate;
                dto.TotalSalary = (long)(dto.ManDate * dto.Salary + dto.Allowance);
                long conID = _workerSalaryBUS.getConID(_WksID);
                double totalEst = _estimateDetailBUS.getTotal(conID, EstimateDetailDTO.TYPE_WORKER);
                long sum = _workerBUS.sumTotal(_WksID);
                if ((dto.TotalSalary + sum+_ohtersCost) > totalEst)
                {
                    if (KryptonMessageBox.Show("Tổng chi phí bảng lương đã vượt dự toán công nhân, dự toán công nhân hiện tại là :" +
                        totalEst + " bạn có muốn tiếp tục lưu",
                        Constants.CONFIRM, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        long ID = _workerBUS.CreateWks(dto);
                        foreach (DayWorkingDTO item in list)
                        {
                            item.WorkerID = ID;
                            _workerBUS.CreateDayWorking(item);
                        }
                        this.Close();
                    }
                }
                else
                {
                    long ID = _workerBUS.CreateWks(dto);
                    foreach (DayWorkingDTO item in list)
                    {
                        item.WorkerID = ID;
                        _workerBUS.CreateDayWorking(item);
                    }
                    this.Close();
                }

            }
            else
            {
                if (!validate()) return;
                dtoTemp.Fullname = ipName.Text;
                dtoTemp.Position = ipPosition.Text;
                dtoTemp.Salary = Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP);
                dtoTemp.Allowance = Global.ConvertMoneyToLong(txtAllowance.Text, Constants.SPLIP_MONEY);
                dtoTemp.Reason = txtReason.Text;
                dtoTemp.ManDate = manDate;
                dtoTemp.TotalSalary = (long)(dtoTemp.ManDate * dtoTemp.Salary + dtoTemp.Allowance);
                long conID = _workerSalaryBUS.getConID(dtoTemp.WorkersSalaryID);
                double totalEst = _estimateDetailBUS.getTotal(conID, EstimateDetailDTO.TYPE_WORKER);
                long sum = _workerBUS.sumTotal(dtoTemp.WorkersSalaryID);
                if ((dtoTemp.TotalSalary + sum + _ohtersCost) > totalEst)
                {
                    if (KryptonMessageBox.Show("Tổng chi phí bảng lương đã vượt dự toán công nhân, dự toán công nhân hiện tại là :" +
                        totalEst + " bạn có muốn tiếp tục lưu",
                        Constants.CONFIRM, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _workerBUS.updateWks(dtoTemp);
                        foreach (DayWorkingDTO item in list)
                        {
                            item.WorkerID = _WkID;
                            _workerBUS.CreateDayWorking(item);
                        }
                        this.Close();
                    }
                }
                else
                {
                   
                    _workerBUS.updateWks(dtoTemp);
                    foreach (DayWorkingDTO item in list)
                    {
                        item.WorkerID = _WkID;
                        _workerBUS.CreateDayWorking(item);
                    }
                    this.Close();
                }
            }
           

        }
        private Boolean validate()
        {
            if(ipName.Text.Trim().Equals("")){
                MessageBox.Show("vui lòng nhập tên !");
                return false;
            }else if(ipPosition.Text.Trim().Equals("")){
                 MessageBox.Show("vui lòng nhập vị trí !");
                 return false;
            }
            return true;
        }

        private void ipSalary_Leave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }

        private void ipSalary_MouseLeave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }

        private void dgvWD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                manDate = 0;
                foreach (DayWorkingDTO item in list)
                {
                    manDate += item.Value;
                }

                lbManDate.Text = manDate.ToString();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAllowance_Enter(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void txtAllowance_Leave(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxMoneyLeave(textBox);
        }

        private void dgvWD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string s = e.FormattedValue.ToString();
                if (Global.ValidateDoubleNumber(s))
                {
                    double num = Convert.ToDouble(s);
                    if (num < 0 || num > 2)
                    {
                        KryptonMessageBox.Show("Chỉ cho phép nhập từ 0 đến 2", Constants.CONFIRM, MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
                else
                {
                    KryptonMessageBox.Show("Nhập sai thông tin Km", Constants.CONFIRM, MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

            }
        }
        
    }
}