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
        private long _materialId;
        private long _estimateId;
        private double _totalCost;
        private long temID;

        //khởi tạo dư toán chi tiết
        public EstimateDetail(long estimateId)
        {
            _estimateId = estimateId;
            InitializeComponent();
            CenterToParent();
            resetDataSource(estimateId,-1);
            
            
        }
        // load form
        private void EstimateDetail_Load(object sender, EventArgs e)
        {
            cbSearchMaterial.Items.Add(new MaterialDTO("Tất cả",0));
            cbSearchMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbSearchMaterial.DisplayMember = "MaterialName";
            cbMaterial.Items.AddRange(_materialBUS.LoadAllMaterials().ToArray());
            cbMaterial.DisplayMember = "MaterialName";


            loadDetailValues(0);
            SetLayout();
        }
        private void SetLayout()
        {
            dgvEstimateDetails.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEstimateDetails);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }
        // load lại dử liệu
        public void resetDataSource(long estimateId,long materialId)
        {
            List<EstimateDetailDTO> list = _estimateDetailBUS.search(estimateId, materialId);
            dgvEstimateDetails.DataSource = list;
            sum(list);
        }


        private void sum(List<EstimateDetailDTO> list)
        {
            long total = 0;
            foreach (EstimateDetailDTO dto in list)
            {
                total += dto.TotalCostEstimate;
            }
            ipSummary.Text = Global.ConvertLongToMoney(total, Global.SEP);
        }

        // sưa dự toán chi tiết
        private void btSave_Click(object sender, EventArgs e)
        {
            dtoTemp.Name = ipName.Text;
            if (cbType.SelectedIndex == 0)
            {
                if (cbMaterial.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn Vật liệu");
                    return;
                }

                if (!validateQuantity(ipQuantity.Text)) return;
                dtoTemp.QuantityEstimate = Convert.ToDouble(ipQuantity.Text);
                dtoTemp.UnitCostEstimate = Global.ConvertMoneyToLong(ipPrice.Text, ".");
                dtoTemp.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                dtoTemp.UnitCostEstimateFormated = ipPrice.Text;


            }
            else
            {
                if (ipName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tên");
                    return;
                }
                dtoTemp.QuantityEstimate =0;
                dtoTemp.UnitCostEstimate = 0;
                dtoTemp.MaterialID = 0;
            }
            dtoTemp.TotalCostEstimate = Global.ConvertMoneyToLong(ipTotal.Text, ".");
            dtoTemp.TotalCostEstimateFormated = ipTotal.Text;
            if (temID != dtoTemp.MaterialID && _estimateDetailBUS.check(dtoTemp.MaterialID, dtoTemp.EstimateID))
            {
                MessageBox.Show("Vật liệu này đã tồn tại !");
                return;
            }
            _estimateDetailBUS.UpdateEstimateDetail (dtoTemp);
            MessageBox.Show("Cập nhật thành công!");
            resetDataSource(_estimateId, _materialId);

        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            AddNewEsDetail add = new AddNewEsDetail(_estimateId);
            add.ShowDialog();
            _estimateBUS.UpdateEstimate(_estimateId);
            resetDataSource(_estimateId, _materialId);
            loadDetailValues(0);
        }
        // chọn nguyên vật liệu
        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            if (dto!=null) lbUnit.Text = "(" + dto.EstimateCalUnit + ")";
            

        }
        
        // tính tỏng giá tiền
        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {


            if (Global.ValidateDoubleNumber(ipQuantity.Text))
            {
                _totalCost = Global.ConvertMoneyToLong(ipPrice.Text,".") * Convert.ToDouble(ipQuantity.Text);
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
        // xóa dư toán chi tiết 
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstimateDetails.SelectedRows)
            {

                string strRightID = row.Cells["EstimateDetailID"].Value.ToString();
                long EstimateDetailID = Convert.ToInt64(strRightID);
                _estimateDetailBUS.DeleteEstimateDetail(EstimateDetailID);

            }
            _estimateBUS.UpdateEstimate(_estimateId);
            resetDataSource(_estimateId, _materialId);
            loadDetailValues(0);
        }
        private void btDelete_Click_1(object sender, EventArgs e)
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
            resetDataSource(_estimateId, _materialId);
            loadDetailValues(0);
        }

        // sửa lổi check box
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
        //thêm -------------------------------------------
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddNewEsDetail add = new AddNewEsDetail(_estimateId);
            add.ShowDialog();
            _estimateBUS.UpdateEstimate(_estimateId);
            resetDataSource(_estimateId, _materialId);
            loadDetailValues(0);
        }
        //chọn để xem chi tiết
        private void dgvEstimateDetails_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvEstimateDetails.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvEstimateDetails.Rows.Count == 0)
            {

                return;
            }
            dtoTemp = dgvEstimateDetails.Rows[currentMouseOverRow].DataBoundItem as EstimateDetailDTO;
            ipName.Text = dtoTemp.Name;
            if (dtoTemp.MaterialID != 0)
            {
                cbType.SelectedIndex = 0;
                foreach (MaterialDTO dto in cbMaterial.Items)
                {
                    if (dto.MaterialID.Equals(dtoTemp.MaterialID))
                        cbMaterial.SelectedItem = dto;
                }
                ipQuantity.Text = dtoTemp.QuantityEstimate.ToString();
                ipPrice.Text = dtoTemp.UnitCostEstimateFormated;
            }
            else
            {
                cbType.SelectedIndex = 1;
                ipTotal.Text = dtoTemp.TotalCostEstimateFormated;
                
            }
            temID = dtoTemp.MaterialID;
            setDisplay();

        }
        public void setDisplay()
        {
            if (cbType.SelectedIndex == 1)
            {
                cbMaterial.Enabled = false;
                ipQuantity.Enabled = false;
                ipPrice.Enabled = false;
                ipName.Enabled = true;
                ipTotal.ReadOnly = false;



                cbMaterial.SelectedIndex = -1;
                ipQuantity.Text = "";
                ipPrice.Text = "";
                ipTotal.Text = "";
            }
            else
            {
                ipName.Enabled = false;
                cbMaterial.Enabled = true;
                ipQuantity.Enabled = true;
                ipPrice.Enabled = true;
                ipName.Text = "";
                ipTotal.Text = "";
            }

                

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
        // tifm du toan chi tiet
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchMaterial.SelectedIndex > -1)
                _materialId = (cbSearchMaterial.SelectedItem as MaterialDTO).MaterialID;
            resetDataSource(_estimateId, _materialId);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDisplay();
        }

        private void ipPrice_Leave(object sender, EventArgs e)
        {
            ipPrice.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipPrice.Text,"."),".");
        }

        private void ipTotal_MouseLeave(object sender, EventArgs e)
        {
            ipTotal.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipTotal.Text, "."), ".");
        }

        private void ipTotal_Leave(object sender, EventArgs e)
        {
            ipTotal.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipTotal.Text, "."), ".");
        }

      

    }
}