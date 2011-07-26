using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class ProgressIriManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private long _estimateID = 0;
        public ProgressIriManagement(long estimateID)
        {
            InitializeComponent();
            CenterToScreen();
            _estimateID = estimateID;

        }

        private void ProgressIriManagement_Load(object sender, EventArgs e)
        {
            loadEstimate();
            loadReal();
        }

        public void loadEstimate()
        {
            EstimateIriDetailDTO dtoTemp = _estimateDetailBUS.LoadOneEstimateIriDetailByEst(_estimateID, EstimateIriDetailDTO.TYPE_EST);
            lbEstTotal.Text = Global.ConvertLongToMoney(dtoTemp.TotalCost, Global.SEP);
            lbEstWeight.Text = dtoTemp.Weight.ToString();
            lbEstLength.Text = dtoTemp.Length.ToString();
            lbEstContainers.Text = dtoTemp.Containers.ToString();
        }
        public void loadReal()
        {
            List<EstimateIriDetailDTO> dtoTemps = _estimateDetailBUS.LoadAllEstimateIriDetailsByEst(_estimateID, EstimateIriDetailDTO.TYPE_REAL);
            dgv.DataSource = dtoTemps;
            EstimateIriDetailDTO dtoTemp = new EstimateIriDetailDTO();
            foreach (EstimateIriDetailDTO item in dtoTemps)
            {
                dtoTemp.Weight += item.Weight;
                dtoTemp.Length += item.Length;
                dtoTemp.Containers += item.Containers;
                if (dtoTemps.IndexOf(item) == (dtoTemps.Count - 1))
                    dtoTemp.Progress = item.Progress;
            }
            
            lbRealWeight.Text = dtoTemp.Weight.ToString();
            lbRealLengh.Text = dtoTemp.Length.ToString();
            lbRealContainer.Text = dtoTemp.Containers.ToString();
            lbCurrentProgress.Text = dtoTemp.Progress.ToString();
        }

        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            if(!validate())return;
            EstimateIriDetailDTO Entity = new EstimateIriDetailDTO();
            if (!ipEWeight.Text.Trim().Equals(""))
                Entity.Weight = Convert.ToDouble(ipEWeight.Text);
            else Entity.Weight = 0;
            if (!ipELength.Text.Trim().Equals(""))
                Entity.Length = Convert.ToDouble(ipELength.Text);
            else Entity.Length = 0;
            if (!ipEcontainer.Text.Trim().Equals(""))
                Entity.Containers = Convert.ToInt64(ipEcontainer.Text);
            else Entity.Containers = 0;
            Entity.Note = ipEnote.Text;
            Entity.Progress = Convert.ToInt32(ipEProgress.Text);
            Entity.Date = dtEDate.Value.Date;
            Entity.EstimateID = _estimateID;
            Entity.Reporter = ipEreporter.Text;
            Entity.Type = EstimateIriDetailDTO.TYPE_REAL;
            _estimateDetailBUS.CreateEstimateDetailIri(Entity);
            loadReal();

        }
        public bool validate()
        {
            if (!ipEWeight.Text.Trim().Equals("") && !Global.ValidateDoubleNumber(ipEWeight.Text))
            {
                KryptonMessageBox.Show("Sai thông tin khối lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipELength.Text.Trim().Equals("") && !Global.ValidateDoubleNumber(ipELength.Text))
            {
                KryptonMessageBox.Show("Sai thông tin chiều dài", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipEcontainer.Text.Trim().Equals("") && !Global.ValidateLongNumber(ipEcontainer.Text))
            {
                KryptonMessageBox.Show("Sai thông tin số bể", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!Global.ValidateInputNumber(ipEProgress.Text))
            {
                    KryptonMessageBox.Show("Sai thông tin tiến độ", Constants.CONFIRM, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
            }

            return true;
        }
    }
}