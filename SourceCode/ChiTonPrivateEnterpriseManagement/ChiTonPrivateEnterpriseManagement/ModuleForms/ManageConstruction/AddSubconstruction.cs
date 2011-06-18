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
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class AddSubconstruction : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
         private List<SubcontractorDTO> subCons = new List<SubcontractorDTO>();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();

        private ConstructionDTO _constructionDTO = new ConstructionDTO();
        private ConstructionDTO _tempDTO = new ConstructionDTO();
        private bool update = false;


        public AddSubconstruction()
        {
        }

        public AddSubconstruction(long parentId,bool edit=false)
        {
            _tempDTO.ParentID = parentId;
            CenterToParent();
            InitializeComponent();
            loadSubcons();
         
        }

        private void loadSubcons(){
            subCons= _subcontractorBUS.loadAllSubcontractorDTO();
        }

        public AddSubconstruction(long constructionId)
        {
            InitializeComponent();
            loadSubcons();
            update = true;
            _tempDTO = _constructionBus.LoadConstructionById(constructionId);
            ipConstructionName.Text = _tempDTO.ConstructionName;
            ipDes.Text = _tempDTO.ConstructionAddress;
            ipAddress.Text = _tempDTO.ConstructionAddress;
            cbStatus.SelectedItem = _tempDTO.Status;
         
        }



        private void rdSubcon_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void btEditSubcons_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            
        }

        private void AddConstruction_Load(object sender, EventArgs e)
        {

            CenterToParent();
            cbSubconName.DisplayMember = "SubcontractorName";
            cbSubconName.Items.AddRange(subCons.ToArray());
            foreach (SubcontractorDTO dto in subCons)
            {
                if (_tempDTO.SubconstractorID.Equals(dto.SubcontractorID))
                    cbSubconName.SelectedItem = dto;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                _constructionDTO.CommencementDate = DateTime.Parse(dtStartDate.Text);
                _constructionDTO.CompletionDate = DateTime.Parse(dtEndDate.Text);
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
                _constructionDTO.ParentID = _tempDTO.ParentID;
                _constructionDTO.SubconstractorID = (cbSubconName.SelectedItem as SubcontractorDTO).SubcontractorID;
                bool test = _constructionBus.CreateConstruction(_constructionDTO);


                //-------------------------------------------------------------------------------------
                if (test)
                    MessageBox.Show("Tạo công trình thành công !");
                this.Close();

               
            }
            else
            {
                _constructionDTO.ConstructionID = _tempDTO.ConstructionID;
                _constructionDTO.CommencementDate = DateTime.Parse(dtStartDate.Text);
                _constructionDTO.CompletionDate = DateTime.Parse(dtEndDate.Text);
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
                _constructionDTO.SubconstractorID = (cbSubconName.SelectedItem as SubcontractorDTO).SubcontractorID;
                bool test = _constructionBus.updateConstruction(_constructionDTO);

                if (test)
                    MessageBox.Show("Sửa công trình thành công !");
                this.Close();
            }
        }

        private void rdhasEstimate_CheckedChanged(object sender, EventArgs e)
        {
            _constructionDTO.HasEstimate = true;
        }

        private void rdNoEstimate_CheckedChanged(object sender, EventArgs e)
        {
            _constructionDTO.HasEstimate = false;
        }

   

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
            cbSubconName.Items.Add(box.subcontractorDTO);
            cbSubconName.SelectedItem = box.subcontractorDTO;
        }
    }
}