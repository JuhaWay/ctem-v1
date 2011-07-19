using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class WarehouseDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private readonly WarehouseBUS _warehouseBus = new WarehouseBUS();
        private string _warehousename;

        public WarehouseDetail(string warehousename)
        {
            InitializeComponent();
            _warehousename = warehousename;
        }

        private void WarehouseDetail_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            CenterToScreen();
            dgvWHDetail.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdWH, Constants.CHILD_FORM);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetDataCombobox(cbbMaterial, Constants.MATERIAL_SEARCH);
            Global.SetDataCombobox(cbbNameSearch, Constants.WAREHOUSE_SEARCH);
            Global.SetDaulftDatagridview(dgvWHDetail);
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbMaterial, Constants.MATERIAL_SEARCH);
            for (int i = 0; i < cbbNameSearch.Items.Count; i++)
            {
                string name = cbbNameSearch.Items[i].ToString();
                if (name.Equals(_warehousename))
                {
                    cbbNameSearch.SelectedIndex = i;
                    i = cbbNameSearch.Items.Count;
                }
            }
            Global.SetDataCombobox(cbbNameSearch, Constants.WAREHOUSE_SEARCH);            
            LoadData();
        }

        private void LoadData()
        {
            string whname = cbbNameSearch.Text;
            if (whname.Equals(Constants.ALL))
            {
                whname = Constants.EMPTY_TEXT;
            }
            string materialname = cbbMaterial.Text;
            if (materialname.Equals(Constants.ALL))
            {
                materialname = Constants.EMPTY_TEXT;
            }
            dgvWHDetail.DataSource = _warehouseBus.GetWarehouseDetail(whname, materialname);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                btnSearch_Click(null, null);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
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