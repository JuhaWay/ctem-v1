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
    public partial class SalaryManagement : KryptonForm
    {
        EmployeeBUS _empBus = new EmployeeBUS();
        List<EmployerDTO> listEmployee = new List<EmployerDTO>();
        List<EmployeeSalaryDTO> listSalary;
        public SalaryManagement()
        {
            InitializeComponent();
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            Setlayout();
            RefreshData();
        }

        private void Setlayout()
        {
            dgvSalary.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtNo.ReadOnly = true;
            Global.SetTextBoxNumberLeave(txtSalary);
            Global.SetTextBoxNumberLeave(txtAllowance);
            Global.SetTextBoxNumberLeave(txtPhoneCost);
            Global.SetTextBoxNumberLeave(txtDebtPay);
            Global.SetTextBoxNumberLeave(txtActualIncome);
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdAdvance, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvSalary);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbNameSearch, Constants.EMPLOYEE_SEARCH);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.SetDataCombobox(cbbIsPay, Constants.IS_PAY);
            Global.SetLayoutButton(btnSearch);
            MakeEdit(false);
        }

        private void MakeEdit(bool edit)
        {
            txtActualIncome.ReadOnly = !edit;
            txtAllowance.ReadOnly = !edit;
            txtDebtPay.ReadOnly = !edit;
            txtNote.ReadOnly = !edit;
            txtPhoneCost.ReadOnly = !edit;
            txtSalary.ReadOnly = !edit;
            cbbEmployee.Enabled = edit;
            cbbIsPay.Enabled = edit;
            dtpMonth.Enabled = edit;
        }

        private void LoadData()
        {
            string name = cbbNameSearch.Text;
            if (name.Equals(Constants.ALL))
            {
                name = Constants.EMPTY_TEXT;
            }
            string from = dtpSearchFrom.Value.ToString("yyyyMM");
            string to = dtpSearchTo.Value.ToString("yyyyMM");
            listSalary = _empBus.LoadSalary(name, from, to);
            dgvSalary.DataSource = listSalary;
        }

        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            NewSalary newSalary = new NewSalary();
            newSalary.ShowDialog();
            RefreshData();
        }

        private void RefreshData()
        {
            if (cbbNameSearch.Items.Count > 0)
            {
                cbbNameSearch.SelectedIndex = 0;
            }
            dtpSearchTo.Value = DateTime.Today;
            dtpSearchFrom.Value = Global.GetFirstDateInMonth();
            LoadData();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch (Exception)
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            if (cbbNameSearch.Items.Count > 0)
            {
                cbbNameSearch.SelectedIndex = 0;
            }
            dtpSearchFrom.Value = dtpSearchFrom.MinDate;
            dtpSearchTo.Value = dtpSearchTo.MaxDate;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSalary.SelectedRows)
                {
                    long salaryId = Convert.ToInt64(row.Cells["EmployeeSalaryID"].Value.ToString());
                    success = _empBus.DeleteSalary(salaryId);

                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _empBus.DeleteAllSalary();
                if (success)
                {
                    KryptonMessageBox.Show(Constants.DELETE_SUCESS);
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR);
                }
            }
            RefreshData();
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(true);
            dtpMonth.Focus();
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(false);
            dgvSalary.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(txtNo.Text);
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
                EmployeeSalaryID = id,
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
            bool success = _empBus.UpdateEmployeeSalary(salaryDTO);
            if (success)
            {
                KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM);
            }
            else
            {
                KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSalary.SelectedRows[0];
                txtNo.Text = row.Cells["EmployeeSalaryID"].Value.ToString();
                string username = row.Cells["Username"].Value.ToString();
                for (int i = 0; i < cbbEmployee.Items.Count; i++)
                {
                    EmployerDTO emp = cbbEmployee.Items[i] as EmployerDTO;
                    if (emp.Username.Equals(username))
                    {
                        cbbEmployee.SelectedIndex = i;
                        i = cbbEmployee.Items.Count;
                    }
                }
                string month = row.Cells["MonthFormat"].Value.ToString();
                dtpMonth.Value = DateTime.ParseExact("01/" + month, "dd/MM/yyyy", null);
                txtSalary.Text = row.Cells["SalaryFormat"].Value.ToString();
                txtAllowance.Text = row.Cells["AllowanceFormat"].Value.ToString();
                txtPhoneCost.Text = row.Cells["PhoneCostFormat"].Value.ToString();
                txtDebtPay.Text = row.Cells["DebtPayFormat"].Value.ToString();
                txtActualIncome.Text = row.Cells["ActualIncomeFormat"].Value.ToString();
                int isactive = Convert.ToInt32(row.Cells["IsPay"].Value.ToString());
                if (isactive == 1)
                {
                    cbbIsPay.SelectedIndex = 0;
                }
                else
                {
                    cbbIsPay.SelectedIndex = 1;
                }
                txtNote.Text = Convert.ToString(row.Cells["Note"].Value.ToString());
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            Global.SetTextBoxMoneyLeave(textBox);
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

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
            cbbNameSearch.Focus();
        }

        private void HideSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            dgvSalary.Focus();
        }

        private void cbbNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}