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
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        public AddnewVehicleDairy()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void AddnewVehicleDairy_Load(object sender, EventArgs e)
        {
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbDriver.DisplayMember = "Username";
            cbVehicle.Items.AddRange(_vehicleBUS.LoadAllVehicles().ToArray());
            cbVehicle.DisplayMember = "Name";
            Global.SetLayoutPanelNewForm(pnMain);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            VehicleDairyDTO dto = new VehicleDairyDTO();
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
            dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
            dto.RoadMap = ipMaproad.Text;
            dto.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
            dto.DamagedCost = Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP);
            dto.Date = dtDay.Value.Date;
            dto.isPaid = false;
            _vehicleDairyBUS.CreateVehicleDairy(dto);
            MessageBox.Show("Tạo thành công!");
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