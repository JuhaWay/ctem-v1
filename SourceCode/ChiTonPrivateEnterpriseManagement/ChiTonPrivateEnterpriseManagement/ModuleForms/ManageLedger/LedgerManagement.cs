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
            dgvLedger.DataSource = _ledgerBUS.LoadLedgers();
            loadDetailValues(0);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddnewLedger form = new AddnewLedger();
            form.ShowDialog();
            dgvLedger.DataSource = _ledgerBUS.LoadLedgers();
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

                return;
            }
            dtoTemp = dgvLedger.Rows[currentMouseOverRow].DataBoundItem as LedgerDTO;
            ipName.Text = dtoTemp.Name;
            cbType.Text = dtoTemp.Type;
            ipNumber.Text = dtoTemp.Number.ToString();
            ipPerson.Text = dtoTemp.Person;
            ipReason.Text = dtoTemp.Reason;
            cbMethod.Text = dtoTemp.Method;
            dtDate.Value = dtoTemp.Date;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            dtoTemp.Name = ipName.Text;
            dtoTemp.Type = cbType.Text;
            dtoTemp.Number = Convert.ToInt64(ipNumber.Text);
            dtoTemp.Person = ipPerson.Text;
            dtoTemp.Reason = ipReason.Text;
            dtoTemp.Method = cbMethod.Text;
            dtoTemp.Date = dtDate.Value.Date;
            _ledgerBUS.updateLedger(dtoTemp);
            MessageBox.Show("cập nhật thành công!");
            dgvLedger.DataSource = _ledgerBUS.LoadLedgers();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa thông tin ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvLedger.Rows)
                {
                    DataGridViewCell c = dgvLedger.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strID = row.Cells["LedgerID"].Value.ToString();
                        long id = Convert.ToInt64(strID);
                        _ledgerBUS.delete(id);
                    }
                }
                dgvLedger.DataSource = _ledgerBUS.LoadLedgers();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LedgerDTO dto = new LedgerDTO();
            dto.Name = ipSearchName.Text.Trim();
            dto.Type = cbSearchType.Text.Trim();
            dto.Person = ipSearchPerson.Text.Trim();
            dgvLedger.DataSource=_ledgerBUS.LedgerSearch(dto);
        }
    }
}