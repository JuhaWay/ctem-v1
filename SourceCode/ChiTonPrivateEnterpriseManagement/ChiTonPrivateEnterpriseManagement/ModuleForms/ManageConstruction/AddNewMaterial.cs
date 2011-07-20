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

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class AddNewMaterial : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private MaterialBUS _materialBUS = new MaterialBUS(); 
    
        public AddNewMaterial()
        {
            CenterToParent();
            InitializeComponent();
        }

        public AddNewMaterial(string name)
        {
            CenterToParent();
            InitializeComponent();
            ipName.Text = name;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;
            MaterialDTO dto = new MaterialDTO();
            dto.MaterialName = ipName.Text;
            dto.MaterialParentID = 0;
            dto.EstimateCalUnit = ipEU.Text;
            dto.RealCalUnit = ipRU.Text;
            dto.Ratio = Convert.ToDouble(ipRatio.Text);

            _materialBUS.CreateMaterials(dto);
            KryptonMessageBox.Show("Tạo thành công");
            this.Close();
        }
        private void AddNewMaterial_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox1);
            Global.SetLayoutGroupBoxNewForm(kryptonGroupBox2);
            Global.SetLayoutButton(btSave);
            Global.SetLayoutButton(btClose);
        }
        private bool validateForm()
        {
            if(ipName.Text.Trim().Equals("")){
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (ipName.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền tên", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (ipEU.Text.Trim().Equals(""))
            {
                KryptonMessageBox.Show("Vui Lòng điền đơn vị dự toán", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            
            if(ipRU.Text.Trim().Equals("")){
                KryptonMessageBox.Show("Vui Lòng điền đơn vị quyết toán", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            if (!Global.ValidateDoubleNumber(ipRatio.Text.Trim()))
            {
                KryptonMessageBox.Show("chỉ số quy đổi sai", Constants.CONFIRM, MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}