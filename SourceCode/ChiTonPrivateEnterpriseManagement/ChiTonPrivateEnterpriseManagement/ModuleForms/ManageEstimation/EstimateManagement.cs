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
    }
}
