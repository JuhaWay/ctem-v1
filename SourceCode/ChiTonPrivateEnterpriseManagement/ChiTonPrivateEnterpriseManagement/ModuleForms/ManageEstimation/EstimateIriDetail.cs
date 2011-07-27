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
    public partial class EstimateIriDetail : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private EstimateIriDetailDTO dtoTemp = new EstimateIriDetailDTO();
        private long _estimateID = 0;
        public EstimateIriDetail(long estimateID)
        {
            InitializeComponent();
            CenterToScreen();
            _estimateID = estimateID;
        }

        private void EstimateIriDetail_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);
            Global.SetLayoutPanelNewForm(kryptonPanel);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);
            LoadForm();
        }

        public void LoadForm(){
            dtoTemp = _estimateDetailBUS.LoadOneEstimateIriDetailByEst(_estimateID, EstimateIriDetailDTO.TYPE_EST);
            if (dtoTemp != null)
            {
                ipNumber.Text = Global.ConvertLongToMoney(dtoTemp.TotalCost, Global.SEP);
                ipWeight.Text = dtoTemp.Weight.ToString();
                ipLength.Text = dtoTemp.Length.ToString(); ;
                ipHoles.Text = dtoTemp.Containers.ToString();
                ipNote.Text = dtoTemp.Note;
            }
            else dtoTemp = new EstimateIriDetailDTO();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            if (KryptonMessageBox.Show("Bạn có muốn lưu thông tin", Constants.CONFIRM, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtoTemp.TotalCost = Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP);
                if (!ipWeight.Text.Trim().Equals(""))
                    dtoTemp.Weight = Convert.ToDouble(ipWeight.Text);
                else dtoTemp.Weight = 0;
                if (!ipLength.Text.Trim().Equals(""))
                    dtoTemp.Length = Convert.ToDouble(ipLength.Text);
                else dtoTemp.Length = 0;
                if (!ipHoles.Text.Trim().Equals(""))
                    dtoTemp.Containers = Convert.ToInt64(ipHoles.Text);
                else dtoTemp.Containers = 0;
                dtoTemp.Note = ipNote.Text;
                dtoTemp.Date = DateTime.Today ;
                dtoTemp.Reporter = "";
                if (dtoTemp.EstimateIriDetailID != 0)
                    _estimateDetailBUS.UpdateEstimateDetailIri(dtoTemp);
                else
                {
                    dtoTemp.EstimateID = _estimateID;
                    _estimateDetailBUS.CreateEstimateDetailIri(dtoTemp);
                }
                this.Close();
            }
        }

        public bool validate()
        {
            if (!Global.ValidateMoney(ipNumber))
            {
                KryptonMessageBox.Show("Sai thông tin số tiền", Constants.CONFIRM, MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipWeight.Text.Trim().Equals("")&&!Global.ValidateDoubleNumber(ipWeight.Text))
            {
                KryptonMessageBox.Show("Sai thông tin khối lượng", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipLength.Text.Trim().Equals("") && !Global.ValidateDoubleNumber(ipLength.Text))
            {
                KryptonMessageBox.Show("Sai thông tin chiều dài", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            else if (!ipHoles.Text.Trim().Equals("") && !Global.ValidateLongNumber(ipHoles.Text))
            {
                KryptonMessageBox.Show("Sai thông tin số bể", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}