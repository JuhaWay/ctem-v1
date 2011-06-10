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
using AdvancedDataGridView;

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
                //dgvCons.DataSource = listConstructions;
                foreach (ConstructionDTO dto in listConstructions)
                {
                    TreeGridNode node = dgvCons.Nodes.Add(null,dto.ConstructionID, dto.ConstructionName,dto.SubcontractorName, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDate.ToString(), dto.CompletionDate.ToString(), "123");
                    node.Nodes.Add(null, dto.ConstructionID, dto.ConstructionName, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDate.ToString(), dto.CompletionDate.ToString(), "123"); ;
                }
          

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddConstruction panel = new AddConstruction();
            panel.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddConstruction form = new AddConstruction();

            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    AddConstruction editForm = new AddConstruction(ConstructionID);
                    editForm.ShowDialog();
                }
            }
        }

        private void dgvCons_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex==0){
            dgvCons.BeginEdit(true);
            DataGridViewCell c = dgvCons.Rows[e.RowIndex].Cells[0];
            if (c.AccessibilityObject.Value.Equals("False"))
                    c.AccessibilityObject.Value = "True";
            else
                c.AccessibilityObject.Value = "False";
            }
        }

    }
}