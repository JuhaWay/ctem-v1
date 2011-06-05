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
        public SelectSubConstructionBox()
        {
            
        }
        public SelectSubConstructionBox(List<SubcontractorDTO> _list)
        {
            InitializeComponent();
            foreach (SubcontractorDTO dto in _list)
            {
                lbxListSubcontractor.Items.Add(dto);
            }
            
        }

        private void SelectSubConstructionBox_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.conbox.DataSource = _subcontractorBUS.loadAllSubcontractorDTO();
            this.conbox.DisplayMember = "SubcontractorName";
            this.conbox.ValueMember = "SubcontractorID";


            lbxListSubcontractor.DisplayMember = "SubcontractorName";
            lbxListSubcontractor.ValueMember = "SubcontractorID";

            
        }

        private void exsiteSubconRadio_CheckedChanged(object sender, EventArgs e)
        {
                conbox.Enabled = true;
                phoneInPut.Enabled=false;
                subNameInput.Enabled=false;
                addressInPut.Enabled = false;
                newSubContainer.Enabled = false;
                exitSubContainer.Enabled = true;
        }

        private void NewSubConstructionRadio_CheckedChanged(object sender, EventArgs e)
        {
                conbox.Enabled = false;
                phoneInPut.Enabled = true;
                subNameInput.Enabled = true;
                addressInPut.Enabled = true;
                newSubContainer.Enabled = true;
                exitSubContainer.Enabled = false;
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
            if (exsiteSubconRadio.Checked)
            {
               
                SubcontractorDTO item = conbox.SelectedItem as SubcontractorDTO;
                if (item == null)
                {
                    MessageBox.Show("Nhà thầu này chưa tồn tại vui lòng tạo mới :");
                    NewSubConstructionRadio.Checked = true;
                    subNameInput.Text = conbox.Text;
                }
                else 
                    lbxListSubcontractor.Items.Add(item);
               
               
            }
            else
            {
                bool test = _subcontractorBUS.CreateSubcontractor(subNameInput.Text, addressInPut.Text, phoneInPut.Text);
                if (test)
                {
                    SubcontractorDTO item = _subcontractorBUS.LoadSubcontractorByName(subNameInput.Text);
                    lbxListSubcontractor.Items.Add(item);
                   
                }
            }
        }
    }
}