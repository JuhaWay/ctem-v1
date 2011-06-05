using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Modules;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageConstruction
{
    public partial class ConstructionManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        private List<ConstructionDTO> listConstructions;
        private ConstructionBus _constructionBus = new ConstructionBus();
        public ConstructionManagement()
        {
            InitializeComponent();
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConstructionManagement_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo;
            dbInfo = new DatabaseInfo();
            dbInfo.LoadInfo();


            listConstructions = _constructionBus.LoadAllConstructions();
            dgvCons.DataSource = listConstructions;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddConstruction panel = new AddConstruction();
            panel.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strConstructionID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strConstructionID);
                }
            }
        }
    }
}