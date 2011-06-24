using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageDebt;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation;
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageFinalAccount;
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

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EmployeeBUS employeeBUS;
        public MainForm()
        {
            InitializeComponent();
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            bsaProfiles.Text = Global.CurrentUser.Username + " (" + Global.CurrentUser.Fullname + ")";
            loadMenu();
        }

        private void loadMenu()
        {
            int numRootNodes = tvwMenu.Nodes.Count;
            for (int i = 0; i < numRootNodes; i++)
            {
                tvwMenu.Nodes.Remove(tvwMenu.Nodes[0]);
            }
            LeftMenuBUS leftMenuBUS = new LeftMenuBUS();
            List<LeftMenuDTO> listMenus = new List<LeftMenuDTO>();
            listMenus = leftMenuBUS.GetMenuByRoleID(Global.CurrentUser.RoleID);
            foreach (var menuparent in listMenus)
            {
                if (menuparent.MenuParent == 0)
                {
                    tvwMenu.Nodes.Add(menuparent.MenuName).Name = menuparent.MenuName;                    
                    var ParentNode = tvwMenu.Nodes[menuparent.MenuName];
                    ParentNode.ImageIndex = 0;
                    foreach (var menuchild in listMenus)
                    {
                        if (menuchild.MenuParent == menuparent.MenuID)
                        {
                            ParentNode.Nodes.Add(menuchild.MenuName).Name = menuchild.MenuName;
                            ParentNode.Nodes[menuchild.MenuName].ImageIndex = 1;
                        }
                    }
                }
            }
        }        

        private void btnhdgMenuHideShow_Click(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Left;
                hdgMenu.Width = Constants.WIDTH_MENU_HIDE;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_HIDE;
                slcMain.IsSplitterFixed = true;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowRight;
                hdgMenu.PaletteMode = PaletteMode.SparklePurple;                
            }
            else
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Top;
                hdgMenu.Width = Constants.WIDTH_MENU_SHOW;
                slcMain.SplitterDistance = Constants.WIDTH_MENU_SHOW;
                slcMain.IsSplitterFixed = false;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowLeft;
                hdgMenu.PaletteMode = PaletteMode.Global;
            }
        }

        private void hdgMenu_MouseHover(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = PaletteMode.Global;
            }
        }

        private void hdgMenu_MouseLeave(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.PaletteMode = PaletteMode.SparklePurple;
            }
        }

        private void tvwMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_MENU].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_ROLE].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_RIGHT].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_USER].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_CONSTRUCTION].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_DEBT].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_MATERIAL].IsSelected)
                {
                    return;
                }
            }
            catch { }
    
            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_SYSTEM].IsSelected)
                {
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_USER].Nodes[Constants.MANAGE_EMPLOYEE_SALARY].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_USER].Nodes[Constants.MANAGE_EMPLOYEE_ADVANCE].IsSelected)
                {
                    AdvanceManagement advanceManagement = new AdvanceManagement();
                    advanceManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(advanceManagement);
                    advanceManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_USER].Nodes[Constants.RESET_PASSWORD].IsSelected)
                {
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_CONSTRUCTION].Nodes[Constants.MANAGE_SUBCONTRACTORS].IsSelected)
                {
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_CONSTRUCTION].Nodes[Constants.MANAGE_WORKER].IsSelected)
                {
                    WorkerSalaryManagement workerSalaryManagement = new WorkerSalaryManagement();
                    workerSalaryManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(workerSalaryManagement);
                    workerSalaryManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_ESTIMATE_ACCOUNT].Nodes[Constants.MANAGE_ESTIMATE].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_ESTIMATE_ACCOUNT].Nodes[Constants.MANAGE_ACCOUNT].IsSelected)
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
                if (tvwMenu.Nodes[Constants.MANAGE_ESTIMATE_ACCOUNT].Nodes[Constants.MANAGE_PROCESS].IsSelected)
                {
                    return;
                }
            }
            catch { }


            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_WAREHOUSE].Nodes[Constants.MANAGE_MAIN_WAREHOUSE].IsSelected)
                {
                    WarehouseManagement warehouseManagement = new WarehouseManagement(Constants.MAIN_WAREHOUSE);
                    warehouseManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(warehouseManagement);
                    warehouseManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_WAREHOUSE].Nodes[Constants.MANAGE_CONSTRUCTION_WAREHOUSE].IsSelected)
                {
                    WarehouseManagement warehouseManagement = new WarehouseManagement(Constants.CONSTRUCTION_WAREHOUSE);
                    warehouseManagement.MdiParent = this;
                    pnlMainContent.Controls.Add(warehouseManagement);
                    warehouseManagement.Show();
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_WAREHOUSE].Nodes[Constants.MANAGE_STOCK].IsSelected)
                {
                    return;
                }
            }
            catch { }

            try
            {
                if (tvwMenu.Nodes[Constants.MANAGE_DEBT].Nodes[Constants.MANAGE_COMPARE_DEBT].IsSelected)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMenu();
        }

        private void tvwMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tvwMenu_NodeMouseDoubleClick(null, null);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.IsLogout = true;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm.IsLogout = false;
            Close();
        }

        private void txtProfiles_LinkClicked(object sender, EventArgs e)
        {
            Profiles profileForm = new Profiles(Global.CurrentUser);
            profileForm.ShowDialog();
        }
    }
}