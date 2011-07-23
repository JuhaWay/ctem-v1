using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class EmployeeExpenseReceiptDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private bool _isNew;
        private long _salaryId;
        private long _empId;
        private string _month;
        private readonly EmployeeBUS _employeeBus = new EmployeeBUS();
        public EmployeeExpenseReceiptDetail()
        {
            InitializeComponent();
            _isNew = true;
        }

        public EmployeeExpenseReceiptDetail(long salaryId, long empId, string month)
        {
            InitializeComponent();
            _isNew = false;
            _salaryId = salaryId;
            _empId = empId;
            _month = month;
        }

        private void EmployeeExpenseReceiptDetail_Load(object sender, EventArgs e)
        {
            SetLayoutCommon();
            if (!_isNew)
            {
                InnitLayoutEdit();
            }
        }
        private void SetLayoutCommon()
        {
            CenterToScreen();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(kryptonPanel1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox3);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox4);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox5);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.SetDataCombobox(cbbIsPay, Constants.IS_PAY);
            txtTotalAdvance.ReadOnly = true;
            txtAllowance.ReadOnly = true;
            txtActIncome.ReadOnly = true;
            var empDto = cbbEmployee.SelectedItem as EmployerDTO;
            string emp = empDto.Fullname;
            DateTime month = dtpMonth.Value;            
            txtAllowance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, "Phụ Cấp"), Constants.SPLIP_MONEY);
            txtTotalAdvance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, "Ứng Lương"),
                                                             Constants.SPLIP_MONEY);
        }

        private void InnitLayoutEdit()
        {
            var salary = _employeeBus.LoadSalaryById(_salaryId);
            if (salary != null)
            {
                txtSalary.Text = salary.SalaryFormat;
                txt10pcSalary.Text = salary.SalarypcFormat;
                txtDebtPay.Text = salary.DebtPayFormat;
                txtDebt1.Text = salary.Debt1Format;
                txtDebt2.Text = salary.Debt2Format;
                txtActIncome.Text = salary.ActualIncomeFormat;
                for (int i = 0; i < cbbEmployee.Items.Count; i++)
                {
                    var emp = cbbEmployee.Items[i] as EmployerDTO;
                    if (emp.employeeID == salary.EmployeeID)
                    {
                        cbbEmployee.SelectedIndex = i;
                        i = cbbEmployee.Items.Count;
                    }
                }
                DateTime dtmonth = DateTime.ParseExact(salary.Month + "01 00:00:00", "yyyyMMdd hh:mm:ss", null);
                dtpMonth.Value = dtmonth;
                if (salary.IsPay)
                {
                    cbbIsPay.SelectedIndex = 0;
                }
                else
                {
                    cbbIsPay.SelectedIndex = 1;
                }
            }            
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var empDto = cbbEmployee.SelectedItem as EmployerDTO;
            string emp = empDto.Fullname;
            DateTime month = dtpMonth.Value;
            string type = "Phụ Cấp";
            var advanceManagement = new AdvanceManagement(emp, month, type);
            advanceManagement.ShowDialog();
            txtAllowance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, type), Constants.SPLIP_MONEY);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            DateTime dtmonth = DateTime.ParseExact("01/" + dtpMonth.Text, "dd/MM/yyyy", null);
            string strmonth = dtmonth.ToString("yyyyMM");
            var employer = cbbEmployee.SelectedItem as EmployerDTO;
            long empId = employer.employeeID;
            string username = employer.Username;
            string fullname = employer.Fullname;
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, Constants.SPLIP_MONEY);
            long salarycp = Global.ConvertMoneyToLong(txt10pcSalary.Text, Constants.SPLIP_MONEY);
            long allowance = Global.ConvertMoneyToLong(txtAllowance.Text, Constants.SPLIP_MONEY);
            long debtPay = Global.ConvertMoneyToLong(txtDebtPay.Text, Constants.SPLIP_MONEY);
            long debt1 = Global.ConvertMoneyToLong(txtDebt1.Text, Constants.SPLIP_MONEY);
            long debt2 = Global.ConvertMoneyToLong(txtDebt1.Text, Constants.SPLIP_MONEY);
            long totalAdvance = Global.ConvertMoneyToLong(txtTotalAdvance.Text, Constants.SPLIP_MONEY);            
            long actualIncome = Global.ConvertMoneyToLong(txtActIncome.Text, Constants.SPLIP_MONEY);
            bool isPay = Global.GenerateStatus(cbbIsPay.Text);
            DateTime dateReceive = dtpDateReceive.Value;
            var salaryDTO = new EmployeeSalaryDTO()
            {
                EmployeeSalaryID = _salaryId,
                EmployeeID = empId,
                Fullname = fullname,
                Username = username,
                Month = strmonth,
                Salary = salary,
                Salarypc = salarycp,
                TotalAllowance = allowance,
                DebtPay = debtPay,
                Debt1 = debt1,
                Debt2 = debt2,
                TotalAdvanceSalary = totalAdvance,
                ActualIncome = actualIncome,
                IsPay = isPay,
                DateReceive = dateReceive,
            };
            bool success;
            if(_isNew)
            {
                success = _employeeBus.CreateEmployeeSalary(salaryDTO);
                if (success)
                {
                    if (KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearLayout();
                        dtpMonth.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
                }
            }
            else
            {
                success = _employeeBus.UpdateEmployeeSalary(salaryDTO);
                if (success)
                {
                    if (KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {                        
                        dtpMonth.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }

        private void ClearLayout()
        {
            return;
        }

        private void btnDetialAdvance_Click(object sender, EventArgs e)
        {
            var empDto = cbbEmployee.SelectedItem as EmployerDTO;
            string emp = empDto.Fullname;
            DateTime month = dtpMonth.Value;
            string type = "Ứng Lương";
            var advanceManagement = new AdvanceManagement(emp, month, type);
            advanceManagement.ShowDialog();
            txtTotalAdvance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, type), Constants.SPLIP_MONEY);
        }

        private void cbbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var empDto = cbbEmployee.SelectedItem as EmployerDTO;
            string emp = empDto.Fullname;
            DateTime month = dtpMonth.Value;
            txtAllowance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, "Phụ Cấp"), Constants.SPLIP_MONEY);
            txtTotalAdvance.Text = Global.ConvertLongToMoney(_employeeBus.GetTotal(emp, month, "Ứng Lương"),
                                                             Constants.SPLIP_MONEY);
        }

        private void txt10pcSalary_Enter(object sender, EventArgs e)
        {
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, Constants.SPLIP_MONEY);
            long salarypc = (long) (salary*0.1);
            txt10pcSalary.Text = Global.ConvertLongToMoney(salarypc, Constants.SPLIP_MONEY);
        }

        private void txtActIncome_Enter(object sender, EventArgs e)
        {
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, Constants.SPLIP_MONEY);
            long salarycp = Global.ConvertMoneyToLong(txt10pcSalary.Text, Constants.SPLIP_MONEY);
            long allowance = Global.ConvertMoneyToLong(txtAllowance.Text, Constants.SPLIP_MONEY);
            long debtPay = Global.ConvertMoneyToLong(txtDebtPay.Text, Constants.SPLIP_MONEY);
            long debt1 = Global.ConvertMoneyToLong(txtDebt1.Text, Constants.SPLIP_MONEY);
            long debt2 = Global.ConvertMoneyToLong(txtDebt1.Text, Constants.SPLIP_MONEY);
            long totalAdvance = Global.ConvertMoneyToLong(txtTotalAdvance.Text, Constants.SPLIP_MONEY);
            long actualIncome = salary - salarycp - debtPay - debt1 - debt2 - totalAdvance;
            txtActIncome.Text = Global.ConvertLongToMoney(actualIncome, Constants.SPLIP_MONEY);
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxMoneyLeave(textBox);
        }

        private void GenMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch
            {
            }
        }
    }
}