using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    public partial class FinalAccountManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDTO> ListFinalAccount;
        private FinalAccountBUS FinalAcc = new FinalAccountBUS();

        public FinalAccountManagement()
        {
            InitializeComponent();
        }

        private void FinalAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            ListFinalAccount = FinalAcc.GetAll();
            dgvLeftBot.DataSource = ListFinalAccount;
        }

        private void btnAddFinalAccount_Click(object sender, EventArgs e)
        {
            NewFinalAccount newFinalAccountForm = new NewFinalAccount();
            newFinalAccountForm.ShowDialog();
        }
    }
}