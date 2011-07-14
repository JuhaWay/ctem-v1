using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class WarehouseManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<WarehouseDTO> ListWarehouse;
        private WarehouseBUS _warehouseBus = new WarehouseBUS();
        private CheckBox _ckBox;
        private string _type;

        public WarehouseManagement()
        {
            _type = Constants.MAIN_WAREHOUSE;
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvWH);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            SetLayout();
            LoadData(_type);
        }

        private void SetLayout()
        {
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdWH, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvWH);
            Global.SetLayoutSplipContainer(slcMain, 2);
        } 

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvWH);
        }

        private void LoadData(string type)
        {
            if (type.Equals(Constants.MAIN_WAREHOUSE))
            {
                ListWarehouse = _warehouseBus.LoadWarehouses(Constants.MAIN_WAREHOUSE);
            }
            else
            {
                ListWarehouse = _warehouseBus.LoadWarehouses(Constants.CONSTRUCTION_WAREHOUSE);
            }
            
            dgvWH.DataSource = ListWarehouse;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            NewWarehouse newWarehouseForm = new NewWarehouse();
            newWarehouseForm.ShowDialog();
        }
    }
}