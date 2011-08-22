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
    public partial class FinalAccountDebt : KryptonForm
    {
        private bool _isNew;
        private List<FinalAccountDTO> ListFinalAccount;
        private List<FinalAccountDTO> ListDebtAccount = new List<FinalAccountDTO>(); 
        private long totalDebt = 0;
        private long _id = 0;
        private readonly FinalAccountBUS FinalAcc = new FinalAccountBUS();

        public FinalAccountDebt()
        {
            _isNew = true;
            InitializeComponent();
        }

        public FinalAccountDebt(long id)
        {
            _isNew = false;
            _id = id;
            InitializeComponent();
        }

        private void FinalAccountManagement_Load(object sender, EventArgs e)
        {            
            SetLayout();
            InitData();
        }

        private void InitData()
        {
            if (_isNew)
            {
                if (cbbDebtSearch.Items.Count >= 0)
                {
                    cbbDebtSearch.SelectedIndex = 0;
                }
                dtpSearchTo.Value = DateTime.Today;
                dtpSearchFrom.Value = DateTime.Today.AddMonths(-1);
                LoadData();
            }
            else
            {                
                DateTime fromdate = dtpSearchFrom.MinDate;
                DateTime todate = dtpSearchTo.MaxDate;
                 ListFinalAccount = FinalAcc.GetFinalAccount(0, Constants.EMPTY_TEXT, fromdate, todate, 1, _id);
                dgvAccount.DataSource = ListFinalAccount;                               
            }
        }

        private void SetLayout()
        {
            CenterToParent();
            dgvAccount.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvAccount);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbDebtSearch, Constants.DEBT);
            Global.SetLayoutButton(btnSearch);
            Global.SetDaulftDatagridview(dgvAccount);
            if (!_isNew)
            {
                btnUnableEdit.Enabled = ButtonEnabled.False;
            }
        }

        private void RefreshData()
        {
            if (cbbDebtSearch.Items.Count > 0) { cbbDebtSearch.SelectedIndex = 0; }
            dtpSearchTo.Value = DateTime.Today;
            dtpSearchFrom.Value = Global.GetFirstDateInMonth();
            LoadData();
        }

        private void LoadData()
        {
            string debtName = cbbDebtSearch.Text;            
            DateTime fromdate = dtpSearchFrom.Value;
            DateTime todate = dtpSearchTo.Value.AddDays(1);
            ListFinalAccount = FinalAcc.GetFinalAccount(0, debtName, fromdate, todate, 0, 0);
            foreach (FinalAccountDTO finalAccountDTO in ListFinalAccount)
            {
                if (finalAccountDTO.TotalCost > 0)
                {
                    finalAccountDTO.IsPay = 1;
                    ListDebtAccount.Add(finalAccountDTO);
                    totalDebt += finalAccountDTO.TotalCost;
                    hdEdit.Values.Heading = String.Format("Tổng Số Nợ: {0} (VND)", Global.ConvertLongToMoney(totalDebt, Constants.SPLIP_MONEY));
                }
            }
            dgvAccount.DataSource = ListFinalAccount;                               
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnHideShowSearch_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
            else
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
            cbbDebtSearch.Focus();
        }

        private void HideSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, false);
                gbxSearch.Visible = false;
            }
        }        

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }   

        private void btnUnableEdit_Click(object sender, EventArgs e)
        {
            foreach (FinalAccountDTO finalAccountDTO in ListDebtAccount)
            {
                if (finalAccountDTO.ComparationDebtID != 0)
                {
                    KryptonMessageBox.Show("Các phiếu mua hàng đã từng được đọ sổ ở các lần trước", Constants.CONFIRM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string name = cbbDebtSearch.Text;                      
            using (NewCompareDebt newcompDebt = new NewCompareDebt(name, dtpSearchFrom.Value, dtpSearchTo.Value, totalDebt, ListDebtAccount))
            {
                newcompDebt.ShowDialog();
            }
            Close();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 4)
            {                
                if (dgvAccount[e.ColumnIndex, e.RowIndex].Value.ToString().Equals("0"))
                {                    
                    FinalAccountDTO finalAccountDTO = dgvAccount.Rows[e.RowIndex].DataBoundItem as FinalAccountDTO;
                    if (finalAccountDTO != null)
                    {
                        if (finalAccountDTO.TotalCost <= 0)
                        {
                            KryptonMessageBox.Show("Phiếu Mua Hàng Này Chưa Nhập Giá Nên Không Thể Thanh Toán.",
                                                   Constants.ALERT_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            dgvAccount[e.ColumnIndex, e.RowIndex].Value = 1;
                            ListDebtAccount.Add(finalAccountDTO);
                            totalDebt += finalAccountDTO.TotalCost;
                            hdEdit.Values.Heading = String.Format("Tổng Số Nợ: {0} (VND)", Global.ConvertLongToMoney(totalDebt, Constants.SPLIP_MONEY));
                        }                        
                    }
                }
                else
                {
                    dgvAccount[e.ColumnIndex, e.RowIndex].Value = 0;
                    FinalAccountDTO finalAccountDTO = dgvAccount.Rows[e.RowIndex].DataBoundItem as FinalAccountDTO;
                    ListDebtAccount.Remove(finalAccountDTO);
                    totalDebt -= finalAccountDTO.TotalCost;
                    hdEdit.Values.Heading = String.Format("Tổng Số Nợ: {0} (VND)", Global.ConvertLongToMoney(totalDebt, Constants.SPLIP_MONEY));                     
                }
            }                        
        }        
    }
}