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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class NewAdvance : KryptonForm
    {
        readonly EmployeeBUS _employeeBus = new EmployeeBUS();
        public NewAdvance()
        {
            InitializeComponent();
        }

        private void NewAdvance_Load(object sender, EventArgs e)
        {
            SetLayout();
        }

        private void SetLayout()
        {
            CenterToParent();
            cbbEmployee.Focus();
            Global.SetTextBoxNumberLeave(txtTotalAdvance);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(gbxAdd1);
            Global.SetLayoutGroupBoxNewForm(gbxAdd2);
            Global.SetLayoutSplipContainerNewForm(slcMain);
            Global.SetLayoutPanelNewForm(pnlButton);
            Global.SetLayoutGroupBoxNewForm(gbxButton);
            Global.SetLayoutButton(btnSave);
            Global.SetLayoutButton(btnClose);
            Global.SetLayoutButton(btnClear);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.TextBoxRequireInput(txtReason);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            long employeeId = Global.GetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            long totalAdvance = Global.ConvertMoneyToLong(txtTotalAdvance.Text, ".");
            string reason = txtReason.Text;
            string note = txtNote.Text;
            var advanceObj = new EmployeeAdvanceDTO()
                                 {
                                     EmployeeID = employeeId,
                                     TotalAdvance = totalAdvance,
                                     Reason = reason,
                                     Note = note
                                 };
            bool success = _employeeBus.CreateEmployeeAdvance(advanceObj);
            if (success)
            {
                if (KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearLayout();
                    cbbEmployee.Focus();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                KryptonMessageBox.Show(Constants.CREATE_SUCCESS, Constants.CONFIRM);
            }            
        }

        private void ClearLayout()
        {
            cbbEmployee.SelectedIndex = 0;
            Global.SetDataTextBox(txtTotalAdvance, Constants.NUMBER);
            txtReason.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (txtReason.Text.Equals(Constants.EMPTY_TEXT))
            {
                Global.TextBoxRequireInput(txtTotalAdvance);
            }
            else
            {
                Global.TextBoxRequireInputed(txtTotalAdvance);
            }
        }

        private void txtTotalAdvance_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtTotalAdvance);
        }

        private void txtTotalAdvance_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtTotalAdvance);
        }

        private void genarateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch (Exception)
            {
            }
        }
    }
}