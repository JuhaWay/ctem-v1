using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights
{
    public partial class RightsManagement: KryptonForm
    {
        EmployerDTO employer;
        Global global = new Global();
        RightBUS rightBUS = new RightBUS();
        List<RightDTO> listRights;
        CheckBox _ckBox;
        public RightsManagement()
        {
            InitializeComponent();
        }
        public RightsManagement(EmployerDTO _employer)
        {
            employer = _employer;
            InitializeComponent();
        }

        private void loadRights()
        {
            listRights = rightBUS.LoadAllRight();
            dgvRights.DataSource = listRights;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadRights();
        }

        private void RightsManagementForm_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvRights);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            loadRights();
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvRights);
        }            


        private void btnNewRight_Click(object sender, EventArgs e)
        {
            NewRight newRight = new NewRight(employer, listRights);
            newRight.ShowDialog();
        }

        private void btnDeleteRight_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa những quyền này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = false;
                foreach (DataGridViewRow row in dgvRights.Rows)
                {
                    DataGridViewCell c = dgvRights.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strRightID = row.Cells["RightID"].Value.ToString();
                        long RightID = Convert.ToInt64(strRightID);
                        success = rightBUS.DeleteRight(RightID);
                        if (success == false)
                        {
                            MessageBox.Show("Faile");
                        }
                    }
                }
                loadRights();
            }
        }

        private void btnEditRight_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in dgvRights.Rows)
            {
                DataGridViewCell c = dgvRights.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["RightID"].Value.ToString();
                    long RightID = Convert.ToInt64(strRightID);
                    NewRight newRight = new NewRight(employer, RightID, listRights);
                    newRight.ShowDialog();
                }
            }
        }

        private void dgvRights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvRights.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvRights[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvRights.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvRights[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvRights.Rows[e.RowIndex].Selected = true;
                }
            }
        }
    }
}