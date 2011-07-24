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
    public partial class DayWorkingForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public List<DayWorkingDTO> _list = new List<DayWorkingDTO>();
        private WorkerBUS _workerBUS = new WorkerBUS();
        public DayWorkingForm(DateTime _fromDate,DateTime _toDate,long WorkerID)
        {
            InitializeComponent();
            CenterToScreen();
            _list = _workerBUS.LoadAllDaysWorking(WorkerID);
            dgvWD.DataSource = _list;
            
        }
    }
}