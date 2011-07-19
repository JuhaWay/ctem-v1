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
    public partial class NewStockOut : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        bool _isNew;
        bool _isEdit;
        private readonly WarehouseBUS _warehouseBus = new WarehouseBUS();
        private List<StockOutDetailDTO> _listDetail;
        public NewStockOut()
        {
            InitializeComponent();
            _isNew = true;
            _isEdit = false;
        }

        private void NewStockOut_Load(object sender, EventArgs e)
        {
            SetData();
            SetLauout();
            if (_isEdit)
            {
                setInnitLayout();
            }
        }

        private void SetData()
        {
            Global.SetDataCombobox(cbbDriver, Constants.DRIVER);
            Global.SetDataCombobox(cbbmaterial, Constants.MATERIAL);
            Global.SetDataCombobox(cbbStockOutFrom, Constants.CONSTRUCTION_WAREHOUSE);
            Global.SetDataCombobox(cbbStockOutTo, Constants.CONSTRUCTION_WAREHOUSE);
            Global.SetDataCombobox(cbbTypyWarehouse, Constants.WAREHOUSE_TYPE);
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
            cbbTypyWarehouse.SelectedIndex = 0;
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
            else
            {
                var warehousefrom = cbbStockOutFrom.SelectedItem as WarehouseDTO;
                var warehouseto = cbbStockOutTo.SelectedItem as WarehouseDTO;
                var material = (MaterialDTO)cbbmaterial.SelectedItem;
                var stockOutDetailDTO = new StockOutDetailDTO();
                stockOutDetailDTO.WarehouseFromId = warehousefrom.WarehouseID;
                stockOutDetailDTO.WarehouseToId = warehouseto.WarehouseID;
                stockOutDetailDTO.MaterialId = material.MaterialID;
                stockOutDetailDTO.MaterialName = material.MaterialName;
                stockOutDetailDTO.MaterialUnitCall = material.RealCalUnit;
                stockOutDetailDTO.Note = txtNoteDetail.Text;
                if (cbbTypyWarehouse.Text.Equals(Constants.CONSTRUCTION_WAREHOUSE))
                {
                    stockOutDetailDTO.WarehouseToId = 0;
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
            var datestock = dtpStockOutDate.Value;
            string stockFrom = cbbStockOutFrom.Text;
            string stockTo = cbbStockOutTo.Text;
            string driver = cbbDriver.Text;
            long transConst = Global.ConvertMoneyToLong(txtTransportationCost.Text, Constants.SPLIP_MONEY);
            string note = txtNote.Text;
            var vehicle = cbbVehicle.SelectedItem as VehicleDTO;
            long vehicleId = 0;
            if (vehicle != null)
            {
                vehicleId = vehicle.VehicleID;
            }
            if (cbbTypyWarehouse.Text.Equals(Constants.CONSTRUCTION_WAREHOUSE))
            {
                stockTo = "Công Trình";
                driver = Constants.EMPTY_TEXT;
                transConst = 0;
                vehicleId = 0;
            }
            var stockout = new StockOutDTO
                                        {
                                            DateStockOut = datestock,
                                            Note = note,
                                            StockOutFrom = stockFrom,
                                            StockOutTo = stockTo,
                                            DriverName = driver,
                                            NoVehicle = vehicleId,
                                            TransportationCost = transConst
                                        };
            _warehouseBus.CreateStockOut(stockout);
            foreach (StockOutDetailDTO stockOutDetailDTO in _listDetail)
            {
                _warehouseBus.CreateStockOutDetail(stockOutDetailDTO);
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

        private void cbbTypyWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypyWarehouse.Text.Equals(Constants.MAIN_WAREHOUSE))
            {
                cbbStockOutTo.Enabled = true;
                Global.SetDataCombobox(cbbStockOutFrom, Constants.MAIN_WAREHOUSE);
                Global.SetDataCombobox(cbbStockOutFrom, Constants.WAREHOUSE);
            }
            else
            {
                cbbStockOutTo.Enabled = false;
                Global.SetDataCombobox(cbbStockOutFrom, Constants.CONSTRUCTION_WAREHOUSE);
            }
        }            
    }
}