using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class estDetailForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private bool isEdit;
        private bool isNew;
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
        public estDetailForm(long estimateId)
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
            SetLayout();
            btnNew_Click(null, null);
            btnHideShowSearch_Click(null, null);            
        }
        private void SetLayout()
        {
            ipTotal.ReadOnly = true;
            dgvEstimateDetails.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEstimateDetails);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutSplipContainer(slcMain, 1);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);            
            Global.SetTextBoxNumberLeave(ipQuantity);
            Global.SetTextBoxMoneyLeave(ipPrice);
            Global.SetTextBoxMoneyLeave(ipTotal);
        }
        // load lại dử liệu
        public void resetDataSource(long estimateId,long materialId)
        {
            List<EstimateDetailDTO> list = _estimateDetailBUS.search(estimateId, materialId);
            dgvEstimateDetails.DataSource = list;
        }
        
        // sưa dự toán chi tiết
        private void btSave_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                dtoTemp.Name = ipName.Text;
                if (cbType.SelectedIndex == 0)
                {
                    if (ValidateInput())
                    {
                        if (cbMaterial.SelectedIndex < 0)
                        {
                            MessageBox.Show("Vui lòng chọn Vật liệu");
                            return;
                        }

                        if (!validateQuantity(ipQuantity.Text)) return;
                        dtoTemp.QuantityEstimate = Convert.ToDouble(ipQuantity.Text);
                        dtoTemp.UnitCostEstimate = Global.ConvertMoneyToLong(ipPrice.Text, Constants.SPLIP_MONEY);
                        dtoTemp.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                        dtoTemp.UnitCostEstimateFormated = ipPrice.Text;
                    }
                    else
                    {
                        KryptonMessageBox.Show("Kiểm Tra Các Con Số Đã Nhập", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (ipName.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Vui lòng nhập chi tiết");
                        return;
                    }
                    dtoTemp.QuantityEstimate = 0;
                    dtoTemp.UnitCostEstimate = 0;
                    dtoTemp.MaterialID = 0;
                }
                dtoTemp.TotalCostEstimate = Global.ConvertMoneyToLong(ipTotal.Text, Constants.SPLIP_MONEY);
                dtoTemp.TotalCostEstimateFormated = ipTotal.Text;
                if (temID != dtoTemp.MaterialID && _estimateDetailBUS.check(dtoTemp.MaterialID, dtoTemp.EstimateID))
                {
                    MessageBox.Show("Vật liệu này đã tồn tại !");
                    return;
                }
                _estimateDetailBUS.UpdateEstimateDetail(dtoTemp);
                MessageBox.Show("Cập nhật thành công!");
                resetDataSource(_estimateId, _materialId);
            }
            if (isNew)
            {
                EstimateDetailDTO entity = new EstimateDetailDTO();
                entity.Name = ipName.Text;
                entity.EstimateID = _estimateId;
                if (cbType.SelectedIndex == 0)
                {
                    if(ValidateInput())
                    {
                        if (cbMaterial.SelectedIndex < 0)
                        {
                            MessageBox.Show("Vui lòng chọn Vật liệu");
                            return;
                        }

                        if (!validateQuantity(ipQuantity.Text)) return;
                        entity.QuantityEstimate = Convert.ToDouble(ipQuantity.Text);
                        entity.UnitCostEstimate = Global.ConvertMoneyToLong(ipPrice.Text, Constants.SPLIP_MONEY);
                        entity.MaterialID = (cbMaterial.SelectedItem as MaterialDTO).MaterialID;
                        entity.MaterialName = (cbMaterial.SelectedItem as MaterialDTO).MaterialName;
                        entity.UnitCostEstimateFormated = ipPrice.Text;
                    }
                    else
                    {
                        KryptonMessageBox.Show("Kiểm Tra Các Con Số Đã Nhập", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (ipName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập chi tiết");
                    return;
                }
                entity.TotalCostEstimate = Global.ConvertMoneyToLong(ipTotal.Text, Constants.SPLIP_MONEY);
                entity.TotalCostEstimateFormated = ipTotal.Text;
                if (_estimateDetailBUS.check(entity.MaterialID, entity.EstimateID))
                {
                    MessageBox.Show("Vật liệu này đã tồn tại !");
                    return;
                }
                _estimateDetailBUS.CreateEstimateDetail(entity);
                resetDataSource(_estimateId, _materialId);
                btnNew_Click(null, null);
                cbType.Focus();
                }
            _estimateBUS.UpdateEstimate(_estimateId);
            //

        }

        private bool ValidateInput()
        {
            if ((Global.ConvertMoneyToLong(ipPrice.Text, Constants.SPLIP_MONEY) > 0 || Convert.ToDouble(ipQuantity.Text) > 0) && Global.ConvertMoneyToLong(ipTotal.Text, Constants.SPLIP_MONEY) <= 0)
            {
                return false;
            }
            return true;
        }

        // chọn nguyên vật liệu
        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialDTO dto = cbMaterial.SelectedItem as MaterialDTO;
            if (dto!=null) btnCalUnit.Text = "(" + dto.EstimateCalUnit + ")";
        }
        
        // xóa dư toán chi tiết 
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEstimateDetails.SelectedRows.Count > 0)
            {
                KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM);
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
            else
            {
                KryptonMessageBox.Show("Phải Chọn Đối Tượng Trước Khi Xóa", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
        }
                        
        //chọn để xem chi tiết
        private void dgvEstimateDetails_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvEstimateDetails.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
            isNew = false;
            isEdit = true;
            LayoutEdit();
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
                ipTotal.Text = dtoTemp.TotalCostEstimateFormated;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            isEdit = false;
            ClearLayout();
            cbType.Focus();
        }

        private void ClearLayout()
        {
            cbType.Enabled = true;
            cbType.SelectedIndex = 0;
            if (cbMaterial.Items.Count > 0)
            {
                cbMaterial.SelectedIndex = 0;
            }
            cbMaterial.Enabled = true;
            ipQuantity.Text = Constants.ZERO_NUMBER;
            ipPrice.Text = Constants.ZERO_NUMBER;
            ipTotal.Text = Constants.ZERO_NUMBER;
            ipQuantity.ReadOnly = false;
            ipPrice.ReadOnly = false;
            ipTotal.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNew = false;
            isEdit = true;
            LayoutEdit();
            ipQuantity.Focus();
        }
        private void LayoutEdit()
        {
            cbType.Enabled = false;
            cbMaterial.Enabled = false;
            ipQuantity.ReadOnly = false;
            ipPrice.ReadOnly = false;
            if (cbType.SelectedIndex == 0)
            {
                ipTotal.ReadOnly = false;
            }
            else
            {
                ipTotal.ReadOnly = true;
            }
        }

        private void ipQuantity_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(ipQuantity);
        }

        private void ipQuantity_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxDoubleLeave(ipQuantity);
            try
            {
                if (Convert.ToDouble(ipQuantity) < 0)
                {
                    ipQuantity.Text = Constants.ZERO_NUMBER;
                };
            }
            catch
            {
            }
        }

        private void ipPrice_Enter(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void ipPrice_Leave(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxMoneyLeave(textBox);
            try
            {
                if (Convert.ToDouble(ipQuantity) < 0)
                {
                    ipQuantity.Text = Constants.ZERO_NUMBER;
                };
            }
            catch
            {
            }
        }

        private void ipTotal_Enter(object sender, EventArgs e)
        {
            if (ipQuantity.Enabled && ipPrice.Enabled)
            {
                if (ipPrice.Text.Equals(Constants.ZERO_NUMBER) || ipQuantity.Text.Equals(Constants.ZERO_NUMBER))
                {
                    ipTotal.Text = Constants.EMPTY_TEXT;
                }
                else
                {
                    ipTotal.Text = Global.ConvertLongToMoney((long)(Global.ConvertMoneyToLong(ipPrice.Text, Constants.SPLIP_MONEY) *
                                   Convert.ToDouble(ipQuantity.Text)), Constants.SPLIP_MONEY);
                }
            }
        }

        private void cbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSave_Click(null, null);
            }
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
        }

        private void cbMaterial_Leave(object sender, EventArgs e)
        {
            MaterialBUS matBus = new MaterialBUS();
            List<MaterialDTO> listMaterial = matBus.LoadAllMaterials();
            bool isExist = false;            
            string nameMaterial = cbMaterial.Text;
            for (int i = 0; i < listMaterial.Count; i++)
            {
                MaterialDTO materialDTO = listMaterial[i];
                if (materialDTO.MaterialName.Equals(nameMaterial))
                {
                    isExist = true;
                    i = listMaterial.Count;
                }
            }
            if (!isExist)
            {
                if(KryptonMessageBox.Show(Constants.NOT_EXIST_MATERIAL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddNewMaterial newMaterial = new AddNewMaterial(nameMaterial);
                    newMaterial.ShowDialog();
                    listMaterial = matBus.LoadAllMaterials();
                    Global.SetDataCombobox(cbMaterial, "Material");
                    cbMaterial.SelectedIndex = listMaterial.Count - 1;
                }
                else
                {
                    cbMaterial.Focus();
                }
            }          
        }

        private void GenMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch
            {
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
            cbSearchMaterial.Focus();
        }

        private void HideSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            dgvEstimateDetails.Focus();
        }

        private void cbSearchMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }

        private void ipQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!ipQuantity.Text.Equals(Constants.EMPTY_TEXT))
            {
                if (!Global.ValidateDoubleNumber(ipQuantity.Text))
                {
                    KryptonMessageBox.Show(Constants.INPUT_NUMBER_ONLY, Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                    ipQuantity.Text = Constants.ZERO_NUMBER;
                    ipQuantity.Focus();
                }
            }
        }

        private void ipTotal_TextChanged(object sender, EventArgs e)
        {
            if (!ipTotal.Text.Equals(Constants.ZERO_NUMBER) && !ipTotal.Text.Equals(Constants.EMPTY_TEXT))
            {
                if (Global.ConvertMoneyToLong(ipTotal.Text, Constants.SPLIP_MONEY) == 0)
                {
                    KryptonMessageBox.Show(Constants.INPUT_NUMBER_ONLY, Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                    ipTotal.Text = Constants.ZERO_NUMBER;
                    ipTotal.Focus();
                }
            }            
        }

        private void ipPrice_TextChanged(object sender, EventArgs e)
        {
            if (!ipPrice.Text.Equals(Constants.ZERO_NUMBER) && !ipPrice.Text.Equals(Constants.EMPTY_TEXT))
            {
                if (Global.ConvertMoneyToLong(ipPrice.Text, Constants.SPLIP_MONEY) == 0)
                {
                    KryptonMessageBox.Show(Constants.INPUT_NUMBER_ONLY, Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                    ipPrice.Text = Constants.ZERO_NUMBER;
                    ipPrice.Focus();
                }
            }            
        }
    }
}