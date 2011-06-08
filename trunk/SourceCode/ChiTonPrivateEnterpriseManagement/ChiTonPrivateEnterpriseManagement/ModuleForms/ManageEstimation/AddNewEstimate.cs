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
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation
{
    public partial class AddNewEstimate : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private ConstructionBus _constructionBus = new ConstructionBus();
        private EstimateBUS _estimateBUS = new EstimateBUS();
        public AddNewEstimate()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void AddNewEstimate_Load(object sender, EventArgs e)
        {
            cbConstruction.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbConstruction.DisplayMember = "ConstructionName";
            cbConstruction.ValueMember = "ConstructionID";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ConstructionDTO dto = cbConstruction.SelectedItem as ConstructionDTO;
            bool test = _estimateBUS.creatEstimate(dto.ConstructionID,ipEstName.Text,
                long.Parse(ipTotalCost.Text),0,new DateTime(2011,6,1),new DateTime(2011,6,1),
                "","");
           if(test) 
               MessageBox.Show("Tạo dự toán thành công !");
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}