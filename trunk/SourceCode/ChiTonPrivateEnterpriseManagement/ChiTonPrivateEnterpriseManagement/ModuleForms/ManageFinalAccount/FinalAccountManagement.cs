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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    public partial class FinalAccountManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDTO> ListFinalAccount;
        private readonly FinalAccountBUS FinalAcc = new FinalAccountBUS();

        public FinalAccountManagement()
        {
            InitializeComponent();
        }

        private void FinalAccountManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvAccount.Focus();
            pnlSearch.Height = 82;
            gbxSearch.Height = 78;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvAccount);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbNameSearch, "Account Search");
            Global.SetDataCombobox(cbbCons, "Construction Search");
            Global.SetDataCombobox(cbbDebt, "Debt Search");
            Global.SetLayoutButton(btnSearch);
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbNameSearch, "Account Search");
            Global.SetDataCombobox(cbbCons, "Construction Search");
            Global.SetDataCombobox(cbbDebt, "Debt Search");
            txtId.Text = Constants.ZERO_NUMBER;
            dtpSearchTo.Value = DateTime.Today;
            dtpSearchFrom.Value = Global.GetFirstDateInMonth();
            LoadData();
        }

        private void LoadData()
        {
            long id = Convert.ToInt64(txtId.Text);
            string name = cbbNameSearch.Text;
            string consName = cbbCons.Text;
            string debtName = cbbDebt.Text;
            if (name.Equals("Tất Cả")) { name = Constants.EMPTY_TEXT; }
            if (consName.Equals("Tất Cả")) { consName = Constants.EMPTY_TEXT; }
            if (debtName.Equals("Tất Cả")) { debtName = Constants.EMPTY_TEXT; }
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            ListFinalAccount = FinalAcc.GetFinalAccount(id, name, consName, debtName, fromdate, todate);
            dgvAccount.DataSource = ListFinalAccount;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newFinalAccountForm = new NewFinalAccount();
            newFinalAccountForm.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtId.Text = Constants.ZERO_NUMBER;
            if (cbbNameSearch.Items.Count > 0) { cbbNameSearch.SelectedIndex = 0; }
            if (cbbCons.Items.Count > 0) { cbbCons.SelectedIndex = 0; }
            if (cbbDebt.Items.Count > 0) { cbbDebt.SelectedIndex = 0; }
            dtpSearchFrom.Value = dtpSearchFrom.MinDate;
            dtpSearchTo.Value = dtpSearchTo.MaxDate;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvAccount.SelectedRows)
                {
                    long id = Convert.ToInt64(row.Cells["FinalAccountID"].Value.ToString());
                    success = FinalAcc.DeleteFinalAccount(id);
                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = FinalAcc.DeleteAll();
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
            }
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
    }
}