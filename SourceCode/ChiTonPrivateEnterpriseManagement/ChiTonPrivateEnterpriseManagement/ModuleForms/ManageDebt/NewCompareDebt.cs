using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class NewCompareDebt : KryptonForm
    {
        private readonly DebtBUS _debtBus = new DebtBUS();
        private string _debtname;
        private DateTime _from;
        private DateTime _to;
        private long _totalCost;
        private List<FinalAccountDTO> _listDebtAccount;

        public NewCompareDebt()
        {
            InitializeComponent();
        }

        public NewCompareDebt(string debtName, DateTime from, DateTime to, long totalCost, List<FinalAccountDTO> listDebtAccount)
        {
            InitializeComponent();
            _debtname = debtName;
            _from = from;
            _to = to;
            _totalCost = totalCost;
            _listDebtAccount = listDebtAccount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                long debtId = Global.GetDataCombobox(cbbDebt, Constants.DEBT);                
                var compareDate = dtpDateCompare.Value;
                var fromDate = dtpFromDate.Value;
                var toDate = dtpToDate.Value;
                string representationDebtName = txtRepresentationDebtName.Text;
                long totalOwe = Global.ConvertMoneyToLong(txtTotalOwe.Text, Constants.SPLIP_MONEY);
                long totalNewOwe = Global.ConvertMoneyToLong(txtTotalNewOwe.Text, Constants.SPLIP_MONEY);
                long totalOldOwe = Global.ConvertMoneyToLong(txtOldOwe.Text, Constants.SPLIP_MONEY);
                long pay = Global.ConvertMoneyToLong(txtPay.Text, Constants.SPLIP_MONEY);
                long con = Global.ConvertMoneyToLong(txtCon.Text, Constants.SPLIP_MONEY);
                string note = txtNote.Text;
                var compareDebtDto = new CompareDebtDTO()
                {
                    DebtID = debtId,
                    RepresentationDebtName = representationDebtName,
                    DateCompare = compareDate,
                    FromDate = fromDate,
                    ToDate = toDate,
                    TotalOwe = totalOwe,
                    TotalNewOwe = totalNewOwe,
                    TotalOldOwe = totalOldOwe,
                    TotalPayed = pay,
                    Con = con,
                    Note = note
                };
                long id = _debtBus.Create(compareDebtDto);
                if (id != 0)
                {
                    KryptonMessageBox.Show("Đã Tạo Mới Thành Công", Constants.CONFIRM, MessageBoxButtons.OK,
                                           MessageBoxIcon.Question);
                    FinalAccountBUS finalAccountBus = new FinalAccountBUS();
                    foreach (FinalAccountDTO accountDTO in _listDebtAccount)
                    {
                        accountDTO.ComparationDebtID = id;
                        accountDTO.IsPay = 1;
                        finalAccountBus.UpdateFinalAccount(accountDTO);
                    }
                    Close();
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
                    errors += (String.Format("* {0}\n", error));
                }
                KryptonMessageBox.Show(errors, Constants.ALERT_ERROR);
                dtpDateCompare.Focus();
            }
        }

        private bool ValidateInput()
        {
            Global.SetTextBoxMoneyLeave(txtTotalNewOwe);
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
            SetInnitValue();
        }

        private void SetInnitValue()
        {
            long totaloldowe = 0;
            for (int i = 0; i < cbbDebt.Items.Count; i++)
            {
                DebtDTO debt = cbbDebt.Items[i] as DebtDTO;
                if (debt.DebtName.Equals(_debtname))
                {
                    cbbDebt.SelectedIndex = i;
                    i = cbbDebt.Items.Count;
                    txtTotalOwe.Text = debt.TotalOweFomated;
                    totaloldowe = debt.TotalOwe - _totalCost;
                }
            }
            txtOldOwe.Text = Global.ConvertLongToMoney(totaloldowe, Constants.SPLIP_MONEY);
            dtpFromDate.Value = _from;
            dtpToDate.Value = _to;
            txtTotalNewOwe.Text = Global.ConvertLongToMoney(_totalCost, Constants.SPLIP_MONEY);
            Global.SetTextBoxNumberEnter(txtPay);
        }

        private void SetLayout()
        {
            CenterToParent();
            cbbDebt.Focus();
            Global.SetTextBoxNumberLeave(txtTotalNewOwe);
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
            Global.SetTextBoxNumberLeave(txtTotalNewOwe);            
            txtNote.Text = Constants.EMPTY_TEXT;
            dtpDateCompare.Value = DateTime.Today;
            dtpFromDate.Value = Global.GetFirstDateInMonth();
            dtpToDate.Value = DateTime.Today;
            if (cbbDebt.Items.Count > 0)
            {
                cbbDebt.SelectedIndex = 0;                
            }
        }

        private void txtPay_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(txtPay);
        }

        private void txtPay_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(txtPay);
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            long pay = Global.ConvertMoneyToLong(txtPay.Text, Constants.SPLIP_MONEY);
            long total = Global.ConvertMoneyToLong(txtTotalOwe.Text, Constants.SPLIP_MONEY);
            long con = total - pay;
            txtCon.Text = Global.ConvertLongToMoney(con, Constants.SPLIP_MONEY);
        }
    }
}