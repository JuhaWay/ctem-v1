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
    public partial class AddNewWS : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private ConstructionBus _constructionBus = new ConstructionBus();
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        public AddNewWS()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void AddNewWS_Load(object sender, EventArgs e)
        {
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.Name = ipName.Text;
            dto.FromDate  = DateTime.Parse(dtFromdate.Text);
            dto.ToDate = DateTime.Parse(dtTodate.Text);
            dto.TotalSalary = 0;
            dto.CreatedBy = "";
            dto.UpdatedBy = "";
            dto.CreateDate = new DateTime(2011, 06, 11);
            dto.LastUpdate = new DateTime(2011, 06, 11);

            _workerSalaryBUS.CreateWks(dto);
            MessageBox.Show("Tạo tổng kết thành công !");
            this.Close();
        }
    }
}