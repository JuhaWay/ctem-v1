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
    public partial class NewSalary : KryptonForm
    {
        List<EmployeeSalaryDTO> listSalary = new List<EmployeeSalaryDTO>();
        EmployeeBUS employeeBUS = new EmployeeBUS();
        public NewSalary()
        {
            InitializeComponent();
        }

        private void NewSalary_Load(object sender, EventArgs e)
        {
            Setlayout();
            CenterToParent();
            setDefaultComboBox();
        }

        private void Setlayout()
        {
            CenterToParent();
            cbbEmployee.Focus();
            Global.SetTextBoxNumberLeave(txtSalary);
            Global.SetTextBoxNumberLeave(txtAllowance);
            Global.SetTextBoxNumberLeave(txtPhoneCost);
            Global.SetTextBoxNumberLeave(txtDebtPay);
            Global.SetTextBoxNumberLeave(txtActualIncome);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
        }

        private void setDefaultComboBox()
        {
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.SetDataCombobox(cbbIsPay, Constants.IS_PAY);
        }              

        private void ClearInput()
        {
            txtSalary.Text = Constants.EMPTY_TEXT;
            txtAllowance.Text = Constants.EMPTY_TEXT;
            txtPhoneCost.Text = Constants.EMPTY_TEXT;
            txtDebtPay.Text = Constants.EMPTY_TEXT;
            txtActualIncome.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
            cbbEmployee.SelectedItem = 0;
            cbbIsPay.SelectedItem = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string month = dtpMonth.Text;
            DateTime dtmonth = DateTime.ParseExact("01/" + month, "dd/MM/yyyy", null);
            string strmonth = dtmonth.ToString("yyyyMM");
            EmployerDTO employer = (EmployerDTO)cbbEmployee.SelectedItem;
            long empId = employer.employeeID;
            string username = employer.Username;
            string fullname = employer.Fullname;
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, ".");
            long allowance = Global.ConvertMoneyToLong(txtAllowance.Text, ".");
            long phoneCost = Global.ConvertMoneyToLong(txtPhoneCost.Text, ".");
            long debtPay = Global.ConvertMoneyToLong(txtDebtPay.Text, ".");
            long actualIncome = Global.ConvertMoneyToLong(txtActualIncome.Text, ".");
            int isPay = Global.GenerateStatus(cbbIsPay.Text);
            string notes = txtNote.Text;
            EmployeeSalaryDTO salaryDTO = new EmployeeSalaryDTO()
            {
                EmployeeID = empId,
                Fullname = fullname,
                Username = username,
                Month = strmonth,
                Salary = salary,
                Allowance = allowance,
                PhoneCost = phoneCost,
                DebtPay = debtPay,
                ActualIncome = actualIncome,
                IsPay = isPay,
                Note = notes
            };
            bool success = employeeBUS.CreateEmployeeSalary(salaryDTO);
            if (success)
            {
                if (KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearInput();
                    dtpMonth.Focus();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM);
            }
        }

        
        private void textboxNewSalary_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void textboxNewSalary_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            Global.SetTextBoxMoneyLeave(textBox);
        }                

        private void genarateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch (Exception)
            {                
            }
        }

        private void txtActualIncome_Enter(object sender, EventArgs e)
        {
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, ".");
            long allowance = Global.ConvertMoneyToLong(txtAllowance.Text, ".");
            long phoneCost = Global.ConvertMoneyToLong(txtPhoneCost.Text, ".");
            long debtPay = Global.ConvertMoneyToLong(txtDebtPay.Text, ".");
            long actualIncome = salary + allowance + phoneCost - debtPay;
            txtActualIncome.Text = Global.ConvertLongToMoney(actualIncome, ".");
        }       
        
    }
}