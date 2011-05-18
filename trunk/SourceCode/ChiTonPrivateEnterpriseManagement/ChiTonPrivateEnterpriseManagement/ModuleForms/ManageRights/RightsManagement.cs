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
        CheckBox ckBox;
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
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();
            dgvRights.Columns[0].Width = 25;
            dgvRights.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRights.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ckBox = new CheckBox();
            //Get the column header cell bounds
            Rectangle rect = this.dgvRights.GetCellDisplayRectangle(0, -1, true);
            ckBox.Size = new Size(18, 18);
            ckBox.BackColor = Color.Transparent;
            //Change the location of the CheckBox to make it stay on the header
            rect.Location = new Point(30, 4);
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            //Add the CheckBox into the DataGridView
            this.dgvRights.Controls.Add(ckBox);
            for (int i = 1; i < dgvRights.ColumnCount; i++)
            {
                dgvRights.Columns[i].Width = (dgvRights.Width - dgvRights.RowHeadersWidth - dgvRights.Columns[0].Width) / (dgvRights.ColumnCount - 1);
                dgvRights.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRights.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            loadRights();
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
                        else
                        {
                            dgvRights.Rows.RemoveAt(row.Index);
                        }
                    }
                }
            }
        }

        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < this.dgvRights.RowCount; j++)
            {
                DataGridViewCell c = dgvRights.Rows[j].Cells[0];
                c.AccessibilityObject.Value = ckBox.Checked.ToString();
                dgvRights[0, j].Value = this.ckBox.Checked;
                dgvRights.Rows[j].Selected = this.ckBox.Checked;
            }
            this.dgvRights.EndEdit();
            dgvRights.Refresh();

        }

        private void dgvRights_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    NewRight newRight = new NewRight(RightID, listRights);
                }
            }
        }
    }
}