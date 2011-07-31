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
    public partial class NewFinalAccount : KryptonForm
    {
        bool _isNew;
        private bool _isNewItem;
        long _id;
        private List<FinalAccountDetailDTO> listFinalAccountDetail = new List<FinalAccountDetailDTO>();
        private List<EstimateDTO> listEstimate;
        private List<EstimateDetailDTO> listMaterialInEstimate;
        private List<MaterialDTO> listMaterial;
        private long EstimateID;
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        MaterialBUS materialBUS = new MaterialBUS();
        FinalAccountBUS finalaccountBUS = new FinalAccountBUS();
        EstimateBUS estimateBus = new EstimateBUS();
        EstimateDetailBUS estimateDetailBus = new EstimateDetailBUS();
        FinalAccountDTO currenAccount = new FinalAccountDTO();

        public NewFinalAccount()
        {
            InitializeComponent();
            _isNew = true;            
        }

        public NewFinalAccount(long id)
        {
            InitializeComponent();            
            _isNew = false;
            _id = id;
        }

        private void NewFinalAccount_Load(object sender, EventArgs e)
        {
            SetData();
            SetLauout();
            if (!_isNew)
            {
                setInnitLayout();
            }
        }

        private void setInnitLayout()
        {
            List<FinalAccountDTO> listaccount = finalaccountBUS.GetFinalAccountById(_id, dtpDateAccount.MinDate, dtpDateAccount.MaxDate);
            currenAccount = listaccount[0];
            listFinalAccountDetail = finalaccountBUS.GetFinalAccountDetailByFAId(_id);
            RefreshDisplayData();
            txtNo.Text = currenAccount.FinalAccountID.ToString();            
            txtNote.Text = currenAccount.Note;
            txtPersonAccount.Text = currenAccount.PersonAccount;
            txtTotalCost.Text = currenAccount.TotalCostFormated;
            txtTransportationCost.Text = currenAccount.TransportationCostFormated;
            if (currenAccount.ConstructionID == 0)
            {
                cbbToPlace.SelectedIndex = 1;
                for (int i = 0; i < cbbMainWarehouse.Items.Count; i++)
                {
                    var warehouseDTO = cbbMainWarehouse.Items[i] as WarehouseDTO;
                    if (warehouseDTO.WarehouseID == currenAccount.WarehouseID)
                    {
                        cbbMainWarehouse.SelectedIndex = i;
                        i = cbbMainWarehouse.Items.Count;
                    }
                }
            }
            else
            {
                cbbToPlace.SelectedIndex = 0;
                for (int i = 0; i < cbbConstruction.Items.Count; i++)
                {
                    var constructionDTO = cbbConstruction.Items[i] as ConstructionDTO;
                    if (constructionDTO.ConstructionID == currenAccount.ConstructionID)
                    {
                        cbbConstruction.SelectedIndex = i;
                        i = cbbConstruction.Items.Count;
                    }
                }
            }
            if (currenAccount.IsPay == 1)
            {
                cbbStatus.SelectedIndex = 0;
            }
            else
            {
                cbbStatus.SelectedIndex = 1;
            }
            
            for (int i = 0; i < cbbDebt.Items.Count; i++)
            {
                var debtDTO = cbbDebt.Items[i] as DebtDTO;
                if (debtDTO.DebtID == currenAccount.DebtID)
                {
                    cbbDebt.SelectedIndex = i;
                    i = cbbDebt.Items.Count;
                }
            }
        }

        private void RefreshDisplayData()
        {
            List<FinalAccountDTO> listaccount = finalaccountBUS.GetFinalAccountById(_id, dtpDateAccount.MinDate, dtpDateAccount.MaxDate);
            currenAccount = listaccount[0];
            listFinalAccountDetail = finalaccountBUS.GetFinalAccountDetailByFAId(_id);
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
            cbbMaterial.Focus();
        }

        private void SetLauout()
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
            Global.TextBoxRequireInput(txtPersonAccount);            
        }

        private void SetData()
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
            // Not Yet Create FinalAccount
            if (_isNew)
            {
                KryptonMessageBox.Show("Bạn Phải Tạo Phiếu Mua Hàng Trước Khi Nhập Mặt Hàng", Constants.CONFIRM,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNo.Focus();
                return;
            }

            // Created Final Account
            long transCost = Global.ConvertMoneyToLong(txtTransportationCost.Text, Constants.SPLIP_MONEY);
            var material = (MaterialDTO)cbbMaterial.SelectedItem;
            var finalaccountitem = new FinalAccountDetailDTO();
            finalaccountitem.FinalAccountID = Convert.ToInt64(txtNo.Text);
            finalaccountitem.MaterialID = material.MaterialID;
            finalaccountitem.MaterialName = material.MaterialName;
            finalaccountitem.RealCalUnit = material.RealCalUnit;
            finalaccountitem.Quantity = Convert.ToDouble(txtQuantity.Text);
            finalaccountitem.QuantityEst = finalaccountitem.Quantity * material.Ratio;
            finalaccountitem.UnitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, Constants.SPLIP_MONEY);
            finalaccountitem.UnitCostFormated = txtUnitCost.Text;
            finalaccountitem.TotalCost = Global.ConvertMoneyToLong(txtTotalCostItem.Text, Constants.SPLIP_MONEY);
            finalaccountitem.TotalCostFormated = txtTotalCostItem.Text;
            finalaccountitem.Note = txtNoteItem.Text;
            
            // Create New Item but it is exist
            if (_isNewItem && CheckExistItem())
            {
                KryptonMessageBox.Show(Constants.ERROR_EXIST_ITEM, Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshDisplayData();
                cbbMaterial.Focus();
            }

            else if (finalaccountitem.Quantity <= 0)
            {
                KryptonMessageBox.Show("Số Lượng Không Thể Bằng 0", Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshDisplayData();
                cbbMaterial.Focus();
            }

            // Create New Item but not exist Or Update Item
            else
            {
                long constructionId;
                long warehouseId;
                var itemfinded = finalaccountBUS.FindAccountItem(finalaccountitem.FinalAccountID, finalaccountitem.MaterialID);

                // To Main Warehouse
                if (cbbMainWarehouse.Enabled)
                {
                    var warehouse = (WarehouseDTO)cbbMainWarehouse.SelectedItem;                    
                    warehouseId = warehouse.WarehouseID;
                    var materialWh = warehouseBUS.FindMateriral(warehouseId, finalaccountitem.MaterialID);

                    // Update Item
                    if (itemfinded != null)
                    {
                        materialWh.Quantity = materialWh.Quantity - itemfinded.Quantity + finalaccountitem.Quantity;
                        if (itemfinded.TotalCost > 0)
                        {
                            materialWh.TotalCost = materialWh.TotalCost - itemfinded.TotalCost + finalaccountitem.TotalCost;
                        }
                        else
                        {
                            materialWh.TotalCost = (long)(materialWh.TotalCost - (itemfinded.Quantity*materialWh.AveragePrice) +
                                                   finalaccountitem.TotalCost + transCost);
                        }
                        materialWh.AveragePrice = (long) (materialWh.TotalCost/materialWh.Quantity);
                        warehouseBUS.UpdateWarehouseItem(materialWh);
                        finalaccountitem.FinalAccountDetailID = itemfinded.FinalAccountDetailID;
                        finalaccountBUS.UpdateFinalAccountDetail(finalaccountitem);
                        for( int i = 0; i < listFinalAccountDetail.Count; i++)
                        {
                            if (listFinalAccountDetail[i].MaterialID == material.MaterialID)
                            {
                                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                long totalCost = totalCostCurr - listFinalAccountDetail[i].TotalCost + finalaccountitem.TotalCost;
                                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);                                
                            }
                        }
                    }

                    // Create Item
                    else
                    {
                        // Exist Material
                        if (materialWh != null)
                        {
                            materialWh.Quantity += finalaccountitem.Quantity;
                            if (finalaccountitem.TotalCost > 0)
                            {
                                materialWh.TotalCost += (finalaccountitem.TotalCost + transCost);
                            }
                            else
                            {
                                long totalCostAvg = (long)(materialWh.AveragePrice * finalaccountitem.Quantity);
                                materialWh.TotalCost += (totalCostAvg);
                            }
                            materialWh.AveragePrice = (long) (materialWh.TotalCost/materialWh.Quantity);
                            warehouseBUS.UpdateWarehouseItem(materialWh);
                        }
                        // Not Exits Material
                        else
                        {
                            // Price is null
                            if (finalaccountitem.UnitCost == 0)
                            {
                                KryptonMessageBox.Show(
                                    " Vật Tư Này Chưa Tồn Tại Trong Kho.\n Bạn Phải Nhập Giá Cho Lần Nhập Kho Đầu Tiên Này",
                                    Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtQuantity.Focus();
                                return;
                            }
                            // Have Price
                            else
                            {
                                materialWh = new WarehouseMaterialDTO();
                                materialWh.MaterialID = finalaccountitem.MaterialID;
                                materialWh.WarehouseID = warehouseId;
                                materialWh.Quantity = finalaccountitem.Quantity;
                                materialWh.TotalCost = finalaccountitem.TotalCost + transCost;
                                materialWh.AveragePrice = (long) (materialWh.TotalCost/materialWh.Quantity);
                                warehouseBUS.CreateWarehouseItem(materialWh);
                            }
                        }
                        finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                        long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                        long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                        txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                    }
                }
                
                // To Construction
                else
                {                    
                    bool isExistEst = false;
                    var construction = (ConstructionDTO)cbbConstruction.SelectedItem;
                    string typeCons = construction.type;
                    constructionId = construction.ConstructionID;
                    warehouseId = construction.WarehouseID;
                    var materialWh = warehouseBUS.FindMateriral(warehouseId, finalaccountitem.MaterialID);
                    var selectMaterial = (MaterialDTO)cbbMaterial.SelectedItem;
                    var currEstDetail = new EstimateDetailDTO();
                    listEstimate = estimateBus.LoadEstimateByConstruction(constructionId);
                    EstimateID = listEstimate[0].EstimateID;
                    listMaterialInEstimate = materialBUS.LoadALlMaterialsEstimate(constructionId);
                    for (int i = 0; i < listMaterialInEstimate.Count; i++)
                    {
                        currEstDetail = listMaterialInEstimate[i];
                        if (selectMaterial.MaterialID == currEstDetail.MaterialID || selectMaterial.MaterialID == currEstDetail.MaterialParentId)
                        {
                            isExistEst = true;
                            i = listMaterialInEstimate.Count;
                        }
                    }

                    #region Create Item
                    if (itemfinded == null)
                    {
                        // Công Trình Xây Dựng - Không Tồn Tại Trong Est
                        if (!isExistEst && typeCons.Equals("Công trình xây dựng"))
                        {
                            DialogResult result = KryptonMessageBox.Show(
                                    " Loại Vật Liệu Này Không Có Trong Dự Toán.\n Bạn Có Chắc Chắn Đã Giải Trình Với Nhà Đầu Tư Để Tăng Dự Toán",
                                    Constants.CONFIRM, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                var estimateDetailDTO = new EstimateDetailDTO();
                                estimateDetailDTO.No = Constants.EMPTY_TEXT;
                                estimateDetailDTO.Name = Constants.EMPTY_TEXT;
                                estimateDetailDTO.EstimateID = EstimateID;
                                estimateDetailDTO.MaterialID = finalaccountitem.MaterialID;
                                estimateDetailDTO.QuantityEstimate = finalaccountitem.QuantityEst;
                                estimateDetailDTO.QuantityReal = finalaccountitem.QuantityEst;
                                estimateDetailDTO.TotalCostEstimate = finalaccountitem.TotalCost;
                                estimateDetailDTO.TotalCostReal = finalaccountitem.TotalCost;
                                estimateDetailDTO.UnitCostEstimate = (long)(estimateDetailDTO.TotalCostEstimate /
                                                                    estimateDetailDTO.QuantityEstimate);
                                estimateDetailDTO.UnitCostReal = (long) estimateDetailDTO.UnitCostEstimate;
                                estimateDetailDTO.Type = "Chi Phí Phát Sinh";
                                estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                                finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                                // Exist Material
                                if (materialWh != null)
                                {
                                    materialWh.Quantity += finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.UpdateWarehouseItem(materialWh);
                                }
                                // Not Exits Material
                                else
                                {
                                    materialWh = new WarehouseMaterialDTO();
                                    materialWh.MaterialID = finalaccountitem.MaterialID;
                                    materialWh.WarehouseID = warehouseId;
                                    materialWh.Quantity = finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.CreateWarehouseItem(materialWh);                                    
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                var estimateDetailDTO = new EstimateDetailDTO();
                                estimateDetailDTO.EstimateID = EstimateID;
                                estimateDetailDTO.No = Constants.EMPTY_TEXT;
                                estimateDetailDTO.Name = Constants.EMPTY_TEXT;
                                estimateDetailDTO.MaterialID = finalaccountitem.MaterialID;
                                estimateDetailDTO.QuantityEstimate = 0;
                                estimateDetailDTO.QuantityReal = finalaccountitem.QuantityEst;
                                estimateDetailDTO.TotalCostEstimate = 0;
                                estimateDetailDTO.TotalCostReal = finalaccountitem.TotalCost;
                                estimateDetailDTO.UnitCostEstimate = 0;
                                estimateDetailDTO.UnitCostReal = (long) (finalaccountitem.TotalCost/finalaccountitem.QuantityEst);
                                estimateDetailDTO.Type = "Chi Phí Phát Sinh";
                                estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                                finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);

                                // Exist Material
                                if (materialWh != null)
                                {
                                    materialWh.Quantity += finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.UpdateWarehouseItem(materialWh);
                                }

                                // Not Exits Material
                                else
                                {
                                    materialWh = new WarehouseMaterialDTO();
                                    materialWh.MaterialID = finalaccountitem.MaterialID;
                                    materialWh.WarehouseID = warehouseId;
                                    materialWh.Quantity = finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.CreateWarehouseItem(materialWh);
                                }
                            }
                            else
                            {
                                RefreshDisplayData();
                                return;
                            }
                        }

                        // // Công Trình Thủy Lợi - Không Tồn Tại Trong Est
                        else if (!isExistEst && typeCons.Equals("Công trình Thủy lợi"))
                        {
                            EstimateDetailDTO estimateDetailDTO = new EstimateDetailDTO();
                            estimateDetailDTO.EstimateID = EstimateID;
                            estimateDetailDTO.MaterialID = finalaccountitem.MaterialID;
                            estimateDetailDTO.QuantityEstimate = 0;
                            estimateDetailDTO.QuantityReal = finalaccountitem.Quantity;
                            estimateDetailDTO.TotalCostEstimate = 0;
                            estimateDetailDTO.TotalCostReal = finalaccountitem.TotalCost;
                            estimateDetailDTO.UnitCostEstimate = 0;
                            estimateDetailDTO.UnitCostReal = finalaccountitem.UnitCost;
                            estimateDetailDTO.Type = "Chi Phí Phát Sinh";
                            estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                            finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                            long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                            long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                            txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                        }

                        // Exits In Estimate
                        else if (isExistEst)
                        {
                            currEstDetail.QuantityReal += finalaccountitem.QuantityEst;
                            currEstDetail.TotalCostReal += finalaccountitem.TotalCost;
                            currEstDetail.UnitCostReal = (long)(currEstDetail.TotalCostReal / currEstDetail.QuantityReal);
                            if (currEstDetail.QuantityReal > (currEstDetail.QuantityEstimate * 0.8) && currEstDetail.QuantityReal < currEstDetail.QuantityEstimate)
                            {
                                if(KryptonMessageBox.Show(" Nếu Mua Mặt Hàng Này Sẽ Vượt Quá 80% Dự Toán.\n Bạn Chắc Chắn Mún Mua?", Constants.CONFIRM,
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {                                    
                                    estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                    finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                                    long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                    long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                                    txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                                    // Exist Material
                                    if (materialWh != null)
                                    {
                                        materialWh.Quantity += finalaccountitem.Quantity;
                                        materialWh.TotalCost = 0;
                                        materialWh.AveragePrice = 0;
                                        warehouseBUS.UpdateWarehouseItem(materialWh);
                                    }
                                    // Not Exits Material
                                    else
                                    {
                                        materialWh = new WarehouseMaterialDTO();
                                        materialWh.MaterialID = finalaccountitem.MaterialID;
                                        materialWh.WarehouseID = warehouseId;
                                        materialWh.Quantity = finalaccountitem.Quantity;
                                        materialWh.TotalCost = 0;
                                        materialWh.AveragePrice = 0;
                                        warehouseBUS.CreateWarehouseItem(materialWh);
                                    }
                                }
                                else
                                {
                                    RefreshDisplayData();
                                }
                            }
                            else if (currEstDetail.QuantityReal > currEstDetail.QuantityEstimate)
                            {
                                if (KryptonMessageBox.Show(" Nếu Mua Mặt Hàng Này Sẽ Vượt Quá 100% Dự Toán.\n Bạn Chắc Chắn Đã Giải Trình Với Chủ Đầu Tư?", Constants.CONFIRM,
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {                                    
                                    estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                    finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                                    long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                    long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                                    txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                                    // Exist Material
                                    if (materialWh != null)
                                    {
                                        materialWh.Quantity += finalaccountitem.Quantity;
                                        materialWh.TotalCost = 0;
                                        materialWh.AveragePrice = 0;
                                        warehouseBUS.UpdateWarehouseItem(materialWh);
                                    }
                                    // Not Exits Material
                                    else
                                    {
                                        materialWh = new WarehouseMaterialDTO();
                                        materialWh.MaterialID = finalaccountitem.MaterialID;
                                        materialWh.WarehouseID = warehouseId;
                                        materialWh.Quantity = finalaccountitem.Quantity;
                                        materialWh.TotalCost = 0;
                                        materialWh.AveragePrice = 0;
                                        warehouseBUS.CreateWarehouseItem(materialWh);
                                    }
                                }
                                else
                                {
                                    RefreshDisplayData();
                                }
                            }
                            else
                            {                                
                                estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                finalaccountBUS.CreateFinalAccountDetail(finalaccountitem);
                                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                long totalCost = totalCostCurr + finalaccountitem.TotalCost;
                                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                                // Exist Material
                                if (materialWh != null)
                                {
                                    materialWh.Quantity += finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.UpdateWarehouseItem(materialWh);
                                }
                                // Not Exits Material
                                else
                                {
                                    materialWh = new WarehouseMaterialDTO();
                                    materialWh.MaterialID = finalaccountitem.MaterialID;
                                    materialWh.WarehouseID = warehouseId;
                                    materialWh.Quantity = finalaccountitem.Quantity;
                                    materialWh.TotalCost = 0;
                                    materialWh.AveragePrice = 0;
                                    warehouseBUS.CreateWarehouseItem(materialWh);
                                }
                            }
                        }
                    }
                    #endregion

                    #region Update Item
                    if (itemfinded != null)
                    {
                        materialWh.Quantity = materialWh.Quantity - itemfinded.Quantity + finalaccountitem.Quantity;
                        warehouseBUS.UpdateWarehouseItem(materialWh);
                        finalaccountitem.FinalAccountDetailID = itemfinded.FinalAccountDetailID;
                        finalaccountBUS.UpdateFinalAccountDetail(finalaccountitem);
                        currEstDetail.QuantityReal = (long)(currEstDetail.QuantityReal - (itemfinded.Quantity * material.Ratio) +
                                                      finalaccountitem.QuantityEst);
                        currEstDetail.TotalCostReal = currEstDetail.TotalCostReal - itemfinded.TotalCost +
                                                     finalaccountitem.TotalCost;
                        currEstDetail.UnitCostReal = (long) (currEstDetail.TotalCostReal/currEstDetail.QuantityReal);
                        if (currEstDetail.Type.Equals("Chi Phí Phát Sinh"))
                        {
                            currEstDetail.QuantityEstimate = (long)(currEstDetail.QuantityEstimate - itemfinded.QuantityEst +
                                                      finalaccountitem.QuantityEst);
                            currEstDetail.TotalCostEstimate = currEstDetail.TotalCostEstimate - itemfinded.TotalCost +
                                                         finalaccountitem.TotalCost;
                            currEstDetail.UnitCostEstimate = currEstDetail.TotalCostEstimate / currEstDetail.QuantityEstimate;
                        }
                        estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                        for (int i = 0; i < listFinalAccountDetail.Count; i++)
                        {
                            if (listFinalAccountDetail[i].MaterialID == material.MaterialID)
                            {
                                long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                                long totalCost = totalCostCurr - listFinalAccountDetail[i].TotalCost + finalaccountitem.TotalCost;
                                txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                            }
                        }
                    }
                    #endregion
                }
                RefreshDisplayData();
                btnSave_Click(null, null);
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
        
        private bool ValidateInput()
        {
            if (!Global.ValidateIntNumber(txtNo.Text))
            {
                KryptonMessageBox.Show("Chưa Nhập Mã Phiếu Mua Hàng", Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNo.Focus();
                return false;
            }
            if (txtPersonAccount.Text.Equals(Constants.EMPTY_TEXT))
            {
                KryptonMessageBox.Show("Chưa Nhập Người Thực Hiện", Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            long finalAccountId = Convert.ToInt32(txtNo.Text);
            string accountPerson = txtPersonAccount.Text;
            long debtId = Global.GetDataCombobox(cbbDebt, Constants.DEBT);
            DateTime dateaccount = DateTime.Parse(dtpDateAccount.Text);
            long transportationCost = Global.ConvertMoneyToLong(txtTransportationCost.Text, Constants.SPLIP_MONEY);
            long totalCost = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
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
            long constructionId;
            long warehouseId;
            if (cbbConstruction.Enabled)
            {
                var construction = (ConstructionDTO) cbbConstruction.SelectedItem;
                constructionId = construction.ConstructionID;
                warehouseId = construction.WarehouseID;
            }
            else
            {
                var warehouse = (WarehouseDTO) cbbMainWarehouse.SelectedItem;
                constructionId = 0;
                warehouseId = warehouse.WarehouseID;                
            }
            var finalAccount = new FinalAccountDTO()
                                               {
                                                   FinalAccountID = finalAccountId,                                                   
                                                   ConstructionID = constructionId,
                                                   DateAccount = dateaccount,
                                                   DebtID = debtId,
                                                   TransportationCost = transportationCost,
                                                   TotalCost = totalCost,
                                                   IsPay = ispay,
                                                   WarehouseID = warehouseId,
                                                   PersonAccount = accountPerson,
                                                   Note = note
                                               };
            if (_isNew)
            {
                bool success = finalaccountBUS.CreateFinalAccount(finalAccount);
                if (success)
                {
                    KryptonMessageBox.Show(
                        " Bạn Đã Tạo Phiếu Mua Hàng Thành Công.\n Bây Giờ Bạn Có Thể Nhập Các Mặt Hàng Cần Mua",
                        Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isNew = false;
                }
                else
                {
                    KryptonMessageBox.Show(
                        " Mã Phiếu Mua Hàng Đã Tồn Tại.\n Nhập Mã Mua Hàng Mới Trước Khi Lưu Lại",
                        Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _isNew = true;
                    txtNo.Focus();
                }
            }
            else
            {
                bool success = finalaccountBUS.UpdateFinalAccount(finalAccount);
                if (success)
                {
                    KryptonMessageBox.Show(Constants.UPDATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.OK);
                }                
            }
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
            Global.SetTextBoxMoneyLeave(textBox);
        }

        private void txtTotalCostItem_Enter(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtQuantity.Text);
            long unitCost = Global.ConvertMoneyToLong(txtUnitCost.Text, Constants.SPLIP_MONEY);
            txtTotalCostItem.Text = Global.ConvertLongToMoney((long)(quantity * unitCost), Constants.SPLIP_MONEY);
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
            string nameMaterial = cbbMaterial.Text;
            for (int i = 0; i < listMaterial.Count; i++)
            {
                MaterialDTO materialDTO = listMaterial[i];
                if (materialDTO.MaterialName.ToUpper().Equals(nameMaterial.ToUpper()))
                {
                    isExist = true;
                    cbbMaterial.SelectedItem = materialDTO;
                    i = listMaterial.Count;
                }
            }
            if (!isExist)
            {
                if (KryptonMessageBox.Show(Constants.NOT_EXIST_MATERIAL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddNewMaterial newMaterial = new AddNewMaterial(nameMaterial);
                    newMaterial.ShowDialog();
                    listMaterial = materialBUS.LoadAllMaterials();
                    Global.SetDataCombobox(cbbMaterial, Constants.MATERIAL);
                    cbbMaterial.SelectedIndex = listMaterial.Count - 1;
                }
            }
        }

        private void dgvAccDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _isNewItem = false;
            int indexMaterial = 0;
            DataGridViewRow r = dgvAccDetail.Rows[e.RowIndex];
            if (r.DataBoundItem == null)
            {
                return;
            }
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
            cbbMaterial.SelectedIndex = indexMaterial;
            txtQuantity.Text = r.Cells["Quantity"].Value.ToString();
            txtUnitCost.Text = r.Cells["UnitCostFormated"].Value.ToString();
            txtTotalCostItem.Text = r.Cells["TotalCostFormated"].Value.ToString();
            txtNoteItem.Text = r.Cells["Note"].Value.ToString();
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
            Global.SetTextBoxNumberEnter(txtNo);
            Global.SetTextBoxNumberEnter(txtQuantity);
            Global.SetTextBoxNumberEnter(txtTotalCost);
            Global.SetTextBoxNumberEnter(txtTotalCostItem);
            Global.SetTextBoxNumberEnter(txtTransportationCost);
            Global.SetTextBoxNumberEnter(txtUnitCost);            
            txtNote.Text = Constants.EMPTY_TEXT;
            txtNoteItem.Text = Constants.EMPTY_TEXT;
            txtPersonAccount.Text = Constants.EMPTY_TEXT;
            if (cbbConstruction.Items.Count > 0)
            {
                cbbConstruction.SelectedIndex = 0;
            }
            if (cbbDebt.Items.Count > 0)
            {
                cbbDebt.SelectedIndex = 0;
            }
            if (cbbMainWarehouse.Items.Count > 0)
            {
                cbbMainWarehouse.SelectedIndex = 0;
            }
            if (cbbMaterial.Items.Count > 0)
            {
                cbbMaterial.SelectedIndex = 0;
            }
            if (cbbStatus.Items.Count > 0)
            {
                cbbStatus.SelectedIndex = 0;
            }
            if (cbbToPlace.Items.Count > 0)
            {
                cbbToPlace.SelectedIndex = 0;
            }
            int totalDetail = listFinalAccountDetail.Count;
            for (int i = 0; i < totalDetail; i++)
            {
                listFinalAccountDetail.RemoveAt(0);
            }
            RefreshDisplayData();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberLeave(txtQuantity);
        }

        private void txtTotalCostItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddItem_Click(null, null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isNewItem = true;
            RefreshDisplayData();
        }

        private void hdDetailInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxNewItem.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlNewItem, 210, 2, 8, false);
                gbxNewItem.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxNewItem.Visible = true;
                Global.DownUpControl(this, pnlNewItem, 210, 2, 8, true);
            }
        }        
    }
}