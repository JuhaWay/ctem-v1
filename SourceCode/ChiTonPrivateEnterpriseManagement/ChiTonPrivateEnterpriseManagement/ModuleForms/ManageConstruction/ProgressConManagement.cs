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
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class ProgressConManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private ConstructionBus _constructionBus = new ConstructionBus();
        private long _constructionID = 0;
        private long _DisbursementProgressID = 0;
        private List<DisbursementDTO> _disbursementList = new List<DisbursementDTO>();
        public ProgressConManagement(long ConstructionID)
        {
            InitializeComponent();
            CenterToScreen();
            _constructionID = ConstructionID;
        }
        private void ProgressConManagement_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(kryptonHeader1, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(kryptonHeader2, Constants.CHILD_FORM);
            Global.SetLayoutSplipContainerInChildForm(kryptonSplitContainer1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox3);
            Global.SetDaulftDatagridview(kryptonDataGridView2);
            loadHtrs();
            loadleftForm();
        }
        public void loadHtrs(){
            cbState.Items.Add(new PayDTO("Toàn bộ giai đoạn",0));
            cbState.Items.AddRange(_constructionBus.LoadAllDisbursementProgress(_constructionID,0).ToArray());
            cbState.DisplayMember = "State";
            List<ProgressHrtDTO> list = _constructionBus.LoadAllProgressHtr(_constructionID);
            kryptonDataGridView2.DataSource = list;
            if (list != null && list.Count > 0)
                ipCurrentProgress.Text = list[list.Count-1].Progress.ToString();
        }
       

        public void loadleftForm()
        {
            summaryState();
            SummaryDis();
          
        }
        public void summaryState()
        {
            PayDTO dto = new PayDTO();
            if (cbState.SelectedIndex <= 0)
            {
                ConstructionDTO con = _constructionBus.LoadConstructionById(_constructionID);
                lbNumber.Text = con.TotalEstimateCostFormated;
                lbRate.Text = "100";
                lbFrom.Text = con.CommencementDateFormated;
                lbEnd.Text = con.CompletionDateFormated;
            }
            else
            {
                long id = (cbState.SelectedItem as PayDTO).DisbursementProgressID;
                dto = _constructionBus.LoadAllDisbursementProgress(id);
                lbNumber.Text = Global.ConvertLongToMoney(dto.Number, Global.SEP);
                lbRate.Text = dto.Rate.ToString();
                lbFrom.Text = dto.Start.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
                lbEnd.Text = dto.End.ToString(Constants.DATETIME_FORMAT_SHORTDATE);
            }
        }
        public void SummaryDis()
        {
                 long ID = 0;
                 if (cbState.SelectedIndex > -1)
                ID = (cbState.SelectedItem as PayDTO).DisbursementProgressID;
                _disbursementList = _constructionBus.LoadAllDisbursement(ID, _constructionID);
                long NumReal = 0;
                long NumFine = 0;
                long NumAward = 0;
                long Others = 0;
                foreach (DisbursementDTO temp in _disbursementList)
                {
                    NumReal += temp.Number;
                    if(temp.Reason.Equals("Thưởng"))
                        NumAward+= temp.OthersCost;
                    else if(temp.Reason.Equals("Phạt"))
                        NumFine+=temp.OthersCost;
                    else if(temp.Reason.Equals("Khác"))
                        Others += temp.OthersCost;


                }
                lbRealNum.Text = Global.ConvertLongToMoney(NumReal, Global.SEP);
                lbAwardMoney.Text = Global.ConvertLongToMoney(NumAward, Global.SEP);
                lbfineMoney.Text = Global.ConvertLongToMoney(NumFine, Global.SEP);
                lbOthersMoney.Text = Global.ConvertLongToMoney(Others, Global.SEP);
        }
        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbState.SelectedIndex > -1)
                _DisbursementProgressID = (cbState.SelectedItem as PayDTO).DisbursementProgressID;
            loadleftForm();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            Disbursement form = new Disbursement(_DisbursementProgressID, _constructionID);
            form.ShowDialog();
            SummaryDis();
        }
        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            if (KryptonMessageBox.Show("Bạn có muốn cập nhật tiến độ", Constants.CONFIRM, MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ProgressHrtDTO dto = new ProgressHrtDTO();
                dto.ConstructionID = _constructionID;
                dto.Editor = ipEditor.Text;
                dto.Date = dtDate.Value.Date;
                dto.Progress = Convert.ToInt32(ipProgress.Text);
                dto.Note = ipNote.Text;
                _constructionBus.CreateProgressHrt(dto);
                loadHtrs();
            }
       
        }

        private bool validate()
        {
            if (!Global.ValidateIntNumber(ipProgress.Text) || Convert.ToInt32(ipProgress.Text) > 100)
            {
                    KryptonMessageBox.Show("Sai thông tin tỷ lệ", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                    return false;
            }
            else if (ipEditor.Text.Equals(""))
            {
                KryptonMessageBox.Show("vui lòng điền người cập nhật", Constants.CONFIRM, MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       
    }
}