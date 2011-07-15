using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class StockOutManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public StockOutManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newStockOut = new NewStockOut();
            newStockOut.ShowDialog();

        }

        private void StockOutManagement_Load(object sender, EventArgs e)
        {
            Setlayout();
        }

        private void Setlayout()
        {
            dgvStockout.Focus();
            pnlSearch.Height = 82;
            gbxSearch.Height = 78;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvStockout);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);   
        }
    }
}