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
            Global.CenterToParent(btnMoveUp, pnlMoveUp, Constants.HORISONTAL_TOP, 0);
            Global.CenterToParent(btnMoveDown, pnlMoveDown, Constants.HORISONTAL_TOP, 0);
            Global.CenterToParent(pnlNewSalaryItem, pnlMain, Constants.HORISONTAL_BOT_CUSTOM, pnlMoveUp.Height);
        }

        private void setDefaultComboBox()
        {
            listEmployee = employeeBUS.LoadAllEmployee();
            foreach (EmployerDTO employer in listEmployee)
            {
                cbbEmployee.Items.Add(employer);
            }
            cbbEmployee.DisplayMember = "Username";
            cbbEmployee.ValueMember = "employeeID";

            cbbIsPay.Items.Add(Constants.PAY);
            cbbIsPay.Items.Add(Constants.NOTPAY);
            cbbIsPay.SelectedIndex = 0;
        }        

        public void Refreshdgv()
        {
            dgvSalary.DataSource = null;
            dgvSalary.DataSource = listSalary;
            dgvSalary.Refresh();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            locationXpnlNewItem = pnlMain.Width / 2 - pnlNewSalaryItem.Height / 2;
            int locationY = pnlNewSalaryItem.Location.Y;
            while (pnlNewSalaryItem.Location.Y > (Height/2 - pnlNewSalaryItem.Height/2))
            {
                locationY -= 40;
                pnlNewSalaryItem.Location = new Point(locationXpnlNewItem, locationY);
                Refresh();
            }
            pnlMoveUp.Visible = false;
            pnlMoveDown.Visible = true;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int locationY = pnlNewSalaryItem.Location.Y;
            locationXpnlNewItem = pnlMain.Width/2 - pnlNewSalaryItem.Height/2;
            while (pnlNewSalaryItem.Location.Y < (pnlMain.Height - pnlMoveUp.Height))
            {
                locationY += 40;
                pnlNewSalaryItem.Location = new Point(locationXpnlNewItem, locationY);
                Refresh();
            }
            if (pnlNewSalaryItem.Location.Y > pnlMain.Height - pnlMoveUp.Height)
            {
                pnlNewSalaryItem.Location = new Point(locationXpnlNewItem, pnlMain.Height - pnlMoveUp.Height);
            }
            pnlMoveUp.Visible = true;
            pnlMoveDown.Visible = false;
        }

        private void NewSalary_SizeChanged(object sender, EventArgs e)
        {
            if (pnlMoveDown.Visible)
            {
                Global.CenterToParent(pnlNewSalaryItem, pnlMain, Constants.CENTER, 0);                
                Refresh();
            }
            else
            {
                Global.CenterToParent(pnlNewSalaryItem, pnlMain, Constants.HORISONTAL_BOT_CUSTOM, pnlMoveUp.Height);
                Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string month = dtpMonth.Text;
            DateTime dtmonth = DateTime.ParseExact("01/" + month, "dd/MM/yyyy", null);
            string strmonth = dtmonth.ToString("yyyyMM");
            EmployerDTO employer = (EmployerDTO) cbbEmployee.SelectedItem;
            long empId = employer.employeeID;
            long salary = Convert.ToInt64(txtSalary.Text);
            long allowance = Convert.ToInt64(txtAllowance.Text);
            long phoneCost = Convert.ToInt64(txtPhoneCost.Text);
            long debtPay = Convert.ToInt64(txtDebtPay.Text);
            long actualIncome = Convert.ToInt64(txtActualIncome.Text);
            int isPay = GenerateStatus(cbbIsPay.Text);
            string notes = txtNote.Text;
            EmployeeSalaryDTO salaryDTO = new EmployeeSalaryDTO()
                                           {
                                               EmployeeID = empId,
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

        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            pnlNewSalaryItem.Visible = true;
            Global.CenterToParent(pnlNewSalaryItem, pnlMain, Constants.CENTER, 0);
            pnlMoveUp.Visible = false;
            pnlMoveDown.Visible = true;
        }

        private void btnClosedNewItem_Click(object sender, EventArgs e)
        {
            pnlNewSalaryItem.Visible = false;
        }

        private void textboxNewSalary_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            ClearTextboxSalary(textBox);
        }

        private void textboxNewSalary_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox) sender;
            SetInitValueTexboxSalary(textBox);
            if (!Global.ValidateULongNumber(textBox.Text))
            {
                textBox.Focus();
                textBox.Text = Constants.EMPTY_TEXT;
            }            
        }

        private void ClearTextboxSalary(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals("0"))
            {
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
                ActiveControl.Text += "000";                    
            }
            catch (Exception)
            {                
            }
        }
        
    }
}