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
            Global.SetDataCombobox(cbbCons, Constants.CONSTRUCTION_SEARCH);
            Global.SetDataCombobox(cbbDebt, Constants.DEBT_SEARCH);
            Global.SetDataCombobox(cbbWarehouse, Constants.MAIN_WAREHOUSE_SEARCH);
            Global.SetDataCombobox(cbbStatus, Constants.IS_PAY);
            Global.SetLayoutButton(btnSearch);
        }

        private void RefreshData()
        {            
            if (cbbCons.Items.Count > 0) { cbbCons.SelectedIndex = 0; }
            if (cbbDebt.Items.Count > 0) { cbbDebt.SelectedIndex = 0; }
            if (cbbWarehouse.Items.Count > 0) { cbbWarehouse.SelectedIndex = 0; }
            if (cbbStatus.Items.Count > 0) { cbbStatus.SelectedIndex = 0; }
            dtpSearchTo.Value = DateTime.Today;
            dtpSearchFrom.Value = Global.GetFirstDateInMonth();
            LoadData();
        }

        private void LoadData()
        {
            long whid = 0;
            int status = -1;
            ConstructionDTO constructionDTO = cbbCons.SelectedItem as ConstructionDTO;
            WarehouseDTO warehouseDTO = cbbWarehouse.SelectedItem as WarehouseDTO;
            if (cbbWarehouse.Enabled)
            {
                whid = warehouseDTO.WarehouseID;
            }
            else
            {
                whid = constructionDTO.WarehouseID;
            }
            string debtName = cbbDebt.Text;
            if (debtName.Equals("Tất Cả")) { debtName = Constants.EMPTY_TEXT; }
            if (cbbStatus.Text.Equals(Constants.PAY))
            {
                status = 1;
            }
            else if (cbbStatus.Text.Equals(Constants.NOTPAY))
            {
                status = 0;
            }            
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            ListFinalAccount = FinalAcc.GetFinalAccount(whid, debtName, fromdate, todate, status, -1);
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
            if (cbbCons.Items.Count > 0) { cbbCons.SelectedIndex = 0; }
            if (cbbDebt.Items.Count > 0) { cbbDebt.SelectedIndex = 0; }
            if (cbbWarehouse.Items.Count > 0) { cbbWarehouse.SelectedIndex = 0; }
            if (cbbStatus.Items.Count > 0) { cbbStatus.SelectedIndex = 0; }
            dtpSearchFrom.Value = dtpSearchFrom.MinDate;
            dtpSearchTo.Value = dtpSearchTo.MaxDate;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                " Chức Năng Này Hiện Tại Ảnh Hưởng Đến Nhiều Chức Năng.\n Chúc Tôi Sẽ Nâng Cấp Chức Năng Này Cho Phiên Bản Sau",
                Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //bool success = false;
            //if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    foreach (DataGridViewRow row in dgvAccount.SelectedRows)
            //    {
            //        long id = Convert.ToInt64(row.Cells["FinalAccountID"].Value.ToString());
            //        success = FinalAcc.DeleteFinalAccount(id);
            //    }
            //    KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
            //    RefreshData();
            //}
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                " Chức Năng Này Hiện Tại Ảnh Hưởng Đến Nhiều Chức Năng.\n Chúc Tôi Sẽ Nâng Cấp Chức Năng Này Cho Phiên Bản Sau",
                Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    bool success = FinalAcc.DeleteAll();
            //    KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
            //}
            //RefreshData();
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
            cbbWarehouse.Focus();
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgvAccount.SelectedRows[0].Cells["FinalAccountID"].Value.ToString());
                var newFinalAccountForm = new NewFinalAccount(id);
                newFinalAccountForm.ShowDialog();
                RefreshData();
            }
            catch (Exception)
            {
                KryptonMessageBox.Show("Hiện Không Có Giữ Liệu Để Xem", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void cbbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWarehouse.SelectedIndex == 0)
            {
                cbbCons.Enabled = true;
            }
            else
            {
                cbbCons.Enabled = false;
            }
        }

        private void cbbCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCons.SelectedIndex == 0)
            {
                cbbWarehouse.Enabled = true;
            }
            else
            {
                cbbWarehouse.Enabled = false;
            }
        }
    }
}