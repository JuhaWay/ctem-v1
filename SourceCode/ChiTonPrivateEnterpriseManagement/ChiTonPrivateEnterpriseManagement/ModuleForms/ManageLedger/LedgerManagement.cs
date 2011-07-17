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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger
{
    public partial class LedgerManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private LedgerBUS _ledgerBUS = new LedgerBUS();
        private LedgerDTO dtoTemp = new LedgerDTO();
        public LedgerManagement()
        {
            InitializeComponent();
        }

        private void LedgerManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            refresh();
        }
        private void SetLayout()
        {
            dgvLedger.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvLedger);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddnewLedger form = new AddnewLedger();
            form.ShowDialog();
            refresh();
        }

        public void refresh()
        {
            LedgerDTO dto = new LedgerDTO();
            dto.Name = ipSearchName.Text.Trim();
            dto.Type = cbSearchType.Text.Trim();
            dto.Person = ipSearchPerson.Text.Trim();
            dgvLedger.DataSource = _ledgerBUS.LedgerSearch(dto);
            loadDetailValues(0);
        }

        private void dgvLedger_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvLedger.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvLedger.Rows.Count == 0)
            {
                reset();
                dtoTemp = null;
                return;
            }
            dtoTemp = dgvLedger.Rows[currentMouseOverRow].DataBoundItem as LedgerDTO;
            ipName.Text = dtoTemp.Name;
            cbType.Text = dtoTemp.Type;
            ipNumber.Text = dtoTemp.NumberFormated;
            ipPerson.Text = dtoTemp.Person;
            ipReason.Text = dtoTemp.Reason;
            cbMethod.Text = dtoTemp.Method;
            dtDate.Value = dtoTemp.Date;

        }

        public void reset()
        {
            ipName.Text = "";
            cbType.Text = "";
            ipNumber.Text = "";
            ipPerson.Text = "";
            ipReason.Text = "";
            cbMethod.Text = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (dtoTemp == null) return;
            if (!validateForm()) return;
            dtoTemp.Name = ipName.Text;
            dtoTemp.Type = cbType.Text;
            dtoTemp.Number = Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP);
            dtoTemp.Person = ipPerson.Text;
            dtoTemp.Reason = ipReason.Text;
            dtoTemp.Method = cbMethod.Text;
            dtoTemp.Date = dtDate.Value.Date;
            _ledgerBUS.updateLedger(dtoTemp);
            MessageBox.Show("cập nhật thành công!");
            refresh();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa thông tin ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvLedger.SelectedRows)
                {

                    long id = (row.DataBoundItem as LedgerDTO).LedgerID;
                        _ledgerBUS.delete(id);
                }
                refresh();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private bool validateForm()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (cbType.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn loại", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (!Global.ValidateMoney(ipNumber))
            {
                KryptonMessageBox.Show("Nhập sai số tiền", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (cbMethod.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn hình thức", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ipNumber_MouseLeave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }

        private void ipNumber_Leave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }
    }
}