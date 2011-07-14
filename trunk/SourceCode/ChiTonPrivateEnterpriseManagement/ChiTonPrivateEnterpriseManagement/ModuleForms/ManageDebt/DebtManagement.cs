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
    public partial class DebtManagement : KryptonForm
    {
        private List<DebtDTO> _listDebt;
        private readonly DebtBUS _debtBus = new DebtBUS();

        public DebtManagement()
        {
            InitializeComponent();
        }

        private void DebtManagement_Load(object sender, EventArgs e)
        {            
            SetLayout();
            RefreshData();
        }

        private void SetLayout()
        {
            dgvDebt.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtDebtId.ReadOnly = true;
            txtTotalOwe.Text = Constants.ZERO_NUMBER;
            txtIdSearch.Text = Constants.ZERO_NUMBER;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvDebt);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetDataCombobox(cbbStatus, "Status");
            Global.SetDataCombobox(cbbStatusSearch, "Status Search");            
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.TextBoxRequireInput(txtDebtName);
            MakeEdit(false);
        }

        private void LoadData()
        {
            Global.SetTextBoxNumberLeave(txtIdSearch);
            long id = Convert.ToInt64(txtIdSearch.Text);
            string name = cbbNameSearch.Text;
            if (name.Equals("Tất Cả"))
            {
                name = Constants.EMPTY_TEXT;
            }
            int status;
            if (cbbStatusSearch.Text.Equals(Constants.ACTIVE))
            {
                status = 1;
            }
            else if (cbbStatusSearch.Text.Equals(Constants.INACTIVE))
            {
                status = 0;
            }
            else
            {
                status = -1;
            }
            _listDebt = _debtBus.GetDebt(id, name, status);
            dgvDebt.DataSource = _listDebt;
        }

        private void RefreshData()
        {
            Global.SetDataCombobox(cbbNameSearch, "Debt Search");
            txtIdSearch.Text = Constants.ZERO_NUMBER;
            cbbNameSearch.SelectedIndex = 0;
            cbbStatusSearch.SelectedIndex = 1;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newDebt = new NewDebt();
            newDebt.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            txtIdSearch.Text = Constants.ZERO_NUMBER;
            cbbNameSearch.SelectedIndex = 0;
            cbbStatusSearch.SelectedIndex = 0;
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvDebt.SelectedRows)
                {
                    long debtId = Convert.ToInt64(row.Cells["DebtID"].Value.ToString());
                    success = _debtBus.DeleteDebt(debtId);
                    
                }
                KryptonMessageBox.Show(success ? Constants.DELETE_SUCESS : Constants.ERROR);
                RefreshData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETEALL, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _debtBus.DeleteAll();
                if (success)
                {
                    KryptonMessageBox.Show(Constants.DELETE_SUCESS);
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR);
                }
            }
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            MakeEdit(true);
            txtDebtName.Focus();
        }

        private void MakeEdit(bool edit)
        {
            txtAddress.ReadOnly = !edit;
            txtDebtName.ReadOnly = !edit;
            txtDescription.ReadOnly = !edit;
            txtPhonenumber.ReadOnly = !edit;
            txtTotalOwe.ReadOnly = !edit;
            cbbStatus.Enabled = edit;
            btnSave.Enabled = edit ? ButtonEnabled.True : ButtonEnabled.False;
            cmsEdit.Items[2].Enabled = edit;
        }

        private void dgvDebt_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = ButtonEnabled.True;
            cmsDGV.Items[3].Enabled = true;
            DataGridViewRow r = dgvDebt.Rows[e.RowIndex];
            long debtId = Convert.ToInt64(r.Cells["DebtID"].Value.ToString());
            string debtName = Convert.ToString(r.Cells["DebtName"].Value.ToString());
            string address = Convert.ToString(r.Cells["Address"].Value.ToString());
            string totalDebt = r.Cells["TotalOwe"].Value.ToString();
            string note = Convert.ToString(r.Cells["Note"].Value.ToString());
            string phoneNumber = Convert.ToString(r.Cells["PhoneNumber"].Value.ToString());
            int isactive = Convert.ToInt32(r.Cells["IsActive"].Value.ToString());
            FillDataEdit(debtId, debtName, address, phoneNumber, totalDebt, note, isactive);
        }

        private void FillDataEdit(long debtId, string name, string address, string phone, string totalDebt, string note, int isactive)
        {
            txtDebtId.Text = debtId.ToString();            
            txtAddress.Text = address;
            txtDebtName.Text = name;
            txtTotalOwe.Text = totalDebt;
            txtDescription.Text = note;
            txtPhonenumber.Text = phone;
            if (isactive == 1)
            {
                cbbStatus.SelectedIndex = 0;
            }
            else
            {
                cbbStatus.SelectedIndex = 1;
            }
        }

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            MakeEdit(false);
            dgvDebt.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                long debtId = Convert.ToInt64(txtDebtId.Text);
                string debtName = txtDebtName.Text;
                string address = txtAddress.Text;
                long totalDebt = Global.ConvertMoneyToLong(txtTotalOwe.Text, ".");
                string note = txtDescription.Text;
                string phoneNumber = txtPhonenumber.Text;
                int isactive = cbbStatus.Text.Equals(Constants.ACTIVE) ? 1 : 0;
                var debt = new DebtDTO()
                               {
                                   DebtID = debtId,
                                   DebtName = debtName,
                                   Address = address,
                                   TotalOwe = totalDebt,
                                   Note = note,
                                   PhoneNumber = phoneNumber,
                                   IsActive = isactive
                               };
                bool success = _debtBus.Update(debt);
                KryptonMessageBox.Show(success ? Constants.UPDATE_SUCCESS : Constants.ERROR, Constants.ANNOUNCE);
                RefreshData();
            }
            else
            {
                string errors = "";
                foreach (string error in Global.ListError)
                {
                    errors += ("* " + error + "\n");
                }
                KryptonMessageBox.Show(errors, Constants.ALERT_ERROR);
                txtDebtName.Focus();
            }
        }

        private bool ValidateInput()
        {
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            Global.ListError.Clear();
            if (Global.ValidateNotEmptyText(txtDebtName) && Global.ValidatePhoneNumber(txtPhonenumber))
            {
                return true;
            }
            return false;
        }

        private void txtTotalOwe_Leave(object sender, EventArgs e)
        {
            var texBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberLeave(texBox);            
        }

        private void txtTotalOwe_Enter(object sender, EventArgs e)
        {
            var textBox = sender as KryptonTextBox;
            Global.SetTextBoxNumberEnter(textBox);
        }

        private void GenMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch
            {
            }
        }

        private void dgvDebt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = ButtonEnabled.False;
            cmsDGV.Items[3].Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtIdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;                
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
            txtIdSearch.Focus();
        }

        private void HideSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            txtIdSearch.Focus();
        }

        private void txtPhonenumber_Leave(object sender, EventArgs e)
        {
            if (Global.ValidateNotEmptyText(txtPhonenumber) && Global.ValidatePhoneNumber(txtPhonenumber))
            {
                txtPhonenumber.Text = Global.FomatPhoneNumber(txtPhonenumber.Text);                
            }
        }

        private void txtDebtName_TextChanged(object sender, EventArgs e)
        {
            if (txtDebtName.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.TextBoxRequireInput(txtDebtName);
            }
            else
            {
                Global.TextBoxRequireInputed(txtDebtName);
            }
        }

    }
}