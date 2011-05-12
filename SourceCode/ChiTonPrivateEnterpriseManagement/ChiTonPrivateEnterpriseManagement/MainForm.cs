using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;

namespace ChiTonPrivateEnterpriseManagement
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        Constants constant = new Constants();
        public MainForm()
        {
            InitializeComponent();
            LoadMenu(constant.ROLE_ADMIN);
        }

        private void LoadMenu (string role)
        {
            if (role.Equals(constant.ROLE_ADMIN))
            {
                LoadMenuManageEmployees(role);
            }

            if (role.Equals(constant.ROLE_MANAGER))
            {
                LoadMenuManageEmployees(role);
                LoadMenuManageConstruction(role);
            }

            if (role.Equals(constant.ROLE_CHIEF_ACCOUNTANT))
            {

            }

            if (role.Equals(constant.ROLE_ACCOUNTANT))
            {

            }
        }

        private void LoadMenuManageEmployees(string right)
        {
            tvwMenu.Nodes.Add(constant.MANAGE_EMPLOYEES).Name = constant.MANAGE_EMPLOYEES;
            var Manage_Employees = tvwMenu.Nodes[constant.MANAGE_EMPLOYEES];
            if (right.Equals(constant.ROLE_ADMIN))
            {
                Manage_Employees.Nodes.Add(constant.MANAGE_EMPLOYEES_INFO).Name = constant.MANAGE_EMPLOYEES_INFO;

            }
        }

        private void abc()
        {
            MessageBox.Show("abc");
        }

        private void LoadMenuManageConstruction(string right)
        {
            tvwMenu.Nodes.Add(constant.MANAGE_CONSTRUCTION).Name = constant.MANAGE_CONSTRUCTION;
            var Manage_Construction = tvwMenu.Nodes[constant.MANAGE_CONSTRUCTION];
            if (right.Equals(constant.ROLE_MANAGER))
            {
                Manage_Construction.Nodes.Add(constant.MANAGE_CONSTRUCTION_INFO);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnhdgMenuHideShow_Click(object sender, EventArgs e)
        {
            if (btnhdgMenuHideShow.Type == PaletteButtonSpecStyle.ArrowRight)
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Left;
                hdgMenu.Width = constant.WIDTH_MENU_HIDE;
                btnhdgMenuHideShow.Type = PaletteButtonSpecStyle.ArrowRight;
                hdgMenu.PaletteMode = PaletteMode.SparklePurple;                
            }
            else
            {
                hdgMenu.HeaderPositionPrimary = VisualOrientation.Top;
                hdgMenu.Width = constant.WIDTH_MENU_SHOW;
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
            if (tvwMenu.Nodes[constant.MANAGE_EMPLOYEES].Nodes[constant.MANAGE_EMPLOYEES_INFO].IsSelected)
            {
                abc();
            }
        }
    }
}