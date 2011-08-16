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
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class CompareDetailForm : KryptonForm
    {
        private long _id;
        private long _totalcost;
        private bool _isNew;
        private List<CompareDebtDetailDTO> _listDetail;
        public long totalPayed;
        readonly DebtBUS _debtBus = new DebtBUS();
        public CompareDetailForm(long id, long totalcost)
        {
            InitializeComponent();
            _id = id;
            _totalcost = totalcost;
            _isNew = true;
        }

        private void CompareDetailForm_Load(object sender, EventArgs e)
        {
            Setlayout();
            LoadData();            
        }

        private void Setlayout()
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutSplipContainer(kryptonSplitContainer1, 1);
            Global.SetLayoutHeaderGroup(hd1, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hd2, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvCompareDetail);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox1);
            Global.SetLayoutGroupBoxButton(kryptonGroupBox2);            
            ClearLayout();
        }

        private void LoadData()
        {
            _listDetail = _debtBus.GetCompareDebtDetail(_id);
            dgvCompareDetail.DataSource = _listDetail;
            totalPayed = 0;
            foreach (CompareDebtDetailDTO detailDTO in _listDetail)
            {

                totalPayed += detailDTO.Payed;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
            _isNew = true;
        }

        private void ClearLayout()
        {
            dtpDatepay.Value = DateTime.Today;
            txtNamePerson.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
            txtPayed.Text = Constants.ZERO_NUMBER;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nameperson = txtNamePerson.Text;
            string note = txtNote.Text;
            DateTime datePay = dtpDatepay.Value;
            long payed = Global.ConvertMoneyToLong(txtPayed.Text, Constants.SPLIP_MONEY);
            if ((totalPayed + payed) > _totalcost)
            {
                if (KryptonMessageBox.Show(String.Format("Bạn Trả Vượt Số Nợ\nBạn Có Muốn Trả Đúng Số Nợ Còn Lại Là {0} (VND) Hay Không?", Global.ConvertLongToMoney(_totalcost - totalPayed, Constants.SPLIP_MONEY)), Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    payed = _totalcost - totalPayed;
                    txtPayed.Text = Global.ConvertLongToMoney(payed, Constants.SPLIP_MONEY);
                }
                else
                {
                    txtPayed.Text = Constants.ZERO_NUMBER;
                    return;
                }
            }
            
            CompareDebtDetailDTO detailDTO = new CompareDebtDetailDTO()
                                                 {
                                                     ComparationDebtID = _id,
                                                     RepresentationDebtName = nameperson,
                                                     Note = note,
                                                     Payed = payed,
                                                     DatePay = datePay
                                                 };
            if (_isNew)
            {
                bool success = _debtBus.CreateCompareDetail(detailDTO);
                if (success)
                {
                    KryptonMessageBox.Show("Đã Tạo Mới Thành Công!", Constants.CONFIRM, MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    ClearLayout();
                }
            }
            else
            {
                detailDTO.DetailID = Convert.ToInt64(dgvCompareDetail.SelectedRows[0].Cells[""].Value);
                bool success = _debtBus.UpdateCompareDetail(detailDTO);
                if (success)
                {
                    KryptonMessageBox.Show("Đã Sửa Đổi Thành Công!", Constants.CONFIRM, MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);                    
                }
            }
            LoadData();
        }

        private void txtPayed_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtPayed);            
        }

        private void txtPayed_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtPayed);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _debtBus.DeleteDebtCompareDetail(Convert.ToInt64(dgvCompareDetail.SelectedRows[0].Cells[""].Value));
        }

        private void dgvCompareDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CompareDebtDetailDTO detailDTO = dgvCompareDetail.SelectedRows[0].DataBoundItem as CompareDebtDetailDTO;
                txtNamePerson.Text = detailDTO.RepresentationDebtName;
                txtNote.Text = detailDTO.Note;
                txtPayed.Text = detailDTO.PayedFormat;
                dtpDatepay.Value = detailDTO.DatePay;
                _isNew = false;
            }
        }
    }
}