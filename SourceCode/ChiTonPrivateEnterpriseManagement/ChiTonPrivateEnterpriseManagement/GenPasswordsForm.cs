using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class GenPasswordsForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public GenPasswordsForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Text = DataProvider.Encrypt(txtPassword.Text);
        }
    }
}