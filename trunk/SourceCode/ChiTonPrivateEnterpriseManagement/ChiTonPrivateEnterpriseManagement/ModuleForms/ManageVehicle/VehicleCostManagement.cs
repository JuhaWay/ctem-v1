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
    public partial class VehicleCostManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private VehicleDairyBUS _vehicleDairyBUS = new VehicleDairyBUS();
        private List<VehicleDairyCostDTO> _costs = new List<VehicleDairyCostDTO>();
        private long _vehicleID = 0;
        public VehicleCostManagement(long vehicleID)
        {
            InitializeComponent();
            _vehicleID = vehicleID;
        }

        private void VehicleCostManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            CenterToScreen();
            dtFromDate.Value = new DateTime(dtToDate.Value.Year-1,dtToDate.Value.Month,dtToDate.Value.Day);
            cbTypeCost.Items.AddRange(VehicleDairyCostDTO.getTypeCost().ToArray());
            search();
        }


        private void SetLayout()
        {
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvCost);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            this.WindowState = FormWindowState.Normal;
        }



        public void search()
        {
            VehicleDairyCostDTO search = new VehicleDairyCostDTO();
            search.VehicleID = _vehicleID;
            search.FromDate = dtFromDate.Value.Date;
            search.ToDate = dtToDate.Value.Date;
            search.Type = cbTypeCost.Text.Trim(); ;
            _costs = _vehicleDairyBUS.searchVehicleDairyCost(search);
            reloadCosts();

        }
        public void reloadCosts()
        {
            dgvCost.DataSource = _costs;
            double total = 0;
            foreach (VehicleDairyCostDTO item in _costs)
            {
                total += item.TotalCost;
            }
            ipSumCost.Text = Global.ConvertDoubleToMoney(total, Global.SEP);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void cbTypeCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}