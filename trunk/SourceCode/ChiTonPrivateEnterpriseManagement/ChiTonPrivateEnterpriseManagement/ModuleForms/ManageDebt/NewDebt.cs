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
            string nameDebt = txtDebtName.Text;
            long totalOwe = Global.ConvertMoneyToLong(txtTotalOwe.Text, ".");
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
            debtBUS.AddDebt(debt);
            ClearLayout();
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
            CenterToParent();
            setData();
        }

        private void setData()
        {
            cbbStatus.Items.Add(Constants.ACTIVE);
            cbbStatus.Items.Add(Constants.INACTIVE);
            cbbStatus.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}