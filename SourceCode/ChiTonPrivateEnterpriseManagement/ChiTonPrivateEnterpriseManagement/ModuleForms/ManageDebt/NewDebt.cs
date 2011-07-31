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
    public partial class NewDebt : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        DebtBUS debtBUS = new DebtBUS();
        public NewDebt()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string nameDebt = txtDebtName.Text;
                long totalOwe = Global.ConvertMoneyToLong(txtTotalOwe.Text, Constants.SPLIP_MONEY);
                string phonenumber = txtPhonenumber.Text;
                string address = txtAddress.Text;
                string description = txtDescription.Text;
                DebtDTO debt = new DebtDTO()
                {
                    DebtName = nameDebt,
                    PhoneNumber = phonenumber,
                    TotalOwe = totalOwe,
                    Address = address,
                    Note = description,
                    CreatedBy = Global.CurrentUser.Username
                };
                if (cbbStatus.Text.Equals(Constants.ACTIVE))
                {
                    debt.IsActive = 1;
                }
                else
                {
                    debt.IsActive = 0;
                }
                bool success = debtBUS.AddDebt(debt);
                if (success)
                {
                    if (KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClearLayout();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void ClearLayout()
        {
            txtDebtName.Text = Constants.EMPTY_TEXT;
            txtPhonenumber.Text = Constants.EMPTY_TEXT;
            txtDescription.Text = Constants.EMPTY_TEXT;
            txtAddress.Text = Constants.EMPTY_TEXT;
            txtDebtName.Focus();
        }

        private void NewDebt_Load(object sender, EventArgs e)
        {
            SetLayout();
        }

        private void SetLayout()
        {
            CenterToParent();
            txtDebtName.Focus();
            Global.SetTextBoxNumberLeave(txtTotalOwe);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(pnlMain);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.SetDataCombobox(cbbStatus, Constants.STATUS);
            Global.TextBoxRequireInput(txtDebtName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }

        private void txtPhonenumber_Leave(object sender, EventArgs e)
        {
            if (Global.ValidateNotEmptyText(txtPhonenumber) && Global.ValidatePhoneNumber(txtPhonenumber))
            {
                txtPhonenumber.Text = Global.FomatPhoneNumber(txtPhonenumber.Text);                
            }
        }

        private void txtTotalOwe_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberLeave(txtTotalOwe);
        }

        private void txtTotalOwe_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalOwe);
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
    }
}