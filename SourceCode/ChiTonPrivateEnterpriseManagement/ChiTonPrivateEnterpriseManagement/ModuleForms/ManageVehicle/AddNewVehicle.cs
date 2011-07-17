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
using ChiTonPrivateEnterpriseManagement.Classes.Global;

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
            CenterToParent();
        }
        public void loadData(){
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbCons.ValueMember="ConstructionID";
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbManager.ValueMember = "employeeID";
            cbHouse.Items.AddRange(_warehouseBUS.LoadWarehouses("", "", -1).ToArray());
            cbHouse.DisplayMember = "WarehouseName";
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            VehicleDTO dto = new VehicleDTO();
            dto.Name = ipName.Text;
            dto.Number = ipNumber.Text;
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            dto.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
            dto.Status = cbStatus.Text;
            _vehicleBUS.CreateVehicle(dto);
            MessageBox.Show(" tạo thành công !");
            this.Close();
        }
        private bool validate()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (ipNumber.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền biển số", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbCons.SelectedIndex<0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn công trình", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbManager.SelectedIndex<0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn quản lí", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbHouse.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn kho", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void AddNewVehicle_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
            loadData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}