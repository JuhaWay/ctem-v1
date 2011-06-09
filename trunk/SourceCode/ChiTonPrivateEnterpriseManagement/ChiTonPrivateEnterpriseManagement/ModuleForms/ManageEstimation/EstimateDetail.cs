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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private  EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        private MaterialBUS _materialBUS = new MaterialBUS();


        private long _estimateId;
        private long _totalCost;
        public EstimateDetail()
        {
            InitializeComponent();
        }

        public EstimateDetail(long estimateId)
        {
            _estimateId = estimateId;
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
            _estimateDetailBUS.CreateEstimateDetail(_estimateId,dto.MaterialID, long.Parse(ipQuantity.Text),
                                                        long.Parse(ipPrice.Text), _totalCost);
            List<EstimateDetailDTO> esDetails =_estimateDetailBUS.LoadAllEstimateDetails(_estimateId);
            _estimateBUS.UpdateEstimate(_estimateId, getTotalCost(esDetails));
            resetDataSource(_estimateId);
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


            if (isNumber(ipPrice.Text) && isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text.Equals("") ? "0" : ipPrice.Text) *
                    Convert.ToInt64(ipQuantity.Text.Equals("") ? "0" : ipQuantity.Text);
                lbTotalCostNum.Text = _totalCost.ToString();
            }
            else
                _totalCost = 0;
        }


        public bool isNumber(string text)
        {
            bool textIsNumeric = true;
            try
            {
                long.Parse(text);
            }
            catch
            {
                textIsNumeric = false;
            }
            return textIsNumeric;
        }
        private void ipPrice_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(ipPrice.Text) && isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text.Equals("") ? "0" : ipPrice.Text) *
                    Convert.ToInt64(ipQuantity.Text.Equals("") ? "0" : ipQuantity.Text);
                lbTotalCostNum.Text = _totalCost.ToString();
            }
            else _totalCost = 0;
        }
    }
}