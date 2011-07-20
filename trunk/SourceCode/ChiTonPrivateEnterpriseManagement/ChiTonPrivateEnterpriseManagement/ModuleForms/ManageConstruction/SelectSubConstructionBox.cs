using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class SelectSubConstructionBox : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        public SubcontractorDTO subcontractorDTO;
        public SelectSubConstructionBox()
        {
            CenterToParent();
            InitializeComponent();
        }
        public SelectSubConstructionBox(List<SubcontractorDTO> _list)
        {
            
        }

        private void SelectSubConstructionBox_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(newSubContainer);
            Global.SetLayoutPanelNewForm(kryptonPanel);
            Global.SetLayoutButton(addButton);
            Global.TextBoxRequireInput(subNameInput);
        }

        private void okeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                long id = _subcontractorBUS.CreateSubcontractor(subNameInput.Text, addressInPut.Text, phoneInPut.Text);
                subcontractorDTO = _subcontractorBUS.LoadSubcontractorById(id);
                this.Close();
            }
            else
            {
                string error = Constants.EMPTY_TEXT;
                foreach (string err in Global.ListError)
                {
                    error += " * " + err + '\n';
                }
                KryptonMessageBox.Show(error, Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validate()
        {
            if (Global.ValidateNotEmptyText(subNameInput))
            {
                return true;
            }
            return false;
        }

        private void phoneInPut_Leave(object sender, EventArgs e)
        {
            if (Global.ValidatePhoneNumber(phoneInPut) && Global.ValidateNotEmptyText(phoneInPut))
            {
                phoneInPut.Text = Global.FomatPhoneNumber(phoneInPut.Text);
            }
            else
            {
                KryptonMessageBox.Show("Số Điện Thoại Không Đúng", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                phoneInPut.Focus();
            }
        }
    }
}