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
namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class AddNewWk : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private WorkerBUS _workerBUS = new WorkerBUS();

        private long WksID;
        public AddNewWk(long id)
        {
            WksID = id;
            CenterToParent();
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            WorkerTempDTO dto = new WorkerTempDTO();
            dto.WorkersSalaryID = WksID;
            dto.Fullname = ipName.Text;
            dto.Position = ipPosition.Text;
            dto.ManDate = Convert.ToInt32(ipManDate.Text);
            dto.Salary = Convert.ToInt64(ipSalary.Text);
            dto.CreatedBy = "";
            dto.UpdatedBy = "";
            dto.CreatedDate = new DateTime(2011, 06, 11);
            dto.LastUpdated = new DateTime(2011, 06, 11);
            _workerBUS.CreateWks(dto);
            MessageBox.Show("Tạo thành công !           ");
            this.Close();

        }
    }
}