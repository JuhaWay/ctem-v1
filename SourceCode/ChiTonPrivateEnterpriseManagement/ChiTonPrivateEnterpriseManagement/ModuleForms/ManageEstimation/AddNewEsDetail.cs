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
        private List<EstimateDetailDTO> dgvProvider = new List<EstimateDetailDTO>();


        private long _estimateId;

        private double _totalCost;
        public AddNewEsDetail(long estimateId)
        {
            CenterToParent();
            _estimateId = estimateId;
            InitializeComponent();
            CenterToScreen();
        }

        private void AddNewEsDetail_Load(object sender, EventArgs e)
        {
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbMaterial.DisplayMember = "MaterialName";
            Global.SetLayoutPanelNewForm(pnMain);
            cbType.SelectedIndex = 0;
            Global.SetDaulftDatagridview(dgvEst);
        }

        private void refresh(EstimateDetailDTO dto){
            dgvProvider.Add(dto);
            dgvEst.DataSource = null;
            dgvEst.DataSource = dgvProvider;
        }
        private void btSave_Click(object sender, EventArgs e)
        {

            save();
            
        }

        private void save()
        {
            EstimateDetailDTO entity = new EstimateDetailDTO();
            entity.Name = ipName.Text;
            entity.EstimateID = _estimateId;
            if (cbType.SelectedIndex == 0)
            {
                if (cbMaterial.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn Vật liệu");
                    return;
                }

                if (!validateQuantity(ipQuantity.Text)) return;
                entity.QuantityEstimate = Convert.ToDouble(ipQuantity.Text);
                entity.UnitCostEstimate = Global.ConvertMoneyToLong(ipPrice.Text, ".");
                entity.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                entity.MaterialName = (cbMaterial.SelectedItem as MaterialDTO).MaterialName;
                entity.UnitCostEstimateFormated = ipPrice.Text;
               

            }
            else if (ipName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            entity.TotalCostEstimate = Global.ConvertMoneyToLong(ipTotal.Text, ".");
            entity.TotalCostEstimateFormated = ipTotal.Text;
            _estimateDetailBUS.CreateEstimateDetail(entity);
            refresh(entity);
        }


        // validate thong tin
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

            if (!Global.ValidateDoubleNumber(s))
            {
                MessageBox.Show("Dử liệu của số lượng ko đúng !");
                return false;
            }
            return true;
        }


        public bool validatePrice(string s)
        {

            if (!Global.ValidateLongNumber(s))
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
            lbUnit1.Text = dto.EstimateCalUnit;
        }

        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {


            if (Global.ValidateDoubleNumber(ipQuantity.Text))
            {
                _totalCost = Global.ConvertMoneyToLong(ipPrice.Text, ".") * Convert.ToDouble(ipQuantity.Text);
                ipTotal.Text = Global.ConvertLongToMoney((long)_totalCost, ".");
            }
            else
                _totalCost = 0;
        }

        //tính tổng gia tiền
        private void ipPrice_TextChanged(object sender, EventArgs e)
        {
            if (Global.ValidateDoubleNumber(ipQuantity.Text))
            {
                _totalCost = Global.ConvertMoneyToLong(ipPrice.Text, ".") * Convert.ToDouble(ipQuantity.Text);
                ipTotal.Text = Global.ConvertLongToMoney((long)_totalCost, ".");
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
                ipName.Enabled = true;
                ipTotal.ReadOnly = false;
            }
            else
            {
                ipName.Enabled = false;
                cbMaterial.Enabled = true;
                ipQuantity.Enabled = true;
                ipPrice.Enabled = true;
                ipTotal.ReadOnly = true;
            }
        }

        private void ipPrice_MouseLeave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, "."), ".");
        }

        private void ipPrice_Leave(object sender, EventArgs e)
        {
              ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text, "."), ".");
        
        }

        private void ipTotal_Leave(object sender, EventArgs e)
        {
            ipTotal.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipTotal.Text, "."), ".");
        }

        private void ipTotal_MouseLeave(object sender, EventArgs e)
        {
            ipTotal.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipTotal.Text, "."), ".");
        }

        private void AddNewEsDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                save();

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

    }
}