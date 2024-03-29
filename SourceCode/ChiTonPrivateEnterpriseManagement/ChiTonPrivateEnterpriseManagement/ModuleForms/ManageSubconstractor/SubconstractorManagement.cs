﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageSubconstractor
{
    public partial class SubconstractorManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();

        private SubcontractorDTO dtoTemp = new SubcontractorDTO();
        public SubconstractorManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
            refresh();
        }

        private void SubconstractorManagement_Load(object sender, EventArgs e)
        {
            SetLayout();
            refresh();
        }
        private void SetLayout()
        {
            dgvSubcons.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvSubcons);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutGroupBoxNewForm(newSubContainer);
        }
        public void refresh()
        {
            dgvSubcons.DataSource = _subcontractorBUS.search(ipSearchName.Text.Trim());
            loadDetailValues(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgvSubcons_MouseClick(object sender, MouseEventArgs e)
        {

            int currentMouseOverRow = dgvSubcons.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow < 0) currentMouseOverRow = 0;
            loadDetailValues(currentMouseOverRow);
        }
        private void loadDetailValues(int currentMouseOverRow)
        {
            if (dgvSubcons.Rows.Count == 0)
            {
                reset();
                dtoTemp = null;
                return;
            }
            dtoTemp = dgvSubcons.Rows[currentMouseOverRow].DataBoundItem as SubcontractorDTO;
            ipName.Text = dtoTemp.SubcontractorName;
            ipAddress.Text = dtoTemp.SubcontractorAddress;
            ipPhone.Text = dtoTemp.PhoneNumber;

        }

        public void reset()
        {
            ipName.Text ="";
            ipAddress.Text = "";
            ipPhone.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtoTemp == null) return;
            if (!validate()) return;
            dtoTemp.SubcontractorName = ipName.Text;
            dtoTemp.SubcontractorAddress = ipAddress.Text;
            dtoTemp.PhoneNumber = ipPhone.Text;
            _subcontractorBUS.updateSubcontractor(dtoTemp);
            KryptonMessageBox.Show("Cập nhật thành công", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            refresh();
        }
        private bool validate()
        {
            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("vui lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(Constants.CONFIRM_DELETE, Constants.CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSubcons.SelectedRows)
                {
                    long id = (row.DataBoundItem as SubcontractorDTO).SubcontractorID;
                    _subcontractorBUS.deleteSubcontractor(id);
                }
                refresh();
            }
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

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gbxSearch.Visible)
            {
                btnHideShowSearch.Type = PaletteButtonSpecStyle.ArrowUp;
                gbxSearch.Visible = true;
                Global.DownUpControl(this, pnlSearch, 62, 2, 4, true);
            }
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

        private void phoneInPut_Leave(object sender, EventArgs e)
        {
            if (Global.ValidatePhoneNumber(ipPhone) && Global.ValidateNotEmptyText(ipPhone))
            {
                ipPhone.Text = Global.FomatPhoneNumber(ipPhone.Text);
            }
            else
            {
                KryptonMessageBox.Show("Số Điện Thoại Không Đúng", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                ipPhone.Focus();
            }
        }

        private void ipSearchName_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}