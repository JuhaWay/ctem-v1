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
    public partial class ProgressIriManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        EstimateIriDetailDTO temp = new EstimateIriDetailDTO();
        private long _estimateID = 0;
        public ProgressIriManagement(long estimateID)
        {
            InitializeComponent();
            CenterToScreen();
            _estimateID = estimateID;

        }

        private void ProgressIriManagement_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(kryptonPanel);
            Global.SetLayoutSplipContainerInChildForm(kryptonSplitContainer1);
            Global.SetLayoutGroupBoxChildForm(kryptonGroupBox1);
            Global.SetLayoutGroupBoxChildForm(kryptonGroupBox2);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox3);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox4);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox5);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgv);
            dgv.ReadOnly = false;
            loadEstimate();
            loadReal();
            setButtonValue();
        }

        public void loadEstimate()
        {
            EstimateIriDetailDTO dtoTemp = _estimateDetailBUS.LoadOneEstimateIriDetailByEst(_estimateID, EstimateIriDetailDTO.TYPE_EST);
            if (dtoTemp == null)
            {
                KryptonMessageBox.Show("Bạn Chưa Tạo Dự Toán Cho Công Trình Này", Constants.ALERT_ERROR,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temp = null;
            }
            else
            {
                lbEstTotal.Text = Global.ConvertLongToMoney(dtoTemp.TotalCost, Global.SEP);
                lbEstWeight.Text = dtoTemp.Weight.ToString();
                lbEstLength.Text = dtoTemp.Length.ToString();
                lbEstContainers.Text = dtoTemp.Containers.ToString();
                temp = dtoTemp;
            }
        }
        public void loadReal()
        {
            if (temp == null)
            {
                return;
            }
            List<EstimateIriDetailDTO> dtoTemps = _estimateDetailBUS.LoadAllEstimateIriDetailsByEst(_estimateID, EstimateIriDetailDTO.TYPE_REAL);            
            dgv.DataSource = dtoTemps;
            EstimateIriDetailDTO dtoTemp = new EstimateIriDetailDTO();
            foreach (EstimateIriDetailDTO item in dtoTemps)
            {
                dtoTemp.Weight += item.Weight;
                dtoTemp.Length += item.Length;
                dtoTemp.Containers += item.Containers;
                if (dtoTemps.IndexOf(item) == (dtoTemps.Count - 1))
                    dtoTemp.Progress = item.Progress;
            }
            
            lbRealWeight.Text = dtoTemp.Weight.ToString();
            lbRealLengh.Text = dtoTemp.Length.ToString();
            lbRealContainer.Text = dtoTemp.Containers.ToString();
            lbCurrentProgress.Text = dtoTemp.Progress.ToString();
        }

        public void setButtonValue()
        {
            
        }
        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            if(!validate())return;
            if (KryptonMessageBox.Show("Bạn có muốn cập nhật tiến độ", Constants.CONFIRM, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EstimateIriDetailDTO Entity = new EstimateIriDetailDTO();
                if (!ipEWeight.Text.Trim().Equals(""))
                Entity.Weight = Convert.ToDouble(ipEWeight.Text);
                if (!ipELength.Text.Trim().Equals(""))
                Entity.Length = Convert.ToDouble(ipELength.Text);
                if (!ipEcontainer.Text.Trim().Equals(""))
                Entity.Containers = Convert.ToInt64(ipEcontainer.Text);
                if (!ipEProgress.Text.Trim().Equals(""))
                Entity.Progress = Convert.ToInt32(ipEProgress.Text);
                Entity.Note = ipEnote.Text;
                Entity.Date = dtEDate.Value.Date;
                Entity.EstimateID = _estimateID;
                Entity.Reporter = ipEreporter.Text;
                Entity.Type = EstimateIriDetailDTO.TYPE_REAL;
                _estimateDetailBUS.CreateEstimateDetailIri(Entity);
                reSet();
                loadReal();
            }

        }

        public void reSet()
        {
            ipEWeight.Text = "";
            ipELength.Text = "";
            ipEcontainer.Text = "";
            ipEProgress.Text = "";
            ipEnote.Text = "";
            ipEreporter.Text = "";
        }

        public bool validate()
        {
            if (!ipEWeight.Text.Trim().Equals("") && !Global.ValidateDoubleNumber(ipEWeight.Text))
            {
                KryptonMessageBox.Show("Sai thông tin khối lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipELength.Text.Trim().Equals("") && !Global.ValidateDoubleNumber(ipELength.Text))
            {
                KryptonMessageBox.Show("Sai thông tin chiều dài", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipEcontainer.Text.Trim().Equals("") && !Global.ValidateLongNumber(ipEcontainer.Text))
            {
                KryptonMessageBox.Show("Sai thông tin số bể", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!Global.ValidateInputNumber(ipEProgress.Text))
            {
                    KryptonMessageBox.Show("Sai thông tin tiến độ", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
            }

            return true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0){
                if (dgv.Rows.Count <= 0) return;
                if (KryptonMessageBox.Show("Bạn có lưu thay đổi", Constants.CONFIRM, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstimateIriDetailDTO Entity = dgv.Rows[e.RowIndex].DataBoundItem as EstimateIriDetailDTO;
                    _estimateDetailBUS.UpdateEstimateDetailIri(Entity);
                    loadReal();
                }
            }
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            string s = e.FormattedValue.ToString();
            if (e.ColumnIndex == 1)
            {
                
                if (!Global.ValidateDoubleNumber(s))
                {
                    KryptonMessageBox.Show("Sai thông tin khối lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                   e.Cancel=true;
                }
            }
            if (e.ColumnIndex == 2)
            {
                if ( !Global.ValidateDoubleNumber(s))
                {
                    KryptonMessageBox.Show("Sai thông tin chiều dài", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (!Global.ValidateLongNumber(s))
                {
                    KryptonMessageBox.Show("Sai thông tin số bể", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (!Global.ValidateInputNumber(s))
                {
                    KryptonMessageBox.Show("Sai thông tin tiến độ", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Bạn có xóa không", Constants.CONFIRM, MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    long ID = (row.DataBoundItem as EstimateIriDetailDTO).EstimateIriDetailID;
                    _estimateDetailBUS.DeleteEstimateDetailIri(ID);
                }
                loadReal();
            }
        }
    }
}