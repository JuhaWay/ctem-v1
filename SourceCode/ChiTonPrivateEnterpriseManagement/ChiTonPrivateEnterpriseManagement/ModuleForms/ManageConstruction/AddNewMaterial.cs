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
    public partial class AddNewMaterial : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private MaterialBUS _materialBUS = new MaterialBUS(); 

    
        public AddNewMaterial()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MaterialDTO dto = new MaterialDTO();
            dto.MaterialName = ipName.Text;
            dto.MaterialParentID = 0;
            dto.EstimateCalUnit = ipEU.Text;
            dto.RealCalUnit = ipRU.Text;
            dto.Ratio = float.Parse(ipRatio.Text);

            _materialBUS.CreateMaterials(dto);
            MessageBox.Show("Tạo thành công");
            this.Close();
        }

        private void ipRU_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipRatio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRatio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {

        }

        private void lbRU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ipEU_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbParent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ipName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbName_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}