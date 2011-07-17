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
    public partial class VehicleManageMent : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private WarehouseBUS _warehouseBUS = new WarehouseBUS();
        private VehicleDTO dtoTemp = new VehicleDTO();
        public VehicleManageMent()
        {
            InitializeComponent();
        }

        private void VehicleManageMent_Load(object sender, EventArgs e)
        {
            dgvVehicle.DataSource = _vehicleBUS.LoadAllVehicles();
            cbSearchCons.Items.Add(new ConstructionDTO("toàn bộ",-1));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";
            cbSearchCons.ValueMember = "ConstructionID";

            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbCons.ValueMember = "ConstructionID";
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbManager.ValueMember = "employeeID";

            cbHouse.Items.AddRange(_warehouseBUS.LoadWarehouses("", "", -1).ToArray());
            cbHouse.DisplayMember = "WarehouseName";
            loadDetailValues(0);
            SetLayout();

        }
        private void SetLayout()
        {
            dgvVehicle.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvVehicle);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            VehicleDTO dto = new VehicleDTO();
            dto.Name = ipSearchName.Text.Trim().Equals("") ? null : ipSearchName.Text;
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.Number = ipSearchNumber.Text.Trim().Equals("") ? null : ipSearchNumber.Text;
            dgvVehicle.DataSource = _vehicleBUS.searchVehicle(dto);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewVehicle form = new AddNewVehicle();
            form.ShowDialog();
            dgvVehicle.DataSource = _vehicleBUS.LoadAllVehicles();

        }

        private void dgvVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvVehicle.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvVehicle.Rows.Count == 0)
            {
                
                return;
            }
            dtoTemp = dgvVehicle.Rows[currentMouseOverRow].DataBoundItem as VehicleDTO;
            ipName.Text = dtoTemp.Name;
            ipNumber.Text = dtoTemp.Number;
            foreach(ConstructionDTO item in cbCons.Items){
                if (dtoTemp.ConstructionID.Equals(item.ConstructionID))
                    cbCons.SelectedItem = item;
            }
            foreach (EmployerDTO item in cbManager.Items)
            {
                if (dtoTemp.ManagerID.Equals(item.employeeID))
                    cbManager.SelectedItem = item;
            }
            foreach (WarehouseDTO item in cbHouse.Items)
            {
                if (dtoTemp.WarehouseID.Equals(item.WarehouseID))
                    cbHouse.SelectedItem = item;
            }
            cbStatus.Text = dtoTemp.Status;
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            dtoTemp.Name = ipName.Text;
            dtoTemp.Number = ipNumber.Text;
            dtoTemp.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dtoTemp.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            dtoTemp.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
            dtoTemp.Status = cbStatus.Text;
            _vehicleBUS.UpdateVehicle(dtoTemp);
            MessageBox.Show(" cập nhật thành công !");
            dgvVehicle.DataSource = _vehicleBUS.LoadAllVehicles();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (KryptonMessageBox.Show("Xóa bảng lương ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvVehicle.SelectedRows)
                {
                    long id = (row.DataBoundItem as VehicleDTO).VehicleID;
                        _vehicleBUS.delete(id);
                }
                dgvVehicle.DataSource = _vehicleBUS.LoadAllVehicles();
            }
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
            if (cbCons.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn công trình", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbManager.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn quản lí", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            if (cbHouse.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn khó", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}