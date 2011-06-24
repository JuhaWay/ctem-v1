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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount
{
    public partial class FinalAccountManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<FinalAccountDTO> ListFinalAccount;
        private FinalAccountBUS FinalAcc = new FinalAccountBUS();
        private CheckBox _ckBox;

        public FinalAccountManagement()
        {
            InitializeComponent();
        }

        private void FinalAccountManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            LoadData();
        }

        private void SetLayout()
        {            
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvLeftBot);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvLeftBot);
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
            LoadData();
        }

        private void FinalAccountManagement_SizeChanged(object sender, EventArgs e)
        {
            SetLayout();
        }
    }
}