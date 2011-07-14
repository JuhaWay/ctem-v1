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
        private CheckBox _ckBox;
        public ConstructionManagement()
        {
            InitializeComponent();
        }
        // load form
        private void ConstructionManagement_Load(object sender, EventArgs e)
        {
            _ckBox = new CheckBox();
            Global.SetLayoutDataGridview(_ckBox, dgvCons);
            _ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            dtFromdate.Value = new DateTime(dtTodate.Value.Year, dtTodate.Value.Month - 5, dtTodate.Value.Day);
            search();

        }
        // check all check box
        void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.CheckBoxCheck(_ckBox, dgvCons);
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
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                if (c.AccessibilityObject.Value.Equals("True") && ParentId == 0)
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    AddConstruction editForm = new AddConstruction(ConstructionID,1);
                    editForm.ShowDialog();
                    break;
                }
            }
            search();
        }
        // sửa công trình
        private void btEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    string type = row.Cells["Type"].Value.ToString();
                    long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                    long ConstructionID = Convert.ToInt64(strRightID);
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
                }
            }
            search();
        }
        // sửa lổi chọn check box
        private void dgvCons_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell c = dgvCons.Rows[e.RowIndex].Cells[0];
            if(e.ColumnIndex==0){
                dgvCons.BeginEdit(true);            
                if (c.AccessibilityObject.Value.Equals("False"))
                        c.AccessibilityObject.Value = "True";
                else
                    c.AccessibilityObject.Value = "False";
            }
            displayButton();
        }
        public void displayButton()
        {
            int count = 0;
            int countParent = 0;
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                if (c.AccessibilityObject.Value.Equals("True"))
                {
                    long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                    if (ParentId == 0)
                        countParent++;
                    count++;
                }
            }
            if (countParent == 1 && count == 1)
            {
                btAddChild.Enabled = ButtonEnabled.True;
                btAddSubConstractor.Enabled = ButtonEnabled.True;
            }
            else
            {
                btAddChild.Enabled = ButtonEnabled.False;
                btAddSubConstractor.Enabled = ButtonEnabled.False;
            }

        }
        // tạo công trình phụ 
        private void btAddSubConstractor_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                if (c.AccessibilityObject.Value.Equals("True") && ParentId == 0)
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    AddSubconstruction editForm = new AddSubconstruction(ConstructionID, false);
                    editForm.ShowDialog();
                }
            }
            search();
        }

      
        // xóa công trình
        private void btDelete_Click(object sender, EventArgs e)
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
            foreach (DataGridViewRow row in dgvCons.Rows)
            {
                DataGridViewCell c = dgvCons.Rows[row.Index].Cells[0];
                long ParentId = Convert.ToInt64(row.Cells["ParentId"].Value.ToString());
                bool HasEstimate = Convert.ToBoolean(row.Cells["HasEstimate"].Value.ToString());
                if (c.AccessibilityObject.Value.Equals("True") && HasEstimate)
                {
                    string strRightID = row.Cells["ConstructionID"].Value.ToString();
                    long ConstructionID = Convert.ToInt64(strRightID);
                    EstimateManagement editForm = new EstimateManagement(ConstructionID);
                    editForm.ShowDialog();
                }
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
                    dto.ProgressRate = dto.ProgressRate / children.Count;
                    TreeGridNode node = dgvCons.Nodes.Add(null, dto.ConstructionID, dto.ConstructionName, dto.Status,dto.ProgressRate, dto.TotalEstimateCost, dto.TotalRealCost,dto.type, dto.SubcontractorName, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDate.ToString(), dto.CompletionDate.ToString(), dto.ParentID, dto.CreatedBy, dto.CreatedDate, dto.UpdatedBy, dto.LastUpdated,dto.HasEstimate);                  
                    foreach (ConstructionDTO child in children)
                    {
                        node.Nodes.Add(null, child.ConstructionID, child.ConstructionName, child.Status, child.ProgressRate, child.TotalEstimateCost, child.TotalRealCost,child.type, child.SubcontractorName, child.Description, child.ConstructionAddress,
                        child.CommencementDate.ToString(), child.CompletionDate.ToString(), child.ParentID, child.CreatedBy, child.CreatedDate, child.UpdatedBy, child.LastUpdated,child.HasEstimate);
                    }
                    node.Expand();

                }
            }
        }
        // sửa lỏi checkbox
        private void dgvCons_Scroll(object sender, ScrollEventArgs e)
        {
            _ckBox.Visible = false;
            if(e.NewValue<=10)
                _ckBox.Visible = true;
        }

  
       
    }
}