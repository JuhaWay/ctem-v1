using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights
{
    public partial class NewRight : KryptonForm
    {
        EmployerDTO employer;
        List<RightDTO> listRights;
        RightBUS rightBUS = new RightBUS();
        bool isNew = false;
        bool isEdit = false;

        public NewRight(EmployerDTO _employer, List<RightDTO> _listRights)
        {
            employer = _employer;
            listRights = _listRights;
            InitializeComponent();
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string rightName = txtRightName.Text;
            string description = txtDescription.Text;
            bool isActive = ckbisActive.Checked;
            rightBUS.AddRight(rightName, isActive, description, employer, listRights);
        }
    }
}