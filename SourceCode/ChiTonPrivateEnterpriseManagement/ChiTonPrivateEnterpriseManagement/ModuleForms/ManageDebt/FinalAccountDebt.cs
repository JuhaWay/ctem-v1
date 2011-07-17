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
    public partial class FinalAccountDebt : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDTO> ListFinalAccount;
        private string _debtName;
        private readonly FinalAccountBUS FinalAcc = new FinalAccountBUS();

        public FinalAccountDebt(string debtname)
        {
            InitializeComponent();
            _debtName = debtname;
        }

        private void FinalAccountManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            InitData();
        }

        private void InitData()
        {
            for (int i = 0; i < cbbDebtSearch.Items.Count; i++)
            {
                string name = cbbDebtSearch.Items[i].ToString();
                if (name.Equals(_debtName))
                {
                    cbbDebtSearch.SelectedIndex = i;
                    i = cbbDebtSearch.Items.Count;
                }
            }
            dtpSearchTo.Value = dtpSearchTo.MaxDate;
            dtpSearchFrom.Value = dtpSearchFrom.MinDate;
            LoadData();
        }

        private void SetLayout()
        {
            dgvAccount.Focus();
            pnlSearch.Height = 82;
            gbxSearch.Height = 78;
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvAccount);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbDebtSearch, Constants.DEBT_SEARCH);
            Global.SetLayoutButton(btnSearch);
            Global.SetDaulftDatagridview(dgvAccount);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetDataCombobox(cbbStatus, Constants.IS_PAY);
        }

        private void RefreshData()
        {
            if (cbbDebtSearch.Items.Count > 0) { cbbDebtSearch.SelectedIndex = 0; }
            dtpSearchTo.Value = DateTime.Today;
            dtpSearchFrom.Value = Global.GetFirstDateInMonth();
            LoadData();
        }

        private void LoadData()
        {
            string debtName = cbbDebtSearch.Text;
            if (debtName.Equals(Constants.ALL)) { debtName = Constants.EMPTY_TEXT; }
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            ListFinalAccount = FinalAcc.GetFinalAccount(0, Constants.EMPTY_TEXT, Constants.EMPTY_TEXT, debtName, fromdate, todate);
            dgvAccount.DataSource = ListFinalAccount;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 82, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 82, 2, 4, true);
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
            cbbDebtSearch.Focus();
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtNo.Text = dgvAccount.SelectedRows[0].Cells["FinalAccountID"].Value.ToString();
                txtNameFinalAccount.Text = dgvAccount.SelectedRows[0].Cells["FinalAccountName"].Value.ToString();
                txtTotalCost.Text = dgvAccount.SelectedRows[0].Cells["TotalCostFormated"].Value.ToString();
                int ispay = Convert.ToInt32(dgvAccount.SelectedRows[0].Cells["IsPay"].Value.ToString());
                if (ispay == 0)
                {
                    cbbStatus.SelectedIndex = 1;
                }
                else
                {
                    cbbStatus.SelectedIndex = 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(dgvAccount.SelectedRows[0].Cells["FinalAccountID"].Value.ToString());
            int ispay;
            if (cbbStatus.Text.Equals(Constants.PAY))
            {
                ispay = 1;
            }
            else
            {
                ispay = 0;
            }
            long TotalCost = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
            for (int i = 0; i < ListFinalAccount.Count; i++)
            {
                FinalAccountDTO item = ListFinalAccount[i];
                if (item.FinalAccountID == id)
                {
                    ListFinalAccount[i].IsPay = ispay;
                    ListFinalAccount[i].TotalCost = TotalCost;
                    ListFinalAccount[i].TotalCostFormated = Global.ConvertLongToMoney(TotalCost, Constants.SPLIP_MONEY);                    
                }
                RefreshLayout();
                i = ListFinalAccount.Count;
            }
        }

        private void RefreshLayout()
        {
            dgvAccount.DataSource = null;
            dgvAccount.DataSource = ListFinalAccount;
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            string name = cbbDebtSearch.Text;
            long totalCost = 0;
            foreach (FinalAccountDTO acc in ListFinalAccount)
            {
                totalCost += acc.TotalCost;
                FinalAccountBUS faccBus = new FinalAccountBUS();
                faccBus.UpdateFinalAccount(acc);
            }
            NewCompareDebt newcompDebt = new NewCompareDebt(name, dtpSearchFrom.Value, dtpSearchTo.Value, totalCost);
            newcompDebt.ShowDialog();
        }
    }
}