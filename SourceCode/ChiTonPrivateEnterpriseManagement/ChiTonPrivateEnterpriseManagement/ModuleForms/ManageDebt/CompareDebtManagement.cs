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
    public partial class CompareDebtManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<CompareDebtDTO> _listCompareDebt;
        DebtBUS _debtBus = new DebtBUS();
        public CompareDebtManagement()
        {
            InitializeComponent();
        }

        private void CompareDebtManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            _listCompareDebt = _debtBus.GetAllCompareDebt();
            dgvLeftBot.DataSource = _listCompareDebt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewCompareDebt compareDebt = new NewCompareDebt();
            compareDebt.ShowDialog();

        }
        
    }
}