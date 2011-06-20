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
            RefreshDataGridSource();
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
            dtoTemp.MaterialName = ipName.Text;
            dtoTemp.MaterialParentID = 0;
            dtoTemp.EstimateCalUnit = ipEU.Text;
            dtoTemp.RealCalUnit = ipRU.Text;
            dtoTemp.Ratio = float.Parse(ipRatio.Text);

            _materialBUS.UpdateMaterials(dtoTemp);
            MessageBox.Show("Cập nhật  thành công");
            RefreshDataGridSource();
        }

        private void dgvMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvMaterials.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvMaterials[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvMaterials.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvMaterials[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvMaterials.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvMaterials.Rows)
                    {
                        DataGridViewCell c = dgvMaterials.Rows[row.Index].Cells[0];
                        if (c.AccessibilityObject.Value.Equals("True"))
                        {
                            string strID = row.Cells["MaterialID"].Value.ToString();
                            long mID = Convert.ToInt64(strID);
                            _materialBUS.deleteMaterials(mID);
                        }
                    }
                    RefreshDataGridSource();
                }catch(Exception ex){
                    MessageBox.Show("không thể xóa vật liêu đang được sử dụng");
                }
            }

        }
    }
}