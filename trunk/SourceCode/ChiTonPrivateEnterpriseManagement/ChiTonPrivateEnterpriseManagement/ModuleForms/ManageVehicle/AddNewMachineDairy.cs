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
    public partial class AddNewMachineDairy : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private List<RoadMapDTO> list = new List<RoadMapDTO>();
        private RoadMapDTO dtoTemp = new RoadMapDTO();
        private VehicleDairyDTO _vehicleDairyDTO = new VehicleDairyDTO();
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
            cbDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbDriver.DisplayMember = "Username";
            VehicleDTO dto = new VehicleDTO();
            dto.Name = "";
            dto.Number = "";
            dto.Category = VehicleDTO.CATEGORY_MACHINE;
            cbVehicle.Items.AddRange(_vehicleBUS.searchVehicle(dto).ToArray());
            cbVehicle.DisplayMember = "Number";
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";

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
            ipFualCost.Text = _vehicleDairyDTO.FualCostFormated;
            ipDamagedCost.Text = _vehicleDairyDTO.DamagedCostFormated;
            ipReason.Text = _vehicleDairyDTO.Reason;
            cbPaid.Checked = _vehicleDairyDTO.isPaid;
            ipTotalCost.Text = _vehicleDairyDTO.TotalcostFormated;
            dtDay.Value = _vehicleDairyDTO.Date;
            ipTask.Text = _vehicleDairyDTO.Task;


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (_ID == 0)
            {
                if (!validateForm()) return;
                VehicleDairyDTO dto = new VehicleDairyDTO();
                dto.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                dto.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
                dto.DamagedCost = Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP);
                dto.Date = dtDay.Value.Date;
                dto.isPaid = cbPaid.Checked;
                dto.Reason = ipReason.Text;
                dto.Totalcost = dto.FualCost + dto.DamagedCost;
                dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
                dto.Task = ipTask.Text.Trim();
                long ID = _vehicleDairyBUS.CreateVehicleDairy(dto);
               
            }
            else
            {
                if (!validateForm()) return;
                _vehicleDairyDTO.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
                _vehicleDairyDTO.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
                _vehicleDairyDTO.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
                _vehicleDairyDTO.DamagedCost = Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP);
                _vehicleDairyDTO.Date = dtDay.Value.Date;
                _vehicleDairyDTO.isPaid = cbPaid.Checked;
                _vehicleDairyDTO.Reason = ipReason.Text;
                _vehicleDairyDTO.Totalcost = _vehicleDairyDTO.FualCost + _vehicleDairyDTO.DamagedCost;
                _vehicleDairyDTO.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
                _vehicleDairyDTO.Task = ipTask.Text.Trim();
                _vehicleDairyBUS.UpdateVehicleDairy(_vehicleDairyDTO);
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
            if (cbCons.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn công trình", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ipFualCost_TextChanged(object sender, EventArgs e)
        {
            long f = (Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP));
            long d = (Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP));
            long t = d + f;
            ipTotalCost.Text = Global.ConvertLongToMoney(t, Global.SEP);
        }

        private void ipDamagedCost_TextChanged(object sender, EventArgs e)
        {
            long f = (Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP));
            long d = (Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP));
            long t = d + f;
            ipTotalCost.Text = Global.ConvertLongToMoney(t, Global.SEP);
        }
     

        private void ipDamagedCost_Leave(object sender, EventArgs e)
        {
            ipDamagedCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP), Global.SEP);
        }

        private void ipDamagedCost_MouseLeave(object sender, EventArgs e)
        {
            ipDamagedCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP), Global.SEP);
        }

        private void ipFualCost_Leave(object sender, EventArgs e)
        {
            ipFualCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP), Global.SEP);
        }

        private void ipFualCost_MouseLeave(object sender, EventArgs e)
        {
            ipFualCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP), Global.SEP);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}