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
    public partial class AddNewMachineDairy : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private FinalAccountBUS _finalAccountBUS = new FinalAccountBUS();
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private WarehouseBUS _warehouseBUS = new WarehouseBUS();
        private DebtBUS _debtBUS = new DebtBUS();
        private List<RoadMapDTO> list = new List<RoadMapDTO>();
        private RoadMapDTO dtoTemp = new RoadMapDTO();
        private VehicleDairyDTO _vehicleDairyDTO = new VehicleDairyDTO();
        private List<VehicleDairyCostDTO> _costs = new List<VehicleDairyCostDTO>();
        private long _ID = 0;
        public AddNewMachineDairy()
        {
            InitializeComponent();
            CenterToParent();
        }

        public AddNewMachineDairy(long ID)
        {
            InitializeComponent();
            CenterToParent();
            _ID = ID;
        }

        private void AddNewMachineDairy_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(kryptonPanel);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);

            Global.SetLayoutGroupBoxButton(gbCost);
            Global.SetDaulftDatagridview(dgvCost);
            dgvCost.ReadOnly = false;
            Global.SetLayoutHeaderGroup(hdCost, Constants.CHILD_FORM);


            cbDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbDriver.DisplayMember = "Username";
            VehicleDTO dto = new VehicleDTO();
            dto.Name = "";
            dto.Number = "";
            dto.ManagerID = Global.CurrentUser.employeeID;
            dto.Category = VehicleDTO.CATEGORY_MACHINE;
            cbVehicle.Items.AddRange(_vehicleBUS.searchVehicle(dto).ToArray());
            cbVehicle.DisplayMember = "Number";
            cbCons.Items.Add(new ConstructionDTO("",0));
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbTypeCost.Items.AddRange(VehicleDairyCostDTO.getTypeCost().ToArray());


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
            cbProvider.Items.AddRange(_debtBUS.GetDebt(0, "", -1).ToArray());
            cbProvider.DisplayMember = "DebtName";
            
            
            if (_ID > 0)
                loadUpdateForm();
        }
        public void loadUpdateForm()
        {
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
            ipTask.Text = _vehicleDairyDTO.Task;
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
       

        private void ipDamagedCost_Leave(object sender, EventArgs e)
        {
            //ipDamagedCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP), Global.SEP);
        }

      

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSaveCost_Click(object sender, EventArgs e)
        {
            if (!validateCost()) return;
            VehicleDairyCostDTO entity = new VehicleDairyCostDTO();
            entity.Type = cbTypeCost.Text;
            entity.Quantity = Global.ConvertMoneyToDouble(ipQuantity.Text, Global.SEP);
            entity.Price = Global.ConvertMoneyToDouble(ipPrice.Text, Global.SEP);
            entity.TotalCost = entity.Quantity * entity.Price;
            entity.Unit = ipUnit.Text.Trim();
            entity.Taker = ipTaker.Text.Trim();
            entity.Name = ipName.Text.Trim();
            entity.Date = dtDate.Value.Date;

            entity.PriceFormated = Global.ConvertDoubleToMoney(entity.Price, Global.SEP);
            entity.TotalCostFormated = Global.ConvertDoubleToMoney(entity.TotalCost, Global.SEP);
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
                dto.Taker = ipTaker.Text;
                dto.Totalcost = dto.FualCost + dto.DamagedCost;
                if (cbCons.SelectedIndex>-1)
                dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
                dto.Task = ipTask.Text.Trim();
                dto.DamagedCost = Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP);
                dto.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP) + dto.DamagedCost;
                if (cbHouse.SelectedIndex > 0)
                    dto.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
                else dto.WarehouseID = 0;
                if (cbProvider.SelectedIndex > 0)
                    dto.DebtID = (cbProvider.SelectedItem as DebtDTO).DebtID;
                else dto.DebtID = 0;
                double totalEst = _estimateDetailBUS.getTotal(dto.ConstructionID,EstimateDetailDTO.TYPE_MACHINE);
                if (dto.ConstructionID>0 && dto.Totalcost > totalEst)
                {
                    if (KryptonMessageBox.Show("Tổng chi phí máy cơ đã vượt dự toán máy cơ, dự toán máy hiện tại là :" +
                        totalEst + " bạn có muốn tiếp tục lưu",
                        Constants.CONFIRM, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
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
                        foreach (VehicleDairyCostDTO item in _costs)
                        {
                            item.VehicleID = dto.VehicleID;
                            item.VehicleDairyID = ID;
                            item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                            item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP);
                            _vehicleDairyBUS.CreateVehicleDairyCost(item);
                        }
                        this.Close();
                    }


                }
                else
                {
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
                    foreach (VehicleDairyCostDTO item in _costs)
                    {
                        item.VehicleID = dto.VehicleID;
                        item.VehicleDairyID = ID;
                        item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                        item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP);
                        _vehicleDairyBUS.CreateVehicleDairyCost(item);
                    }
                    this.Close();
                }
               

            }
            else
            {
                if (!validateForm()) return;
                _vehicleDairyDTO.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                _vehicleDairyDTO.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                _vehicleDairyDTO.Date = dtDay.Value.Date;
                _vehicleDairyDTO.isPaid = cbPaid.Checked;
                _vehicleDairyDTO.Taker = ipTaker.Text;
                _vehicleDairyDTO.Totalcost = _vehicleDairyDTO.FualCost + _vehicleDairyDTO.DamagedCost;
                 if (cbCons.SelectedIndex > -1)
                _vehicleDairyDTO.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;                
                _vehicleDairyDTO.Task = ipTask.Text.Trim();
                _vehicleDairyDTO.DamagedCost = Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP);
                _vehicleDairyDTO.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP) + _vehicleDairyDTO.DamagedCost;
                if (cbHouse.SelectedIndex > 0)
                    _vehicleDairyDTO.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
                else _vehicleDairyDTO.WarehouseID = 0;
                if (cbProvider.SelectedIndex > 0)
                    _vehicleDairyDTO.DebtID = (cbProvider.SelectedItem as DebtDTO).DebtID;
                else _vehicleDairyDTO.DebtID = 0;
                double totalEst = _estimateDetailBUS.getTotal(_vehicleDairyDTO.ConstructionID, EstimateDetailDTO.TYPE_MACHINE);
                if (_vehicleDairyDTO.ConstructionID > 0 && _vehicleDairyDTO.Totalcost > totalEst)
                {
                    if (KryptonMessageBox.Show("Tổng chi phí máy cơ đã vượt dự toán máy cơ, dự toán máy hiện tại là :" +
                        totalEst + " bạn có muốn tiếp tục lưu",
                        Constants.CONFIRM, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _vehicleDairyBUS.UpdateVehicleDairy(_vehicleDairyDTO);
                        _vehicleDairyBUS.deleteVehicleDairyCost(_ID);
                        foreach (VehicleDairyCostDTO item in _costs)
                        {
                            item.VehicleID = _vehicleDairyDTO.VehicleID;
                            item.VehicleDairyID = _ID;
                            item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                            item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP);
                            _vehicleDairyBUS.CreateVehicleDairyCost(item);
                        }
                        this.Close();
                    }
                }
                else
                {
                    _vehicleDairyBUS.UpdateVehicleDairy(_vehicleDairyDTO);
                    _vehicleDairyBUS.deleteVehicleDairyCost(_ID);
                    foreach (VehicleDairyCostDTO item in _costs)
                    {
                        item.VehicleID = _vehicleDairyDTO.VehicleID;
                        item.VehicleDairyID = _ID;
                        item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                        item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP);
                        _vehicleDairyBUS.CreateVehicleDairyCost(item);
                    }
                    this.Close();
                }
            }
           
        }

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
     
        private bool validateCost()
        {

            if (cbTypeCost.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn loại chi phí", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void dgvCost_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvCost.Rows.Count == 0) return;
            if (e.ColumnIndex == 1)
            {
                if (!Global.ValidateDoubleNumber(e.FormattedValue.ToString()))
                {
                    KryptonMessageBox.Show("Nhập sai thông tin số lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void ipPrice_MouseLeave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, Global.SEP), Global.SEP);
        }

        private void ipPrice_Leave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, Global.SEP), Global.SEP);
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

        private void btDeleteCost_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCost.SelectedRows)
            {
                _costs.Remove(row.DataBoundItem as VehicleDairyCostDTO);

            }
            reloadCosts();
        }
        private void ipQuantity_Leave(object sender, EventArgs e)
        {
            ipQuantity.Text = Global.ConvertDoubleToMoney(Global.ConvertMoneyToDouble(ipQuantity.Text, Global.SEP), Global.SEP);
        }

        private void ipQuantity_MouseLeave(object sender, EventArgs e)
        {
            ipQuantity.Text = Global.ConvertDoubleToMoney(Global.ConvertMoneyToDouble(ipQuantity.Text, Global.SEP), Global.SEP);
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
    }
}