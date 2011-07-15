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
using ChiTonPrivateEnterpriseManagement.Classes.Global;

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
        // load form
        private void ConstructionManagement_Load(object sender, EventArgs e)
        {
            SetLayout();         
            dtFromdate.Value = new DateTime(dtTodate.Value.Year, dtTodate.Value.Month - 5, dtTodate.Value.Day);
            search();
            displayButton();

        }

        private void SetLayout()
        {
            dgvCons.Focus();
            pnlSearch.Height = 72;
            gbxSearch.Height = 68;
            Global.SetLayoutForm(this, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdDebt, Constants.CHILD_FORM);
            Global.SetDaulftDatagridview(dgvCons);
            Global.SetLayoutGroupBoxSearch(gbxSearch);
            Global.SetLayoutPanelChildForm(pnlSearch);
            Global.SetLayoutButton(btnSearch);
        }
        
        // tao mới công trình chính cha
        private void btAddnew_Click(object sender, EventArgs e)
        {
            AddConstruction panel = new AddConstruction();
            panel.ShowDialog();
            search();
        }
        // tạo công trình con thuoc doanh nghiệp
        private void btAddChild_Click(object sender, EventArgs e)
        {

            string sParentId = dgvCons.SelectedRows[0].Cells["ParentId"].Value.ToString();
            long ParentId = Convert.ToInt64(sParentId);
            string sConstructionID = dgvCons.SelectedRows[0].Cells["ConstructionID"].Value.ToString();
            long ConstructionID = Convert.ToInt64(sConstructionID);
            AddConstruction editForm = new AddConstruction(ConstructionID, 1);
            editForm.ShowDialog();
            search();
        }
        // sửa công trình
        private void btEdit_Click(object sender, EventArgs e)
        {
           
            string sParentId = dgvCons.SelectedRows[0].Cells["ParentId"].Value.ToString();
            long ParentId = Convert.ToInt64(sParentId);
            string type = dgvCons.SelectedRows[0].Cells["Type"].Value.ToString();
            string sConstructionID = dgvCons.SelectedRows[0].Cells["ConstructionID"].Value.ToString();
            long ConstructionID = Convert.ToInt64(sConstructionID);
            if (ParentId == 0 || type.Trim().Equals(ConstructionDTO.MAIN))
            {
                AddConstruction editForm = new AddConstruction(ConstructionID);
                editForm.ShowDialog();
            }
            else
            {
                AddSubconstruction editForm = new AddSubconstruction(ConstructionID);
                editForm.ShowDialog();
            }
            search();
        }
       
        public void displayButton()
        {
            if (dgvCons.SelectedRows.Count <= 0) return;
            string sParentId = dgvCons.SelectedRows[0].Cells["ParentId"].Value.ToString();
            long ParentId = Convert.ToInt64(sParentId);

            if (dgvCons.SelectedRows.Count==1)
                btEdit.Enabled = ButtonEnabled.True;
            else
                btEdit.Enabled = ButtonEnabled.False;
            if (dgvCons.SelectedRows.Count == 1 && ParentId == 0)
            {
                btAddchild.Enabled = ButtonEnabled.True;
                btAddSubs.Enabled = ButtonEnabled.True;             
               
            }
            else
            {

                btAddchild.Enabled = ButtonEnabled.False;
                btAddSubs.Enabled = ButtonEnabled.False;
            }


        }
        // tạo công trình phụ 
        private void btAddSubConstractor_Click(object sender, EventArgs e)
        {
            string sConstructionID = dgvCons.SelectedRows[0].Cells["ConstructionID"].Value.ToString();
            long ConstructionID = Convert.ToInt64(sConstructionID);
            AddSubconstruction editForm = new AddSubconstruction(ConstructionID, false);
            editForm.ShowDialog();
            search();
        }

      
        // xóa công trình
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show("Xóa công trình,dự toán?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCons.SelectedRows)
                {
                    
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    _constructionBus.DeleteConstruction(ConstructionID);
      
                }
            }
            search();
        }

        // menu chuột phải
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
        // xem dự toán của công trình
        private void btViewEstimate_Click(object sender, EventArgs e)
        {
                 
                string sConstructionID = dgvCons.SelectedRows[0].Cells["ConstructionID"].Value.ToString();
                long ConstructionID = Convert.ToInt64(sConstructionID);
                bool HasEstimate = Convert.ToBoolean(dgvCons.SelectedRows[0].Cells["HasEstimate"].Value.ToString());
                if (HasEstimate)
                {
                    EstimateManagement editForm = new EstimateManagement(ConstructionID);
                    editForm.WindowState = FormWindowState.Normal;
                    editForm.ShowDialog();
                }

            search();
        }

        // xem tiến độ công trình
        private void btViewProgress_Click(object sender, EventArgs e)
        {

        }
        // xem giải ngân công trình
        private void btViewReal_Click(object sender, EventArgs e)
        {

        }
        //tím kiếm công trình
        private void btSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            ConstructionDTO dto = new ConstructionDTO();
            dto.ConstructionName = ipName.Text;
            if (cbStatus.SelectedIndex > -1)
                dto.Status = cbStatus.Text.Trim();
            else
            {
                dto.Status = "";
            }
            dto.FromDate = dtFromdate.Value;
            dto.ToDate = dtTodate.Value;
            searchData(dto);
        }
        public void searchData(ConstructionDTO con)
        {
            listConstructions = _constructionBus.SearchConstructions(con);
            dgvCons.Nodes.Clear();
            foreach (ConstructionDTO dto in listConstructions)
            {
                if (dto.ParentID == 0)
                {
                    List<ConstructionDTO> children = _constructionBus.LoadChildenById(dto.ConstructionID);
                    foreach (ConstructionDTO item in children)
                    {
                        dto.TotalEstimateCost += item.TotalEstimateCost;
                        dto.TotalRealCost += item.TotalRealCost;
                        dto.ProgressRate += item.ProgressRate;
                    }
                    dto.TotalEstimateCostFormated = Global.ConvertLongToMoney(dto.TotalEstimateCost,".");
                    dto.TotalRealCostFormated = Global.ConvertLongToMoney(dto.TotalRealCost, ".");
                    //dto.ProgressRate = dto.ProgressRate / children.Count;
                    TreeGridNode node = dgvCons.Nodes.Add(dto.ConstructionID, dto.ConstructionName, dto.type, dto.SubcontractorName, dto.Status, dto.ProgressRate, dto.TotalEstimateCostFormated, dto.TotalRealCostFormated, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDateFormated, dto.CompletionDateFormated, dto.ParentID, dto.CreatedBy, dto.CreateDateFormated, dto.UpdatedBy, dto.LastUpdatedFormated, dto.HasEstimate);                  
                    foreach (ConstructionDTO child in children)
                    {
                        node.Nodes.Add(child.ConstructionID, child.ConstructionName, child.type, child.SubcontractorName, child.Status, child.ProgressRate, child.TotalEstimateCostFormated, child.TotalRealCostFormated, child.Description, child.ConstructionAddress,
                        child.CommencementDateFormated, child.CompletionDateFormated, child.ParentID, child.CreatedBy, child.CreateDateFormated, child.UpdatedBy, child.LastUpdatedFormated, child.HasEstimate);
                    }
                    node.Expand();

                }
            }
        }

        private void dgvCons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            displayButton();
        }
       
    }
}