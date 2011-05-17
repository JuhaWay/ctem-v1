using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights
{
    public partial class RightsManagement: KryptonForm
    {
        EmployerDTO employer;
        Global global = new Global();
        RightBUS rightBUS = new RightBUS();
        List<RightDTO> listRights;
        public RightsManagement(EmployerDTO _employer)
        {
            employer = _employer;
            InitializeComponent();
        }

        private void loadRights()
        {
            listRights = rightBUS.LoadAllRight();
            dgvRights.DataSource = listRights;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadRights();
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            loadRights();
        }

        private void btnNewRight_Click(object sender, EventArgs e)
        {
            NewRight newRight = new NewRight(employer, listRights);
            newRight.ShowDialog();
        }


    }
}