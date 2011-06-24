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
    public partial class NewWarehouse : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<ConstructionDTO> ListConstruction;
        ConstructionBus constructionBUS = new ConstructionBus();
        WarehouseBUS warehouseBUS = new WarehouseBUS();

        public NewWarehouse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string warehousename = txtWarehouseName.Text;
            string type = cbbType.Text;
            string namemanager = txtNameManager.Text;
            string address = txtAddress.Text;
            string description = txtDescription.Text;
            long constructionID = 0;
            int isactive;            
            if (cbbStatus.Text.Equals(Constants.ACTIVE))
            {
                isactive = 1;
            }
            else
            {
                isactive = 0;
            }
            WarehouseDTO warehouse = new WarehouseDTO()
                                         {
                                             WarehouseName = warehousename,
                                             Type = type,
                                             ManagerName = namemanager,
                                             Address = address,
                                             Description = description,
                                             IsActive = isactive
                                         };
            if (cbbConstruction.Enabled)
            {
                ConstructionDTO construcion = (ConstructionDTO)cbbConstruction.SelectedItem;
                warehouse.ConstructionID = construcion.ConstructionID;
            }
            warehouseBUS.CreateWarehouse(warehouse);
        }

        private void NewWarehouse_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void setData()
        {
            cbbType.Items.Add(Constants.CONSTRUCTION_WAREHOUSE);
            cbbType.Items.Add(Constants.MAIN_WAREHOUSE);
            if (cbbType.Items.Count != 0)
            {
                cbbType.SelectedIndex = 0;                
            }

            ListConstruction = constructionBUS.LoadAllConstructions();
            cbbConstruction.DataSource = ListConstruction;
            cbbConstruction.ValueMember = Constants.CONSTRUCTION_VALUEMEMBER;
            cbbConstruction.DisplayMember = Constants.CONSTRUCTION_DISPLAYMEMBER;
            if (cbbConstruction.Items.Count != 0)
            {
                cbbConstruction.SelectedIndex = 0;                
            }

            cbbStatus.Items.Add(Constants.ACTIVE);
            cbbStatus.Items.Add(Constants.INACTIVE);
            if (cbbStatus.Items.Count != 0)
            {
                cbbStatus.SelectedIndex = 0;
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.Text.Equals(Constants.CONSTRUCTION_WAREHOUSE))
            {
                cbbConstruction.Enabled = true;
            }
            else
            {
                cbbConstruction.Enabled = false;
            }
        }
    }
}