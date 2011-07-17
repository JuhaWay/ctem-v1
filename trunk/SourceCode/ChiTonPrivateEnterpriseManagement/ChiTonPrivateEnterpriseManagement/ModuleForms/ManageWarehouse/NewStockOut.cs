using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageWarehouse
{
    public partial class NewStockOut : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        bool isNew;
        bool isEdit;
        private readonly WarehouseBUS _warehouseBus = new WarehouseBUS();
        public NewStockOut()
        {
            InitializeComponent();
            isNew = true;
            isEdit = false;
        }

        private void NewStockOut_Load(object sender, EventArgs e)
        {
            setData();
            setLauout();
            if (isEdit)
            {
                setInnitLayout();
            }
        }

        private void setData()
        {
            Global.SetDataCombobox(cbbDriver, Constants.TO_PLACE);
            Global.SetDataCombobox(cbbmaterial, Constants.IS_PAY);
            Global.SetDataCombobox(cbbStockOutFrom, Constants.CONSTRUCTION);
            Global.SetDataCombobox(cbbStockOutTo, Constants.MAIN_WAREHOUSE);
            Global.SetDataCombobox(cbbTypyWarehouse, Constants.DEBT);
            Global.SetDataCombobox(cbbVehicle, Constants.DEBT);
            listMaterial = materialBUS.LoadAllMaterials();
            Global.SetDataCombobox(cbbMaterial, Constants.MATERIAL);
        }

        private void setLauout()
        {
            CenterToParent();
            Global.SetLayoutForm(this, Constants.DIALOG_FORM);
            Global.SetLayoutSplipContainerNewForm(slcFinalAccInfo);
            Global.SetLayoutGroupBoxNewForm(gbxEdit1);
            Global.SetLayoutGroupBoxNewForm(gbxEdit2);
            Global.SetLayoutPanelChildForm(pnlNewItem);
            Global.SetLayoutGroupBoxSearch(gbxNewItem);
            Global.SetLayoutHeaderGroup(hdDetailInfo, Constants.CHILD_FORM);
            Global.SetLayoutHeaderGroup(hdMainInfo, Constants.CHILD_FORM);
            Global.SetLayoutSplipContainer(slcMain, 1);
            Global.SetDaulftDatagridview(dgvAccDetail);
            Global.SetTextBoxNumberLeave(txtNo);
            Global.SetTextBoxNumberLeave(txtTransportationCost);
            Global.SetTextBoxNumberLeave(txtTotalCost);
            Global.SetTextBoxNumberLeave(txtQuantity);
            Global.SetTextBoxNumberLeave(txtUnitCost);
            Global.SetTextBoxNumberLeave(txtTotalCostItem);
            Global.TextBoxRequireInput(txtPersonAccount);
            Global.TextBoxRequireInput(txtNameFinalAccount);
        }

        private void setInnitLayout()
        {
            List<FinalAccountDTO> listaccount = finalaccountBUS.GetFinalAccountById(_id, dtpDateAccount.MinDate, dtpDateAccount.MaxDate);
            FinalAccountDTO currenAccount = listaccount[0];
            listFinalAccountDetail = finalaccountBUS.GetFinalAccountDetailByFAId(_id);
            RefreshDisplayData();
            txtNo.Text = currenAccount.FinalAccountID.ToString();
            txtNameFinalAccount.Text = currenAccount.FinalAccountName;
            txtNo.Text = currenAccount.Note;
            txtPersonAccount.Text = currenAccount.PersonAccount;
            txtTotalCost.Text = currenAccount.TotalCostFormated;
            txtTransportationCost.Text = currenAccount.TransportationCostFormated;
            if (currenAccount.ConstructionID == 0)
            {
                cbbToPlace.SelectedIndex = 1;
            }
            if (currenAccount.IsPay == 1)
            {
                cbbStatus.SelectedIndex = 0;
            }
            else
            {
                cbbStatus.SelectedIndex = 1;
            }
        }

        private void RefreshDisplayData()
        {
            dgvAccDetail.DataSource = null;
            dgvAccDetail.DataSource = listFinalAccountDetail;
            if (cbbMaterial.Items.Count > 0)
            {
                cbbMaterial.SelectedIndex = 0;
            }
            txtQuantity.Text = Constants.ZERO_NUMBER;
            txtUnitCost.Text = Constants.ZERO_NUMBER;
            txtTotalCostItem.Text = Constants.ZERO_NUMBER;
            txtNoteItem.Text = Constants.EMPTY_TEXT;
        }

    }
}