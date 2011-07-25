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
    public partial class Disbursement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private ConstructionBus _constructionBus = new ConstructionBus();
        List<DisbursementDTO> _list = new List<DisbursementDTO>();
        private long _DisbursementProgressID = 0;
        private long _constructionID = 0;
        public Disbursement(long DisbursementProgressID,long constructionID)
        {
            InitializeComponent();
            CenterToScreen();
            _DisbursementProgressID = DisbursementProgressID;
            _constructionID = constructionID;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DisbursementDTO dto = new DisbursementDTO();
            dto.NumberFormated = ipNumber.Text;
            dto.Date = dtDate.Value.Date;
            dto.OthersCostFormated = ipOthersCost.Text;
            dto.Reason = cbReason.Text.Trim();
            dto.Note = ipNote.Text;
            dto.Taker = ipTakers.Text;
            _list.Add(dto);
            dgvDisbur.DataSource = null;
            dgvDisbur.DataSource = _list; 
        }

        private void Disbursement_Load(object sender, EventArgs e)
        {
            loadData();
        }


        public void loadData()
        {
            _list = _constructionBus.LoadAllDisbursement(_DisbursementProgressID,_constructionID);
            if(_list!=null && _list.Count>0)   dgvDisbur.DataSource = _list;
            
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDisbur.SelectedRows)
            {
                _list.Remove(row.DataBoundItem as DisbursementDTO);
            }
            dgvDisbur.DataSource = null;
            dgvDisbur.DataSource = _list;
        }

       
        private void btSaveRoad_Click(object sender, EventArgs e)
        {
            _constructionBus.DeleteDisbursement(_DisbursementProgressID,_constructionID);
            foreach(DisbursementDTO dto in _list){
                dto.DisbursementProgressID = _DisbursementProgressID;
                dto.ConstructionID = _constructionID;
                dto.Number = Global.ConvertMoneyToLong(dto.NumberFormated, Global.SEP);
                dto.OthersCost = Global.ConvertMoneyToLong(dto.OthersCostFormated, Global.SEP);
                 _constructionBus.CreateDisbursement(dto);

            }
            this.Close();
        }
        private void ipNumber_Leave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }

        private void ipNumber_MouseLeave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }

        private void ipOthersCost_MouseLeave(object sender, EventArgs e)
        {
            ipOthersCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipOthersCost.Text, Global.SEP), Global.SEP);
        }

        private void ipOthersCost_Leave(object sender, EventArgs e)
        {
            ipOthersCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipOthersCost.Text, Global.SEP), Global.SEP);
        }

    }
}