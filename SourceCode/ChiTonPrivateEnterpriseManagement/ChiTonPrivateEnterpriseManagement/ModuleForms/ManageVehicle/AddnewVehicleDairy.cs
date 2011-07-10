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
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            VehicleDairyDTO dto = new VehicleDairyDTO();
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
            dto.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
            dto.RoadMap = ipMaproad.Text;
            dto.FualCost = Convert.ToInt64(ipFualCost.Text);
            dto.DamagedCost = Convert.ToInt64(ipDamagedCost.Text);
            dto.Date = dtDay.Value.Date;
            dto.isPaid = false;
            _vehicleDairyBUS.CreateVehicleDairy(dto);
            MessageBox.Show("Tạo thành công!");
            this.Close();
        }
    }
} 