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
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt
{
    public partial class NewCompareDebt : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        CompareDebtBUS compareBus = new CompareDebtBUS();
        public NewCompareDebt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long debtId = Global.GetDataCombobox(cbbDebt, "Debt");
            string representationDebtName = txtRepresentationDebtName.Text;
            DateTime compareDate = DateTime.Parse(dtpDateCompare.Text);
            DateTime fromDate = DateTime.Parse(dtpFromDate.Text);
            DateTime toDate = DateTime.Parse(dtpToDate.Text);
            long totalOwe = Convert.ToInt64(txtToalOwe.Text);
            string note = txtNote.Text;
            CompareDebtDTO compareDebtDto = new CompareDebtDTO()
                                                {
                                                    DebtID = debtId,
                                                    RepresentationDebtName = representationDebtName,
                                                    DateCompare = compareDate,
                                                    FromDate = fromDate,
                                                    ToDate = toDate,
                                                    TotalOwe = totalOwe,
                                                    Note = note
                                                };
            compareBus.Create(compareDebtDto);
            Close();
            FinalAccountManagement finalAccountManagement = new FinalAccountManagement();
            finalAccountManagement.Show();
        }

        private void NewCompareDebt_Load(object sender, EventArgs e)
        {
            Global.SetDataCombobox(cbbDebt, "Debt");
        }
    }
}