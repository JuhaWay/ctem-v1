using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class SalaryManagement : KryptonForm
    {
        EmployeeBUS employeeBUS = new EmployeeBUS();
        List<EmployerDTO> listEmployee = new List<EmployerDTO>();
        List<EmployeeSalaryDTO> listSalary;
        public SalaryManagement()
        {
            InitializeComponent();
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            Setlayout();
            loadSalary();
            listEmployee = employeeBUS.LoadAllEmployee();
        }

        private void Setlayout()
        {
            dgvSalary.Focus();
            pnlSearch.Height = 62;
            gbxSearch.Height = 58;
            txtTotalAdvance.Text = Constants.ZERO_NUMBER;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdAdvance, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdEdit, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvSalary);
            Global.SetLayoutSplipContainer(slcMain, 2);
            Global.SetLayoutSplipContainerInChildForm(slcEdit);
            Global.SetLayoutGroupBoxChildForm(gbxEdit1);
            Global.SetLayoutGroupBoxChildForm(gbxEdit2);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetDataCombobox(cbbNameSearch, Constants.EMPLOYEE_SEARCH);
            Global.SetDataCombobox(cbbEmployee, Constants.EMPLOYEE);
            Global.SetLayoutButton(btnSearch);
            //MakeEdit(false);
        }

        private void loadSalary()
        {
            listSalary = employeeBUS.LoadAllSalary();
            dgvSalary.DataSource = listSalary;
        }

        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            NewSalary newSalary = new NewSalary();
            newSalary.ShowDialog();
        }

    

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += Constants.THOUSAND;
            }
            catch (Exception)
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}