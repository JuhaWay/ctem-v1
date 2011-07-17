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
    public partial class VehicleDairyManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private VehicleBUS _vehicleBUS = new VehicleBUS();
        private VehicleDairyDTO dtoTemp = new VehicleDairyDTO();
        public VehicleDairyManagement()
        {
            InitializeComponent();
        }

        private void VehicleDairyManagement_Load(object sender, EventArgs e)
        {
            VehicleDairyDTO seachDto = new VehicleDairyDTO();
            seachDto.ConstructionID = 0;
            seachDto.VehicleID = 0;
            seachDto.DriverID = 0;
            dtFromdate.Value = new DateTime(dtTodate.Value.Year, dtTodate.Value.Month, dtTodate.Value.Day - 3);

            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";

            cbSearchDriver.Items.Add(new EmployerDTO("Tất cả", 0));
            cbSearchDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbSearchDriver.DisplayMember = "Username";
            cbSearchVehicle.Items.Add(new VehicleDTO("Tất cả", 0));
            cbSearchVehicle.Items.AddRange(_vehicleBUS.LoadAllVehicles().ToArray());
            cbSearchVehicle.DisplayMember = "Name";



            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            cbDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbDriver.DisplayMember = "Username";
            cbVehicle.Items.AddRange(_vehicleBUS.LoadAllVehicles().ToArray());
            cbVehicle.DisplayMember = "Name";

            SetLayout();
            initData();

        }


        private void SetLayout()
        {
            dgvVehicleDairy.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvVehicleDairy);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            VehicleDairyDTO seachDto = new VehicleDairyDTO();
            if (cbSearchCons.SelectedIndex>-1)
            seachDto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            if (cbSearchVehicle.SelectedIndex > -1)
            seachDto.VehicleID = (cbSearchVehicle.SelectedItem as VehicleDTO).VehicleID; ;
            if (cbSearchDriver.SelectedIndex > -1)
            seachDto.DriverID = (cbSearchDriver.SelectedItem as EmployerDTO).employeeID; ;
            seachDto.FromDate = dtFromdate.Value;
            seachDto.ToDate = dtTodate.Value;
            List<VehicleDairyDTO> list = _vehicleDairyBUS.searchVehicleDairy(seachDto);
            dgvVehicleDairy.DataSource = list;
            calculateTotal(list);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddnewVehicleDairy form = new AddnewVehicleDairy();
            form.ShowDialog();
            initData();
        }
        public void calculateTotal(List<VehicleDairyDTO>dtos){
            long countFual=0;
            long countDamaged=0;
            foreach(VehicleDairyDTO dto in dtos){
                countFual += dto.FualCost;
                countDamaged += dto.DamagedCost;
              }
            ipTotalFualCost.Text = Global.ConvertLongToMoney(countFual, Global.SEP);
            ipTotalDamagedCost.Text = Global.ConvertLongToMoney(countDamaged, Global.SEP);

        }
        public void initData()
        {
            VehicleDairyDTO seachDto = new VehicleDairyDTO();
            seachDto.FromDate = dtFromdate.Value;
            seachDto.ToDate = dtTodate.Value;
            List<VehicleDairyDTO> list = _vehicleDairyBUS.searchVehicleDairy(seachDto);
            dgvVehicleDairy.DataSource = list;
            calculateTotal(list);
            loadDetailValues(0);
        }
        private void dgvVehicleDairy_MouseClick(object sender, MouseEventArgs e)
        {

            int currentMouseOverRow = dgvVehicleDairy.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvVehicleDairy.Rows.Count == 0)
            {

                return;
            }
            dtoTemp = dgvVehicleDairy.Rows[currentMouseOverRow].DataBoundItem as VehicleDairyDTO;
            foreach (ConstructionDTO item in cbCons.Items)
            {
                if (dtoTemp.ConstructionID.Equals(item.ConstructionID))
                    cbCons.SelectedItem = item;
            }
            foreach (EmployerDTO item in cbDriver.Items)
            {
                if (dtoTemp.DriverID.Equals(item.employeeID))
                    cbDriver.SelectedItem = item;
            }
            foreach (VehicleDTO item in cbVehicle.Items)
            {
                if (dtoTemp.VehicleID.Equals(item.VehicleID))
                    cbVehicle.SelectedItem = item;
            }
            ipFualCost.Text = Global.ConvertLongToMoney(dtoTemp.FualCost, Global.SEP);
            ipDamagedCost.Text = Global.ConvertLongToMoney(dtoTemp.DamagedCost, Global.SEP);
            ipMaproad.Text = dtoTemp.RoadMap;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            dtoTemp.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dtoTemp.DriverID = (cbDriver.SelectedItem as EmployerDTO).employeeID;
            dtoTemp.VehicleID = (cbVehicle.SelectedItem as VehicleDTO).VehicleID;
            dtoTemp.RoadMap = ipMaproad.Text;
            dtoTemp.FualCost = Global.ConvertMoneyToLong(ipFualCost.Text, Global.SEP);
            dtoTemp.DamagedCost = Global.ConvertMoneyToLong(ipDamagedCost.Text, Global.SEP);
            dtoTemp.Date = dtDay.Value.Date;
            dtoTemp.isPaid = false;
            _vehicleDairyBUS.UpdateVehicleDairy(dtoTemp);
            MessageBox.Show("Cập nhật  thành công!");
            initData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa Nhật ký  ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvVehicleDairy.SelectedRows)
                {
                    long id = (row.DataBoundItem as VehicleDairyDTO).VehicleDairyID;
                        _vehicleDairyBUS.delete(id);
                   
                }
               initData();
            }
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

    }
}