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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class WorkerSalaryManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();

        private WorkerSalaryDTO _dtoTemp = new WorkerSalaryDTO(); 
        public WorkerSalaryManagement()
        {
            InitializeComponent();
        }

        private void dgvWks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                MenuItem add = new MenuItem("Tạo mới");
                add.Click += new System.EventHandler(this.addMenu_Click);
                m.MenuItems.Add(add);
                int currentMouseOverRow = dgvWks.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    MenuItem detail = new MenuItem("Danh sách nhân viên");
                    detail.Click += new System.EventHandler(this.listWorkerMenu_Click);
                    m.MenuItems.Add(detail);
                }

                m.Show(dgvWks, new Point(e.X, e.Y));

            }
        }

        public void listWorkerMenu_Click(object sender, System.EventArgs e)
        {

            foreach (DataGridViewRow row in dgvWks.Rows)
            {
                DataGridViewCell c = dgvWks.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                    long id = Convert.ToInt64(strID);
                    WorkerList editForm = new WorkerList(id);
                    editForm.ShowDialog();
                }
            }
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();

        }

        public void addMenu_Click(object sender, System.EventArgs e)
        {
          
            AddNewWS add = new AddNewWS();
            add.ShowDialog();
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private void WorkerSalaryManagement_Load(object sender, EventArgs e)
        {
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
            cbCons.DataSource = _constructionBus.LoadAllConstructions();
            cbCons.DisplayMember = "ConstructionName";

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (_dtoTemp == null)
            {
                MessageBox.Show("không tồn tại bảng lương!");
                return;
            }
            if (!validate()) return;
            _dtoTemp.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            _dtoTemp.Name = ipName.Text;
            _dtoTemp.FromDate = DateTime.Parse(dtFromdate.Text);
            _dtoTemp.ToDate = DateTime.Parse(dtTodate.Text);
            _dtoTemp.CreatedBy = "";
            _dtoTemp.UpdatedBy = "";
            _dtoTemp.CreateDate = new DateTime(2011, 06, 11);
            _dtoTemp.LastUpdate = new DateTime(2011, 06, 11);

            _workerSalaryBUS.UpdateWks(_dtoTemp);
            MessageBox.Show("Tạo tổng kết thành công !");
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private void dgvWks_SelectionChanged(object sender, EventArgs e)
        {
           DataGridViewSelectedRowCollection co =  dgvWks.SelectedRows as DataGridViewSelectedRowCollection;
           if (co.Count > 0)
           {
               DataGridViewRow[] arr = new DataGridViewRow[co.Count];
               co.CopyTo(arr, 0);
               foreach (DataGridViewRow item in arr)
               {
                   _dtoTemp = item.DataBoundItem as WorkerSalaryDTO;

               }
               ipName.Text = _dtoTemp.Name;
               foreach (ConstructionDTO temp in cbCons.Items)
               {
                   if (temp.ConstructionID.Equals(_dtoTemp.ConstructionID))
                       cbCons.SelectedItem = temp;
               }
               dtFromdate.Value = _dtoTemp.FromDate;
               dtTodate.Value = _dtoTemp.ToDate;

           }
           else
           {
               reSetValue();
           }
          
        }
        private void reSetValue()
        {
            _dtoTemp = null;
            ipName.Text = "";
            cbCons.SelectedIndex = -1;
            dtFromdate.Text = "";
            dtTodate.Text = "";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWks.Rows)
            {
                DataGridViewCell c = dgvWks.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                    long id = Convert.ToInt64(strID);
                    WorkerList editForm = new WorkerList(id);
                    editForm.ShowDialog();
                }
            }
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private void dgvWks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCell c = dgvWks.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    dgvWks[e.ColumnIndex, e.RowIndex].Value = false;
                    c.AccessibilityObject.Value = "False";
                    dgvWks.Rows[e.RowIndex].Selected = false;
                }
                else
                {
                    dgvWks[e.ColumnIndex, e.RowIndex].Value = true;
                    c.AccessibilityObject.Value = "True";
                    dgvWks.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewWS add = new AddNewWS();
            add.ShowDialog();
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private void btViewEst_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWks.Rows)
            {
                DataGridViewCell c = dgvWks.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                    long id = Convert.ToInt64(strID);
                    WorkerList editForm = new WorkerList(id);
                    editForm.ShowDialog();
                }
            }
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private bool validate(){
            if(ipName.Text.Trim().Equals("")){
                MessageBox.Show("vui lòng điền tên");
                return false;
            }
            else if (cbCons.SelectedIndex < 0)
            {
                MessageBox.Show("vui lòng chọn công trình");
                return false;
            }
            return true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa bảng lương ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvWks.Rows)
                {
                    DataGridViewCell c = dgvWks.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                        long id = Convert.ToInt64(strID);
                        _workerSalaryBUS.delete(id);
                    }
                }
                dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
            }
        }
    }
}