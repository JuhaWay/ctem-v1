using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private EstimateBUS _estimateBUS = new EstimateBUS();


        private long _constructionID=-1;
        private EstimateDTO dtoTemp = new EstimateDTO();

        public EstimateManagement()
        {
            initForm();
        }
        public EstimateManagement(long consID)
        {
            initForm();
            CenterToParent();
            _constructionID = consID;
        }
        public void initForm()
        {
            InitializeComponent();
        }

        private void EstimateManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            if (_constructionID == -1) dgvEstimate.DataSource = _estimateBUS.LoadAllEstimates();
            else dgvEstimate.DataSource = _estimateBUS.LoadEstimateByConstruction(_constructionID);
        }

        private void btCreateEst_Click(object sender, EventArgs e)
        {
            AddNewEstimate addForm = new AddNewEstimate();
            addForm.ShowDialog();
            dgvEstimate.DataSource = _estimateBUS.LoadAllEstimates();
        }

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
                    EstimateDetail editForm = new EstimateDetail(EstimateID,ConstructionID);
                    editForm.ShowDialog();
                }
            }

            loadData();

        }

        private void btEditEst_Click(object sender, EventArgs e)
        {

        }

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

        private void dgvEstimate_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvEstimate.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow > -1)
            {
                dtoTemp = dgvEstimate.Rows[currentMouseOverRow].DataBoundItem as EstimateDTO;
                ipEstName.Text = dtoTemp.EstimateName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            _estimateBUS.UpdateNameEstimate(dtoTemp.EstimateID, ipEstName.Text);
            MessageBox.Show("cập nhật thành công!");
            loadData();
        }
    }
}
