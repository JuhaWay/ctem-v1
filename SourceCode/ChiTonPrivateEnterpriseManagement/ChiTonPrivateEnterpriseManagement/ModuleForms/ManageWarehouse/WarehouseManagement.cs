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

        public WarehouseManagement(string type)
        {
            _type = type;
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvLeftBot);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            LoadData(_type);
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvLeftBot);
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
            
            dgvLeftBot.DataSource = ListWarehouse;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            NewWarehouse newWarehouseForm = new NewWarehouse();
            newWarehouseForm.ShowDialog();
        }
    }
}