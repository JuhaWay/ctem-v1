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
    public partial class NewEmployee : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private bool isNext;
        private bool isPre;
        private List<RoleDTO> listRoles = new List<RoleDTO>();
        private List<RightDTO> listRights = new List<RightDTO>();
        private RoleBUS roleBUS = new RoleBUS();
        private RightBUS rightBUS = new RightBUS();

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            CenterToParent();
            slcMain.SplitterDistance = Width;
            loadRole();
            loadRight();
            DefineStatus();
        }

        private void DefineStatus()
        {
            cbbStatus.Items.Add(Constants.ACTIVE);
            cbbStatus.Items.Add(Constants.INACTIVE);
            cbbStatus.SelectedIndex = 0;
        }

        private void loadRole()
        {
            listRoles = roleBUS.GetAll();
            foreach (var role in listRoles)
            {
                cbbRole.Items.Add(role);
            }
            cbbRole.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
            cbbRole.ValueMember = Constants.ROLE_VALUEMEMBER;
        }

        private void loadRight()
        {
            listRights = new List<RightDTO>();
            listRights = rightBUS.LoadAllRight();
            foreach (RightDTO right in listRights)
            {
                clbRights.ListBox.Items.Add(right);
            }
            clbRights.ListBox.ValueMember = Constants.RIGHT_VALUEMEMBER;
            clbRights.ListBox.DisplayMember = Constants.RIGHT_DISPLAYMEMBER;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            isNext = true;
            timerLayoutSLC.Enabled = true;            
        }

        private void timerLayoutSLC_Tick(object sender, EventArgs e)
        {            
            slcMain.ContainerBackStyle = PaletteBackStyle.ControlClient;            
            if (isNext)
            {
                while (slcMain.SplitterDistance > (slcMain.SplitterWidth + 1))
                {
                    slcMain.SplitterDistance -= 10;
                    Refresh();
                }
            }
            if (isPre)
            {
                while (slcMain.SplitterDistance < (Width - (slcMain.SplitterWidth + 16)))
                {
                    slcMain.SplitterDistance += 10;
                    Refresh();
                }

                isPre = false;
                timerLayoutSLC.Enabled = false;
            }            
            slcMain.ContainerBackStyle = PaletteBackStyle.PanelClient;            
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            isPre = true;
            timerLayoutSLC.Enabled = true;            
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRights.ListBox.Items.Count; i++)
            {
                clbRights.SetItemChecked(i, false);
            }
            RoleDTO selectedRole = (RoleDTO)cbbRole.SelectedItem;
            List<RightDTO> listRightForRole = new List<RightDTO>();
            listRightForRole = rightBUS.GetRightByRole(selectedRole.RightsValue);
            foreach (RightDTO right in listRightForRole)
            {
                clbRights.SelectedItem = right;
            }
        }

        private void clbRights_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbRights.ListBox.SelectedIndex;
            clbRights.SetItemChecked(index, true);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void rdbFull_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFull.Checked == true)
            {
                foreach (RightDTO item in clbRights.Items)
                {
                        
                }
            }
        }
    }
}