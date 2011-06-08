using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private EstimateBUS _estimateBUS = new EstimateBUS();

        public EstimateManagement()
        {
            InitializeComponent();
        }

        private void EstimateManagement_Load(object sender, EventArgs e)
        {
            dgvEstimate.DataSource = _estimateBUS.LoadAllEstimates();
        }

        private void btCreateEst_Click(object sender, EventArgs e)
        {
            AddNewEstimate addForm = new AddNewEstimate();
            addForm.ShowDialog();
        }

        private void btViewEst_Click(object sender, EventArgs e)
        {
            EstimateDetail esDetail = new EstimateDetail();
            esDetail.ShowDialog();
        }
    }
}
