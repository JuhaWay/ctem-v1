using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class NewStockOut : KryptonForm
    {
        bool _isNew;        
        private List<EstimateDTO> listEstimate;
        private List<EstimateDetailDTO> listMaterialInEstimate;
        readonly EstimateBUS estimateBus = new EstimateBUS();
        readonly MaterialBUS materialBUS = new MaterialBUS();
        EstimateDetailBUS estimateDetailBus = new EstimateDetailBUS();
        private readonly WarehouseBUS _warehouseBus = new WarehouseBUS();
        private readonly ConstructionBus _constructionBus = new ConstructionBus();
        private List<StockOutDetailDTO> _listDetail = new List<StockOutDetailDTO>();
        public NewStockOut()
        {
            InitializeComponent();
            _isNew = true;            
        }

        private void NewStockOut_Load(object sender, EventArgs e)
        {
            SetData();
            SetLauout();
            if (!_isNew)
            {
                setInnitLayout();
            }            
        }

        private void SetData()
        {
            Global.SetDataCombobox(cbbDriver, Constants.DRIVER);
            Global.SetDataCombobox(cbbmaterial, Constants.MATERIAL);
            Global.SetDataCombobox(cbbStockOutFrom, Constants.MAIN_WAREHOUSE);
            Global.SetDataCombobox(cbbStockOutTo, Constants.CONSTRUCTION_WAREHOUSE);            
            Global.SetDataCombobox(cbbVehicle, Constants.VERHICLE);
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
            Global.SetDaulftDatagridview(dgvStockOutDetail);
            Global.SetTextBoxNumberLeave(txtTransportationCost);
            Global.SetTextBoxNumberLeave(txtQuantity);
        }

        private void setInnitLayout()
        {
            //List<FinalAccountDTO> listaccount = finalaccountBUS.GetFinalAccountById(_id, dtpDateAccount.MinDate, dtpDateAccount.MaxDate);
            //FinalAccountDTO currenAccount = listaccount[0];
            //listFinalAccountDetail = finalaccountBUS.GetFinalAccountDetailByFAId(_id);
            //RefreshDisplayData();
            //txtNo.Text = currenAccount.FinalAccountID.ToString();
            //txtNameFinalAccount.Text = currenAccount.FinalAccountName;
            //txtNo.Text = currenAccount.Note;
            //txtPersonAccount.Text = currenAccount.PersonAccount;
            //txtTotalCost.Text = currenAccount.TotalCostFormated;
            //txtTransportationCost.Text = currenAccount.TransportationCostFormated;
            //if (currenAccount.ConstructionID == 0)
            //{
            //    cbbToPlace.SelectedIndex = 1;
            //}
            //if (currenAccount.IsPay == 1)
            //{
            //    cbbStatus.SelectedIndex = 0;
            //}
            //else
            //{
            //    cbbStatus.SelectedIndex = 1;
            //}
        }

        private void RefreshDisplayData()
        {
            dgvStockOutDetail.DataSource = null;
            dgvStockOutDetail.DataSource = _listDetail;
            if (cbbmaterial.Items.Count > 0)
            {
                cbbmaterial.SelectedIndex = 0;
            }
            txtQuantity.Text = Constants.ZERO_NUMBER;
            txtNoteDetail.Text = Constants.EMPTY_TEXT;
        }

        private void txtTransportationCost_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTransportationCost);
        }

        private void txtTransportationCost_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtTransportationCost);
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtQuantity);
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberLeave(txtQuantity);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbbVehicle.SelectedIndex = 0;            
            cbbStockOutTo.SelectedIndex = 0;
            cbbStockOutFrom.SelectedIndex = 0;
            cbbmaterial.SelectedIndex = 0;
            cbbDriver.SelectedIndex = 0;
            txtTransportationCost.Text = Constants.ZERO_NUMBER;
            txtQuantity.Text = Constants.ZERO_NUMBER;
            txtNote.Text = Constants.EMPTY_TEXT;
            txtNoteDetail.Text = Constants.EMPTY_TEXT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckExistItem())
            {
                KryptonMessageBox.Show(Constants.ERROR_EXIST_ITEM, Constants.CONFIRM);
                RefreshDisplayData();
            }
            else if (_isNew)
            {
                KryptonMessageBox.Show("Bạn Phải Tạo Phiếu Xuất Kho Trước Khi Nhập Vật Liệu Cần Xuất", Constants.CONFIRM,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNo.Focus();
                return;
            }
            else
            {
                var warehousefrom = cbbStockOutFrom.SelectedItem as WarehouseDTO;
                var warehouseto = cbbStockOutTo.SelectedItem as WarehouseDTO;
                var material = (WarehouseMaterialDTO)cbbmaterial.SelectedItem;
                var stockOutDetailDTO = new StockOutDetailDTO();
                stockOutDetailDTO.StockOutId = txtNo.Text;
                stockOutDetailDTO.WarehouseFromId = warehousefrom.WarehouseID;
                stockOutDetailDTO.WarehouseToId = warehouseto.WarehouseID;
                stockOutDetailDTO.MaterialId = material.MaterialID;
                stockOutDetailDTO.MaterialName = material.MaterialName;
                stockOutDetailDTO.MaterialUnitCall = material.UnitCal;
                stockOutDetailDTO.Price = Global.ConvertMoneyToLong(txtUnitCost.Text, Constants.SPLIP_MONEY);
                stockOutDetailDTO.TotalCost = Global.ConvertMoneyToLong(txtTotalCostItem.Text, Constants.SPLIP_MONEY);
                stockOutDetailDTO.Note = txtNoteDetail.Text;

                var itemfinded = _warehouseBus.FindStockOutItem(stockOutDetailDTO.StockOutId, stockOutDetailDTO.MaterialId);
                ConstructionDTO consDTO = _constructionBus.LoadConstructionById(warehouseto.ConstructionID);
                if (!consDTO.type.Equals(ConstructionDTO.SUB))
                {
                    bool isExistEst = false;
                    string typeCons = consDTO.type;
                    long constructionId = consDTO.ConstructionID;
                    long warehouseId = consDTO.WarehouseID;
                    //var materialWh = _warehouseBus.FindMateriral(warehouseId, stockOutDetailDTO.MaterialId);
                    var selectMaterial = (MaterialDTO) cbbmaterial.SelectedItem;
                    var currEstDetail = new EstimateDetailDTO();
                    listEstimate = estimateBus.LoadEstimateByConstruction(constructionId);
                    long EstimateID = listEstimate[0].EstimateID;
                    listMaterialInEstimate = materialBUS.LoadALlMaterialsEstimate(constructionId);
                    for (int i = 0; i < listMaterialInEstimate.Count; i++)
                    {
                        currEstDetail = listMaterialInEstimate[i];
                        if (selectMaterial.MaterialID == currEstDetail.MaterialID ||
                            selectMaterial.MaterialID == currEstDetail.MaterialParentId)
                        {
                            isExistEst = true;
                            i = listMaterialInEstimate.Count;
                        }
                    }

                    if (itemfinded == null)
                    {
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
                                estimateDetailDTO.MaterialID = stockOutDetailDTO.MaterialId;
                                estimateDetailDTO.QuantityEstimate = stockOutDetailDTO.Quantity*material.Ratio;
                                estimateDetailDTO.QuantityReal = (long) (stockOutDetailDTO.Quantity*material.Ratio);
                                estimateDetailDTO.TotalCostEstimate = stockOutDetailDTO.TotalCost;
                                estimateDetailDTO.TotalCostReal = stockOutDetailDTO.TotalCost;
                                estimateDetailDTO.UnitCostEstimate = (long) (estimateDetailDTO.TotalCostEstimate/
                                                                             estimateDetailDTO.QuantityEstimate);
                                estimateDetailDTO.UnitCostReal = (long) estimateDetailDTO.UnitCostEstimate;
                                estimateDetailDTO.Type = EstimateDetailDTO.TYPE_GENERAL;
                                estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                                _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                            }
                            else if (result == DialogResult.No)
                            {
                                var estimateDetailDTO = new EstimateDetailDTO();
                                estimateDetailDTO.EstimateID = EstimateID;
                                estimateDetailDTO.No = Constants.EMPTY_TEXT;
                                estimateDetailDTO.Name = Constants.EMPTY_TEXT;
                                estimateDetailDTO.MaterialID = stockOutDetailDTO.MaterialId;
                                estimateDetailDTO.QuantityEstimate = 0;
                                estimateDetailDTO.QuantityReal = stockOutDetailDTO.Quantity*material.Ratio;
                                estimateDetailDTO.TotalCostEstimate = 0;
                                estimateDetailDTO.TotalCostReal = stockOutDetailDTO.TotalCost;
                                estimateDetailDTO.UnitCostEstimate = 0;
                                estimateDetailDTO.UnitCostReal =
                                    (long) (stockOutDetailDTO.TotalCost/stockOutDetailDTO.Quantity);
                                estimateDetailDTO.Type = EstimateDetailDTO.TYPE_GENERAL;
                                estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                                _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                            }
                            else
                            {
                                RefreshDisplayData();
                                return;
                            }
                        }

                        else if (!isExistEst && typeCons.Equals("Công trình Thủy lợi"))
                        {
                            EstimateDetailDTO estimateDetailDTO = new EstimateDetailDTO();
                            estimateDetailDTO.EstimateID = EstimateID;
                            estimateDetailDTO.MaterialID = stockOutDetailDTO.MaterialId;
                            estimateDetailDTO.QuantityEstimate = 0;
                            estimateDetailDTO.QuantityReal = stockOutDetailDTO.Quantity;
                            estimateDetailDTO.TotalCostEstimate = 0;
                            estimateDetailDTO.TotalCostReal = stockOutDetailDTO.TotalCost;
                            estimateDetailDTO.UnitCostEstimate = 0;
                            estimateDetailDTO.UnitCostReal = stockOutDetailDTO.Price;
                            estimateDetailDTO.Type = EstimateDetailDTO.TYPE_GENERAL;
                            estimateDetailBus.CreateEstimateDetail(estimateDetailDTO);
                            _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                        }

                            // Exits In Estimate
                        else if (isExistEst)
                        {
                            currEstDetail.QuantityReal += stockOutDetailDTO.Quantity*material.Ratio;
                            currEstDetail.TotalCostReal += stockOutDetailDTO.TotalCost;
                            currEstDetail.UnitCostReal = (long) (currEstDetail.TotalCostReal/currEstDetail.QuantityReal);
                            if (currEstDetail.QuantityReal > (currEstDetail.QuantityEstimate*0.8) &&
                                currEstDetail.QuantityReal < currEstDetail.QuantityEstimate)
                            {
                                if (KryptonMessageBox.Show(
                                    " Nếu Chuyển Hàng Này Đến Sẽ Vượt Quá 80% Dự Toán.\n Bạn Chắc Chắn Mún Chuyển Đến?",
                                    Constants.CONFIRM,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                    _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                                }
                                else
                                {
                                    RefreshDisplayData();
                                }
                            }
                            else if (currEstDetail.QuantityReal > currEstDetail.QuantityEstimate)
                            {
                                if (KryptonMessageBox.Show(
                                    " Nếu Chuyển Mặt Hàng Này Đến Sẽ Vượt Quá 100% Dự Toán.\n Bạn Chắc Chắn Đã Giải Trình Với Chủ Đầu Tư?",
                                    Constants.CONFIRM,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                    _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                                }
                                else
                                {
                                    RefreshDisplayData();
                                }
                            }
                            else
                            {
                                estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                                _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
                            }
                        }
                    }
                    if (itemfinded != null)
                    {
                        //materialWh.Quantity = materialWh.Quantity - itemfinded.Quantity + finalaccountitem.Quantity;
                        //warehouseBUS.UpdateWarehouseItem(materialWh);
                        //finalaccountitem.FinalAccountDetailID = itemfinded.FinalAccountDetailID;
                        //finalaccountBUS.UpdateFinalAccountDetail(finalaccountitem);
                        //currEstDetail.QuantityReal = (long)(currEstDetail.QuantityReal - (itemfinded.Quantity * material.Ratio) +
                        //                              finalaccountitem.QuantityEst);
                        //currEstDetail.TotalCostReal = currEstDetail.TotalCostReal - itemfinded.TotalCost +
                        //                             finalaccountitem.TotalCost;
                        //currEstDetail.UnitCostReal = (long) (currEstDetail.TotalCostReal/currEstDetail.QuantityReal);
                        //if (currEstDetail.Type.Equals("Chi Phí Phát Sinh"))
                        //{
                        //    currEstDetail.QuantityEstimate = (long)(currEstDetail.QuantityEstimate - itemfinded.QuantityEst +
                        //                              finalaccountitem.QuantityEst);
                        //    currEstDetail.TotalCostEstimate = currEstDetail.TotalCostEstimate - itemfinded.TotalCost +
                        //                                 finalaccountitem.TotalCost;
                        //    currEstDetail.UnitCostEstimate = currEstDetail.TotalCostEstimate / currEstDetail.QuantityEstimate;
                        //}
                        //estimateDetailBus.UpdateEstimateDetail(currEstDetail);
                        //for (int i = 0; i < listFinalAccountDetail.Count; i++)
                        //{
                        //    if (listFinalAccountDetail[i].MaterialID == material.MaterialID)
                        //    {
                        //        long totalCostCurr = Global.ConvertMoneyToLong(txtTotalCost.Text, Constants.SPLIP_MONEY);
                        //        long totalCost = totalCostCurr - listFinalAccountDetail[i].TotalCost + finalaccountitem.TotalCost;
                        //        txtTotalCost.Text = Global.ConvertLongToMoney(totalCost, Constants.SPLIP_MONEY);
                        //    }
                        //}
                    }
                }
                _listDetail.Add(stockOutDetailDTO);
                RefreshDisplayData();
            }
        }

        private bool CheckExistItem()
        {
            bool isExist = false;
            var material = (MaterialDTO)cbbmaterial.SelectedItem;
            foreach (StockOutDetailDTO detailDTO in _listDetail)
            {
                if (detailDTO.MaterialId == material.MaterialID)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvStockOutDetail.SelectedRows)
                {
                    int indexDetail = 0;
                    string materialName = row.Cells["MaterialName"].Value.ToString();
                    for (int i = 0; i < _listDetail.Count; i++)
                    {
                        StockOutDetailDTO detail = _listDetail[i];
                        if (detail != null)
                            if (detail.MaterialName.Equals(materialName))
                            {
                                indexDetail = i;
                            }
                    }
                    _listDetail.RemoveAt(indexDetail);
                }
                RefreshDisplayData();

            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int totalDetail = _listDetail.Count;
                for (int i = 0; i < totalDetail; i++)
                {
                    _listDetail.RemoveAt(0);
                }
                RefreshDisplayData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stockNo = txtNo.Text;
            var datestock = dtpStockOutDate.Value;
            string stockFrom = cbbStockOutFrom.Text;
            string stockTo = cbbStockOutTo.Text;
            string driver = cbbDriver.Text;
            long transConst = Global.ConvertMoneyToLong(txtTransportationCost.Text, Constants.SPLIP_MONEY);
            string note = txtNote.Text;
            var vehicle = cbbVehicle.SelectedItem as VehicleDTO;
            long vehicleId = vehicle != null ? vehicle.VehicleID : 0;
            var stockout = new StockOutDTO
                                        {
                                            StockOutId = stockNo,
                                            DateStockOut = datestock,
                                            Note = note,
                                            StockOutFrom = stockFrom,
                                            StockOutTo = stockTo,
                                            DriverName = driver,
                                            NoVehicle = vehicleId,
                                            TransportationCost = transConst
                                        };            
            if (_isNew)
            {
                bool success = _warehouseBus.CreateStockOut(stockout);
                if (success)
                {
                    KryptonMessageBox.Show(
                        " Tạo Phiếu Xuất Kho Thành Công.\n Bây Giờ bạn Có thể Thêm Các Vật Tư Cho Lần Xuất Hàng Này",
                        Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbmaterial.Focus();
                    _isNew = false;
                }
                else
                {
                    KryptonMessageBox.Show(
                        "Phiếu Mua Hàng Này Đã Tồn Tại. Nhập Phiếu Mua Hàng Khác Và Lưu Lại",
                        Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNo.Focus();
                }
            }
            else
            {
                bool success = _warehouseBus.UpdateStockOut(stockout);
                if (success)
                {
                    KryptonMessageBox.Show(
                        "Đã Lưu Thành Công", Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbmaterial.Focus();
                    _isNew = false;
                }
                else
                {
                    KryptonMessageBox.Show(
                        "Lưu Không Thành Công",
                        Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNo.Focus();
                }
            }
            
        }

        private void cbbStockOutFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var warehouseDTO = cbbStockOutFrom.SelectedItem as WarehouseDTO;
            MaterialBUS materialBus = new MaterialBUS();
            List<MaterialDTO> listMaterialWH = new List<MaterialDTO>();
            listMaterialWH = materialBus.LoadMaterialByWarehouseId(warehouseDTO.WarehouseID);
            cbbmaterial.DataSource = listMaterialWH;
            cbbmaterial.DisplayMember = Constants.MATERIAL_DISPLAYMEMBER;
            cbbmaterial.ValueMember = Constants.MATERIAL_VALUEMEMBER;
        }

        private void cbbmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            WarehouseMaterialDTO item = cbbmaterial.SelectedItem as WarehouseMaterialDTO;
            txtUnitCost.Text = item.AveragePriceFormated;
            txtTotalCostItem.Text = item.TotalCostFormated;
            UnitCal.Text = item.UnitCal;
        }
    }
}