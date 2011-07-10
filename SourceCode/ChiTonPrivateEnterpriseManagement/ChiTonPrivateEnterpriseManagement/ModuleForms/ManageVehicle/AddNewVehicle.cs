using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageVehicle
{
    public partial class AddNewVehicle : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private WarehouseBUS _warehouseBUS = new WarehouseBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();

        public AddNewVehicle()
        {
            InitializeComponent();
        }
        public void loadData(){
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbCons.ValueMember="ConstructionID";
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbManager.ValueMember = "employeeID";
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            VehicleDTO dto = new VehicleDTO();
            dto.Name = ipName.Text;
            dto.Number = ipNumber.Text;
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            dto.WarehouseID = 1;
            dto.Status = cbStatus.Text;
            _vehicleBUS.CreateVehicle(dto);
            MessageBox.Show(" tạo thành công !");
            this.Close();
        }

        private void AddNewVehicle_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}