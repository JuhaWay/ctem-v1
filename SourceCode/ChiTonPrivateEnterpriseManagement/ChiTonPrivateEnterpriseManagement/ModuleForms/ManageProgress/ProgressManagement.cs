using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AdvancedDataGridView;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;
using heaparessential.HeaparGantt;
using Logger = ChiTonPrivateEnterpriseManagement.Classes.Global.Logger;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageProgress
{
    public partial class ProgressManagement : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private int currentTab;       
        private List<ConstructionDTO> listConstructions;
        private ConstructionBus _constructionBus = new ConstructionBus();
        public ProgressManagement()
        {
            InitializeComponent();
        }

        private void ProgressManagement_Load(object sender, EventArgs e)
        {
            currentTab = 0;
            SetLayoutTab();
            LoadData();
        }

        private void gbxTab1_Panel_Click(object sender, EventArgs e)
        {
            currentTab = 0;
            SetLayoutTab();
        }

        private void gbxTab2_Panel_Click(object sender, EventArgs e)
        {
            currentTab = 1;
            SetLayoutTab();
        }

        private void gbxTab2_Panel_MouseHover(object sender, EventArgs e)
        {
            if (currentTab != 1)
            {
                Global.TabHover(gbxTab2);                
            }
        }

        private void gbxTab2_Panel_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != 1)
            {
                Global.TabNormal(gbxTab2);
            }            
        }
    
        private void SetLayoutTab()
        {
            tclMain.SelectedIndex = currentTab;
            SetLayoutTabInit();
            if (currentTab == 0)
            {
                Global.TabEnter(gbxTab1);
            }

            if (currentTab == 1)
            {
                Global.TabEnter(gbxTab2);
            }

            if (currentTab == 2)
            {
                Global.TabEnter(gbxTab3);
            }
        }

        private void SetLayoutTabInit()
        {
            Global.TabNormal(gbxTab1);
            Global.TabNormal(gbxTab2);
            Global.TabNormal(gbxTab3);
        }

        private void gbxTab1_Panel_MouseHover(object sender, EventArgs e)
        {
            if (currentTab != 0)
            {
                Global.TabHover(gbxTab1);
            }
        }

        private void gbxTab1_Panel_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != 0)
            {
                Global.TabNormal(gbxTab1);
            }
        }

        private void kryptonGroupBox1_Panel_Click(object sender, EventArgs e)
        {
            currentTab = 2;
            SetLayoutTab();
        }

        private void kryptonGroupBox1_Panel_MouseHover(object sender, EventArgs e)
        {
            if (currentTab != 2)
            {
                Global.TabHover(gbxTab3);
            }
        }

        private void kryptonGroupBox1_Panel_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab != 2)
            {
                Global.TabNormal(gbxTab3);
            }
        }

        public void LoadData()
        {
            listConstructions = _constructionBus.LoadAllConstructions();
            gtcConsProgress.Items.Clear();
            foreach (ConstructionDTO dto in listConstructions)
            {
                if (dto.ParentID == 0)
                {
                    var jtiParent = new JobTreeItem();
                    jtiParent.Name = dto.ConstructionName;
                    jtiParent.StartDate = dto.CommencementDate;
                    jtiParent.EndDate = dto.CompletionDate;
                    gtcConsProgress.Items.Add(jtiParent);
                    List<ConstructionDTO> children = _constructionBus.LoadChildenById(dto.ConstructionID);
                    foreach (ConstructionDTO child in children)
                    {
                        var jtiChild = new JobTreeItem();
                        jtiChild.Name = child.ConstructionName;
                        jtiChild.StartDate = child.CommencementDate;
                        jtiChild.EndDate = child.CompletionDate;
                        jtiParent.Children.Add(jtiChild);
                    }
                }
            }
            gtcConsProgress.Ruler.StartDate = Global.GetFirstDateInMonth();
        }

        private void btnGotoNextMonth_Click(object sender, EventArgs e)
        {
            gtcConsProgress.Ruler.StartDate = gtcConsProgress.Ruler.StartDate.AddMonths(1);
            gtcConsProgress.Refresh();
        }

        private void btnGotoPreMonth_Click(object sender, EventArgs e)
        {
            gtcConsProgress.Ruler.StartDate = gtcConsProgress.Ruler.StartDate.AddMonths(-1);
            gtcConsProgress.Refresh();
        }

        private void gtcConsProgress_SelectedItemChanged(object sender, heaparessential.HeaparGantt.Common.JobTreeItemEventArgs args)
        {
            try
            {
                ConstructionDTO currentCons;
                String consName = gtcConsProgress.SelectedItem.Name;
                currentCons = _constructionBus.LoadConstructionReportByName(consName);
                
                // Set data progress
                TimeSpan tstotalDay = currentCons.CompletionDate - currentCons.CommencementDate;
                TimeSpan tsfinishDay = DateTime.Today - currentCons.CommencementDate;
                double totalDay = tstotalDay.TotalDays;
                double finishDay = tsfinishDay.TotalDays;
                double leftDay = totalDay - finishDay;
                txtTotalDay.Text = totalDay + " (Days)";
                txtFinishDay.Text = finishDay + " (Days)";
                txtLeft.Text = leftDay + " (Days)";                
                var progessobj = new object[2];
                progessobj[0] = new { Name = "Ngày Hoàn Thành(%)", Value = Global.Percentage(finishDay, totalDay) };
                progessobj[1] = new { Name = "Còn Lại(%)", Value = Global.Percentage(leftDay, totalDay) };
                Global.DrawChart(chartProgress, progessobj, "", SeriesChartType.Pie);

                //Set Data Disbursement
                txtTotalCostEst.Text = Global.ConvertLongToMoney(currentCons.TotalEstimateCost, ".") + " (VND)";
                txtTotalCostAct.Text = Global.ConvertLongToMoney(currentCons.TotalRealCost, ".") + " (VND)";
                txtTotalMaterialCost.Text = Global.ConvertLongToMoney(currentCons.TotalMaterialCost, ".") + " (VND)";
                txtTotalWorkerCost.Text = Global.ConvertLongToMoney(currentCons.TotalWorkerCost, ".") + " (VND)";
                txtTotalMachineCost.Text = Global.ConvertLongToMoney(currentCons.TotalMachineCost, ".") + " (VND)";
                txtTotalCostsIncurred.Text = Global.ConvertLongToMoney(currentCons.TotalCostsIncurred, ".") + " (VND)";
                txtOhter.Text = Global.ConvertLongToMoney(currentCons.TotalOtherCost, ".") + " (VND)";
                var disburobj = new object[5];
                if (currentCons.TotalMaterialCost > 0)
                {
                    disburobj[0] = new { Name = "Vật Tư(%)", Value = Global.Percentage(currentCons.TotalMaterialCost, currentCons.TotalRealCost) };                    
                }
                if (currentCons.TotalWorkerCost > 0)
                {
                    disburobj[1] = new { Name = "Nhân Công(%)", Value = Global.Percentage(currentCons.TotalWorkerCost, currentCons.TotalRealCost) };                    
                }
                if (currentCons.TotalMachineCost > 0)
                {
                    disburobj[2] = new { Name = "Máy Móc(%)", Value = Global.Percentage(currentCons.TotalMachineCost, currentCons.TotalRealCost) };                    
                }
                if (currentCons.TotalCostsIncurred > 0)
                {
                    disburobj[3] = new { Name = "Phát Sinh(%)", Value = Global.Percentage(currentCons.TotalCostsIncurred, currentCons.TotalRealCost) };                    
                }
                if (currentCons.TotalOtherCost > 0)
                {
                    disburobj[4] = new { Name = "Khác(%)", Value = Global.Percentage(currentCons.TotalOtherCost, currentCons.TotalRealCost) };                    
                }
                Global.DrawChart(chartDisbursement, disburobj, "", SeriesChartType.Pie);
            }
            catch (Exception)
            {
                Logger.WriteLog(LogLevel.DEBUG, string.Format("Not select item"));
            }            
        }

        private void tclMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tclMain.SelectedIndex == 0)
            {
                currentTab = 0;
                SetLayoutTab();
            }
            if (tclMain.SelectedIndex == 1)
            {
                currentTab = 1;
                SetLayoutTab();
            }
            if (tclMain.SelectedIndex == 2)
            {
                currentTab = 2;
                SetLayoutTab();
            }
        }   
    }   
}