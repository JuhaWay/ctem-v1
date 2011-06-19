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
    public partial class NewAdvance : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        readonly EmployeeBUS _employeeBus = new EmployeeBUS();
        public NewAdvance()
        {
            InitializeComponent();
        }

        private void NewAdvance_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            cbbEmployee.SelectedIndex = 0;
            Global.SetDataTextBox(txtTotalAdvance, Constants.NUMBER);
            txtReason.Text = Constants.EMPTY_TEXT;
            txtNote.Text = Constants.EMPTY_TEXT;
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            long employeeId = Global.GetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            long totalAdvance = Convert.ToInt64(txtTotalAdvance.Text);
            string reason = txtReason.Text;
            string note = txtNote.Text;
            var advanceObj = new EmployeeAdvanceDTO()
                                 {
                                     EmployeeID = employeeId,
                                     TotalAdvance = totalAdvance,
                                     Reason = reason,
                                     Note = note
                                 };
            _employeeBus.CreateEmployeeAdvance(advanceObj);
        }
    }
}