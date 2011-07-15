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
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class NewCompareDebt : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private readonly DebtBUS _debtBus = new DebtBUS();
        public NewCompareDebt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                long debtId = Global.GetDataCombobox(cbbDebt, Constants.DEBT);
                string representationDebtName = txtRepresentationDebtName.Text;
                var compareDate = dtpDateCompare.Value;
                var fromDate = dtpFromDate.Value;
                var toDate = dtpToDate.Value;
                long totalOwe = Global.ConvertMoneyToLong(txtTotalOwe.Text, ".");
                string note = txtNote.Text;
                var compareDebtDto = new CompareDebtDTO()
                {
                    DebtID = debtId,
                    RepresentationDebtName = representationDebtName,
                    DateCompare = compareDate,
                    FromDate = fromDate,
                    ToDate = toDate,
                    TotalOwe = totalOwe,
                    Note = note
                };
                bool success = _debtBus.Create(compareDebtDto);
                KryptonMessageBox.Show(success ? Constants.CREATE_SUCCESS : Constants.ERROR, Constants.ANNOUNCE);
                ClearLayout();
            }
            else
            {
                string errors = "";
                foreach (string error in Global.ListError)
                {
                    errors += ("* " + error + "\n");
                }
                KryptonMessageBox.Show(errors, Constants.ALERT_ERROR);
                dtpDateCompare.Focus();
            }
        }

        private bool ValidateInput()
        {
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            Global.ListError.Clear();
            if (!Global.ValidateDateFromTo(dtpFromDate.Value, dtpToDate.Value) || !Global.ValidateDateFromTo(dtpToDate.Value, dtpDateCompare.Value))
            {
                return false;
            }
            return true;
        }

        private void NewCompareDebt_Load(object sender, EventArgs e)
        {
            SetLayout();
        }

        private void SetLayout()
        {
            CenterToParent();
            cbbDebt.Focus();
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.SetDataCombobox(cbbDebt, Constants.DEBT);
            ClearLayout();
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

        private void txtToalOwe_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalOwe);
        }

        private void txtToalOwe_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberLeave(txtTotalOwe);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }
        private void ClearLayout()
        {
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            txtRepresentationDebtName.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
            dtpDateCompare.Value = DateTime.Today;
            dtpFromDate.Value = Global.GetFirstDateInMonth();
            dtpToDate.Value = DateTime.Today;
            if (cbbDebt.Items.Count > 0)
            {
                cbbDebt.SelectedIndex = 0;                
            }
        }
    }
}