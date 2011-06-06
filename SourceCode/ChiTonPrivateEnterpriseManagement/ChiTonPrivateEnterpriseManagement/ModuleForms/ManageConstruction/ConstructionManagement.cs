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
                    TreeGridNode node = dgvCons.Nodes.Add(null, dto.ConstructionName, dto.Description, dto.ConstructionAddress,
                        dto.CommencementDate.ToString(), dto.CompletionDate.ToString(), "123");
                    node.Nodes.Add(null, dto.ConstructionName, dto.Description, dto.ConstructionAddress,
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
            
        }
    }
}