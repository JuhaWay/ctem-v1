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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class DebtManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<DebtDTO> ListDebt;
        private DebtBUS debtBUS = new DebtBUS();
        private CheckBox _ckBox;

        public DebtManagement()
        {
            InitializeComponent();
        }

        private void DebtManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SetLayout()
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvLeftBot);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvLeftBot);
        }

        private void LoadData()
        {
            ListDebt = debtBUS.GetAll();
            dgvLeftBot.DataSource = ListDebt;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            NewDebt newDebt = new NewDebt();
            newDebt.Show();
            LoadData();
        }
    }
}