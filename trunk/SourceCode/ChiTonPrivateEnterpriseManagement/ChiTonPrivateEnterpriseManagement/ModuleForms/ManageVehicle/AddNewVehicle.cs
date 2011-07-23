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
            cbCons.Items.Add(new ConstructionDTO("",0));
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbCons.ValueMember="ConstructionID";
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbManager.ValueMember = "employeeID";
            cbHouse.Items.AddRange(_warehouseBUS.LoadWarehouses("", Constants.MAIN_WAREHOUSE, -1).ToArray());
            cbHouse.DisplayMember = "WarehouseName";
            cbCategory.Items.AddRange(VehicleDTO.getCategory().ToArray());
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            disableEdition();
        }

        private void disableEdition()
        {
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCons.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHouse.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            if (_vehicleBUS.Check(ipNumber.Text.Trim(), 0) > 0)
            {
                KryptonMessageBox.Show("Trùng lặp  biển số", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            VehicleDTO dto = new VehicleDTO();
            dto.Name = ipName.Text.Trim();
            dto.Number = ipNumber.Text.Trim();
            if (cbCons.SelectedIndex>-1)
                dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            if (cbHouse.Enabled)
                dto.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
            else
                dto.WarehouseID = 0;
            dto.Status = cbStatus.Text;
            dto.Category = cbCategory.Text.Trim();
            dto.Date = dtDate.Value.Date;
            _vehicleBUS.CreateVehicle(dto);
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

            if (cbCategory.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn chức năng", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbManager.SelectedIndex<0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn quản lí", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbHouse.Enabled && cbHouse.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn kho", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbStatus.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn tình trạng", Constants.CONFIRM, MessageBoxButtons.OK,
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

        private void cbCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCons.SelectedIndex >0)
                cbHouse.Enabled = false;
            else
                cbHouse.Enabled = true;
        }
    }
}