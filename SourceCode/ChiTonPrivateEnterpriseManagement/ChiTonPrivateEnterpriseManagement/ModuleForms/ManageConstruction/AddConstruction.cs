using System;
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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class AddConstruction : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private const int TYPE_PARENT = 0;
        private const int TYPE_CHILD = 1;
        private List<SubcontractorDTO> subCons = new List<SubcontractorDTO>();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();

        private ConstructionDTO _constructionDTO = new ConstructionDTO();
        private long parentId;
        private int type = 0;
        private bool update = false;
        // khởi tạo với type là  con
        public AddConstruction() {
            InitializeComponent();
            CenterToParent();
            loadSubcons();
        }
        // khởi tạo với type là  con
        public AddConstruction(long parent,int type)
        {
            InitializeComponent();
            this.ipProgressRate.Enabled = true;
            this.parentId = parent;          
            this.type = type;
            CenterToParent();
            loadSubcons();
        }
        // load nhà thau phụ
        private void loadSubcons(){
            subCons= _subcontractorBUS.loadAllSubcontractorDTO();
        }
        // khoi tạo để sửa công trình
        public AddConstruction(long constructionId)
        {
            InitializeComponent();
            loadSubcons();
            update = true;
            _constructionDTO = _constructionBus.LoadConstructionById(constructionId);
            if (_constructionDTO.ParentID!=0)
                this.ipProgressRate.Enabled = true;
            ipConstructionName.Text = _constructionDTO.ConstructionName;
            ipDes.Text = _constructionDTO.ConstructionAddress;
            ipAddress.Text = _constructionDTO.ConstructionAddress;
            cbStatus.SelectedItem = _constructionDTO.Status;
            ipProgressRate.Text = _constructionDTO.ProgressRate.ToString();
        }
        // tạo và chọn nhà thầu phụ
        private void btEditSubcons_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            
        }
        // load form
        private void AddConstruction_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        // sửa và tạo
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateConstruction()) return;
            if (!update)
            {
                if (type != TYPE_CHILD)
                {
                    long id = createCons(0,true);
                    type = TYPE_CHILD;
                    createCons(id,true);
                }
                else {
                    createCons(parentId,false);
                }
                
                //--------------------------------------------------------------------
                MessageBox.Show("Tạo công trình thành công !");
                this.Close();

               
            }
            else
            {
                _constructionDTO.CommencementDate = dtStartDate.Value.Date;
                _constructionDTO.CompletionDate = dtEndDate.Value.Date;
                _constructionDTO.ConstructionName = ipConstructionName.Text;
                _constructionDTO.ConstructionAddress = ipAddress.Text;
                _constructionDTO.Description = ipDes.Text;
                _constructionDTO.TotalEstimateCost = 0;
                _constructionDTO.Status = cbStatus.Text;
                if (type == TYPE_CHILD)
                {

                    if (Global.ValidateIntNumber(ipProgressRate.Text))
                       _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);
                    
                }
                bool test = _constructionBus.updateConstruction(_constructionDTO);
                if (test)
                    MessageBox.Show("Sửa công trình thành công !");
                this.Close();
            }
        }
        private long createCons(long parent_Id,bool autoMode){
            // tạo dư liệu
            _constructionDTO.CommencementDate = dtStartDate.Value.Date;
            _constructionDTO.CompletionDate = dtEndDate.Value.Date;
             _constructionDTO.ConstructionName = ipConstructionName.Text;
            _constructionDTO.ConstructionAddress = ipAddress.Text;
            _constructionDTO.Description = ipDes.Text;
            _constructionDTO.TotalEstimateCost = 0;
            _constructionDTO.Status = cbStatus.Text;
            _constructionDTO.type = ConstructionDTO.MAIN;
            if (type == TYPE_CHILD)
            {
                if (autoMode)
                    _constructionDTO.ConstructionName = "con của" + ipConstructionName.Text;
                _constructionDTO.ParentID = parent_Id;
                _constructionDTO.HasEstimate = true;
                if (Global.ValidateIntNumber(ipProgressRate.Text) && !autoMode)
                    _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);
            }

            long id = _constructionBus.CreateConstruction(_constructionDTO);

            //--------------------------------------auto create estimate--------
            if (type == TYPE_CHILD)
            {
                EstimateDTO est = new EstimateDTO();
                est.Type = 0;
                est.TotalCostEstimate = 0;
                est.ConstructionID = id;
                est.EstimateName = "Dự toán cho : " + ipConstructionName.Text;
                _estimateBUS.creatEstimate(est);
            }
            return id;
        }
        // tạo nhà thau phụ
        private void btCreateSubcon_Click(object sender, EventArgs e)
        {
            SelectSubConstructionBox box = new SelectSubConstructionBox();
            box.ShowDialog();
      
        }
        // đóng form
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //validate
        public bool validateConstruction()
        {
            if(ipConstructionName.Text.Equals("")){
                    MessageBox.Show("vui lòng nhập tên!");
                    return false;
             }
            else if (ipAddress.Text.Equals("")){
                 MessageBox.Show("vui lòng nhập Địa chỉ!");
                 return false;
            }
            else if (cbStatus.SelectedIndex<0)
            {
                MessageBox.Show("vui lòng chọn tình trạng!");
                return false;
            }

            return true;
        }
    }
}