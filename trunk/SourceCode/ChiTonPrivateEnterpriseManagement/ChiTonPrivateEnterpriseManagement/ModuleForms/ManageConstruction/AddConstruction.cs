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
        private EmployeeBUS _employeeBUS = new EmployeeBUS();

        private ConstructionDTO _constructionDTO = new ConstructionDTO();
        private long parentId;
        private int type = 0;
        private bool update = false;
        // khởi tạo với type là  cha
        public AddConstruction() {
            InitializeComponent();
            CenterToParent();
            loadSubcons();
            if (!Global.IsAllow(Constants.CREATE_NEW_CONSTRUCTION))
            {
                cbManager.Enabled = false;
            }
           
           
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
            cbManager.Enabled = false;
        }
        // load nhà thau phụ
        private void loadSubcons(){
            cbManager.Items.Add(new EmployerDTO("Tất cả",0));
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            subCons= _subcontractorBUS.loadAllSubcontractorDTO();
        }
        // khoi tạo để sửa công trình
        public AddConstruction(long constructionId)
        {
            InitializeComponent();
            loadSubcons();
            update = true;
            _constructionDTO = _constructionBus.LoadConstructionById(constructionId);
            if (_constructionDTO.ParentID != 0)
            {
                this.ipProgressRate.Enabled = true;
                cbManager.Enabled = false;
            }
            else
            {
                if (!Global.IsAllow(Constants.CREATE_NEW_CONSTRUCTION))
                {
                    cbManager.Enabled = false;
                }
            }

            ipConstructionName.Text = _constructionDTO.ConstructionName;
            ipDes.Text = _constructionDTO.ConstructionAddress;
            ipAddress.Text = _constructionDTO.ConstructionAddress;
            cbStatus.SelectedItem = _constructionDTO.Status;
            ipProgressRate.Text = _constructionDTO.ProgressRate.ToString();
            foreach (EmployerDTO item in cbManager.Items)
            {
                if (_constructionDTO.ManagerID.Equals(item.employeeID))
                    cbManager.SelectedItem = item;
            }
        }

        // load form
        private void AddConstruction_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Global.SetLayoutPanelNewForm(pnMain);
        }



        // tạo và chọn nhà thầu phụ
        private void btEditSubcons_Click(object sender, EventArgs e)
        {

            SelectSubConstructionBox box = new SelectSubConstructionBox(subCons);
            box.ShowDialog();
            
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
                KryptonMessageBox.Show("Tạo thành công", Constants.ALL, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
                else
                {
                    if (cbManager.SelectedIndex > 0)
                    {
                        _constructionDTO.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
                    }
                }
                bool test = _constructionBus.updateConstruction(_constructionDTO);
                KryptonMessageBox.Show("Sửa thành công", Constants.ALL, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
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
                    _constructionDTO.ConstructionName = "công trình con " + ipConstructionName.Text;
                _constructionDTO.ParentID = parent_Id;
                _constructionDTO.HasEstimate = true;
                _constructionDTO.ManagerID = 0;
                if (Global.ValidateIntNumber(ipProgressRate.Text) && !autoMode)
                    _constructionDTO.ProgressRate = Convert.ToInt64(ipProgressRate.Text);
            }else
            {
                if(cbManager.SelectedIndex>0){
                    _constructionDTO.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
                }
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
                KryptonMessageBox.Show("vui lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    return false;
             }
            else if (cbStatus.SelectedIndex<0)
            {
                KryptonMessageBox.Show("vui lòng chọn tình trạng", Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}