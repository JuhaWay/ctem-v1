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
            dgvAccount.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            //txtId.ReadOnly = true;
            //txtTotalOwe.Text = Constants.ZERO_NUMBER;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvAccount);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            //Global.SetDataCombobox(cbbDebt, "Debt");
            Global.SetLayoutButton(btnSearch);
            //MakeEdit(false);
        }

        private void SetLayoutDataGridView()
        {            
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvAccount);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvAccount);
        }

        private void LoadData()
        {
            ListFinalAccount = FinalAcc.GetAll();
            dgvAccount.DataSource = ListFinalAccount;
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