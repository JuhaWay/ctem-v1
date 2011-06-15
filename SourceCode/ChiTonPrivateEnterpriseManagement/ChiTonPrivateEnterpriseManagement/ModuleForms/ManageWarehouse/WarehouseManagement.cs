using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class WarehouseManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<WarehouseDTO> ListWarehouse;
        private WarehouseBUS FinalWarehouse = new WarehouseBUS();

        public WarehouseManagement()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListWarehouse = FinalWarehouse.LoadAllWarehouses();
            dgvLeftBot.DataSource = ListWarehouse;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            //NewWarehouse newWarehouseForm = new NewWarehouse();
            //newWarehouseForm.ShowDialog();
        }
    }
}