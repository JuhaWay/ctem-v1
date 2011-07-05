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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private  EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        private MaterialBUS _materialBUS = new MaterialBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();

        private EstimateDetailDTO dtoTemp = new EstimateDetailDTO();
        private long _estimateId;
        private long _constructionID;
        private long _totalCost;
        public EstimateDetail()
        {
            InitializeComponent();
        }

        public EstimateDetail(long estimateId, long ConstructionID)
        {
            _estimateId = estimateId;
            _constructionID = ConstructionID;
            InitializeComponent();
            resetDataSource(estimateId);
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbMaterial.DisplayMember = "MaterialName";
            
        }

        public void resetDataSource(long estimateId)
        {
            dgvEstimateDetails.DataSource = _estimateDetailBUS.LoadAllEstimateDetails(estimateId);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            if (!validateMaterial(dto)) return;
            else if (!validateQuantity(ipQuantity.Text)) return;
            else if (!validatePrice(ipPrice.Text)) return;
            else
            {
                    // CreateEstimateDetail
                    _estimateDetailBUS.UpdateEstimateDetail(
                        dtoTemp.EstimateDetailID, dto.MaterialID, long.Parse(ipQuantity.Text),
                         long.Parse(ipPrice.Text), _totalCost);
                    // LoadAllEstimateDetails
                    //List<EstimateDetailDTO> esDetails =
                   //     _estimateDetailBUS.LoadAllEstimateDetails(_estimateId);
                    //_estimateBUS.UpdateEstimate(_estimateId, getTotalCost(esDetails));
                    //_constructionBus.UpdateConstructionTotalEstimateCost(_constructionID, getTotalCost(esDetails));
                    MessageBox.Show("Cập nhật thành công!");   
                resetDataSource(_estimateId);
                
            }
        }

        public bool validateMaterial(MaterialDTO dto)
        {
            if (dto == null)
            {
                MessageBox.Show("Vui lòng chọn vật liệu !");
                return false;
            }

            return true;
        }
        public bool validateQuantity(string s){

            if (!Global.isNumber(s))
            {
                MessageBox.Show("Dử liệu của số lượng ko đúng !");
                return false;
            }
            return true;
        }


        public bool validatePrice(string s)
        {

            if (!Global.isNumber(s))
            {
                MessageBox.Show("Dử liệu giá ko đúng !");
                return false;
            }
            return true;
        }

        public long getTotalCost(List<EstimateDetailDTO> esDetails)
        {
            long total = 0;
            foreach (EstimateDetailDTO dto in esDetails)
            {
                total += dto.TotalCostEstimate;
            }
            return total;
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            lbUnit.Text = dto.EstimateCalUnit;
            

        }

        private void EstimateDetail_Load(object sender, EventArgs e)
        {
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
        }

        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {


            if (Global.isNumber(ipPrice.Text) && Global.isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64( ipPrice.Text) * Convert.ToInt64(ipQuantity.Text);
                lbTotalCostNum.Text = _totalCost.ToString();
            }
            else
                _totalCost = 0;
        }


        private void ipPrice_TextChanged(object sender, EventArgs e)
        {
            if (Global.isNumber(ipPrice.Text) && Global.isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text) * Convert.ToInt64(ipQuantity.Text);
                lbTotalCostNum.Text = _totalCost.ToString();
            }
            else _totalCost = 0;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstimateDetails.Rows)
            {
                DataGridViewCell c = dgvEstimateDetails.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["EstimateDetailID"].Value.ToString();
                    long EstimateDetailID = Convert.ToInt64(strRightID);
                    _estimateDetailBUS.DeleteEstimateDetail(EstimateDetailID);
                }
            }
            resetDataSource(_estimateId);
           
        }

        private void dgvEstimateDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvEstimateDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvEstimateDetails[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvEstimateDetails.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvEstimateDetails[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvEstimateDetails.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void kryptonGroupBox2_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddNewEsDetail add = new AddNewEsDetail(_estimateId);
            add.ShowDialog();
            List<EstimateDetailDTO> esDetails =
               _estimateDetailBUS.LoadAllEstimateDetails(_estimateId);
            _estimateBUS.UpdateEstimate(_estimateId, getTotalCost(esDetails));
            _constructionBus.UpdateConstructionTotalEstimateCost(_constructionID, getTotalCost(esDetails));

            resetDataSource(_estimateId);
        }

        private void dgvEstimateDetails_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvEstimateDetails.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow > -1)
            {
                dtoTemp = dgvEstimateDetails.Rows[currentMouseOverRow].DataBoundItem as EstimateDetailDTO;
                foreach (MaterialDTO dto in cbMaterial.Items)
                {
                    if (dto.MaterialID.Equals(dtoTemp.MaterialID))
                        cbMaterial.SelectedItem = dto;
                }
                ipQuantity.Text = dtoTemp.QuantityEstimate.ToString();
                ipPrice.Text = dtoTemp.UnitCostEstimate.ToString();
            }
        }
    }
}