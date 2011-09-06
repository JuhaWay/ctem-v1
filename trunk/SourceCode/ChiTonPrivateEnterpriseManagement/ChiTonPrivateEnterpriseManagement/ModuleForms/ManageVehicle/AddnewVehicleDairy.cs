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
    public partial class AddnewVehicleDairy : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private WarehouseBUS _warehouseBUS = new WarehouseBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private MaterialBUS _materialBUS = new MaterialBUS();
        private DebtBUS _debtBUS = new DebtBUS();
        private readonly WarehouseBUS _warehouseBus = new WarehouseBUS();
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


           



            cbMaterial.Items.Add(new MaterialDTO("", 0));
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbMaterial.DisplayMember = "MaterialName";


            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox3);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);
            Global.SetDaulftDatagridview(dgvRoadMap);
            dgvRoadMap.ReadOnly = false;
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutPanelNewForm(pn1);
            Global.SetLayoutPanelNewForm(kryptonPanel1);


            Global.SetDaulftDatagridview(dgvCost);
            dgvCost.ReadOnly = false;
            Global.SetLayoutHeaderGroup(hdCost, Constants.CHILD_FORM);
            Global.SetLayoutGroupBoxButton(gbCost);

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
            entity.Name = "";
            if(cbMaterial.SelectedIndex>0){
                entity.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                entity.MaterialName = (cbMaterial.SelectedItem as MaterialDTO).MaterialName;
            }
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
                dto.DriverName = (cbDriver.SelectedItem as EmployerDTO).Username;
                dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                dto.Date = dtDay.Value.Date;
                dto.isPaid = cbPaid.Checked;
                dto.Task = "";
                dto.Taker = ipTaker.Text;
                dto.DamagedCost = Global.ConvertMoneyToLong(ipOtherCost.Text, Global.SEP);
                dto.Totalcost = (long)Global.ConvertMoneyToDouble(ipSumCost.Text, Global.SEP) + dto.DamagedCost;
               
                long ID = _vehicleDairyBUS.CreateVehicleDairy(dto);
                foreach (RoadMapDTO item in list)
                {
                    item.VehicleDairyID = ID;
                    _vehicleDairyBUS.CreateRoadMap(item);
                }
                 foreach(VehicleDairyCostDTO item in _costs)
                 {

                     item.VehicleID = dto.VehicleID;
                     item.VehicleDairyID = ID;
                     item.TotalCost = (long)Global.ConvertMoneyToDouble(item.TotalCostFormated, Global.SEP);
                     item.Price = Global.ConvertMoneyToDouble(item.PriceFormated, Global.SEP);
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
            if(e.ColumnIndex==2){
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
            if (e.ColumnIndex == 2 || e.ColumnIndex == 4)
            {
                double total = 0;
                string sprice = dgvCost.Rows[e.RowIndex].Cells[4].Value.ToString();
                double price = Global.ConvertMoneyToDouble(sprice, Global.SEP);
                double quantity = (double)dgvCost.Rows[e.RowIndex].Cells[2].Value;
                total = price * quantity;
                dgvCost.Rows[e.RowIndex].Cells[5].Value = total;


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

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaterial.SelectedIndex > 0)
                ipUnit.Text = (cbMaterial.SelectedItem as MaterialDTO).RealCalUnit;
        }

        private void dgvCost_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 3 || e.ColumnIndex == 5)
                e.Cancel = true;
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonSplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
} 