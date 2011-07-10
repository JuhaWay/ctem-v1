using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class StockOutManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public StockOutManagement()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewStockOut newStockOut = new NewStockOut();
            newStockOut.ShowDialog();
        }
    }
}