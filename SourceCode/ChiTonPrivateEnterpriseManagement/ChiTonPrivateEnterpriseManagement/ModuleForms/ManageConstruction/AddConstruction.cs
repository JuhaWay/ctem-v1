﻿using System;
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
    public partial class AddConstruction : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<SubcontractorDTO> subCons = new List<SubcontractorDTO>();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();

        private ConstructionDTO _constructionDTO = new ConstructionDTO();
        private long ConstructionID;
        private bool update = false;

        public AddConstruction()
        {
            CenterToParent();
            InitializeComponent();
            loadSubcons();
        }

        private void loadSubcons(){
            subCons= _subcontractorBUS.loadAllSubcontractorDTO();
        }

        public AddConstruction(long constructionId)
        {
            InitializeComponent();
            loadSubcons();
            update = true;
            ConstructionDTO dto = _constructionBus.LoadConstructionById(constructionId);
            ConstructionID = dto.ConstructionID;
            ipConstructionName.Text = dto.ConstructionName;
            ipDes.Text = dto.ConstructionAddress;
            ipAddress.Text = dto.ConstructionAddress;
            cbStatus.SelectedItem = dto.Status;
            if (dto.HasEstimate)
                rdhasEstimate.Checked = true;
            else
                rdNoEstimate.Checked = true;
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
                bool test = _constructionBus.CreateConstruction(_constructionDTO);


                //-------------------------------------------------------------------------------------
                if(_constructionDTO.HasEstimate){
                    ConstructionDTO dto = _constructionBus.LoadConstructionByName(ipConstructionName.Text);
                    _estimateBUS.creatEstimate(dto.ConstructionID, "Dự toán cho : " + dto.ConstructionName,
                    0, 0, new DateTime().Date, new DateTime().Date, "", "");
                    }
                if (test)
                    MessageBox.Show("Tạo công trình thành công !");
                this.Close();

               
            }
            else
            {
                _constructionDTO.ConstructionID = ConstructionID;
                _constructionDTO.CommencementDate = DateTime.Parse(dtStartDate.Text);
                _constructionDTO.CompletionDate = DateTime.Parse(dtEndDate.Text);
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
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

        private void btCreateSubcon_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
      
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}