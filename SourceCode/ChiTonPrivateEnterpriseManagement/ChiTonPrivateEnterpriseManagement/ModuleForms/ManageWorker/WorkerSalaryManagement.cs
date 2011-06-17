using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker
{
    public partial class WorkerSalaryManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public WorkerSalaryManagement()
        {
            InitializeComponent();
            ContextMenu mnuContextMenu = new ContextMenu();
            MenuItem item = new MenuItem();
            item.Name="123";
             mnuContextMenu.MenuItems.Add (item);

             this.dgvWks.ContextMenu = mnuContextMenu;
        }
    }
}