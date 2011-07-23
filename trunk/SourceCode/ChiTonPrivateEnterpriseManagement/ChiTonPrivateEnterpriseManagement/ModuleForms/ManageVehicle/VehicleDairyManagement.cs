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
            dtFromdate.Value = new DateTime(dtTodate.Value.Year, dtTodate.Value.Month-3, dtTodate.Value.Day);

            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";

            cbSearchDriver.Items.Add(new EmployerDTO("Tất cả", 0));
            cbSearchDriver.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbSearchDriver.DisplayMember = "Username";
            cbSearchVehicle.Items.Add(new VehicleDTO("Tất cả", 0));
            cbSearchVehicle.Items.AddRange(_vehicleBUS.LoadAllVehicles().ToArray());
            cbSearchVehicle.DisplayMember = "Number";

            cbSearchCategory.Items.AddRange(VehicleDTO.getCategory().ToArray());

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
            seachDto.Category = cbSearchCategory.Text;
            List<VehicleDairyDTO> list = _vehicleDairyBUS.searchVehicleDairy(seachDto);
            dgvVehicleDairy.DataSource = list;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddnewVehicleDairy form = new AddnewVehicleDairy();
            form.ShowDialog();
            initData();
        }
       
        public void initData()
        {
            VehicleDairyDTO seachDto = new VehicleDairyDTO();
            seachDto.FromDate = dtFromdate.Value;
            seachDto.ToDate = dtTodate.Value;
            seachDto.Category = cbSearchCategory.Text;
            List<VehicleDairyDTO> list = _vehicleDairyBUS.searchVehicleDairy(seachDto);
            dgvVehicleDairy.DataSource = list;
        }
        private void dgvVehicleDairy_MouseClick(object sender, MouseEventArgs e)
        {

           

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

        private void btEdit_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvVehicleDairy.SelectedRows)
            {
                VehicleDairyDTO item = (row.DataBoundItem as VehicleDairyDTO);
                if (item.Category.Equals(VehicleDTO.CATEGORY_VEHICLE))
                {
                    AddnewVehicleDairy form = new AddnewVehicleDairy(item.VehicleDairyID);
                    form.ShowDialog();
                }
                else if (item.Category.Equals(VehicleDTO.CATEGORY_MACHINE))
                {
                    AddNewMachineDairy form = new AddNewMachineDairy(item.VehicleDairyID);
                    form.ShowDialog();
                }
                else
                {
                    AddNewBargeDairy form = new AddNewBargeDairy(item.VehicleDairyID);
                    form.ShowDialog();
                }
            }
            initData();
        }

        private void addMachineDairy_Click(object sender, EventArgs e)
        {
            AddNewMachineDairy form = new AddNewMachineDairy();
            form.ShowDialog();
            initData();
        }

        private void addBarge_Click(object sender, EventArgs e)
        {
            AddNewBargeDairy form = new AddNewBargeDairy();
            form.ShowDialog();
            initData();
        }
        

    }
}