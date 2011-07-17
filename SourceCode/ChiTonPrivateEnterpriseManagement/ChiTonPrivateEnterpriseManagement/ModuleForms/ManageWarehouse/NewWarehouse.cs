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
    public partial class NewWarehouse : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<ConstructionDTO> ListConstruction;
        ConstructionBus constructionBUS = new ConstructionBus();
        WarehouseBUS warehouseBUS = new WarehouseBUS();

        public NewWarehouse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
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
                bool success = warehouseBUS.CreateWarehouse(warehouse);
                if (success)
                {
                    if (KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClearLayout();
                        txtWarehouseName.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
                }
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

        private void NewWarehouse_Load(object sender, EventArgs e)
        {
            SetLayout();
            setData();
        }

        private void SetLayout()
        {
            CenterToParent();
            txtWarehouseName.Focus();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.TextBoxRequireInput(txtWarehouseName);
            Global.TextBoxRequireInput(txtNameManager);
        }

        private void setData()
        {
            Global.SetDataCombobox(cbbType, Constants.WAREHOUSE_TYPE);
            Global.SetDataCombobox(cbbConstruction, Constants.CONSTRUCTION);
            Global.SetDataCombobox(cbbStatus, Constants.STATUS);
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbConstruction.Enabled = cbbType.Text.Equals(Constants.CONSTRUCTION_WAREHOUSE);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }
        
        private void ClearLayout()
        {
            txtWarehouseName.Text = Constants.EMPTY_TEXT;
            txtNameManager.Text = Constants.EMPTY_TEXT;
            txtAddress.Text = Constants.EMPTY_TEXT;
            txtDescription.Text = Constants.EMPTY_TEXT;
            cbbType.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;
        }

        private void txtWarehouseName_TextChanged(object sender, EventArgs e)
        {
            if (txtWarehouseName.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.TextBoxRequireInput(txtWarehouseName);
            }
            else
            {
                Global.TextBoxRequireInputed(txtWarehouseName);
            }
        }

        private void txtNameManager_TextChanged(object sender, EventArgs e)
        {
            if (txtNameManager.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.TextBoxRequireInput(txtNameManager);
            }
            else
            {
                Global.TextBoxRequireInputed(txtNameManager);
            }
        }
    }
}