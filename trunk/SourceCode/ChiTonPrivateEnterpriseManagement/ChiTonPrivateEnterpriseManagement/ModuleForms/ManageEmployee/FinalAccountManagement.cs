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
        private bool isDown;
        EmployeeBUS employeeBUS = new EmployeeBUS();
        List<EmployerDTO> listEmployee = new List<EmployerDTO>();
        public SalaryManagement()
        {
            InitializeComponent();
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            lbxHint.Visible = false;
            pnlSelectMonth.Height = 25;
            pnlFilterMoney.Height = 25;
            pnlSort.Height = 25;
            Global.TextHint(txtNameSearch, Color.DarkGray, "Arial", 9);
            loadSalary();
            listEmployee = employeeBUS.LoadAllEmployee();
        }

        private void loadSalary()
        {
            EmployerDTO emp = (EmployerDTO) lbxHint.SelectedItem;
            //long empId = emp.employeeID;
            
            //employeeBUS.GetSalary();
        }
        
        private void btnHideShowClick(ButtonSpecAny btnHideShow)
        {
            if (btnHideShow.Type == PaletteButtonSpecStyle.ArrowDown)
            {
                btnHideShow.Type = PaletteButtonSpecStyle.ArrowUp;
                isDown = true;
            }
            else if (btnHideShow.Type == PaletteButtonSpecStyle.ArrowUp)
            {
                btnHideShow.Type = PaletteButtonSpecStyle.ArrowDown;
                isDown = false;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            lbxHint.Visible = true;
            List<EmployerDTO> listEmployeeSearch = new List<EmployerDTO>();
            foreach (EmployerDTO employer in listEmployee)
            {
                if (employer.Display.Contains(txtNameSearch.Text))
                {
                    listEmployeeSearch.Add(employer);
                }
            }
            lbxHint.DataSource = listEmployeeSearch;
            lbxHint.ValueMember = Constants.EMPLOYEE_VALUEMEMBER;
            lbxHint.DisplayMember = Constants.EMPLOYEE_DISPLAYMEMBER;
        }

        private void txtNameSearch_Enter(object sender, EventArgs e)
        {
            if (txtNameSearch.Text.Equals("Tên Nhân Viên"))
            {
                txtNameSearch.Text = Constants.EMPTY_TEXT;
                Global.TextContent(txtNameSearch, Color.Black, "Arial", 9);
            }
        }

        private void txtNameSearch_Leave(object sender, EventArgs e)
        {
            if (txtNameSearch.Text.Equals(Constants.EMPTY_TEXT))
            {
                txtNameSearch.Text = "Tên Nhân Viên";
                Global.TextHint(txtNameSearch, Color.DarkGray, "Arial", 9);
            }
            lbxHint.Visible = false;
        }

        

        private void btnHideShowSelectMonth_Click(object sender, EventArgs e)
        {
            btnHideShowClick(btnHideShowSelectMonth);
            isDown = Global.DownUpControl(this, pnlSelectMonth, 95, 30, 5, isDown);
        }

        private void btnHideShowFilterMoney_Click(object sender, EventArgs e)
        {
            btnHideShowClick(btnHideShowFilterMoney);
            isDown = Global.DownUpControl(this, pnlFilterMoney, 160, 30, 5, isDown);
        }

        private void bsaSort_Click(object sender, EventArgs e)
        {
            btnHideShowClick(bsaSort);
            isDown = Global.DownUpControl(this, pnlSort, 95, 30, 5, isDown);
        }

        private void tsmHideShowAllFilter_Click(object sender, EventArgs e)
        {
            if (tsmHideShowAllFilter.Text.Equals("Hiện Tất Cả Bộ Lọc"))
            {
                btnHideShowSelectMonth_Click(null, null);
                btnHideShowFilterMoney_Click(null, null);
                bsaSort_Click(null, null);
                tsmHideShowAllFilter.Text = "Ẩn Tất Cả Bộ Lọc";
            }
            else
            {
                btnHideShowSelectMonth_Click(null, null);
                btnHideShowFilterMoney_Click(null, null);
                bsaSort_Click(null, null);
                tsmHideShowAllFilter.Text = "Hiện Tất Cả Bộ Lọc";
            }
        }

        private void btnClosedSearch_Click(object sender, EventArgs e)
        {
            hdgSearch.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hdgSearch.Show();
        }

        private void btnNewSalary_Click(object sender, EventArgs e)
        {
            NewSalary newSalary = new NewSalary();
            newSalary.ShowDialog();
        }

        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmployerDTO employee = (EmployerDTO) lbxHint.SelectedItem;
                txtNameSearch.Text = employee.Fullname;
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveControl.Text += "000";
            }
            catch (Exception)
            {
            }
        }
    }
}