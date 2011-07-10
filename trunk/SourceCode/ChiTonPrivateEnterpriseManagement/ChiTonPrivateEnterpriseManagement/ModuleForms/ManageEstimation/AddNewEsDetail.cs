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
    public partial class AddNewEsDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private MaterialBUS _materialBUS = new MaterialBUS();
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();

        private int _defaultIndex;
        private long _estimateId;

        private long _totalCost;
        public AddNewEsDetail(long estimateId)
        {
            CenterToParent();
            _estimateId = estimateId;
            _defaultIndex = 0;
            InitializeComponent();
        }

        public AddNewEsDetail(long estimateId, int index)
        {
            CenterToParent();
            _estimateId = estimateId;
            _defaultIndex = index;
            InitializeComponent();
        }

        private void AddNewEsDetail_Load(object sender, EventArgs e)
        {
            Global.SetDataCombobox(cbMaterial, "Material");
            cbMaterial.SelectedIndex = _defaultIndex;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            if (!validateMaterial(dto)) return;
            else if (!validateQuantity(ipQuantity.Text)) return;
            else if (!validatePrice(ipPrice.Text)) return;
            else
            {
                    // CreateEstimateDetail
                    _estimateDetailBUS.CreateEstimateDetail(
                    _estimateId, dto.MaterialID, long.Parse(ipQuantity.Text),
                    long.Parse(ipPrice.Text), _totalCost);
                    // LoadAllEstimateDetails
                    //List<EstimateDetailDTO> esDetails =
                    //    _estimateDetailBUS.LoadAllEstimateDetails(_estimateId);
                    //_estimateBUS.UpdateEstimate(_estimateId, getTotalCost(esDetails));
                    //_constructionBus.UpdateConstructionTotalEstimateCost(_constructionID, getTotalCost(esDetails));

            }
            MessageBox.Show("Tạo thành công !");
            this.Close();
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
        public bool validateQuantity(string s)
        {

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

        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {

            if (Global.isNumber(ipPrice.Text) && Global.isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text) * Convert.ToInt64(ipQuantity.Text);
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

    }
}