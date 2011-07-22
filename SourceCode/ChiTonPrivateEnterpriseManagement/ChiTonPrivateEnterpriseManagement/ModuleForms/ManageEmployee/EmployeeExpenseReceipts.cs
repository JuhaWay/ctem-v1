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
    public partial class EmployeeExpenseReceipts : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        List<EmployeeSalaryDTO> _listSalary;
        private readonly EmployeeBUS _empBus = new EmployeeBUS();
        public EmployeeExpenseReceipts()
        {
            InitializeComponent();
        }

        private void EmployeeExpenseReceipts_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvSalary.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdAdvance, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvSalary);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbNameSearch, Constants.EMPLOYEE_SEARCH);
            Global.SetLayoutButton(btnSearch);
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

        private void LoadData()
        {
            string name = cbbNameSearch.Text;
            if (name.Equals(Constants.ALL))
            {
                name = Constants.EMPTY_TEXT;
            }
            string from = dtpSearchFrom.Value.ToString("yyyyMM");
            string to = dtpSearchTo.Value.ToString("yyyyMM");
            _listSalary = _empBus.LoadSalary(name, from, to);
            dgvSalary.DataSource = _listSalary;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var expenseReceiptDetail = new EmployeeExpenseReceiptDetail();
            expenseReceiptDetail.ShowDialog();
            RefreshData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            long salaryId = Convert.ToInt64(dgvSalary.SelectedRows[0].Cells["EmployeeSalaryID"].Value);
            long empId = Convert.ToInt64(dgvSalary.SelectedRows[0].Cells["EmployeeID"].Value);
            string month = dgvSalary.SelectedRows[0].Cells["Month"].Value.ToString();
            var expenseReceiptDetail = new EmployeeExpenseReceiptDetail(salaryId, empId, month);
            expenseReceiptDetail.ShowDialog();
            RefreshData();
        }
    }
}