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
            if (!validate()) return;
            WorkerTempDTO dto = new WorkerTempDTO();
            dto.WorkersSalaryID = WksID;
            dto.Fullname = ipName.Text;
            dto.Position = ipPosition.Text;
            dto.ManDate = Convert.ToDouble(ipManDate.Text);
            dto.Salary = Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP);
            dto.TotalSalary = (long)(dto.ManDate * dto.Salary);
            _workerBUS.CreateWks(dto);
            MessageBox.Show("Tạo thành công !           ");
            this.Close();

        }
        private Boolean validate()
        {
            if(ipName.Text.Trim().Equals("")){
                MessageBox.Show("vui lòng nhập tên !");
                return false;
            }else if(ipPosition.Text.Trim().Equals("")){
                 MessageBox.Show("vui lòng nhập vị trí !");
                 return false;
            }
            return true;
        }

        private void ipSalary_Leave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }

        private void ipSalary_MouseLeave(object sender, EventArgs e)
        {
            ipSalary.Text = Global.ConvertLongToMoney(Global.ConvertMoneyToLong(ipSalary.Text, Global.SEP), Global.SEP);
        }

        private void AddNewWk_Load(object sender, EventArgs e)
        {
            Global.SetLayoutPanelNewForm(pnMain);
        }
    }
}