using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;
using AdvancedDataGridView;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private EstimateBUS _estimateBUS = new EstimateBUS();
        ConstructionBus _constructionBus = new ConstructionBus();
        private List<EstimateDTO> _dtoList = new List<EstimateDTO>();
        private EstimateDTO dtoTemp = new EstimateDTO();
        private long _ManagerID;
        // khoi tao cua so chinh'
        public EstimateManagement()
        {
            initForm();
        }
        //khoi tao tu` man hinh` cong trinh`
        public EstimateManagement(long consID)
        {
            initForm();
            CenterToParent();
        }
        //khoi tao chuong trinh
        public void initForm()
        {
            InitializeComponent();
            SetLayout();
        }
        private void SetLayout()
        {
            dgvEstimate.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvEstimate);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);

        }
        // load du lieu
        private void EstimateManagement_Load(object sender, EventArgs e)
        {
            cbSearchCons.Items.Add(new ConstructionDTO("Tất cả",0));
            cbSearchCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbSearchCons.DisplayMember="ConstructionName";
            authen();
            loadData();
        }
        private void authen()
        {
            if (Global.IsAllow(Constants.CREATE_NEW_CONSTRUCTION))
            {
                cbSearchCons.Enabled = true;
                _ManagerID = 0;
            }
            else
            {
                _ManagerID = Global.CurrentUser.employeeID;
                cbSearchCons.Enabled = false;
            }


        }
        public void loadData()
        {
                EstimateDTO dto = new EstimateDTO();
                dto.ManagerID = _ManagerID;
                dto.EstimateName ="";
                search(dto);
          
         
        }
       
        // lưu thông tin dự toán
        private void btSave_Click(object sender, EventArgs e)
        {
            if (dtoTemp.EstimateID > 0)
            {
                _estimateBUS.UpdateNameEstimate(dtoTemp.EstimateID, ipEstName.Text);
                MessageBox.Show("cập nhật thành công!");
                loadData();
            }
        }        
        //xem du toan chi tiet
        private void btViewDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEstimate.SelectedRows[0];
            string strRightID = row.Cells["EstimateID"].Value.ToString();
            long EstimateID = Convert.ToInt64(strRightID);
            if (EstimateID != 0)
            {
                estDetailForm editForm = new estDetailForm(EstimateID);
                editForm.ShowDialog();
                loadData();
            }
            else
            {
                KryptonMessageBox.Show("Chọn 1 Bảng Dự Toán Trước Khi Bạn Muốn Xem Chi Tiết", Constants.ALERT_ERROR,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvEstimate.Focus();
            }
            
        }

        public EstimateDTO getDto(long ID)
        {
            foreach(EstimateDTO item in _dtoList){
                if (item.EstimateID == ID)
                    return item;
            }
            return null;
        }
        // fix checkall box
        private void btSearch_Click(object sender, EventArgs e)
        {
            EstimateDTO dto = new EstimateDTO();
            dto.EstimateName = ipSeacrchName.Text;
            dto.ManagerID = _ManagerID;
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            search(dto);

        }
        public void search(EstimateDTO dto)
        {
            dgvEstimate.Nodes.Clear();
            List<EstimateDTO> list = _estimateBUS.search(dto);
            _dtoList = list;
            string flag="";
            TreeGridNode node = new TreeGridNode();
            foreach (EstimateDTO item in list)
            {
                if (!item.ParentName.Equals(flag))
                {
                     node = dgvEstimate.Nodes.Add(item.ParentName, "", "", "", "", "", "",0);
                 }
                 node.Nodes.Add(item.ConstructionName,item.EstimateName,item.TotalCostEstimateFormated,
                     item.CreatedBy,item.UpdatedBy,item.CreatedDateFormated,item.UpdatedDateFormated,item.EstimateID);
                 flag = item.ParentName;
                 node.Expand();
             }
            selection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ipEstName.ReadOnly = false;
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

        private void dgvEstimate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {

                selection();
            }
        }
        private void selection()
        {
            if (dgvEstimate.SelectedRows.Count <= 0) return;
            string strEstimateID = dgvEstimate.SelectedRows[0].Cells["EstimateID"].Value.ToString();
            long EstimateID = Convert.ToInt64(strEstimateID);
            if (EstimateID != 0)
            {
                dtoTemp = getDto(EstimateID);
                ipEstName.Text = dtoTemp.EstimateName;
                txtConsName.Text = dtoTemp.ConstructionName;
                txtTotalEst.Text = dtoTemp.TotalCostEstimateFormated;
                ipEstName.Enabled = true;
                txtConsName.Enabled = true;
                txtTotalEst.Enabled = true;
            }
            else
            {
                dtoTemp = new EstimateDTO();
                ipEstName.Text = "";
                txtConsName.Text = "";
                txtTotalEst.Text = "";
                ipEstName.Enabled = false;
                txtConsName.Enabled = false;
                txtTotalEst.Enabled = false;
            }
        }
        private void ipSeacrchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }

        private void dgvEstimate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btViewDetail_Click(null, null);
            }
        }

        private void dgvEstimate_DoubleClick(object sender, EventArgs e)
        {
            btViewDetail_Click(null, null);
        }
    }
}
