using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private EstimateBUS _estimateBUS = new EstimateBUS();
        ConstructionBus _constructionBus = new ConstructionBus();
        private long _constructionID=-1;
        private EstimateDTO dtoTemp = new EstimateDTO();
        // khoi tao cua so chinh'
        public EstimateManagement()
        {
            initForm();
        }
        //khoi tao tu` man hinh` cong trinh`
        public EstimateManagement(long consID)
        {
            initForm();
            CenterToParent();
            _constructionID = consID;
        }
        //khoi tao chuong trinh
        public void initForm()
        {
           
            InitializeComponent();
            SetLayout();
        }
        private void SetLayout()
        {
            dgvEstimate.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEstimate);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }
        // load du lieu
        private void EstimateManagement_Load(object sender, EventArgs e)
        {
            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember="ConstructionName";
            loadData();
            loadDetailValues(0);
        }
        public void loadData()
        {
            if (_constructionID == -1)
            {
                EstimateDTO dto = new EstimateDTO();
                dto.EstimateName ="";
                search(dto);
            }
            else dgvEstimate.DataSource = _estimateBUS.LoadEstimateByConstruction(_constructionID);
        }
        // tao est
        private void btCreateEst_Click(object sender, EventArgs e)
        {
            AddNewEstimate addForm = new AddNewEstimate();
            addForm.ShowDialog();
            dgvEstimate.DataSource = _estimateBUS.LoadAllEstimates();
        }
        // sua du toan
        private void btEditEst_Click(object sender, EventArgs e)
        {

        }
        // xoa
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstimate.Rows)
            {
                DataGridViewCell c = dgvEstimate.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["EstimateID"].Value.ToString();
                    long EstimateID = Convert.ToInt64(strRightID);
                   
                    
                    _estimateBUS.DeleteEstimate(EstimateID);
                }
            }
            loadData();
        }
        //chon dự toán để xem
        private void dgvEstimate_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvEstimate.HitTest(e.X, e.Y).RowIndex;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvEstimate.Rows.Count == 0 || currentMouseOverRow<0)
            {

                return;
            }
            dtoTemp = dgvEstimate.Rows[currentMouseOverRow].DataBoundItem as EstimateDTO;
            ipEstName.Text = dtoTemp.EstimateName;

        }
        // lưu thông tin dự toán
        private void btSave_Click(object sender, EventArgs e)
        {

            _estimateBUS.UpdateNameEstimate(dtoTemp.EstimateID, ipEstName.Text);
            MessageBox.Show("cập nhật thành công!");
            loadData();
        }
        //xem du toan chi tiet
        private void btViewEst_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvEstimate.Rows)
            {
                DataGridViewCell c = dgvEstimate.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["EstimateID"].Value.ToString();
                    long EstimateID = Convert.ToInt64(strRightID);
                    string sConstructionID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(sConstructionID);
                    EstimateDetail editForm = new EstimateDetail(EstimateID);
                    editForm.ShowDialog();
                }
            }

            loadData();

        }
        //xem du toan chi tiet
        private void btViewDetail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstimate.SelectedRows)
            {
                    string strRightID = row.Cells["EstimateID"].Value.ToString();
                    long EstimateID = Convert.ToInt64(strRightID);
                    EstimateDetail editForm = new EstimateDetail(EstimateID);
                    editForm.ShowDialog();
                
            }

            loadData();
        }
        //fix checkbox
        private void dgvEstimate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvEstimate.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvEstimate[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvEstimate.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvEstimate[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvEstimate.Rows[e.RowIndex].Selected = true;
                }
            }
        }
        // fix checkall box
        private void btSearch_Click(object sender, EventArgs e)
        {
            EstimateDTO dto = new EstimateDTO();
            dto.EstimateName = ipSeacrchName.Text;
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            search(dto);

        }
        public void search(EstimateDTO dto)
        {
            dgvEstimate.DataSource=_estimateBUS.search(dto);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ipEstName.ReadOnly = false;
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            ipEstName.ReadOnly = true;
        }
    }
}
