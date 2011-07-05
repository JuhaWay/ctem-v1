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
                bool test = _subcontractorBUS.CreateSubcontractor(subNameInput.Text, addressInPut.Text, phoneInPut.Text);
                if (test)
                {
                    subcontractorDTO = _subcontractorBUS.LoadSubcontractorByName(subNameInput.Text);
                  
                }

                this.Close();
          
        }
    }
}