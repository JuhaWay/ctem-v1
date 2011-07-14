﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    public partial class NewFinalAccount : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDetailDTO> listFinalAccountDetail = new List<FinalAccountDetailDTO>();
        private List<ConstructionDTO> listConstructionHaveWarehouse;
        private List<DebtDTO> listDebt;
        private List<WarehouseDTO> listMainWarehouse;
        private List<MaterialDTO> listMaterialInEstimate;
        private List<MaterialDTO> listMaterial;
        private long EstimateID;
        ConstructionBus constructionBUS = new ConstructionBus();
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        DebtBUS debtBUS = new DebtBUS();
        MaterialBUS materialBUS = new MaterialBUS();
        FinalAccountBUS finalaccountBUS = new FinalAccountBUS();
        EstimateBUS estimateBus = new EstimateBUS();
        private CheckBox _ckBox;

        public NewFinalAccount()
        {
            InitializeComponent();
        }

        private void NewFinalAccount_Load(object sender, EventArgs e)
        {
            CenterToParent();            
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
            List<KryptonTextBox> listTextBox = new List<KryptonTextBox>();
            listTextBox.Add(txtTransportationCost);
            listTextBox.Add(txtTotalCost);
            listTextBox.Add(txtQuantity);
            listTextBox.Add(txtTotalCostItem);
            Global.SetDataTextBox(listTextBox, Constants.NUMBER);
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

            listDebt = debtBUS.GetDebt(0, Constants.EMPTY_TEXT, -1);
            cbbDebt.DataSource = listDebt;
            cbbDebt.ValueMember = Constants.DEBT_VALUEMEMBER;   
            cbbDebt.DisplayMember = Constants.DEBT_DISPLAYMEMBER;

            listMaterial = materialBUS.LoadAllMaterials();
            Global.SetDataCombobox(cbbMaterial, "Material");
        }        

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MaterialDTO material = (MaterialDTO) cbbMaterial.SelectedItem;
            FinalAccountDetailDTO finalaccountitem = new FinalAccountDetailDTO();
            finalaccountitem.FinalAccountID = Convert.ToInt64(txtNo.Text);
            finalaccountitem.MaterialID = material.MaterialID;
            finalaccountitem.MaterialName = material.MaterialName;
            finalaccountitem.RealCalUnit = material.RealCalUnit;
            finalaccountitem.Quantity = Convert.ToInt32(txtQuantity.Text);
            finalaccountitem.QuantityEst = finalaccountitem.Quantity*material.Ratio;
            finalaccountitem.UnitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, ".");
            finalaccountitem.TotalCost = Global.ConvertMoneyToLong(txtTotalCostItem.Text, ".");
            finalaccountitem.Note = txtNoteItem.Text;
            listFinalAccountDetail.Add(finalaccountitem);
            RefreshDisplayData();
            long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, ".");
            long totalCost = totalCostCurr + finalaccountitem.TotalCost;
            txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, ".");
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
            long transportationCost = Global.ConvertMoneyToLong(txtTransportationCost.Text, ".");
            long totalCost = Global.ConvertMoneyToLong(txtTotalCost.Text, ".");
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
                //estimateBus.UpdateEstimateDetail(EstimateID, item);
            }
            //estimateBus.UpdateEstimateTotalRealCost(EstimateID);
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

        private void txtTransportationCost_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox) sender;
            textBox.Text = Constants.EMPTY_TEXT;
        }

        private void txtTransportationCost_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;
            if(textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.SetDataTextBox(textBox, Constants.NUMBER);
            }
        }

        private void txtTotalCostItem_Enter(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtQuantity.Text);
            long unitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, ".");
            long totalCost = quantity*unitCost;
            txtTotalCostItem.Text = Global.ConvertLongToMoney(totalCost, ".");
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += ".000";
            }
            catch (Exception)
            {
            }
        }

        private void cbbMaterial_Leave(object sender, EventArgs e)
        {
            bool isExist = false;
            bool isExistEst = false;
            string nameMaterial = cbbMaterial.Text;
            for (int i = 0; i < listMaterial.Count; i++)
            {
                MaterialDTO materialDTO = listMaterial[i];
                if (materialDTO.MaterialName.Equals(nameMaterial))
                {
                    isExist = true;
                    i = listMaterial.Count;
                }
            }
            if (!isExist)
            {
                if(KryptonMessageBox.Show(Constants.NOT_EXIST_MATERIAL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddNewMaterial newMaterial = new AddNewMaterial();
                    newMaterial.ShowDialog();
                    listMaterial = materialBUS.LoadAllMaterials();
                    Global.SetDataCombobox(cbbMaterial, "Material");
                    cbbMaterial.SelectedIndex = listMaterial.Count - 1;
                }
            }
            if (cbbConstruction.Enabled)
            {
                MaterialDTO selectMaterial = (MaterialDTO)cbbMaterial.SelectedItem;
                listMaterialInEstimate = materialBUS.LoadALlMaterialsEstimate();
                for (int i = 0; i < listMaterialInEstimate.Count; i++)
                {
                    MaterialDTO materialDTO = listMaterial[i];
                    if (materialDTO.Equals(selectMaterial))
                    {
                        isExistEst = true;
                        i = listMaterialInEstimate.Count;
                    }
                }
                if (!isExistEst)
                {
                    if (KryptonMessageBox.Show(Constants.NOT_EXIST_MATERIAL_EST, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ConstructionDTO consDTO = cbbConstruction.SelectedItem as ConstructionDTO;
                        //EstimateID = estimateBus.GetEstIDByConsID(consDTO.ConstructionID);
                        //AddNewEsDetail newEstimate = new AddNewEsDetail(EstimateID, cbbMaterial.SelectedIndex);
                        //newEstimate.ShowDialog();
                    }
                }
            }            
        }
    }
}