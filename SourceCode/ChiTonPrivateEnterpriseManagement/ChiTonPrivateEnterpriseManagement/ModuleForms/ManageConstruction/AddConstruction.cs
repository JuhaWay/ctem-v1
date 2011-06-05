using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class AddConstruction : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<SubcontractorDTO> subCons = new List<SubcontractorDTO>();
        private ConstructionBus _constructionBus = new ConstructionBus();

        public AddConstruction()
        {
            InitializeComponent();
        }

        private void rdSubcon_CheckedChanged(object sender, EventArgs e)
        {
            btEditSubcons.Enabled = true;
            pnSubcons.Enabled = true;

        }

        private void btEditSubcons_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            lbSubcons.Text = "";
            foreach(SubcontractorDTO dto in box.lbxListSubcontractor.Items){

                lbSubcons.Text += "," + dto.SubcontractorName;
                subCons.Add(dto);
            }
        }

        private void AddConstruction_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(dtStartDate.Text);
            DateTime endDate = DateTime.Parse(dtEndDate.Text);
            bool test = 
                _constructionBus.CreateConstruction(ipConstructionName.Text,ipDes.Text,ipAddress.Text,
                               startDate, endDate,Convert.ToInt64(ipTotalCost.Text),cbStatus.Text);
            MessageBox.Show("" + test);
        }

        private void rdhasEstimate_CheckedChanged(object sender, EventArgs e)
        {
            btEditSubcons.Enabled = false;
            pnSubcons.Enabled = false;
        }

        private void rdNoEstimate_CheckedChanged(object sender, EventArgs e)
        {
            btEditSubcons.Enabled = false;
            pnSubcons.Enabled = false;
        }
    }
}