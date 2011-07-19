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
    public partial class MaterialManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private MaterialBUS _materialBUS = new MaterialBUS();

        private MaterialDTO dtoTemp = new MaterialDTO();
        public MaterialManagement()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            RefreshDataGridSource();
            Global.SetLayoutPanelNewForm(subpaint);
        }
        private void SetLayout()
        {
            dgvMaterials.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvMaterials);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
        }
        
        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewMaterial add = new AddNewMaterial();
            add.ShowDialog();
            RefreshDataGridSource();
        }
        private void RefreshDataGridSource(){
            dgvMaterials.DataSource = _materialBUS.LoadAllMaterials();
        }

        private void dgvMaterials_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvMaterials.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow > -1)
            {
                dtoTemp = dgvMaterials.Rows[currentMouseOverRow].DataBoundItem as MaterialDTO;
                ipName.Text = dtoTemp.MaterialName;
                ipEU.Text = dtoTemp.EstimateCalUnit;
                ipRU.Text = dtoTemp.RealCalUnit;
                ipRatio.Text = dtoTemp.Ratio.ToString();
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            dtoTemp.MaterialName = ipName.Text;
            dtoTemp.MaterialParentID = 0;
            dtoTemp.EstimateCalUnit = ipEU.Text;
            dtoTemp.RealCalUnit = ipRU.Text;
            dtoTemp.Ratio = float.Parse(ipRatio.Text);

            _materialBUS.UpdateMaterials(dtoTemp);
            MessageBox.Show("Cập nhật  thành công");
            RefreshDataGridSource();
        }


        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvMaterials.SelectedRows)
                    {
                        long mID = (row.DataBoundItem as MaterialDTO).MaterialID ;
                            _materialBUS.deleteMaterials(mID);
                    }
                    RefreshDataGridSource();
                }catch(Exception ex){
                    MessageBox.Show("không thể xóa vật liêu đang được sử dụng");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMaterials.DataSource = _materialBUS.search(ipSearchName.Text.Trim());
        }
        private bool validateForm()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (ipEU.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền đơn vị dự toán", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (ipRU.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền đơn vị quyết toán", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (!Global.ValidateDoubleNumber(ipRatio.Text.Trim()))
            {
                KryptonMessageBox.Show("chỉ số quy đổi sai", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
    }
}