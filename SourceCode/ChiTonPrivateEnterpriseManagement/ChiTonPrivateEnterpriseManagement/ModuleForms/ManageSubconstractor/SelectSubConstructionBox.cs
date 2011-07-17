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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageSubconstractor
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
        private void SelectSubConstructionBox_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
            
        }

       

        private void okeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
                if (!validate()) return;
                _subcontractorBUS.CreateSubcontractor(subNameInput.Text, addressInPut.Text, phoneInPut.Text);
                this.Close();
          
        }

        private bool validate()
        {
            if (subNameInput.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("vui lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }
    }
}