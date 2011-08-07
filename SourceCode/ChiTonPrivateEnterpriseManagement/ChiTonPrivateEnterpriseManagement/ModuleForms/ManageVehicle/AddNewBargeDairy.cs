using System;
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
    public partial class AddNewBargeDairy : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private List<RoadMapDTO> list = new List<RoadMapDTO>();
        private RoadMapDTO dtoTemp = new RoadMapDTO();
        private VehicleDairyDTO _vehicleDairyDTO = new VehicleDairyDTO();
        private List<VehicleDairyCostDTO> _costs = new List<VehicleDairyCostDTO>();
        private long _ID = 0;
        public AddNewBargeDairy()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public AddNewBargeDairy(long ID)
        {
            InitializeComponent();
            CenterToScreen();
            _ID = ID;
        }
        
        private void AddNewBargeDairy_Load(object sender, EventArgs e)
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
            dto.Category = VehicleDTO.CATEGORY_BARGE;
            cbVehicle.Items.AddRange(_vehicleBUS.searchVehicle(dto).ToArray());
            cbVehicle.DisplayMember = "Number";
            cbTypeCost.Items.AddRange(VehicleDairyCostDTO.getTypeCost().ToArray());

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
            ipFualCost.Text = _vehicleDairyDTO.FualCostFormated;
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

        private void ipFualCost_Leave(object sender, EventArgs e)
        {
            ipFualCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP), Global.SEP);
        }

        private void ipFualCost_MouseLeave(object sender, EventArgs e)
        {
            ipFualCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP), Global.SEP);
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
        public void reloadCosts()
        {
            
            if (_costs != null && _costs.Count > 0)
            {
                dgvCost.DataSource = null;
                dgvCost.DataSource = _costs;
            }
            double total = 0;
            foreach (VehicleDairyCostDTO item in _costs)
            {
                total += item.TotalCost;
            }
            ipSumCost.Text = Global.ConvertDoubleToMoney(total, Global.SEP);
        }


        // lưu thông tin
        private void btSave_Click(object sender, EventArgs e)
        {
            if (_ID == 0)
            {
                if (!validateForm()) return;
                VehicleDairyDTO dto = new VehicleDairyDTO();
                dto.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                dto.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
                dto.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP);
                dto.Date = dtDay.Value.Date;
                dto.isPaid = cbPaid.Checked;
                dto.Taker = ipTaker.Text;
                dto.Task = ipTask.Text;
                dto.Totalcost = dto.FualCost + dto.DamagedCost;
                long ID = _vehicleDairyBUS.CreateVehicleDairy(dto);
                foreach (VehicleDairyCostDTO item in _costs)
                {
                    item.VehicleID = dto.VehicleID;
                    item.VehicleDairyID = ID;
                    item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                    item.Price = (long)Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP); 
                    _vehicleDairyBUS.CreateVehicleDairyCost(item);
                }

            }
            else
            {
                if (!validateForm()) return;
                _vehicleDairyDTO.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                _vehicleDairyDTO.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                _vehicleDairyDTO.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
                _vehicleDairyDTO.Date = dtDay.Value.Date;
                _vehicleDairyDTO.isPaid = cbPaid.Checked;
                _vehicleDairyDTO.Task = ipTask.Text;
                _vehicleDairyDTO.Taker = ipTaker.Text;
                _vehicleDairyDTO.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP);
                _vehicleDairyBUS.UpdateVehicleDairy(_vehicleDairyDTO);
                _vehicleDairyBUS.deleteVehicleDairyCost(_ID);
                foreach (VehicleDairyCostDTO item in _costs)
                {
                    item.VehicleID = _vehicleDairyDTO.VehicleID;
                    item.VehicleDairyID = _ID;
                    item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                    item.Price = (long)Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP); 
                    _vehicleDairyBUS.CreateVehicleDairyCost(item);
                }
            }
            this.Close();
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}