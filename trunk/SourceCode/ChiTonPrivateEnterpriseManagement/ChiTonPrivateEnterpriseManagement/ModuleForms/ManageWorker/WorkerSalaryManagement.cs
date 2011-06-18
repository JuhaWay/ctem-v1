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

        private long _workersSalaryID;
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
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
            dto.WorkersSalaryID = _workersSalaryID;
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.Name = ipName.Text;
            dto.FromDate = DateTime.Parse(dtFromdate.Text);
            dto.ToDate = DateTime.Parse(dtTodate.Text);
            dto.TotalSalary = 0;
            dto.CreatedBy = "";
            dto.UpdatedBy = "";
            dto.CreateDate = new DateTime(2011, 06, 11);
            dto.LastUpdate = new DateTime(2011, 06, 11);

            _workerSalaryBUS.UpdateWks(dto);
            MessageBox.Show("Tạo tổng kết thành công !");
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }

        private void dgvWks_SelectionChanged(object sender, EventArgs e)
        {
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
           DataGridViewSelectedRowCollection co =  dgvWks.SelectedRows as DataGridViewSelectedRowCollection;
           DataGridViewRow[] arr = new DataGridViewRow[co.Count];
           co.CopyTo(arr, 0);
           foreach (DataGridViewRow item in arr)
           {
               dto = item.DataBoundItem as WorkerSalaryDTO;
               
            }
           ipName.Text = dto.Name;
           foreach (ConstructionDTO temp in cbCons.Items)
           {
               if(temp.ConstructionID.Equals(dto.ConstructionID))
                   cbCons.SelectedItem = temp;
           }
           dtFromdate.Value = dto.FromDate;
           dtTodate.Value = dto.ToDate;
           _workersSalaryID = dto.WorkersSalaryID;
          
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
    }
}