﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageVehicle
{
    public partial class AddnewVehicleDairy : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private WarehouseBUS _warehouseBUS = new WarehouseBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private DebtBUS _debtBUS = new DebtBUS();
        private FinalAccountBUS _finalAccountBUS = new FinalAccountBUS();
        private List<RoadMapDTO> list = new List<RoadMapDTO>();
        private List<VehicleDairyCostDTO> _costs = new List<VehicleDairyCostDTO>();
        private RoadMapDTO dtoTemp = new RoadMapDTO();
        private VehicleDairyDTO _vehicleDairyDTO = new VehicleDairyDTO();
        private long _ID = 0;
        public AddnewVehicleDairy()
        {
           
            InitializeComponent();
            CenterToParent();
        }

        public AddnewVehicleDairy(long ID)
        {
            InitializeComponent();
            CenterToParent();
            _ID = ID;
        }

        private void AddnewVehicleDairy_Load(object sender, EventArgs e)
        {
            cbDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbDriver.DisplayMember = "Username";
            VehicleDTO dto = new VehicleDTO();
            dto.Name = "";
            dto.Number = "";
            dto.ManagerID = Global.CurrentUser.employeeID;
            dto.Category = VehicleDTO.CATEGORY_VEHICLE;
            cbVehicle.Items.AddRange(_vehicleBUS.searchVehicle(dto).ToArray());
            cbVehicle.DisplayMember = "Number";

            cbTypeCost.Items.AddRange(VehicleDairyCostDTO.getTypeCost().ToArray());

            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbType.SelectedIndex = 0;

            WarehouseDTO ware = new WarehouseDTO();
            ware.WarehouseID = 0;
            ware.WarehouseName = "";
            cbHouse.Items.Add(ware);
            cbHouse.Items.AddRange(_warehouseBUS.LoadWarehouses("", Constants.MAIN_WAREHOUSE, -1).ToArray());
            cbHouse.DisplayMember = "WarehouseName";




            DebtDTO debt = new DebtDTO();
            debt.DebtID = 0;
            debt.DebtName = "";
            cbProvider.Items.Add(debt);
            cbProvider.Items.AddRange(_debtBUS.GetDebt(0,"",-1).ToArray());
            cbProvider.DisplayMember = "DebtName";


            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetLayoutSplipContainer(kryptonSplitContainer1, 2);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox3);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);
            Global.SetDaulftDatagridview(dgvRoadMap);
            dgvRoadMap.ReadOnly = false;
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutPanelNewForm(pnLeft);
            Global.SetLayoutPanelNewForm(kryptonPanel1);


            Global.SetDaulftDatagridview(dgvCost);
            dgvCost.ReadOnly = false;
            Global.SetLayoutHeaderGroup(hdCost, Constants.CHILD_FORM);
            Global.SetLayoutGroupBoxButton(gbCost);
            Global.SetLayoutGroupBoxButton(gbright);

            if(_ID>0)
                loadUpdateForm();
        }

        public void loadUpdateForm(){
             _vehicleDairyDTO = _vehicleDairyBUS.getByID(_ID);
            foreach (VehicleDTO dto in cbVehicle.Items)
            {
                if (dto.VehicleID == _vehicleDairyDTO.VehicleID)
                    cbVehicle.SelectedItem = dto;
            }
            foreach (EmployerDTO dto in cbDriver.Items)
            {
                if (dto.employeeID == _vehicleDairyDTO.DriverID)
                    cbDriver.SelectedItem = dto;
            }
            foreach (ConstructionDTO dto in cbCons.Items)
            {
                if (dto.ConstructionID == _vehicleDairyDTO.ConstructionID)
                    cbCons.SelectedItem = dto;
            }
            foreach (WarehouseDTO dto in cbHouse.Items)
            {
                if (dto.WarehouseID == _vehicleDairyDTO.WarehouseID)
                    cbHouse.SelectedItem = dto;
            }
            foreach (DebtDTO dto in cbProvider.Items)
            {
                if (dto.DebtID == _vehicleDairyDTO.DebtID)
                    cbProvider.SelectedItem = dto;
            }
            ipOtherCost.Text = _vehicleDairyDTO.DamagedCostFormated;
            cbPaid.Checked = _vehicleDairyDTO.isPaid.Value;
            dtDay.Value = _vehicleDairyDTO.Date;
            ipTaker.Text = _vehicleDairyDTO.Taker;
            list = _vehicleDairyBUS.getALLRoads(_ID);
            dgvRoadMap.DataSource = null;
            dgvRoadMap.DataSource = list;
            firstloadCosts();
            
        }
        public void firstloadCosts()
        {
            VehicleDairyCostDTO search = new VehicleDairyCostDTO();
            search.VehicleDairyID = _ID;
            search.FromDate = null;
            search.ToDate = null;
            search.Type = "";
            _costs = _vehicleDairyBUS.searchVehicleDairyCost(search);
            reloadCosts();
        }
       

        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            if (!validateRoad()) return;
            dtoTemp = new RoadMapDTO();
            dtoTemp.Km = ipKm.Text;
            dtoTemp.From = ipFrom.Text;
            dtoTemp.To = ipTo.Text;
            dtoTemp.Date = dtRmDate.Value.Date;
            list.Add(dtoTemp);
            dgvRoadMap.DataSource = null;
            dgvRoadMap.DataSource = list;
            ipKm.Text = "";
            ipFrom.Text = "";
            ipTo.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
       
            foreach(DataGridViewRow row in dgvRoadMap.SelectedRows){
                list.Remove(row.DataBoundItem as RoadMapDTO);
               
            }
            dgvRoadMap.DataSource = null;
            dgvRoadMap.DataSource = list;
           
        }

       
        // Cost Datagrid view
        private void btSaveCost_Click(object sender, EventArgs e)
        {
            if (!validateCost()) return;
            VehicleDairyCostDTO entity = new VehicleDairyCostDTO();
            entity.Type = cbTypeCost.Text;
            entity.Quantity = Global.ConvertMoneyToDouble(ipQuantity.Text,Global.SEP);
            entity.Price = Global.ConvertMoneyToDouble(ipPrice.Text, Global.SEP);
            entity.TotalCost = entity.Quantity * entity.Price;

            entity.PriceFormated = Global.ConvertDoubleToMoney(entity.Price, Global.SEP);
            entity.TotalCostFormated = Global.ConvertDoubleToMoney(entity.TotalCost, Global.SEP);

            entity.Unit = ipUnit.Text.Trim();
            entity.Taker = ipTaker.Text.Trim();
            entity.Name = ipName.Text.Trim();
            entity.Date = dtDate.Value.Date;
            _costs.Add(entity);
            reloadCosts();
            reset();
           
        }

        public void reset()
        {
            cbTypeCost.SelectedIndex = -1;
            ipQuantity.Text = "";
            ipPrice.Text = "";
            ipName.Text = "";
            ipUnit.Text = "";
        }

        private void btDeleteCost_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCost.SelectedRows)
            {
                _costs.Remove(row.DataBoundItem as VehicleDairyCostDTO);

            }
            reloadCosts();
        }
        public void reloadCosts()
        {
            if (_costs == null)
                _costs = new List<VehicleDairyCostDTO>();
            dgvCost.DataSource = null;
            dgvCost.DataSource = _costs;
            double total = 0;
            foreach (VehicleDairyCostDTO item in _costs)
            {
                total += item.TotalCost;
            }
            ipSumCost.Text = Global.ConvertDoubleToMoney(total, Global.SEP);
        }
        // lưu form----------------------------------------------------------------------------------
        private void btSave_Click(object sender, EventArgs e)
        {
            if (_ID == 0)
            {
                if (!validateForm()) return;
                VehicleDairyDTO dto = new VehicleDairyDTO();
                dto.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                dto.Date = dtDay.Value.Date;
                dto.isPaid = cbPaid.Checked;
                dto.Task = "";
                dto.Taker = ipTaker.Text;
                dto.DamagedCost = Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP);
                dto.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP) + dto.DamagedCost;
                if (cbHouse.SelectedIndex > 0)
                    dto.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
                else dto.WarehouseID = 0;
                if (cbProvider.SelectedIndex > 0)
                    dto.DebtID = (cbProvider.SelectedItem as DebtDTO).DebtID;
                else dto.DebtID = 0;
                if (cbCons.SelectedIndex > -1)
                    dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
                long ID = _vehicleDairyBUS.CreateVehicleDairy(dto);
                if (dto.isPaid == false)
                {
                    FinalAccountDTO faccount = new FinalAccountDTO();
                    faccount.FinalAccountID = "AUTOVEHICEL";
                    faccount.TotalCost = dto.Totalcost;
                    faccount.WarehouseID = dto.WarehouseID;
                    faccount.DebtID = dto.DebtID;
                    faccount.DateAccount = DateTime.Today.Date;
                    faccount.PersonAccount = "";
                    faccount.Note = "";
                    _finalAccountBUS.CreateFinalAccount(faccount);
                }
                foreach (RoadMapDTO item in list)
                {
                    item.VehicleDairyID = ID;
                    _vehicleDairyBUS.CreateRoadMap(item);
                }
                 foreach(VehicleDairyCostDTO item in _costs){
                     item.VehicleID = dto.VehicleID;
                     item.VehicleDairyID = ID;
                     item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                     item.Price =Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP); 
                     _vehicleDairyBUS.CreateVehicleDairyCost(item);
                 }
                 
            }
            else
            {
                if (!validateForm()) return;
                _vehicleDairyDTO.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                _vehicleDairyDTO.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                _vehicleDairyDTO.Date = dtDay.Value.Date;
                _vehicleDairyDTO.isPaid = cbPaid.Checked;
                _vehicleDairyDTO.Task = "";
                _vehicleDairyDTO.Taker = ipTaker.Text;
                _vehicleDairyDTO.DamagedCost = Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP);
                _vehicleDairyDTO.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP) + _vehicleDairyDTO.DamagedCost;
                if (cbHouse.SelectedIndex > 0)
                    _vehicleDairyDTO.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
                else _vehicleDairyDTO.WarehouseID = 0;
                if (cbProvider.SelectedIndex > 0)
                    _vehicleDairyDTO.DebtID = (cbProvider.SelectedItem as DebtDTO).DebtID;
                else _vehicleDairyDTO.DebtID = 0;
                if (cbCons.SelectedIndex > -1)
                    _vehicleDairyDTO.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
                else _vehicleDairyDTO.ConstructionID = 0;
                _vehicleDairyBUS.UpdateVehicleDairy(_vehicleDairyDTO);
                foreach (RoadMapDTO item in list)
                {
                    item.VehicleDairyID = _ID;
                    _vehicleDairyBUS.CreateRoadMap(item);
                }
                _vehicleDairyBUS.deleteVehicleDairyCost(_ID);
                foreach (VehicleDairyCostDTO item in _costs)
                {
                    item.VehicleID = _vehicleDairyDTO.VehicleID;
                    item.VehicleDairyID = _ID;
                    item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                    item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP); 
                    _vehicleDairyBUS.CreateVehicleDairyCost(item);
                }
            }
            this.Close();
        }
        //đóng
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //---------------------------------------------------------------------------------------------
        private bool validateForm()
        {

            if (cbVehicle.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn xe", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            if (cbDriver.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn tài xế", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool validateRoad()
        {

            if (ipFrom.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền nơi đi", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            if (ipTo.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền nơi đến", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            if (!Global.ValidateIntNumber(ipKm.Text))
            {
                KryptonMessageBox.Show("Nhập sai thông tin Km", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool validateCost()
        {

            if (cbTypeCost.SelectedIndex<0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn loại chi phí", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void ipPrice_Leave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, Global.SEP), Global.SEP);
        }

        private void ipPrice_MouseLeave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, Global.SEP), Global.SEP);
        }

        private void dgvCost_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvCost.Rows.Count == 0) return;
            if(e.ColumnIndex==1){
                if(!Global.ValidateDoubleNumber(e.FormattedValue.ToString())){
                    KryptonMessageBox.Show("Nhập sai thông tin số lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void dgvRoadMap_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvRoadMap.Rows.Count <= 0) return;
            if (e.ColumnIndex == 2)
            {
                if (!Global.ValidateIntNumber(e.FormattedValue.ToString()))
                {
                    KryptonMessageBox.Show("Nhập sai thông tin Km", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void dgvCost_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCost.Rows.Count == 0) return;
            if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
            {
                double total = 0;
                string sprice = dgvCost.Rows[e.RowIndex].Cells[3].Value.ToString();
                double price = Global.ConvertMoneyToDouble(sprice, Global.SEP);
                double quantity = (double)dgvCost.Rows[e.RowIndex].Cells[1].Value;
                total = price * quantity;
                dgvCost.Rows[e.RowIndex].Cells[4].Value = total;


                double totalCost = 0;
                foreach (VehicleDairyCostDTO item in _costs)
                {
                    item.TotalCost = Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                    totalCost += item.TotalCost;
                }
                ipSumCost.Text = Global.ConvertDoubleToMoney(totalCost, Global.SEP);
            }
        }
        private void ipQuantity_Leave(object sender, EventArgs e)
        {
            ipQuantity.Text = Global.ConvertDoubleToMoney(Global.ConvertMoneyToDouble(ipQuantity.Text, Global.SEP), Global.SEP);
        }

        private void ipQuantity_MouseLeave(object sender, EventArgs e)
        {
            ipQuantity.Text = Global.ConvertDoubleToMoney(Global.ConvertMoneyToDouble(ipQuantity.Text, Global.SEP), Global.SEP);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                cbCons.SelectedIndex = -1;
                cbCons.Enabled = false;
            }
            else
            {
                cbCons.Enabled = true;
            }
        }

        private void cbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHouse.SelectedIndex > 0)
                cbProvider.Enabled = false;
            else
                cbProvider.Enabled = true;
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvider.SelectedIndex > 0)
                cbHouse.Enabled = false;
            else
                cbHouse.Enabled = true;
        }

       
        private void ipOtherCost_MouseLeave(object sender, EventArgs e)
        {
            ipOtherCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP), Global.SEP);
        }

        private void ipOtherCost_Leave(object sender, EventArgs e)
        {
            ipOtherCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP), Global.SEP);
        }

        private void kryptonGroupBox2_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
} 