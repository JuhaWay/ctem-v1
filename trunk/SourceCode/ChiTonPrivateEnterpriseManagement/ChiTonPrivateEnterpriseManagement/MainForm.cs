using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageLedger;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageProgress;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageVehicle;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWorker;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageMenu;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRights;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageRole;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageSubconstractor;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<LeftMenuDTO> listMenus;
        private string _currentMenu;
        private EmployeeBUS employeeBUS;
        private bool isDown;
        int _index1;
        int _index2;
        int _index3;
        int _index4;
        int _index5;
        int _index6;

        public MainForm()
        {
            InitializeComponent();
            _currentMenu = "None";
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            bsaProfiles.Text = Global.CurrentUser.Username + " (" + Global.CurrentUser.Fullname + ")";
            SetCloseAllMenu();
            LoadData();
            SetMenuForRole();
        }

        private void SetMenuForRole()
        {
            if (_index1 == 0)
            {
                pnlConsMenu.Visible = false;
                hgxConsMenu.Visible = false;
            }
            if (_index2 == 0)
            {
                pnlEmpMenu.Visible = false;
                hgxEmpMenu.Visible = false;
            }
            if (_index3 == 0)
            {
                pnlWHMenu.Visible = false;
                hgxWHMenu.Visible = false;
            }
            if (_index4 == 0)
            {
                pnlDebtMenu.Visible = false;
                hgxDebtMenu.Visible = false;
            }
            if (_index5 == 0)
            {
                pnlLedgerMenu.Visible = false;
                hgxLedgerMenu.Visible = false;
            }
            if (_index6 == 0)
            {
                pnlSystem.Visible = false;
                hgxSystemMenu.Visible = false;
            }
        }

        private void LoadData()
        {
            _index1 = 0;
            _index2 = 0;
            _index3 = 0;
            _index4 = 0;
            _index5 = 0;
            _index6 = 0;
            ClearTreeNode();
            LeftMenuBUS leftMenuBUS = new LeftMenuBUS();            
            listMenus = leftMenuBUS.GetMenuByRoleID(Global.CurrentUser.RoleID);
            foreach (var menu in listMenus)
            {
                if (menu.Type.Equals(Constants.CONSTRUCTION))
                {
                    tvwCons.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwCons.Nodes[menu.MenuName].ImageIndex = _index1;
                    _index1++;
                }
                if (menu.Type.Equals(Constants.EMPLOYEE))
                {
                    tvwEmp.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwEmp.Nodes[menu.MenuName].ImageIndex = _index2;
                    _index2++;
                }
                if (menu.Type.Equals(Constants.WAREHOUSE))
                {
                    tvwWH.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwWH.Nodes[menu.MenuName].ImageIndex = _index3;
                    _index3++;
                }
                if (menu.Type.Equals(Constants.DEBT))
                {
                    tvwDebt.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwDebt.Nodes[menu.MenuName].ImageIndex = _index4;
                    _index4++;
                }
                if (menu.Type.Equals(Constants.LEDGER))
                {
                    tvwLedger.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwLedger.Nodes[menu.MenuName].ImageIndex = _index5;
                    _index5++;
                }
                if (menu.Type.Equals(Constants.SYSTEM))
                {
                    tvwSystem.Nodes.Add(menu.MenuName).Name = menu.MenuName;
                    tvwSystem.Nodes[menu.MenuName].ImageIndex = _index6;
                    _index6++;
                }
            }
        }
        
        private void ClearTreeNode()
        {
            tvwCons.Nodes.Clear();
            tvwEmp.Nodes.Clear();
            tvwWH.Nodes.Clear();
            tvwDebt.Nodes.Clear();
            tvwLedger.Nodes.Clear();
            tvwSystem.Nodes.Clear();
        }        

        private void btnhdgMenuHideShow_Click(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Text.Equals("Ẩn"))
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Left;
                hdgMenu.Width = Constants.WIDTH_MENU_HIDE;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_HIDE;
                slcMain.IsSplitterFixed = true;
                btnhdgMenuHideShow.Text = "Hiện";
            }
            else
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Top;
                hdgMenu.Width = Constants.WIDTH_MENU_SHOW;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_SHOW;
                slcMain.IsSplitterFixed = false;
                btnhdgMenuHideShow.Text = "Ẩn";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.IsLogout = true;
            Close();
        }

        private void txtProfiles_LinkClicked(object sender, EventArgs e)
        {
            Profiles profileForm = new Profiles(Global.CurrentUser);
            profileForm.ShowDialog();
        }

        private void btnHideShow1_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.CONSTRUCTION;
            ButtonHideShowClick();
        }

        private void hgxConsMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.CONSTRUCTION;
            HGXHideShowClick();
        }

        private void btnHideShow2_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.EMPLOYEE;
            ButtonHideShowClick();
        }

        private void hgxEmpMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.EMPLOYEE;
            HGXHideShowClick();
        }

        private void btnHideShow3_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.WAREHOUSE;
            ButtonHideShowClick();
        }

        private void hgxWHMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.WAREHOUSE;
            HGXHideShowClick();
        }

        private void btnHideShow4_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.DEBT;
            ButtonHideShowClick();
        }

        private void hgxDebtMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.DEBT;
            HGXHideShowClick();
        }

        private void btnHideShow5_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.LEDGER;
            ButtonHideShowClick();
        }

        private void hgxLedgerMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.LEDGER;
            HGXHideShowClick();
        }

        private void btnHideShow6_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.SYSTEM;
            ButtonHideShowClick();
        }

        private void hgxSystemMenu_Click(object sender, EventArgs e)
        {
            _currentMenu = Constants.SYSTEM;
            HGXHideShowClick();
        }

        private void ButtonHideShowClick()
        {
            SetCloseAllMenu();
            if (_currentMenu.Equals(Constants.CONSTRUCTION))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow1);
                isDown = Global.DownUpControl(this, hgxConsMenu, Constants.MAX_HEIGHT_HG_CONS, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.EMPLOYEE))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow2);
                isDown = Global.DownUpControl(this, hgxEmpMenu, Constants.MAX_HEIGHT_HG_EMP, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.WAREHOUSE))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow3);
                isDown = Global.DownUpControl(this, hgxWHMenu, Constants.MAX_HEIGHT_HG_WH, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.DEBT))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow4);
                isDown = Global.DownUpControl(this, hgxDebtMenu, Constants.MAX_HEIGHT_HG_DEBT, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            } 
            if (_currentMenu.Equals(Constants.LEDGER))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow5);
                isDown = Global.DownUpControl(this, hgxLedgerMenu, Constants.MAX_HEIGHT_HG_LEDGER, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.SYSTEM))
            {
                isDown = Global.btnHideShowHeaderGroupClick(btnHideShow6);
                isDown = Global.DownUpControl(this, hgxSystemMenu, Constants.MAX_HEIGHT_HG_SYSTEM, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
        }

        private void HGXHideShowClick()
        {
            SetCloseAllMenu();
            if (_currentMenu.Equals(Constants.CONSTRUCTION))
            {
                isDown = Global.btnHideShowClick(btnHideShow1);
                isDown = Global.DownUpControl(this, hgxConsMenu, Constants.MAX_HEIGHT_HG_CONS, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.EMPLOYEE))
            {
                isDown = Global.btnHideShowClick(btnHideShow2);
                isDown = Global.DownUpControl(this, hgxEmpMenu, Constants.MAX_HEIGHT_HG_EMP, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.WAREHOUSE))
            {
                isDown = Global.btnHideShowClick(btnHideShow3);
                isDown = Global.DownUpControl(this, hgxWHMenu, Constants.MAX_HEIGHT_HG_WH, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.DEBT))
            {
                isDown = Global.btnHideShowClick(btnHideShow4);
                isDown = Global.DownUpControl(this, hgxDebtMenu, Constants.MAX_HEIGHT_HG_DEBT, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.LEDGER))
            {
                isDown = Global.btnHideShowClick(btnHideShow5);
                isDown = Global.DownUpControl(this, hgxLedgerMenu, Constants.MAX_HEIGHT_HG_LEDGER, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
            if (_currentMenu.Equals(Constants.SYSTEM))
            {
                isDown = Global.btnHideShowClick(btnHideShow6);
                isDown = Global.DownUpControl(this, hgxSystemMenu, Constants.MAX_HEIGHT_HG_SYSTEM, Constants.MIN_HEIGHT_HEADER_GROUP, 20, isDown);
            }
        }

        private void SetCloseAllMenu()
        {
            if (!_currentMenu.Equals(Constants.CONSTRUCTION))
            {
                btnHideShow1.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxConsMenu, Constants.MAX_HEIGHT_HG_CONS, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            }
            if (!_currentMenu.Equals(Constants.EMPLOYEE))
            {
                btnHideShow2.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxEmpMenu, Constants.MAX_HEIGHT_HG_EMP, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            }
            if (!_currentMenu.Equals(Constants.WAREHOUSE))
            {
                btnHideShow3.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxWHMenu, Constants.MAX_HEIGHT_HG_WH, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            } if (!_currentMenu.Equals(Constants.DEBT))
            {
                btnHideShow4.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxDebtMenu, Constants.MAX_HEIGHT_HG_DEBT, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            } if (!_currentMenu.Equals(Constants.LEDGER))
            {
                btnHideShow5.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxLedgerMenu, Constants.MAX_HEIGHT_HG_LEDGER, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            }
            if (!_currentMenu.Equals(Constants.SYSTEM))
            {
                btnHideShow6.Type = PaletteButtonSpecStyle.ArrowDown;
                Global.DownUpControl(this, hgxSystemMenu, Constants.MAX_HEIGHT_HG_SYSTEM, Constants.MIN_HEIGHT_HEADER_GROUP, 20, false);
            }
        }

        private void tvwCons_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_CONSTRUCTION].IsSelected)
                {
                    ConstructionManagement constructionManagement = new ConstructionManagement();
                    constructionManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(constructionManagement);
                    constructionManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_SUBCONTRACTORS].IsSelected)
                {
                    SubconstractorManagement subCons = new SubconstractorManagement();
                    subCons.MdiParent = this;
                    pnlMainContent.Controls.Add(subCons);
                    subCons.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_WORKER].IsSelected)
                {
                    WorkerSalaryManagement workerSalaryManagement = new WorkerSalaryManagement();
                    workerSalaryManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(workerSalaryManagement);
                    workerSalaryManagement.Dock = DockStyle.Fill;
                    workerSalaryManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_ESTIMATE].IsSelected)
                {
                    EstimateManagement estimateManagement = new EstimateManagement();
                    estimateManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(estimateManagement);
                    estimateManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_ACCOUNT].IsSelected)
                {
                    FinalAccountManagement finalAccountManagement = new FinalAccountManagement();
                    finalAccountManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(finalAccountManagement);
                    finalAccountManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwCons.Nodes[Constants.MANAGE_PROCESS].IsSelected)
                {
                    ProgressManagement progressManagement = new ProgressManagement();
                    progressManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(progressManagement);
                    progressManagement.Show();
                    return;
                }
            }
            catch { }
        }

        private void tvwCons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwCons_NodeMouseDoubleClick(null, null);
            }
        }

        private void tvwEmp_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwEmp.Nodes[Constants.MANAGE_USER].IsSelected)
                {
                    EmployeeManagement employeeManagement = new EmployeeManagement();
                    employeeManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(employeeManagement);
                    employeeManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwEmp.Nodes[Constants.MANAGE_EMPLOYEE_SALARY].IsSelected)
                {
                    SalaryManagement salaryManagement = new SalaryManagement();
                    salaryManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(salaryManagement);
                    salaryManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwEmp.Nodes[Constants.MANAGE_EMPLOYEE_ADVANCE].IsSelected)
                {
                    AdvanceManagement advanceManagement = new AdvanceManagement();
                    advanceManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(advanceManagement);
                    advanceManagement.Show();
                    return;
                }
            }
            catch { }
        }

        private void tvwEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwEmp_NodeMouseDoubleClick(null, null);
            }
        }

        private void tvwWH_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwWH.Nodes[Constants.MANAGE_WAREHOUSE].IsSelected)
                {
                    WarehouseManagement warehouseManagement = new WarehouseManagement();
                    warehouseManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(warehouseManagement);
                    warehouseManagement.Show();
                    return;
                }
            }
            catch { }
            try
            {
                if (tvwWH.Nodes[Constants.MANAGE_STOCK].IsSelected)
                {
                    StockOutManagement stockOutManagement = new StockOutManagement();
                    stockOutManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(stockOutManagement);
                    stockOutManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwWH.Nodes[Constants.MANAGE_VEHICLE].IsSelected)
                {
                    VehicleManageMent vehicleManageMent = new VehicleManageMent();
                    vehicleManageMent.MdiParent = this;
                    pnlMainContent.Controls.Add(vehicleManageMent);
                    vehicleManageMent.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwWH.Nodes[Constants.MANAGE_MATERIAL].IsSelected)
                {
                    MaterialManagement materialManagement = new MaterialManagement();
                    materialManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(materialManagement);
                    materialManagement.Show();
                    return;
                }
            }
            catch { }
        }

        private void tvwWH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwWH_NodeMouseDoubleClick(null, null);
            }
        }

        private void tvwDebt_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwDebt.Nodes[Constants.MANAGE_DEBT].IsSelected)
                {
                    DebtManagement debtManagement = new DebtManagement();
                    debtManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(debtManagement);
                    debtManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwDebt.Nodes[Constants.MANAGE_COMPARE_DEBT].IsSelected)
                {
                    CompareDebtManagement compareDebtManagement = new CompareDebtManagement();
                    compareDebtManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(compareDebtManagement);
                    compareDebtManagement.Show();
                    return;
                }
            }
            catch { }
        }

        private void tvwDebt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwDebt_NodeMouseDoubleClick(null, null);
            }
        }

        private void tvwLedger_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwLedger.Nodes[Constants.MANAGE_LEDGER].IsSelected)
                {
                    LedgerManagement ledgerManagement = new LedgerManagement();
                    ledgerManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(ledgerManagement);
                    ledgerManagement.Show();
                }
            }
            catch { }
        }

        private void tvwLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwLedger_NodeMouseDoubleClick(null, null);
            }
        }

        private void tvwSystem_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwSystem.Nodes[Constants.MANAGE_MENU].IsSelected)
                {
                    MenuManagement menuManagement = new MenuManagement();
                    menuManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(menuManagement);
                    menuManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwSystem.Nodes[Constants.MANAGE_ROLE].IsSelected)
                {
                    RoleManagement roleManagement = new RoleManagement();
                    roleManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(roleManagement);
                    roleManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwSystem.Nodes[Constants.MANAGE_RIGHT].IsSelected)
                {
                    RightsManagement rightsManagement = new RightsManagement();
                    rightsManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(rightsManagement);
                    rightsManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwSystem.Nodes[Constants.RESET_PASSWORD].IsSelected)
                {
                    return;
                }
            }
            catch { }

        }

        private void tvwSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwSystem_NodeMouseDoubleClick(null, null);
            }
        }
    }
}