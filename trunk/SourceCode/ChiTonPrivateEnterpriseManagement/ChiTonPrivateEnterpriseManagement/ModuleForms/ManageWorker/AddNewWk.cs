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

        private long _WksID;
        private long _WkID;
        private DateTime _fromDate;
        private DateTime _toDate;
        WorkerTempDTO dtoTemp = new WorkerTempDTO();
        private List<DayWorkingDTO> list = new List<DayWorkingDTO>();
        private Double manDate = 0;
        public AddNewWk(long id,DateTime fromDate,DateTime toDate)
        {
            _WksID = id;
            _fromDate = fromDate;
            _toDate = toDate;      
            InitializeComponent();
            CenterToParent();
        }

        public AddNewWk(long id,long WkID, DateTime fromDate, DateTime toDate)
        {
            _WksID = id;
            _WkID = WkID;
            _fromDate = fromDate;
            _toDate = toDate;
            InitializeComponent();
            CenterToParent();
            
        }
        private void AddNewWk_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
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
                dto.ManDate = manDate;
                dto.TotalSalary = (long)(dto.ManDate * dto.Salary);
                long ID = _workerBUS.CreateWks(dto);
                foreach (DayWorkingDTO item in list)
                {
                    item.WorkerID = ID;
                    _workerBUS.CreateDayWorking(item);
                }
            }
            else
            {
                if (!validate()) return;
                dtoTemp.Fullname = ipName.Text;
                dtoTemp.Position = ipPosition.Text;
                dtoTemp.Salary = Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP);
                dtoTemp.ManDate = manDate;
                dtoTemp.TotalSalary = (long)(dtoTemp.ManDate * dtoTemp.Salary);
                _workerBUS.updateWks(dtoTemp);
                foreach (DayWorkingDTO item in list)
                {
                    item.WorkerID = _WkID;
                    _workerBUS.CreateDayWorking(item);
                }
            }
            this.Close();

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

                string s = dgvWD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (Global.ValidateDoubleNumber(s))
                {
                    double num = Convert.ToDouble(s);
                    if (num<0 ||num>1.5)
                    {
                        KryptonMessageBox.Show("Chỉ cho phép nhập từ 0 đến 1.5", Constants.CONFIRM, MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                        dgvWD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        
                    }
                }
                else
                {
                    KryptonMessageBox.Show("Nhập sai thông tin Km", Constants.CONFIRM, MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    dgvWD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

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
        
    }
}