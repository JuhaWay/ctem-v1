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

        private void dgvWH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvWH.SelectedRows[0];
                txtId.Text = row.Cells["WarehouseID"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtNameManager.Text = row.Cells["ManagerName"].Value.ToString();
                txtWarehouseName.Text = row.Cells["WarehouseName"].Value.ToString();
                string type = row.Cells["Type"].Value.ToString();
                if (type.Equals(Constants.MAIN_WAREHOUSE))
                {
                    cbbType.SelectedIndex = 1;
                }
                else
                {
                    cbbType.SelectedIndex = 0;
                    string consName = row.Cells["ConstructionName"].Value.ToString();
                    for (int i = 0; i < cbbConstruction.Items.Count; i++)
                    {
                        ConstructionDTO cons = cbbConstruction.Items[i] as ConstructionDTO;
                        if (cons.ConstructionName.Equals(consName))
                        {
                            cbbConstruction.SelectedIndex = i;
                            i = cbbConstruction.Items.Count;
                        }
                    }
                }
                int isactive = Convert.ToInt32(row.Cells["IsActive"].Value.ToString());
                if (isactive == 1)
                {
                    cbbStatus.SelectedIndex = 0;
                }
                else
                {
                    cbbStatus.SelectedIndex = 1;
                }
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbConstruction.Enabled = cbbType.Text.Equals(Constants.CONSTRUCTION_WAREHOUSE);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                long id = Convert.ToInt64(txtId.Text);
                string warehousename = txtWarehouseName.Text;
                string type = cbbType.Text;
                string namemanager = txtNameManager.Text;
                string address = txtAddress.Text;
                string description = txtDescription.Text;
                int isactive;
                if (cbbStatus.Text.Equals(Constants.ACTIVE))
                {
                    isactive = 1;
                }
                else
                {
                    isactive = 0;
                }
                WarehouseDTO warehouse = new WarehouseDTO()
                {
                    WarehouseID = id,
                    WarehouseName = warehousename,
                    Type = type,
                    ManagerName = namemanager,
                    Address = address,
                    Description = description,
                    IsActive = isactive
                };
                if (cbbConstruction.Enabled)
                {
                    ConstructionDTO construcion = (ConstructionDTO)cbbConstruction.SelectedItem;
                    warehouse.ConstructionID = construcion.ConstructionID;
                }
                bool success = _warehouseBus.UpdateWarehouse(warehouse);
                if (success)
                {
                    KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM);
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
                }
                txtWarehouseName.Focus();
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
                txtWarehouseName.Focus();
            }
        }

        private bool ValidateInput()
        {
            Global.ListError.Clear();
            if (Global.ValidateNotEmptyText(txtWarehouseName) && Global.ValidateNotEmptyText(txtNameManager))
            {
                return true;
            }
            return false;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string whname = dgvWH.SelectedRows[0].Cells["WarehouseName"].Value.ToString();
            WarehouseDetail whdetail = new WarehouseDetail(whname);
            whdetail.ShowDialog();
            RefreshData();
        }

        private void cbbTypeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
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

    }
}