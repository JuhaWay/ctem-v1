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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class StockOutManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<StockOutDTO> _listStockout;
        private readonly WarehouseBUS _whBus = new WarehouseBUS(); 
        public StockOutManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newStockOut = new NewStockOut();
            newStockOut.ShowDialog();

        }

        private void StockOutManagement_Load(object sender, EventArgs e)
        {
            Setlayout();
        }

        private void Setlayout()
        {
            dgvStockout.Focus();
            pnlSearch.Height = 82;
            gbxSearch.Height = 78;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvStockout);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetDataCombobox(cbbNameSearch, Constants.WAREHOUSE_SEARCH);
        }

        private void RefreshData()
        {
            if (cbbNameSearch.Items.Count > 0)
            {
                cbbNameSearch.SelectedIndex = 0;
            }
            dtpSearchFrom.Value = dtpSearchFrom.MinDate;
            dtpSearchTo.Value = dtpSearchTo.MaxDate;
            LoadData();
        }

        private void LoadData()
        {
            string whname = cbbNameSearch.Text;
            if (whname.Equals(Constants.ALL))
            {
                whname = Constants.EMPTY_TEXT;
            }
            _listStockout = _whBus.LoadStockOut(whname, dtpSearchFrom.Value, dtpSearchTo.Value);
            dgvStockout.DataSource = _listStockout;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvStockout.SelectedRows)
                {
                    long id = Convert.ToInt64(row.Cells["StockOutId"].Value.ToString());
                    success = _whBus.DeleteStockOut(id);

                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _whBus.DeleteAllEmp();
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
            dgvStockout.Focus();
        }
    }
}