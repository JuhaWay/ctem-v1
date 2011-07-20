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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class EstimateManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private EstimateBUS _estimateBUS = new EstimateBUS();
        ConstructionBus _constructionBus = new ConstructionBus();
        private long _constructionID=-1;
        private EstimateDTO dtoTemp = new EstimateDTO();
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
            _constructionID = consID;
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
            loadData();
        }
        public void loadData()
        {
            if (_constructionID == -1)
            {
                EstimateDTO dto = new EstimateDTO();
                dto.EstimateName ="";
                search(dto);
            }
            else dgvEstimate.DataSource = _estimateBUS.LoadEstimateByConstruction(_constructionID);
        }
       
        // lưu thông tin dự toán
        private void btSave_Click(object sender, EventArgs e)
        {
            _estimateBUS.UpdateNameEstimate(dtoTemp.EstimateID, ipEstName.Text);
            MessageBox.Show("cập nhật thành công!");
            loadData();
        }        
        //xem du toan chi tiet
        private void btViewDetail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstimate.SelectedRows)
            {
                    string strRightID = row.Cells["EstimateID"].Value.ToString();
                    long EstimateID = Convert.ToInt64(strRightID);
                    estDetailForm editForm = new estDetailForm(EstimateID);
                    editForm.ShowDialog();
            }

            loadData();
        }
        // fix checkall box
        private void btSearch_Click(object sender, EventArgs e)
        {
            EstimateDTO dto = new EstimateDTO();
            dto.EstimateName = ipSeacrchName.Text;
            if (cbSearchCons.SelectedIndex > -1)
                dto.ConstructionID = (cbSearchCons.SelectedItem as ConstructionDTO).ConstructionID;
            search(dto);

        }
        public void search(EstimateDTO dto)
        {
            dgvEstimate.DataSource=_estimateBUS.search(dto);
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
                dtoTemp = dgvEstimate.SelectedRows[0].DataBoundItem as EstimateDTO;
                ipEstName.Text = dtoTemp.EstimateName;
                txtConsName.Text = dtoTemp.ConstructionName;
                txtTotalEst.Text = dtoTemp.TotalCostEstimateFormated;
            }
        }

        private void ipSeacrchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }
    }
}
