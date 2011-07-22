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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class WorkerSalaryManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        private ConstructionBus _constructionBus = new ConstructionBus();

        private WorkerSalaryDTO _dtoTemp = new WorkerSalaryDTO();
        private long _ConstructionID;
        public WorkerSalaryManagement()
        {
            InitializeComponent();
            SetLayout();
        }
        private void SetLayout()
        {
            dgvWks.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvWks);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }
        // tạo mới bảng lương
        public void addMenu_Click(object sender, System.EventArgs e)
        {
          
            AddNewWS add = new AddNewWS();
            add.ShowDialog();
            dgvWks.DataSource = _workerSalaryBUS.LoadAllWks();
        }
        // load dử liệu của form
        private void WorkerSalaryManagement_Load(object sender, EventArgs e)
        {
            refresh();
            cbCons.DataSource = _constructionBus.LoadAllConstructions();
            cbCons.DisplayMember = "ConstructionName";
            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";

        }
        public void refresh(){
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
            dto.Name = ipSearchName.Text;
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            List<WorkerSalaryDTO> list = _workerSalaryBUS.search(dto);
            dgvWks.DataSource = list;
            sum(list);
        }
        public void sum(List<WorkerSalaryDTO> list)
        {
            long total = 0;
            foreach (WorkerSalaryDTO item in list)
            {
                total += item.TotalSalary;
            }            
        }
        // lưu thông tin thay đổi 
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
            _dtoTemp.FromDate = dtFromdate.Value.Date;
            _dtoTemp.ToDate = dtTodate.Value.Date;
            _workerSalaryBUS.UpdateWks(_dtoTemp);
            MessageBox.Show("cập nhật thành công !");
            refresh();
        }
        // thay đổi lựa chọn
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
        // reset dử liệu
        private void reSetValue()
        {
            _dtoTemp = null;
            ipName.Text = "";
            cbCons.SelectedIndex = -1;
            dtFromdate.Text = "";
            dtTodate.Text = "";
        }

        // tạo mới bảng lương

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewWS add = new AddNewWS();
            add.ShowDialog();
            refresh();
        }
        //xem chi tiết danh sách công nhân bảng lương
        private void btViewEst_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWks.SelectedRows)
            {
                _ConstructionID = (row.DataBoundItem as WorkerSalaryDTO).ConstructionID;
                string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                long id = Convert.ToInt64(strID);
                WorkerList editForm = new WorkerList(id, _ConstructionID);
                editForm.ShowDialog();
            }
            refresh();
        }
        // validate 
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
        // xóa bảng lương
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa bảng lương ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvWks.SelectedRows)
                {
                        string strID = row.Cells["WorkersSalaryID"].Value.ToString();
                        long id = Convert.ToInt64(strID);
                        _workerSalaryBUS.delete(id);
                 
                }
                refresh();
            }
        }
        // tim kiếm 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            refresh();

        }

    }
}