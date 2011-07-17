﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger
{
    public partial class AddnewLedger : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private LedgerBUS _ledgerBUS = new LedgerBUS();
        public AddnewLedger()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            LedgerDTO dto = new LedgerDTO();
            dto.Name = ipName.Text;
            dto.Type = cbType.Text;
            dto.Number = Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP);
            dto.Person = ipPerson.Text;
            dto.Reason = ipReason.Text;
            dto.Method = cbMethod.Text;
            dto.Date = dtDate.Value.Date;
            _ledgerBUS.CreateLedger(dto);
            MessageBox.Show("tạo thành công!");
            this.Close();
        }

        private void AddnewLedger_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
        }

        private void ipNumber_MouseLeave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }

        private void ipNumber_Leave(object sender, EventArgs e)
        {
            ipNumber.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipNumber.Text, Global.SEP), Global.SEP);
        }
        private bool validateForm()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (cbType.SelectedIndex<0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn loại", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (!Global.ValidateMoney(ipNumber))
            {
                KryptonMessageBox.Show("Nhập sai số tiền", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (cbMethod.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("Vui Lòng chọn hình thức", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}