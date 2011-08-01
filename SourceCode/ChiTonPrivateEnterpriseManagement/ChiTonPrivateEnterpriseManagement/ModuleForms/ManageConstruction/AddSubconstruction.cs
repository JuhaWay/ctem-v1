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
        private List<PayDTO> _pays = new List<PayDTO>();
        private bool update = false;
        // for create new
        public AddSubconstruction(long parentId,bool edit=false)
        {
            _constructionDTO.ParentID = parentId;
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
            _constructionDTO = _constructionBus.LoadConstructionById(constructionId);
            foreach(SubcontractorDTO item in cbSubconName.Items){
                if (item.SubcontractorID.Equals(_constructionDTO.SubconstractorID))
                    cbSubconName.SelectedItem = item;
            }
            ipConstructionName.Text = _constructionDTO.ConstructionName;
            ipDes.Text = _constructionDTO.ConstructionAddress;
            ipAddress.Text = _constructionDTO.ConstructionAddress;
            cbStatus.SelectedItem = _constructionDTO.Status;
            ipProgressRate.Text = _constructionDTO.ProgressRate.ToString();
            ipRealCost.Text = _constructionDTO.TotalRealCost.ToString();
            ipEst.Text = _constructionDTO.TotalEstimateCost.ToString();
            _pays = _constructionBus.LoadAllDisbursementProgress(constructionId,0);
            dgvPaid.DataSource = null;
            if (_pays!= null && _pays.Count>0)
                   dgvPaid.DataSource  = _pays;
            dtStartDate.Value = _constructionDTO.CommencementDate;
            dtEndDate.Value = _constructionDTO.CompletionDate;
         
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
            Global.SetLayoutSplipContainerInChildForm(kryptonSplitContainer1);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox2);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox3);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvPaid);
            dgvPaid.ReadOnly = false;
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btCancel);
            CenterToParent();
            cbSubconName.DisplayMember = "SubcontractorName";
            cbSubconName.Items.AddRange(subCons.ToArray());
            foreach (SubcontractorDTO dto in subCons)
            {
                if (_constructionDTO.SubconstractorID.Equals(dto.SubcontractorID))
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
                _constructionDTO.SubconstractorID = (cbSubconName.SelectedItem as SubcontractorDTO).SubcontractorID;
                _constructionDTO.type = ConstructionDTO.SUB; 
                if (Global.ValidateIntNumber(ipProgressRate.Text))
                    _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);
                _constructionDTO.TotalEstimateCost = Global.ConvertMoneyToLong(ipEst.Text, Global.SEP);
                _constructionDTO.TotalRealCost = Global.ConvertMoneyToLong(ipRealCost.Text, Global.SEP);
                long id = _constructionBus.CreateConstruction(_constructionDTO);
                _constructionBus.UpdateConstructionTotal((long)_constructionDTO.ParentID);

                //tạo dự toán
                EstimateDTO est = new EstimateDTO();
                est.ConstructionID = id;
                est.Type = 1;
                est.TotalCostEstimate = _constructionDTO.TotalEstimateCost;
                est.TotalCostReal = _constructionDTO.TotalRealCost;
                est.EstimateName = "Dự toán cho : " + ipConstructionName.Text;
                _estimateBUS.creatEstimate(est);
                //tạo tiến độ giải ngân
                foreach (PayDTO item in _pays)
                {
                    item.ConstructionID = id;
                    item.Type = 0;
                    _constructionBus.CreateDisbursementProgress(item);
                }
                this.Close();

               
            }
            else
            {
                _constructionDTO.CommencementDate = dtStartDate.Value.Date;
                _constructionDTO.CompletionDate = dtEndDate.Value.Date;
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
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


                //tạo tiến độ giải ngân
                foreach (PayDTO temp in _pays)
                {
                    temp.ConstructionID = _constructionDTO.ConstructionID;
                    temp.Type = 0;
                    temp.Number = Global.ConvertMoneyToLong(temp.NumberFormated, Global.SEP);
                    _constructionBus.CreateDisbursementProgress(temp);
                }
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
             else if (dtEndDate.Value < dtStartDate.Value)
             {
                 KryptonMessageBox.Show("Ngày khởi công không được vượt quá ngày hoàn thành", Constants.CONFIRM, MessageBoxButtons.OK,
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

        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            PayDTO dto = new PayDTO();
            dto.State = ipState.Text;
            dto.Rate = Convert.ToInt32(ipRate.Text);
            dto.Start = dtStart.Value.Date;
            dto.End = dtEnd.Value.Date;
            dto.StartFormated = dto.Start.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
            dto.EndFormated = dto.End.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
            dto.Number = Global.ConvertMoneyToLong(ipPaid.Text, Global.SEP);
            dto.NumberFormated = ipPaid.Text;
            dto.Note = ipNote.Text;
            _pays.Add(dto);
            dgvPaid.DataSource = null;
            dgvPaid.DataSource = _pays;
        }

        private bool validateForm()
        {
            if (ipState.Text.Equals(""))
            {
                KryptonMessageBox.Show("Vui lòng điền giai đoạn", Constants.CONFIRM, MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                return false;
            }
            else if (!Global.ValidateIntNumber(ipRate.Text))
            {
                KryptonMessageBox.Show("Sai thông tin tỷ lệ", Constants.CONFIRM, MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                return false;
            }
            else if (!Global.ValidateIntNumber(ipRate.Text) || Convert.ToInt32(ipRate.Text) > 100)
            {
                    KryptonMessageBox.Show("Sai thông tin tỷ lệ", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    return false;
            }
           
            return true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPaid.SelectedRows)
            {
                _pays.Remove(row.DataBoundItem as PayDTO);
            }
            dgvPaid.DataSource = null;
            dgvPaid.DataSource = _pays;
        }

        private void ipPaid_Leave(object sender, EventArgs e)
        {
            ipPaid.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPaid.Text, Global.SEP), Global.SEP);
        }

        private void ipPaid_MouseLeave(object sender, EventArgs e)
        {
            ipPaid.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPaid.Text, Global.SEP), Global.SEP);
        }
    }
}