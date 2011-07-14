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
        public int locationXpnlNewItem;
        List<EmployeeSalaryDTO> listSalary = new List<EmployeeSalaryDTO>();
        List<EmployerDTO> listEmployee = new List<EmployerDTO>();
        EmployeeBUS employeeBUS = new EmployeeBUS();
        public NewSalary()
        {
            InitializeComponent();
        }

        private void NewSalary_Load(object sender, EventArgs e)
        {
            CenterToParent();
            setDefaultComboBox();
        }

        private void setDefaultComboBox()
        {
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);            

            cbbIsPay.Items.Add(Constants.PAY);
            cbbIsPay.Items.Add(Constants.NOTPAY);
            cbbIsPay.SelectedIndex = 0;
        }        

        public void Refreshdgv()
        {
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
         
        }

        private void NewSalary_SizeChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string month = dtpMonth.Text;
            DateTime dtmonth = DateTime.ParseExact("01/" + month, "dd/MM/yyyy", null);
            string strmonth = dtmonth.ToString("yyyyMM");
            EmployerDTO employer = (EmployerDTO) cbbEmployee.SelectedItem;
            long empId = employer.employeeID;
            string username = employer.Username;
            string fullname = employer.Fullname;
            long salary = Global.ConvertMoneyToLong(txtSalary.Text, ".");
            long allowance = Global.ConvertMoneyToLong(txtAllowance.Text, ".");
            long phoneCost = Global.ConvertMoneyToLong(txtPhoneCost.Text, ".");
            long debtPay = Global.ConvertMoneyToLong(txtDebtPay.Text, ".");
            long actualIncome = Global.ConvertMoneyToLong(txtActualIncome.Text, ".");
            int isPay = GenerateStatus(cbbIsPay.Text);
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
            for (int i = 0; i < listEmployee.Count; i++ )
            {
                EmployerDTO employee = listEmployee[i];
                if (employee.employeeID == empId)
                {
                    salaryDTO.Fullname = employee.Fullname;
                    salaryDTO.Username = employee.Username;
                }
            }
            listSalary.Add(salaryDTO);
            Refreshdgv();
            ClearInput();
        }

        private int GenerateStatus(string strStatus)
        {
            int isActie;
            if (strStatus.Equals(Constants.PAY))
            {
                isActie = Constants.ISACTIVE_TRUE;
            }
            else
            {
                isActie = Constants.ISACTIVE_FALSE;
            }
            return isActie;
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
            foreach (EmployeeSalaryDTO salary in listSalary)
            {
                employeeBUS.CreateEmployeeSalary(salary);
            }
        }

        
        private void textboxNewSalary_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            Global.ClearTextboxSalary(textBox);
        }

        private void textboxNewSalary_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox) sender;
            SetInitValueTexboxSalary(textBox);
            if (!Global.ValidateULongNumber(textBox.Text.Trim().Replace(".", "")))
            {
                textBox.Focus();
                textBox.Text = Constants.EMPTY_TEXT;
            }            
        }
        
        private void SetInitValueTexboxSalary(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                textBox.Text = "0";
            }
        }

        private void genarateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += ".000";                    
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