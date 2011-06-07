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
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        private long ConstructionID;
        private bool update = false;

        public AddConstruction()
        {
            InitializeComponent();
            loadSubcons();
        }

        private void loadSubcons(){
            subCons= _subcontractorBUS.loadAllSubcontractorDTO();
            cbSubcon.Items.AddRange(subCons.ToArray());
            cbSubcon.DisplayMember = "SubcontractorName";
            cbSubcon.ValueMember = "SubcontractorID";
        }

        public AddConstruction(long constructionId)
        {
            InitializeComponent();
            update = true;
            ConstructionDTO dto = _constructionBus.LoadConstructionById(constructionId);
            ConstructionID = dto.ConstructionID;
            ipConstructionName.Text = dto.ConstructionName;
            ipDes.Text = dto.ConstructionAddress;
            ipAddress.Text = dto.ConstructionAddress;
            cbStatus.SelectedItem = dto.Status;
        }



        private void rdSubcon_CheckedChanged(object sender, EventArgs e)
        {
            pnSubcons.Enabled = true;


        }

        private void btEditSubcons_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            
        }

        private void AddConstruction_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                DateTime startDate = DateTime.Parse(dtStartDate.Text);
                DateTime endDate = DateTime.Parse(dtEndDate.Text);
                bool test =
                    _constructionBus.CreateConstruction(ipConstructionName.Text, ipDes.Text, ipAddress.Text,
                                   startDate, endDate, Convert.ToInt64(ipTotalCost.Text), cbStatus.Text);
                ConstructionDTO dto = _constructionBus.LoadConstructionByName(ipConstructionName.Text);
                _estimateBUS.creatEstimate(dto.ConstructionID, "Dự toán cho : " + dto.ConstructionName,
                    0, 0, new DateTime().Date, new DateTime().Date, "", "");
                MessageBox.Show("" + test);
            }
            else
            {
                DateTime startDate = DateTime.Parse(dtStartDate.Text);
                DateTime endDate = DateTime.Parse(dtEndDate.Text);
                bool test =
                    _constructionBus.updateConstruction(ConstructionID,ipConstructionName.Text, ipDes.Text, ipAddress.Text,
                                   startDate, endDate, Convert.ToInt64(ipTotalCost.Text), cbStatus.Text);

               
                MessageBox.Show("Save action =" + test);
            }
        }

        private void rdhasEstimate_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdNoEstimate_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btCreateSubcon_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
            cbSubcon.Items.Add(box.subcontractorDTO);
            cbSubcon.SelectedIndex = cbSubcon.Items.Count-1;
        }
    }
}