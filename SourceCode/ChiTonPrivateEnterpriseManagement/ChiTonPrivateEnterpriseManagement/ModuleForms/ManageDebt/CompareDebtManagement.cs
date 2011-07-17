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
            txtRepresentationDebtName.ReadOnly = !Edit;
            txtNote.ReadOnly = !Edit;
            btnSave.Enabled = Edit ? ButtonEnabled.True : ButtonEnabled.False;
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
            string debtname = dgvComDebt.SelectedRows[0].Cells["DebtName"].Value.ToString();
            var DebtAcc = new FinalAccountDebt(debtname);
            DebtAcc.ShowDialog();
            //var compareDebt = new NewCompareDebt();
            //compareDebt.ShowDialog();
            //RefreshData();
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
                long compareDebtId = Convert.ToInt64(txtId.Text);
                long debtId = Global.GetDataCombobox(cbbDebt, Constants.DEBT);
                string representationDebtName = txtRepresentationDebtName.Text;
                var compareDate = dtpDateCompare.Value;
                var fromDate = dtpFromDate.Value;
                var toDate = dtpToDate.Value;
                long totalOwe = Global.ConvertMoneyToLong(txtTotalOwe.Text, ".");
                string note = txtNote.Text;
                var compareDebtDto = new CompareDebtDTO()
                {
                    ComparationDebtID = compareDebtId,
                    DebtID = debtId,
                    RepresentationDebtName = representationDebtName,
                    DateCompare = compareDate,
                    FromDate = fromDate,
                    ToDate = toDate,
                    TotalOwe = totalOwe,
                    Note = note
                };
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
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            Global.ListError.Clear();
            if (!Global.ValidateDateFromTo(dtpFromDate.Value, dtpToDate.Value) || !Global.ValidateDateFromTo(dtpToDate.Value, dtpDateCompare.Value))
            {
                return false;
            }
            return true;
        }

        private void dgvComDebt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = ButtonEnabled.False;
            cmsDGV.Items[3].Enabled = false;
        }

        private void dgvComDebt_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = ButtonEnabled.True;
            cmsDGV.Items[3].Enabled = true;
            DataGridViewRow r = dgvComDebt.Rows[e.RowIndex];
            long id = Convert.ToInt64(r.Cells["ComparationDebtID"].Value.ToString());
            string debtName = Convert.ToString(r.Cells["DebtName"].Value.ToString());
            string preName = Convert.ToString(r.Cells["RepresentationDebtName"].Value.ToString());
            var dayComp = DateTime.ParseExact(Convert.ToString(r.Cells["DateCompare"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
            var dayFrom = DateTime.ParseExact(Convert.ToString(r.Cells["FromDate"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
            var dayTo = DateTime.ParseExact(Convert.ToString(r.Cells["ToDate"].Value) + " 00:00:00", Constants.DATETIME_FORMAT_SHORTDATE_SHORTTIME, null);
            string totalDebt = r.Cells["TotalOweFormat"].Value.ToString();
            string note = Convert.ToString(r.Cells["Note"].Value.ToString());
            FillDataEdit(id, debtName, preName, dayComp, dayFrom, dayTo, totalDebt, note);
        }

        private void FillDataEdit(long id, string debtName, string preName, DateTime dayComp, DateTime dayFrom, DateTime dayTo, string totalDebt, string note)
        {
            txtId.Text = id.ToString();
            txtRepresentationDebtName.Text = preName;
            dtpDateCompare.Value = dayComp;
            dtpFromDate.Value = dayFrom;
            dtpToDate.Value = dayTo;
            txtTotalOwe.Text = totalDebt;
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
            if (!txtTotalOwe.Text.Equals(Constants.EMPTY_TEXT))
            {
                if (Global.ValidateMoney(txtTotalOwe))
                {
                    long number = Convert.ToInt64(txtTotalOwe.Text.Trim().Replace(".", ""));
                    txtTotalOwe.Text = Global.ConvertLongToMoney(number, ".");
                }
                else
                {                    
                    txtTotalOwe.Text = Constants.EMPTY_TEXT;
                    txtTotalOwe.Focus();
                }
            }
        }

        private void txtTotalOwe_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalOwe);
        }

        private void txtTotalOwe_Leave(object sender, EventArgs e)
        {
            txtTotalOwe.Text = Constants.ZERO_NUMBER;
        }
    }
}