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
        private EstimateDetailBUS _estimateDetailBUS = new EstimateDetailBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();

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
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetDaulftDatagridview(dgvWks);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutSplipContainerInChildForm(kryptonSplitContainer1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(kryptonGroupBox1);
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
            cbManager.DataSource=_employeeBUS.LoadAllEmployee();
            cbManager.DisplayMember = "Username";
            cbCons.DataSource = _constructionBus.LoadAllConstructions();
            cbCons.DisplayMember = "ConstructionName";
            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember = "ConstructionName";
            refresh();

        }
        public void refresh(){
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
            dto.Name = ipSearchName.Text;
            dto.month = dtMonth.Value.Date;
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
            _dtoTemp.Task = ipTask.Text;
            _dtoTemp.ToDate = dtTodate.Value.Date;
            _dtoTemp.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            _dtoTemp.OthersCost = Global.ConvertMoneyToLong(ipOthersCost.Text, Global.SEP);
            _dtoTemp.Reason = txtReason.Text;
            _dtoTemp.TotalCost = _dtoTemp.TotalSalary + _dtoTemp.OthersCost;
            long conID = _workerSalaryBUS.getConID(_dtoTemp.WorkersSalaryID);
            double totalEst = _estimateDetailBUS.getTotal(conID, EstimateDetailDTO.TYPE_WORKER);
            if (_dtoTemp.TotalCost > totalEst)
            {
                if (KryptonMessageBox.Show("Tổng chi phí bảng lương đã vượt dự toán công nhân, dự toán công nhân hiện tại là :" +
                        totalEst + " bạn có muốn tiếp tục lưu",
                        Constants.CONFIRM, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _workerSalaryBUS.UpdateWks(_dtoTemp);
                    MessageBox.Show("cập nhật thành công !");
                    refresh();
                }
            }
            else
            {
                _workerSalaryBUS.UpdateWks(_dtoTemp);
                MessageBox.Show("cập nhật thành công !");
                refresh();
            }
            
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
               if (_dtoTemp == null) return;
               ipName.Text = _dtoTemp.Name;
               foreach (ConstructionDTO temp in cbCons.Items)
               {
                   if (temp.ConstructionID.Equals(_dtoTemp.ConstructionID))
                       cbCons.SelectedItem = temp;
               }
               foreach (EmployerDTO temp in cbManager.Items)
               {
                   if (temp.employeeID.Equals(_dtoTemp.ManagerID))
                       cbManager.SelectedItem = temp;
               }
               dtFromdate.Value = _dtoTemp.FromDate;
               dtTodate.Value = _dtoTemp.ToDate;
               ipOthersCost.Text = _dtoTemp.OthersCostFormated;
               txtReason.Text = _dtoTemp.Reason;
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
                WorkerSalaryDTO item = row.DataBoundItem as WorkerSalaryDTO;
                _ConstructionID = item.ConstructionID;
                long id = item.WorkersSalaryID;
                DateTime fromDate = item.FromDate;
                 DateTime toDate = item.ToDate;
                 WorkerList editForm = new WorkerList(id, _ConstructionID, fromDate, toDate, item.OthersCost);
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
            else if (cbManager.SelectedIndex < 0)
            {
                MessageBox.Show("vui lòng chọn quản lý");
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

        private void ipOthersCost_Leave(object sender, EventArgs e)
        {
            Global.SetTextBoxMoneyLeave(ipOthersCost);
        }

        private void ipOthersCost_MouseLeave(object sender, EventArgs e)
        {
            ipOthersCost.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipOthersCost.Text, Global.SEP), Global.SEP);
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

        private void dgvWks_DoubleClick(object sender, EventArgs e)
        {
            btViewEst_Click(null, null);
        }

        private void ipOthersCost_Enter(object sender, EventArgs e)
        {
            Global.SetTextBoxNumberEnter(ipOthersCost);
        }

        private void ipSearchName_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

    }
}