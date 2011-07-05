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
using ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEstimation;

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



            loadData();
          

        }


        public void loadData(){
            listConstructions = _constructionBus.LoadAllConstructions();
            dgvCons.Nodes.Clear();
            foreach (ConstructionDTO dto in listConstructions)
            {
                if (dto.ParentID == 0)
                {

                    TreeGridNode node = dgvCons.Nodes.Add(null, dto.ConstructionID, dto.ConstructionName,dto.Status, dto.HasEstimate, dto.TotalEstimateCost,dto.TotalRealCost, dto.SubcontractorName, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDate.ToString(), dto.CompletionDate.ToString(),dto.ParentID,dto.CreatedBy,dto.CreatedDate,dto.UpdatedBy,dto.LastUpdated);
                    
                    List<ConstructionDTO> children = _constructionBus.LoadChildenById(dto.ConstructionID);
                    foreach (ConstructionDTO child in children)
                    {
                        node.Nodes.Add(null, child.ConstructionID, child.ConstructionName,child.Status, child.HasEstimate, child.TotalEstimateCost,child.TotalRealCost, child.SubcontractorName, child.Description, child.ConstructionAddress,
                        child.CommencementDate.ToString(), child.CompletionDate.ToString(), child.ParentID,child.CreatedBy,child.CreatedDate,child.UpdatedBy,child.LastUpdated);
                    }
                    node.Expand();   

                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddConstruction panel = new AddConstruction();
            panel.ShowDialog();
            loadData();

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
                    long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                    long ConstructionID = Convert.ToInt64(strRightID);
                    if (ParentId==0)
                    {
                        AddConstruction editForm = new AddConstruction(ConstructionID);
                        editForm.ShowDialog();
                    }
                    else
                    {
                        AddSubconstruction editForm = new AddSubconstruction(ConstructionID);
                        editForm.ShowDialog();
                    }
                }
            }
            loadData();
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

        private void btSubcon_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                if (c.AccessibilityObject.Value.Equals("True") && ParentId==0)
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    AddSubconstruction editForm = new AddSubconstruction(ConstructionID,false);
                    editForm.ShowDialog();
                }
            }
            loadData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa công trình,dự toán?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCons.Rows)
                {
                    DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                    if (c.AccessibilityObject.Value.Equals("True"))
                    {
                        string strRightID = row.Cells["ConstructionID"].Value.ToString();
                        long ConstructionID = Convert.ToInt64(strRightID);
                        _constructionBus.DeleteConstruction(ConstructionID);
                    }
                }
            }
            loadData();
        }

        private void dgvCons_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dgvCons.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dgvCons, new Point(e.X, e.Y));

            }

        }

        private void btViewEst_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                if (c.AccessibilityObject.Value.Equals("True") && ParentId == 0)
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    EstimateManagement editForm = new EstimateManagement(ConstructionID);
                    editForm.ShowDialog();
                }
            }
            loadData();
        }

    }
}