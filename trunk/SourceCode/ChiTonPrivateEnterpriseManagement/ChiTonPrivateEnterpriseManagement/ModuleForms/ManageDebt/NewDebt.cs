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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            string nameDebt = txtDebtName.Text;
            string phonenumber = txtPhonenumber.Text;
            string address = txtAddress.Text;
            string description = txtDescription.Text;
            DebtDTO debt = new DebtDTO()
                               {
                                   DebtName = nameDebt,
                                   PhoneNumber = phonenumber,
                                   Address = address,
                                   Note = description,
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
        }

        private void NewDebt_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void setData()
        {
            cbbStatus.Items.Add(Constants.ACTIVE);
            cbbStatus.Items.Add(Constants.INACTIVE);
            cbbStatus.SelectedIndex = 0;
        }
    }
}