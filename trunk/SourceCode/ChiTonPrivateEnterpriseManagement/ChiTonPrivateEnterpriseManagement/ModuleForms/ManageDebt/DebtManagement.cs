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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class DebtManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<DebtDTO> ListDebt;
        private DebtBUS debtBUS = new DebtBUS();

        public DebtManagement()
        {
            InitializeComponent();
        }

        private void DebtManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListDebt = debtBUS.GetAll();
            dgvLeftBot.DataSource = ListDebt;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {

        }
    }
}