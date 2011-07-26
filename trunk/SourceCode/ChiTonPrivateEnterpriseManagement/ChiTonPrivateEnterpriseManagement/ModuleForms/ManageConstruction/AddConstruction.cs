﻿using System;
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
       
        private List<SubcontractorDTO> subCons = new List<SubcontractorDTO>();
        private ConstructionBus _constructionBus = new ConstructionBus();
        private SubcontractorBUS _subcontractorBUS = new SubcontractorBUS();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        private ConstructionDTO _constructionDTO = new ConstructionDTO();
        //---------------------------------------------------------------------
        private const int TYPE_PARENT = 0;
        private const int TYPE_CHILD = 1;
        private int type = TYPE_PARENT;
        private long _parentID;
        private bool _update;
        // tạo với type là  cha
        public AddConstruction() {
            InitializeComponent();            
            if (!Global.IsAllow(Constants.CREATE_NEW_CONSTRUCTION))
            {
                cbManager.Enabled = false;
            } 
           
        }
        // sửa cha update=true,type=cha|sửa con update = true,type=con|tạo con update = false,type=con
        public AddConstruction(long ID,bool update, int _type)
        {
            // khởi tạo value
            InitializeComponent();            
            _update = update;
            type = _type;
            // kiểm tra xem là update hay tạo mới
            if (_update)
                loadUpdateForm(ID);
            else
            {
                // trường hợp tạo con 
                _parentID = ID;
                this.ipProgressRate.Enabled = true;
            }
        }
        // tải thông tin update
        public void loadUpdateForm(long ID)
        {
            _constructionDTO = _constructionBus.LoadConstructionById(ID);
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
            cbType.Text = _constructionDTO.type;
            foreach (EmployerDTO item in cbManager.Items)
            {
                if (_constructionDTO.ManagerID.Equals(item.employeeID))
                    cbManager.SelectedItem = item;
            }
        }


        // load form
        private void AddConstruction_Load(object sender, EventArgs e)
        {
            loadRefs();
            CenterToParent();
            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox2);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btCancel);
        }
        // load nhà thau phụ
        private void loadRefs()
        {   cbType.Items.AddRange(ConstructionDTO.getType().ToArray());         
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = Constants.EMPLOYEE_DISPLAYMEMBER;
            subCons = _subcontractorBUS.loadAllSubcontractorDTO();
        }
       
        // Lưu các giá trị sửa/tạo và DB
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateConstruction()) return;
            if (!_update)
            {
                // trường hợp là tạo mới
                //tao cha va auto tao con
                if (type != TYPE_CHILD)
                {
                    long id = createCons(0,true);
                    type = TYPE_CHILD;
                    createCons(id,true);
                }
                else {
                    //chi tao con
                    createCons(_parentID,false);
                }
                this.Close();
            }
            // trường hợp là sửa
            else
            {
                update();
            }
        }

        // tạo công trình
        private long createCons(long parent_Id,bool autoMode){
            // tạo dư liệu
            _constructionDTO.CommencementDate = dtStartDate.Value.Date;
            _constructionDTO.CompletionDate = dtEndDate.Value.Date;
             _constructionDTO.ConstructionName = ipConstructionName.Text;
            _constructionDTO.ConstructionAddress = ipAddress.Text;
            _constructionDTO.Description = ipDes.Text;
            _constructionDTO.TotalEstimateCost = 0;
            _constructionDTO.Status = cbStatus.Text;
            _constructionDTO.type = cbType.Text.Trim();
            if (type == TYPE_CHILD)
            {
                if (autoMode)
                    _constructionDTO.ConstructionName = ipConstructionName.Text;
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
                est.EstimateName = "Dự toán cho : " + _constructionDTO.ConstructionName;
                _estimateBUS.creatEstimate(est);
            }
            return id;
        }
        // sửa công trình
        public void update()
        {
            _constructionDTO.CommencementDate = dtStartDate.Value.Date;
            _constructionDTO.CompletionDate = dtEndDate.Value.Date;
            _constructionDTO.ConstructionName = ipConstructionName.Text;
            _constructionDTO.ConstructionAddress = ipAddress.Text;
            _constructionDTO.Description = ipDes.Text;
            _constructionDTO.TotalEstimateCost = 0;
            _constructionDTO.Status = cbStatus.Text;
            _constructionDTO.type = cbType.Text.Trim();

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
            this.Close();
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
            else if (cbType.SelectedIndex < 0)
            {
                KryptonMessageBox.Show("vui lòng chọn Loại", Constants.CONFIRM, MessageBoxButtons.OK,
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

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtEndDate.Value < dtStartDate.Value)
            {
                KryptonMessageBox.Show(Constants.ERROR_DATE, Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                dtEndDate.Value = dtStartDate.Value;
            }
        }

        private void ipProgressRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long progress = Convert.ToInt64(ipProgressRate.Text);
                if (progress > 100)
                {
                    KryptonMessageBox.Show("Tiến Độ Phải Nhỏ Hơn 100%", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                }
            }
            catch
            {
                KryptonMessageBox.Show("Tiến Độ Phải Là Số", Constants.ALERT_ERROR, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text.Equals("Chọn") || cbStatus.Text.Equals("Mới"))
            {
                ipProgressRate.Text = Constants.ZERO_NUMBER;
                ipProgressRate.Enabled = false;
            }
            else if (cbStatus.Text.Equals("Hoàn thành"))
            {
                ipProgressRate.Text = "100";
                ipProgressRate.Enabled = false;
            }
            else
            {
                ipProgressRate.Enabled = true;
            }
        }
    }
}