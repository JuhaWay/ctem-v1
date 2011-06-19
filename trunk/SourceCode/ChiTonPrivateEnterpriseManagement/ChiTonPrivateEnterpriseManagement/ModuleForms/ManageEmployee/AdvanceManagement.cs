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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class AdvanceManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<EmployeeAdvanceDTO> _listAdvance;
        readonly EmployeeBUS _employeeBus = new EmployeeBUS();
        private CheckBox _ckBox;
        public AdvanceManagement()
        {
            InitializeComponent();
        }

        private void AdvanceManagement_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvLeftBot);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);            
            LoadData();
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvLeftBot);
        }

        private void LoadData()
        {
            _listAdvance = _employeeBus.LoadAllAdvance();
            dgvLeftBot.DataSource = _listAdvance;
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            NewAdvance newAdvance = new NewAdvance();            
            newAdvance.ShowDialog();
        }
    }
}