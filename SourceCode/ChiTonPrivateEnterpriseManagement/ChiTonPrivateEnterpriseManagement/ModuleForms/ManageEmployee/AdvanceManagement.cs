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
    public partial class AdvanceManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<EmployeeAdvanceDTO> _listAdvance;
        private string _emp;
        private DateTime _month;
        private string _type;
        private bool _isNew;
        readonly EmployeeBUS _employeeBus = new EmployeeBUS();
        public AdvanceManagement()
        {
            InitializeComponent();
            _isNew = true;
        }

        public AdvanceManagement(string emp, DateTime month, string type)
        {
            InitializeComponent();
            _emp = emp;
            _month = month;
            _type = type;
            _isNew = true;
        }

        private void AdvanceManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvAdvance.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtTotalAdvance.Text = Constants.ZERO_NUMBER;
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdAdvance, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvAdvance);
            Global.SetLayoutSplipContainer(slcMain, 1);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbNameSearch, Constants.EMPLOYEE_SEARCH);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.SetLayoutButton(btnSearch);
            for (int i = 0; i < cbbEmployee.Items.Count; i++)
            {
                var emp = cbbEmployee.Items[i] as EmployerDTO;
                if (emp.Fullname.Equals(_emp))
                {
                    cbbEmployee.SelectedIndex = i;
                    i = cbbEmployee.Items.Count;
                }
            }
            cbbEmployee.Enabled = false;
            if (_type.Equals("Ứng Cho Doanh Nghiệp"))
            {
                cbbEmployee.Enabled = true;
            }            
        }

        private void MakeEdit(bool Edit)
        {            
            txtTotalAdvance.ReadOnly = !Edit;
            txtReason.ReadOnly = !Edit;
            txtNote.ReadOnly = !Edit;
            btnSave.Enabled = Edit ? ButtonEnabled.True : ButtonEnabled.False;
            cmsEdit.Items[2].Enabled = Edit;
        }

        private void LoadData()
        {
            string name = cbbNameSearch.Text;
            if (name.Equals("Tất Cả"))
            {
                name = Constants.EMPTY_TEXT;
            }
            string type = cbbTypeSearch.Text;
            if (cbbTypeSearch.Equals("Tất Cả"))
            {
                type = Constants.EMPTY_TEXT;
            }
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            _listAdvance = _employeeBus.LoadAdvance(name, fromdate, todate, type);
            dgvAdvance.DataSource = _listAdvance;
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbNameSearch, Constants.EMPLOYEE_SEARCH);
            for (int i = 1; i < cbbNameSearch.Items.Count; i++)
            {
                string item = cbbNameSearch.Items[i].ToString();
                if (item.Equals(_emp))
                {
                    cbbNameSearch.SelectedIndex = i;
                    i = cbbNameSearch.Items.Count;
                }
            }
            if (_type.Equals("Ứng Lương"))
            {
                cbbTypeSearch.SelectedIndex = 1;
            }
            else
            {
                cbbTypeSearch.SelectedIndex = 2;
            }            
            int year = _month.Year;
            int month = _month.Month;
            dtpSearchTo.Value = new DateTime(year, month, DateTime.DaysInMonth(year, month), 23, 59, 59);
            dtpSearchFrom.Value = new DateTime(year, month, 1);
            LoadData();
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
                foreach (DataGridViewRow row in dgvAdvance.SelectedRows)
                {
                    long id = Convert.ToInt64(row.Cells["AdvanceID"].Value.ToString());
                    success = _employeeBus.DeleteAdvance(id);
                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _employeeBus.DeleteAllAdvance();
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
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
            cbbEmployee.Focus();
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(false);
            dgvAdvance.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {                
                long employeeId = Global.GetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
                long totalAdvance = Global.ConvertMoneyToLong(txtTotalAdvance.Text, Constants.SPLIP_MONEY);
                string reason = txtReason.Text;
                string note = txtNote.Text;
                DateTime dateAdv = dtpDateAdv.Value;
                var advanceObj = new EmployeeAdvanceDTO()
                {                    
                    EmployeeID = employeeId,
                    TotalAdvance = totalAdvance,
                    Reason = reason,
                    Note = note,
                    DateAdvance = dateAdv,
                    Type = _type
                };
                bool success;
                if (_isNew)
                {
                    success = _employeeBus.CreateEmployeeAdvance(advanceObj);                    
                }
                else
                {
                    long id = Convert.ToInt64(dgvAdvance.SelectedRows[0].Cells["AdvanceID"].Value.ToString());
                    advanceObj.AdvanceID = id;
                    success = _employeeBus.UpdateEmployeeAdvance(advanceObj);
                    KryptonMessageBox.Show(success ? Constants.UPDATE_SUCCESS : Constants.ERROR, Constants.CONFIRM);
                }
                
                RefreshData();
            }
            catch
            {
            }
            
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
        }

        private void dgvAdvance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _isNew = false;
                DataGridViewRow row = dgvAdvance.SelectedRows[0];
                txtNote.Text = row.Cells["Note"].Value.ToString();
                txtReason.Text = row.Cells["Reason"].Value.ToString();
                txtTotalAdvance.Text = row.Cells["TotalAdvanceFormated"].Value.ToString();
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
            }
        }

        private void txtTotalAdvance_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalAdvance);
        }

        private void txtTotalAdvance_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtTotalAdvance);
        }

        private void cbbNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            ClearLayout();
        }

        private void ClearLayout()
        {
            _isNew = true;
            txtTotalAdvance.Text = Constants.ZERO_NUMBER;
            txtReason.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
            MakeEdit(true);
        }
    }
}