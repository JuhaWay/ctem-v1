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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class CompareDebtManagement : KryptonForm
    {
        private List<CompareDebtDTO> _listCompareDebt;
        DebtBUS _debtBus = new DebtBUS();
        public CompareDebtManagement()
        {
            InitializeComponent();
        }

        private void CompareDebtManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvComDebt.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtId.ReadOnly = true;
            txtTotalOwe.Text = Constants.ZERO_NUMBER;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvComDebt);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbDebt, Constants.DEBT);
            Global.SetLayoutButton(btnSearch);
            MakeEdit(false);
        }

        private void MakeEdit(bool Edit)
        {
            cbbDebt.Enabled = Edit;
            dtpToDate.Enabled = Edit;
            dtpFromDate.Enabled = Edit;
            dtpDateCompare.Enabled = Edit;
            txtTotalOwe.ReadOnly = !Edit;
            txtNote.ReadOnly = !Edit;            
            cmsEdit.Items[2].Enabled = Edit;
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbNameSearch, Constants.DEBT_SEARCH);
            cbbNameSearch.SelectedIndex = 0;
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
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            _listCompareDebt = _debtBus.GetCompareDebt(name, fromdate, todate);
            dgvComDebt.DataSource = _listCompareDebt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var DebtAcc = new FinalAccountDebt();
            DebtAcc.ShowDialog();
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            dtpFromDate.Value = dtpFromDate.MinDate;
            dtpToDate.Value = dtpToDate.MaxDate;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvComDebt.SelectedRows)
                {
                    long id = Convert.ToInt64(row.Cells["ComparationDebtID"].Value.ToString());
                    success = _debtBus.DeleteDebtCompare(id);
                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _debtBus.DeleteAllCompare();
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
            }
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(true);
            dtpDateCompare.Focus();
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(false);
            dgvComDebt.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CompareDebtDTO compareDebtDto = dgvComDebt.SelectedRows[0].DataBoundItem as CompareDebtDTO;
                compareDebtDto.TotalPayed = Global.ConvertMoneyToLong(txtPayed.Text, Constants.SPLIP_MONEY);
                compareDebtDto.Note = txtNote.Text;
                compareDebtDto.Con = Global.ConvertMoneyToLong(txtNotPayed.Text, Constants.SPLIP_MONEY);
                bool success = _debtBus.UpdateCompare(compareDebtDto);
                KryptonMessageBox.Show(success ? Constants.UPDATE_SUCCESS : Constants.ERROR, Constants.ANNOUNCE);
                RefreshData();
            }
            else
            {
                string errors = "";
                foreach (string error in Global.ListError)
                {
                    errors += ("* " + error + "\n");
                }
                KryptonMessageBox.Show(errors, Constants.ALERT_ERROR);
                dtpDateCompare.Focus();
            }
        }

        private bool ValidateInput()
        {            
            Global.ListError.Clear();
            if (!Global.ValidateDateFromTo(dtpFromDate.Value, dtpToDate.Value) || !Global.ValidateDateFromTo(dtpToDate.Value, dtpDateCompare.Value))
            {
                return false;
            }
            return true;
        }
       
        private void FillDataEdit(long id, string debtName, DateTime dayComp, DateTime dayFrom, DateTime dayTo, string totalDebt, string totalPayed, string note)
        {
            txtId.Text = id.ToString();            
            dtpDateCompare.Value = dayComp;
            dtpFromDate.Value = dayFrom;
            dtpToDate.Value = dayTo;
            txtTotalOwe.Text = totalDebt;
            txtPayed.Text = totalPayed;
            long totalowe = Global.ConvertMoneyToLong(totalDebt, Constants.SPLIP_MONEY);
            long totalpay = Global.ConvertMoneyToLong(totalPayed, Constants.SPLIP_MONEY);
            long totalnotpay = totalowe - totalpay;
            txtNotPayed.Text = Global.ConvertLongToMoney(totalnotpay, Constants.SPLIP_MONEY);
            txtNote.Text = note;
            foreach (DebtDTO debt in cbbDebt.Items)
            {
                if (debt.DebtName.Equals(debtName))
                {
                    cbbDebt.SelectedItem = debt;
                    return;
                }
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

        private void txtTotalOwe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPay_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtPayed);
        }

        private void txtPay_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtPayed);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(txtId.Text);
            long _totalCost = Global.ConvertMoneyToLong(txtTotalOwe.Text, Constants.SPLIP_MONEY);
            CompareDetailForm detailForm = new CompareDetailForm(id, _totalCost);
            detailForm.ShowDialog();
            txtPayed.Text = Global.ConvertLongToMoney(detailForm.totalPayed, Constants.SPLIP_MONEY);            
            long notpayed = _totalCost - detailForm.totalPayed;
            txtNotPayed.Text = Global.ConvertLongToMoney(notpayed, Constants.SPLIP_MONEY);
            RefreshData();
        }

        private void dgvComDebt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnDelete.Enabled = ButtonEnabled.True;
                cmsDGV.Items[3].Enabled = true;
                DataGridViewRow r = dgvComDebt.Rows[e.RowIndex];
                long id = Convert.ToInt64(r.Cells["ComparationDebtID"].Value.ToString());
                string debtName = Convert.ToString(r.Cells["DebtName"].Value.ToString());                
                var dayComp = DateTime.ParseExact(Convert.ToString(r.Cells["DateCompare"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
                var dayFrom = DateTime.ParseExact(Convert.ToString(r.Cells["FromDate"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
                var dayTo = DateTime.ParseExact(Convert.ToString(r.Cells["ToDate"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
                string totalDebt = r.Cells["TotalOweFormat"].Value.ToString();
                string totalPayed = r.Cells["TotalPayedFormat"].Value.ToString();
                string note = Convert.ToString(r.Cells["Note"].Value.ToString());
                FillDataEdit(id, debtName, dayComp, dayFrom, dayTo, totalDebt, totalPayed, note);
            }            
        }

        private void btnDebtDetail_Click(object sender, EventArgs e)
        {
            try
            {
                long id = Convert.ToInt64(dgvComDebt.SelectedRows[0].Cells["ComparationDebtID"].Value.ToString());
                FinalAccountDebt finalAccountDebt = new FinalAccountDebt(id);
                finalAccountDebt.ShowDialog();
            }
            catch (Exception)
            {                
            }
            
        }

        private void txtPayed_TextChanged(object sender, EventArgs e)
        {
            long pay = Global.ConvertMoneyToLong(txtPayed.Text, Constants.SPLIP_MONEY);
            long total = Global.ConvertMoneyToLong(txtTotalOwe.Text, Constants.SPLIP_MONEY);
            long con = total - pay;
            txtNotPayed.Text = Global.ConvertLongToMoney(con, Constants.SPLIP_MONEY);
        }
    }
}