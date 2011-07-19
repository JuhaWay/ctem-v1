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
    public partial class ResetPassword : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutPanelNewForm(kryptonPanel);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutButton(btnReset);
            Global.SetLayoutButton(btnClose);
            Global.SetDataCombobox(cbbUsers, Constants.USER);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmployeeBUS empBus = new EmployeeBUS();
            EmployerDTO emp = cbbUsers.SelectedItem as EmployerDTO;
            long empid = emp.employeeID;
            string pass = DataProvider.Encrypt(Constants.DEFAULT_PASSWORD);
            bool success = empBus.ResetPassword(empid, pass);
            if (success)
            {
                Global.CurrentUser.Password = pass;
                KryptonMessageBox.Show(" Cập Nhật Thành Công\n Mật Khẩu Mới là: " + Constants.DEFAULT_PASSWORD,
                                       Constants.CONFIRM);                
            }
            else
            {
                KryptonMessageBox.Show(Constants.ERROR, Constants.CONFIRM);
            }
        }
    }
}