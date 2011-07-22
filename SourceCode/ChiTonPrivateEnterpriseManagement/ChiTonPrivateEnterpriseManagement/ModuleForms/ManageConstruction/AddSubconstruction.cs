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
        // for create new
        public AddSubconstruction(long parentId,bool edit=false)
        {
            _tempDTO.ParentID = parentId;
            CenterToParent();
            InitializeComponent();
            loadSubcons();
         
        }
        // for edit
        public AddSubconstruction(long constructionId)
        {
            InitializeComponent();
            loadSubcons();
            update = true;
            _tempDTO = _constructionBus.LoadConstructionById(constructionId);
            foreach(SubcontractorDTO item in cbSubconName.Items){
                if (item.SubcontractorID.Equals(_tempDTO.SubconstractorID))
                    cbSubconName.SelectedItem = item;
            }
            ipConstructionName.Text = _tempDTO.ConstructionName;
            ipDes.Text = _tempDTO.ConstructionAddress;
            ipAddress.Text = _tempDTO.ConstructionAddress;
            cbStatus.SelectedItem = _tempDTO.Status;
            ipProgressRate.Text = _tempDTO.ProgressRate.ToString();
            ipRealCost.Text = _tempDTO.TotalRealCost.ToString();
            ipEst.Text = _tempDTO.TotalEstimateCost.ToString();
         
        }
        //load nha thau phu
        private void loadSubcons()
        {
            subCons = _subcontractorBUS.loadAllSubcontractorDTO();
        }
        //
        private void btEditSubcons_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            
        }
        // load form
        private void AddConstruction_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox2);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btCancel);
            CenterToParent();
            cbSubconName.DisplayMember = "SubcontractorName";
            cbSubconName.Items.AddRange(subCons.ToArray());
            foreach (SubcontractorDTO dto in subCons)
            {
                if (_tempDTO.SubconstractorID.Equals(dto.SubcontractorID))
                    cbSubconName.SelectedItem = dto;
            }

            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetTextBoxNumberLeave(ipProgressRate);
        }
        // lưu
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateConstruction()) return;
            if (!update)
            {
                _constructionDTO.CommencementDate = dtStartDate.Value.Date;
                _constructionDTO.CompletionDate = dtEndDate.Value.Date;
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.Status = cbStatus.Text;
                _constructionDTO.ParentID = _tempDTO.ParentID;
                _constructionDTO.SubconstractorID = (cbSubconName.SelectedItem as SubcontractorDTO).SubcontractorID;
                _constructionDTO.type = ConstructionDTO.SUB; 
                if (Global.ValidateIntNumber(ipProgressRate.Text))
                    _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);
                _constructionDTO.TotalEstimateCost = Global.ConvertMoneyToLong(ipEst.Text, Global.SEP);
                _constructionDTO.TotalRealCost = Global.ConvertMoneyToLong(ipRealCost.Text, Global.SEP);
                long id = _constructionBus.CreateConstruction(_constructionDTO);
                _constructionBus.UpdateConstructionTotal((long)_constructionDTO.ParentID);

                //-------------------------------------------------------------------------------------
                EstimateDTO est = new EstimateDTO();
                est.ConstructionID = id;
                est.Type = 1;
                est.TotalCostEstimate = _constructionDTO.TotalEstimateCost;
                est.TotalCostReal = _constructionDTO.TotalRealCost;
                est.EstimateName = "Dự toán cho : " + ipConstructionName.Text;
                _estimateBUS.creatEstimate(est);
                
                MessageBox.Show("Tạo công trình thành công !");
                this.Close();

               
            }
            else
            {
                _constructionDTO.ConstructionID = _tempDTO.ConstructionID;
                _constructionDTO.CommencementDate = dtStartDate.Value.Date;
                _constructionDTO.CompletionDate = dtEndDate.Value.Date;
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
                _constructionDTO.ParentID = _tempDTO.ParentID;
                _constructionDTO.SubconstractorID = (cbSubconName.SelectedItem as SubcontractorDTO).SubcontractorID;
                if (Global.ValidateIntNumber(ipProgressRate.Text))
                    _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);

                 _constructionDTO.TotalEstimateCost = Global.ConvertMoneyToLong(ipEst.Text, Global.SEP);
                 _constructionDTO.TotalRealCost = Global.ConvertMoneyToLong(ipRealCost.Text, Global.SEP);


                bool test = _constructionBus.updateConstruction(_constructionDTO);
                EstimateDTO item = new EstimateDTO();
                item.ConstructionID = _constructionDTO.ConstructionID;
                item.TotalCostEstimate = _constructionDTO.TotalEstimateCost;
                item.TotalCostReal = _constructionDTO.TotalRealCost;
                _estimateBUS.UpdateNameForSub(item);
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

        private void btcreateSubcon_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
            if (box.subcontractorDTO != null)
            {
                cbSubconName.Items.Add(box.subcontractorDTO);
                cbSubconName.SelectedItem = box.subcontractorDTO;
            }
        }

        public bool validateConstruction()
        {
             if (cbSubconName.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("vui lòng chọn nhà thầu phụ", Constants.CONFIRM, MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return false;
            }
            else if (ipConstructionName.Text.Equals(""))
            {
                KryptonMessageBox.Show("vui lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                return false;
            }
            else if (cbStatus.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("vui lòng chọn tình trạng", Constants.CONFIRM, MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return false;
            }
            

            return true;
        }

        private void ipEst_Leave(object sender, EventArgs e)
        {
            ipEst.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipEst.Text, Constants.SPLIP_MONEY), Global.SEP);
        }

        private void ipEst_MouseLeave(object sender, EventArgs e)
        {
            ipEst.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipEst.Text, Constants.SPLIP_MONEY), Global.SEP);
        }

        private void ipRealCost_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(ipProgressRate);
            if (Global.ConvertMoneyToLong(ipRealCost.Text, Constants.SPLIP_MONEY) > Global.ConvertMoneyToLong(ipEst.Text, Constants.SPLIP_MONEY))
            {
                KryptonMessageBox.Show(" Giải Ngân Không Thể Lớn Hơn Tiền Khoán", Constants.ALERT_ERROR,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ipRealCost.Focus();
            }            
        }

        private void ipProgressRate_Leave(object sender, EventArgs e)
        {
            if (ipProgressRate.Text.Equals(Constants.EMPTY_TEXT))
            {
                ipProgressRate.Text = Constants.ZERO_NUMBER;
            }
            else
            {
                try
                {
                    double progress = Convert.ToDouble(ipProgressRate.Text);
                    if (progress > 100)
                    {
                        KryptonMessageBox.Show("Số Vừa Nhập Không Hợp Lệ", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                        ipProgressRate.Focus();
                    }
                }
                catch (Exception)
                {
                    KryptonMessageBox.Show("Chỉ Được Nhập Số", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    ipProgressRate.Focus();
                }
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text.Equals("Chọn") || cbStatus.Text.Equals("Mới"))
            {
                ipProgressRate.Text = Constants.ZERO_NUMBER;
                ipProgressRate.Enabled = false;
            }
            else if (cbStatus.Text.Equals("Hoàn thành"))
            {
                ipProgressRate.Text = "100";
                ipProgressRate.Enabled = false;
            }
            else
            {
                ipProgressRate.Enabled = true;
            }
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Value > dtStartDate.Value)
            {
                KryptonMessageBox.Show(Constants.ERROR_DATE, Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                dtEndDate.Focus();
            }
        }
    }
}