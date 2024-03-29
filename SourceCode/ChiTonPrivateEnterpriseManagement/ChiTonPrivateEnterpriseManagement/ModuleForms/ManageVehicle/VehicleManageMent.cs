﻿using System;
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
            cbSearchCons.Items.Add(new ConstructionDTO("toàn bộ",-1));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";
            cbSearchCons.ValueMember = "ConstructionID";


            cbCons.Items.Add(new ConstructionDTO("",0));
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbCons.ValueMember = "ConstructionID";
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbManager.ValueMember = "employeeID";

            cbHouse.Items.AddRange(_warehouseBUS.LoadWarehouses("", Constants.MAIN_WAREHOUSE, -1).ToArray());
            cbHouse.DisplayMember = "WarehouseName";
            dtDate.ShowCheckBox = true;
            SetLayout();


            cbSearchCategory.Items.AddRange(VehicleDTO.getCategory().ToArray());
            disableEdition();
            loadData();
        }

        private void disableEdition()
        {
            cbCons.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHouse.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public void loadData()
        {
            VehicleDTO dto = new VehicleDTO();
            dto.Name = ipSearchName.Text.Trim();
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.Number = ipSearchNumber.Text.Trim();
            dto.Category = cbSearchCategory.Text.Trim();
            dgvVehicle.DataSource = _vehicleBUS.searchVehicle(dto);           
            loadDetailValues(0);
        }

        private void SetLayout()
        {
            dgvVehicle.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvVehicle);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutSplipContainerInChildForm(kryptonSplitContainer1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(gbxEdit1);            
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewVehicle form = new AddNewVehicle();
            form.ShowDialog();
            loadData();

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

                dtoTemp = null;
                ipName.Text = "";
                ipNumber.Text = "";
                cbCons.SelectedIndex = -1;

                cbManager.SelectedIndex = -1;
                cbHouse.SelectedIndex = -1;
                cbStatus.Text = "";
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
            if (dtoTemp.Date != DateTime.MinValue.Date)
                dtDate.Value = dtoTemp.Date;
            else dtDate.Checked = false;
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (dtoTemp == null) return;
            if (_vehicleBUS.Check(ipNumber.Text.Trim(), dtoTemp.VehicleID) > 0)
            {
                KryptonMessageBox.Show("Trùng lặp biển số", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }
            if (!validate()) return;
            dtoTemp.Name = ipName.Text.Trim();
            dtoTemp.Number = ipNumber.Text.Trim();
            if (cbCons.SelectedIndex >-1)
                     dtoTemp.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dtoTemp.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            if (cbHouse.Enabled)
                dtoTemp.WarehouseID = (cbHouse.SelectedItem as WarehouseDTO).WarehouseID;
            else
                dtoTemp.WarehouseID = 0;
            dtoTemp.Status = cbStatus.Text;
            if (dtDate.Checked)
                dtoTemp.Date = dtDate.Value.Date;
            else
                dtoTemp.Date = DateTime.MinValue.Date;
            _vehicleBUS.UpdateVehicle(dtoTemp);
            KryptonMessageBox.Show("Cập nhật thành công", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            loadData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (KryptonMessageBox.Show("Bạn có muốn xóa phương tiện này không", Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvVehicle.SelectedRows)
                {
                    long id = (row.DataBoundItem as VehicleDTO).VehicleID;
                        _vehicleBUS.delete(id);
                }
                loadData();
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
            if (cbManager.SelectedIndex < 0)
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

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 72, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 72, 2, 4, true);
            }
        }

        private void ipSearchName_TextChanged(object sender, EventArgs e)
        {
                loadData();
        }

        private void ipSearchNumber_TextChanged(object sender, EventArgs e)
        {
                loadData();
        }

        private void cbCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCons.SelectedIndex >0)
                cbHouse.Enabled = false;
            else
                cbHouse.Enabled = true;
        }

        private void btViewCost_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVehicle.SelectedRows)
            {
                long id = (row.DataBoundItem as VehicleDTO).VehicleID;
                VehicleCostManagement form = new VehicleCostManagement(id);
                form.ShowDialog();
            }
        }
    }
}