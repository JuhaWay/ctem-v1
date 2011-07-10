using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger
{
    public partial class AddnewLedger : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private LedgerBUS _ledgerBUS = new LedgerBUS();
        public AddnewLedger()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            LedgerDTO dto = new LedgerDTO();
            dto.Name = ipName.Text;
            dto.Type = cbType.Text;
            dto.Number = Convert.ToInt64(ipNumber.Text);
            dto.Person = ipPerson.Text;
            dto.Reason = ipReason.Text;
            dto.Method = cbMethod.Text;
            dto.Date = dtDate.Value.Date;
            _ledgerBUS.CreateLedger(dto);
            MessageBox.Show("tạo thành công!");
            this.Close();
        }
    }
}