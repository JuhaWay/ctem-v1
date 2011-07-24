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
    public partial class AddNewWS : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private ConstructionBus _constructionBus = new ConstructionBus();
        private WorkerSalaryBUS _workerSalaryBUS = new WorkerSalaryBUS();
        private EmployeeBUS _employeeBUS = new EmployeeBUS();
        public AddNewWS()
        {
            CenterToParent();
            InitializeComponent();
        }

        private void AddNewWS_Load(object sender, EventArgs e)
        {
            cbManager.Items.AddRange(_employeeBUS.LoadAllEmployee().ToArray());
            cbManager.DisplayMember = "Username";
            cbCons.Items.AddRange(_constructionBus.LoadAllConstructions().ToArray());
            cbCons.DisplayMember = "ConstructionName";
            Global.SetLayoutPanelNewForm(pnMain);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            WorkerSalaryDTO dto = new WorkerSalaryDTO();
            dto.ConstructionID = (cbCons.SelectedItem as ConstructionDTO).ConstructionID;
            dto.ManagerID = (cbManager.SelectedItem as EmployerDTO).employeeID;
            dto.Name = ipName.Text;
            dto.FromDate  = dtFromdate.Value.Date;
            dto.ToDate =dtTodate.Value.Date;
            dto.TotalSalary = 0;
            _workerSalaryBUS.CreateWks(dto);
            MessageBox.Show("Tạo tổng kết thành công !");
            this.Close();
        }
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

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}