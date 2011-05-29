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
        long rightID;
        RightBUS rightBUS = new RightBUS();
        bool isNew = false;
        bool isEdit = false;

        public NewRight(EmployerDTO _employer, List<RightDTO> _listRights)
        {
            isNew = true;
            employer = _employer;
            listRights = _listRights;
            InitializeComponent();
        }

        public NewRight(EmployerDTO _employer, long _rightID, List<RightDTO> _listRights)
        {
            isEdit = true;
            employer = _employer;
            rightID = _rightID;
            listRights = _listRights;
            InitializeComponent();
            setInitValue();
        }

        private void setInitValue()
        {
            foreach (var right in listRights)
            {
                if (right.RightID == rightID)
                {
                    txtRightName.Text = right.RightName;
                    txtDescription.Text = right.Description;
                    ckbisActive.Checked = right.isActive;
                    return;
                }
            }
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                string rightName = txtRightName.Text;
                string description = txtDescription.Text;
                bool isActive = ckbisActive.Checked;
                rightBUS.AddRight(rightName, isActive, description, listRights);
            }
            if (isEdit)
            {
                string rightName = txtRightName.Text;
                string description = txtDescription.Text;
                bool isActive = ckbisActive.Checked;
                rightBUS.EditRight(rightID, rightName, isActive, description, employer, listRights);
            }
            this.Close();
        }
    }
}