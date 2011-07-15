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
            setLauout();
            setData();
        }

        private void RefreshDisplayData()
        {
            dgvAccDetail.DataSource = null;
            dgvAccDetail.DataSource = listFinalAccountDetail;
            if (cbbMaterial.Items.Count > 0)
            {
                cbbMaterial.SelectedIndex = 0;
            }
            txtQuantity.Text = Constants.ZERO_NUMBER;
            txtUnitCost.Text = Constants.ZERO_NUMBER;
            txtTotalCostItem.Text = Constants.ZERO_NUMBER;
            txtNoteItem.Text = Constants.EMPTY_TEXT;
        }

        private void setLauout()
        {
            CenterToParent();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutSplipContainerNewForm(slcFinalAccInfo);
            Global.SetLayoutGroupBoxNewForm(gbxEdit1);
            Global.SetLayoutGroupBoxNewForm(gbxEdit2);
            Global.SetLayoutPanelChildForm(pnlNewItem);
            Global.SetLayoutGroupBoxSearch(gbxNewItem);
            Global.SetLayoutHeaderGroup(hdDetailInfo, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdMainInfo, Constants.CHILD_FORM);
            Global.SetLayoutSplipContainer(slcMain, 1);
            Global.SetDaulftDatagridview(dgvAccDetail);
            Global.SetTextBoxNumberLeave(txtNo);
            Global.SetTextBoxNumberLeave(txtTransportationCost);
            Global.SetTextBoxNumberLeave(txtTotalCost);
            Global.SetTextBoxNumberLeave(txtQuantity);
            Global.SetTextBoxNumberLeave(txtUnitCost);
            Global.SetTextBoxNumberLeave(txtTotalCostItem);
        }

        private void setData()
        {
            Global.SetDataCombobox(cbbToPlace, Constants.TO_PLACE);
            Global.SetDataCombobox(cbbStatus, Constants.IS_PAY);
            Global.SetDataCombobox(cbbConstruction, Constants.CONSTRUCTION);
            Global.SetDataCombobox(cbbMainWarehouse, Constants.MAIN_WAREHOUSE);
            Global.SetDataCombobox(cbbDebt, Constants.DEBT);
            listMaterial = materialBUS.LoadAllMaterials();
            Global.SetDataCombobox(cbbMaterial, Constants.MATERIAL);
        }        

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (CheckExistItem())
            {
                KryptonMessageBox.Show(Constants.ERROR_EXIST_ITEM, Constants.CONFIRM);
                RefreshDisplayData();
            }
            else
            {
                var material = (MaterialDTO)cbbMaterial.SelectedItem;
                var finalaccountitem = new FinalAccountDetailDTO();
                finalaccountitem.FinalAccountID = Convert.ToInt64(txtNo.Text);
                finalaccountitem.MaterialID = material.MaterialID;
                finalaccountitem.MaterialName = material.MaterialName;
                finalaccountitem.RealCalUnit = material.RealCalUnit;
                finalaccountitem.Quantity = Convert.ToDouble(txtQuantity.Text);
                finalaccountitem.QuantityEst = finalaccountitem.Quantity * material.Ratio;
                finalaccountitem.UnitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, ".");
                finalaccountitem.UnitCostFormated = txtUnitCost.Text;
                finalaccountitem.TotalCost = Global.ConvertMoneyToLong(txtTotalCostItem.Text, ".");
                finalaccountitem.TotalCostFormated = txtTotalCostItem.Text;
                finalaccountitem.Note = txtNoteItem.Text;
                listFinalAccountDetail.Add(finalaccountitem);
                RefreshDisplayData();
                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, ".");
                long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, ".");
            }
            
        }

        private bool CheckExistItem()
        {
            bool isExist = false;
            var material = (MaterialDTO)cbbMaterial.SelectedItem;
            foreach (FinalAccountDetailDTO detailDTO in listFinalAccountDetail)
            {
                if (detailDTO.MaterialID == material.MaterialID)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long finalAccountID = Convert.ToInt64(txtNo.Text);
            string finalAccountName = txtNameFinalAccount.Text;
            string accountPerson = txtPersonAccount.Text;
            long debtId = Global.GetDataCombobox(cbbDebt, Constants.DEBT);
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
            if (cbbToPlace.Text.Equals(Constants.MAIN_WAREHOUSE))
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
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void txtTransportationCost_Leave(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberLeave(textBox);
        }

        private void txtTotalCostItem_Enter(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);
                long unitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, ".");
                long totalCost = quantity * unitCost;
                txtTotalCostItem.Text = Global.ConvertLongToMoney(totalCost, ".");
            }
            catch
            {
            }
            
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text +=Constants.THOUSAND;
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
                //if (!isExistEst)
                //{
                //    if (KryptonMessageBox.Show(Constants.NOT_EXIST_MATERIAL_EST, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        var consDTO = cbbConstruction.SelectedItem as ConstructionDTO;
                //        if (consDTO != null)
                //        {
                //            var listestimate = estimateBus.LoadEstimateByConstruction(consDTO.ConstructionID);
                //            if (listestimate.Count > 0)
                //            {
                //                EstimateID = listestimate[0].EstimateID;
                //            }
                //        }
                //        var newEstimate = new AddNewEsDetail(EstimateID);
                //        newEstimate.ShowDialog();
                //    }
                //    else
                //    {
                //        EstimateID = 0;
                //    }
                //}
            }            
        }

        private void dgvAccDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indexMaterial = 0;
            DataGridViewRow r = dgvAccDetail.Rows[e.RowIndex];
            string materialName = r.Cells["MaterialName"].Value.ToString();
            for (int i = 0; i < cbbMaterial.Items.Count; i++)
            {
                var materialDTO = cbbMaterial.Items[i] as MaterialDTO;
                if (materialDTO != null)
                    if (materialDTO.MaterialName.Equals(materialName))
                    {
                        indexMaterial = i;
                        i = cbbMaterial.Items.Count;
                    }
            }
            txtQuantity.Text = r.Cells["Quantity"].Value.ToString();
            txtUnitCost.Text = r.Cells["UnitCostFormated"].Value.ToString();
            txtTotalCostItem.Text = r.Cells["TotalCostFormated"].Value.ToString();
            txtNoteItem.Text = r.Cells["Note"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvAccDetail.SelectedRows)
                {
                    int indexDetail = 0;
                    string materialName = row.Cells["MaterialName"].Value.ToString();
                    for (int i = 0; i < listFinalAccountDetail.Count; i++)
                    {
                        FinalAccountDetailDTO detail = listFinalAccountDetail[i];
                        if (detail != null)
                            if (detail.MaterialName.Equals(materialName))
                            {
                                indexDetail = i;
                            }
                    }
                    listFinalAccountDetail.RemoveAt(indexDetail);
                }
                RefreshDisplayData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int totalDetail = listFinalAccountDetail.Count;
                for (int i = 0; i < totalDetail; i++)
                {
                    listFinalAccountDetail.RemoveAt(0);
                }
                RefreshDisplayData();
            }
        }
    }
}