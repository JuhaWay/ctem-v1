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
    public partial class WarehouseManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<WarehouseDTO> ListWarehouse;
        private WarehouseBUS _warehouseBus = new WarehouseBUS();

        public WarehouseManagement()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvWH.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtId.ReadOnly = true;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdWH, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvWH);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetDataCombobox(cbbTypeSearch, Constants.WAREHOUSE_TYPE_SEARCH);
            Global.SetDataCombobox(cbbStatusSearch, Constants.STATUS_SEARCH);
            Global.SetDataCombobox(cbbNameSearch, Constants.WAREHOUSE_SEARCH);
            Global.SetDataCombobox(cbbType, Constants.WAREHOUSE_TYPE);
            Global.SetDataCombobox(cbbConstruction, Constants.CONSTRUCTION);
            Global.SetDataCombobox(cbbStatus, Constants.STATUS);
            Global.TextBoxRequireInput(txtWarehouseName);
            Global.TextBoxRequireInput(txtNameManager);
            MakeEdit(false);
        }

        private void MakeEdit(bool Edit)
        {
            cbbType.Enabled = Edit;
            cbbStatus.Enabled = Edit;
            cbbConstruction.Enabled = Edit;
            txtWarehouseName.ReadOnly = !Edit;
            txtNameManager.ReadOnly = !Edit;
            txtAddress.ReadOnly = !Edit;
            txtDescription.ReadOnly = !Edit;
            btnSave.Enabled = Edit ? ButtonEnabled.True : ButtonEnabled.False;
            cmsEdit.Items[2].Enabled = Edit;
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbNameSearch, Constants.WAREHOUSE_SEARCH);
            cbbNameSearch.SelectedIndex = 0;
            cbbTypeSearch.SelectedIndex = 0;
            cbbStatusSearch.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            string name = cbbNameSearch.Text;
            if (name.Equals(Constants.ALL))
            {
                name = Constants.EMPTY_TEXT;
            }
            string type = cbbTypeSearch.Text;
            if (type.Equals(Constants.ALL))
            {
                type = Constants.EMPTY_TEXT;
            }
            int status;
            if (cbbStatusSearch.Text.Equals(Constants.ACTIVE))
            {
                status = 1;
            }
            else if (cbbStatusSearch.Text.Equals(Constants.INACTIVE))
            {
                status = 0;
            }
            else
            {
                status = -1;
            }
            ListWarehouse = _warehouseBus.LoadWarehouses(name, type, status);
            dgvWH.DataSource = ListWarehouse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewWarehouse newWarehouseForm = new NewWarehouse();
            newWarehouseForm.ShowDialog();
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
                foreach (DataGridViewRow row in dgvWH.SelectedRows)
                {
                    long id = Convert.ToInt64(row.Cells["WarehouseID"].Value.ToString());
                    success = _warehouseBus.DeleteWarehouse(id);
                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _warehouseBus.DeleteAllWarehouse();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}