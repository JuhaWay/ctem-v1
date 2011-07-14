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


        private long _estimateId;

        private long _totalCost;
        public AddNewEsDetail(long estimateId)
        {
            CenterToParent();
            _estimateId = estimateId;
            InitializeComponent();
        }

        private void AddNewEsDetail_Load(object sender, EventArgs e)
        {
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbMaterial.DisplayMember = "MaterialName";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (ipName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            else if (cbType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại");
                return;
            }
            else
            {
                EstimateDetailDTO entity = new EstimateDetailDTO();
                entity.Name = ipName.Text;
                entity.EstimateID = _estimateId;  
                if (cbType.SelectedIndex == 0)
                {
                    if (!validateQuantity(ipQuantity.Text)) return;
                    if (!validatePrice(ipPrice.Text)) return;
                    entity.QuantityEstimate = Convert.ToInt32(ipQuantity.Text);
                    entity.UnitCostEstimate = Convert.ToInt64(ipQuantity.Text);
                    entity.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                }                          
                entity.TotalCostEstimate = Convert.ToInt64(ipTotal.Text);              
                _estimateDetailBUS.CreateEstimateDetail(entity);
               
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
            if (cbMaterial.SelectedIndex == 0)
            {
                ipQuantity.Enabled = false;
                ipPrice.Enabled = false;
                ipTotal.Enabled = true;
                ipName.Enabled = true;
            }


            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            lbUnit.Text = dto.EstimateCalUnit;
        }

        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {

            if (Global.isNumber(ipPrice.Text) && Global.isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text) * Convert.ToInt64(ipQuantity.Text);
                ipTotal.Text = _totalCost.ToString();
            }
            else
                _totalCost = 0;
        }

        private void ipPrice_TextChanged(object sender, EventArgs e)
        {
            if (Global.isNumber(ipPrice.Text) && Global.isNumber(ipQuantity.Text))
            {
                _totalCost = Convert.ToInt64(ipPrice.Text) * Convert.ToInt64(ipQuantity.Text);
                ipTotal.Text = _totalCost.ToString();
            }
            else _totalCost = 0;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 1)
            {
                cbMaterial.Enabled = false;
                ipQuantity.Enabled = false;
                ipPrice.Enabled = false;
                ipTotal.Enabled = true;
            }
            else
            {
                cbMaterial.Enabled = true;
                ipQuantity.Enabled = true;
                ipPrice.Enabled = true;
                ipTotal.Enabled = false;
            }
        }

    }
}