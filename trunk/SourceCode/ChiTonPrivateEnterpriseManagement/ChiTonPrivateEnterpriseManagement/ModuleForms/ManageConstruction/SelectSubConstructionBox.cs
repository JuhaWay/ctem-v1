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
        }

        private void okeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {         
                long id = _subcontractorBUS.CreateSubcontractor(subNameInput.Text, addressInPut.Text, phoneInPut.Text);
                subcontractorDTO = _subcontractorBUS.LoadSubcontractorById(id);
                this.Close();
          
        }
    }
}