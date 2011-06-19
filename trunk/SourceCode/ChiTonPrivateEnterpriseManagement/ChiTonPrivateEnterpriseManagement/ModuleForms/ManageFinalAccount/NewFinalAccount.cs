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
    public partial class NewFinalAccount : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDetailDTO> listFinalAccountDetail;
        private List<ConstructionDTO> listConstructionHaveWarehouse;
        private List<DebtDTO> listDebt;
        private List<WarehouseDTO> listMainWarehouse;
        private List<MaterialDTO> listMaterialInEstimate;
        ConstructionBus constructionBUS = new ConstructionBus();
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        DebtBUS debtBUS = new DebtBUS();
        MaterialBUS materialBUS = new MaterialBUS();
        FinalAccountBUS finalaccountBUS = new FinalAccountBUS();
        private CheckBox _ckBox;

        public NewFinalAccount()
        {
            InitializeComponent();
        }

        private void NewFinalAccount_Load(object sender, EventArgs e)
        {
            setLauout();
            setData();
        }

        private void RefreshDisplayData()
        {
            dgvContentBot.DataSource = null;
            dgvContentBot.DataSource = listFinalAccountDetail;
        }

        private void setLauout()
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvContentBot);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            pnlNewItem.Visible = false;
            Global.CenterToParent(pnlNewItem, this, Constants.CENTER, 0);
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvContentBot);
        }

        private void setData()
        {
            cbbToPlace.Items.Add(Constants.TO_CONSTRUCTION_WAREHOUSE);
            cbbToPlace.Items.Add(Constants.TO_MAIN_WAREHOUSE);
            cbbToPlace.SelectedIndex = 0;

            cbbStatus.Items.Add(Constants.PAY);
            cbbStatus.Items.Add(Constants.NOTPAY);
            cbbStatus.SelectedIndex = 0;

            listConstructionHaveWarehouse = constructionBUS.LoadAllConstructionsHaveWarehouse();
            cbbConstruction.DataSource = listConstructionHaveWarehouse;
            cbbConstruction.ValueMember = Constants.CONSTRUCTION_VALUEMEMBER;
            cbbConstruction.DisplayMember = Constants.CONSTRUCTION_DISPLAYMEMBER;

            listMainWarehouse = warehouseBUS.LoadWarehouses(Constants.MAIN_WAREHOUSE);
            cbbMainWarehouse.DataSource = listMainWarehouse;
            cbbMainWarehouse.ValueMember = Constants.WAREHOUSE_VALUEMEMBER;
            cbbMainWarehouse.DisplayMember = Constants.WAREHOUSE_DISPLAYMEMBER;

            listDebt = debtBUS.GetAll();
            cbbDebt.DataSource = listDebt;
            cbbDebt.ValueMember = Constants.DEBT_VALUEMEMBER;   
            cbbDebt.DisplayMember = Constants.DEBT_DISPLAYMEMBER;

            listMaterialInEstimate = materialBUS.LoadALlMaterialsEstimate();
            cbbMaterial.DataSource = listMaterialInEstimate;
            cbbMaterial.ValueMember = Constants.MATERIAL_VALUEMEMBER;
            cbbMaterial.DisplayMember = Constants.MATERIAL_DISPLAYMEMBER;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MaterialDTO material = (MaterialDTO) cbbMaterial.SelectedItem;
            FinalAccountDetailDTO finalaccountitem = new FinalAccountDetailDTO();
            finalaccountitem.FinalAccountID = Convert.ToInt64(txtNo.Text);
            finalaccountitem.MaterialID = material.MaterialID;
            finalaccountitem.MaterialName = material.MaterialName;
            finalaccountitem.Quantity = Convert.ToInt32(txtQuantity.Text);
            finalaccountitem.UnitCost = Convert.ToInt32(txtUnitCost.Text);
            finalaccountitem.Note = txtNoteItem.Text;
            listFinalAccountDetail.Add(finalaccountitem);
            RefreshDisplayData();
        }

        private void btnAddFinalAccountItem_Click(object sender, EventArgs e)
        {
            pnlNewItem.Visible = true;
        }

        private void btnCloseNewItem_Click(object sender, EventArgs e)
        {
            pnlNewItem.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long finalAccountID = Convert.ToInt64(txtNo.Text);
            string finalAccountName = txtNameFinalAccount.Text;
            string accountPerson = txtPersonAccount.Text;
            DebtDTO debt = (DebtDTO) cbbDebt.SelectedItem;
            long debtId = debt.DebtID;
            DateTime dateaccount = DateTime.Parse(dtpDateAccount.Text);
            long transportationCost = Convert.ToInt64(txtTransportationCost.Text);
            long totalCost = Convert.ToInt64(txtTotalCost.Text);
            string note = txtNote.Text;
            int ispay;            
            if (cbbStatus.Text.Equals(Constants.PAY))
            {
                ispay = 1;
            }
            else
            {
                ispay = 0;
            }
            long constructionID;
            long warehouseID;
            if (cbbConstruction.Enabled)
            {
                ConstructionDTO construction = (ConstructionDTO) cbbConstruction.SelectedItem;
                constructionID = construction.ConstructionID;
                warehouseID = construction.WarehouseID;
            }
            else
            {
                WarehouseDTO warehouse = (WarehouseDTO) cbbMainWarehouse.SelectedItem;
                constructionID = 0;
                warehouseID = warehouse.WarehouseID;                
            }
            FinalAccountDTO finalAccount = new FinalAccountDTO()
                                               {
                                                   FinalAccountID = finalAccountID,
                                                   FinalAccountName = finalAccountName,
                                                   ConstructionID = constructionID,
                                                   DateAccount = dateaccount,
                                                   DebtID = debtId,
                                                   TransportationCost = transportationCost,
                                                   TotalCost = totalCost,
                                                   IsPay = ispay,
                                                   WarehouseID = warehouseID,
                                                   PersonAccount = accountPerson,
                                                   Note = note
                                               };
            finalaccountBUS.CreateFinalAccount(finalAccount);
            foreach (FinalAccountDetailDTO item in listFinalAccountDetail)
            {
                finalaccountBUS.CreateFinalAccountDetail(item);
            }
        }

        private void cbbToPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbToPlace.Text.Equals(Constants.TO_MAIN_WAREHOUSE))
            {
                cbbMainWarehouse.Enabled = true;
                cbbConstruction.Enabled = false;
            }
            else
            {
                cbbMainWarehouse.Enabled = false;
                cbbConstruction.Enabled = true;
            }
        }

        private void NewFinalAccount_SizeChanged(object sender, EventArgs e)
        {
            Global.CenterToParent(pnlNewItem, this, Constants.CENTER, 0);
        }
    }
}