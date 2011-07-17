using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using ChiTonPrivateEnterpriseManagement.Classes.BUS;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    class Global
    {
        public static List<RightDTO> Rights;
        public static EmployerDTO CurrentUser;
        public static string SEP = ".";
        public static List<string> ListError = new List<string>();
        public static bool DownUpControl(KryptonForm form, KryptonPanel panel, int maxheight, int minheight, int speed, bool isDown)
        {
            if (isDown)
            {
                while (panel.Height <= maxheight)
                {
                    panel.Height += speed;
                    form.Refresh();
                }
                if (panel.Height > maxheight)
                {
                    panel.Height = maxheight;
                }
                isDown = false;
            }
            else if (!isDown)
            {
                while (panel.Height >= minheight)
                {
                    panel.Height -= speed;
                    form.Refresh();
                }
                if (panel.Height < minheight)
                {
                    panel.Height = minheight;
                }
                isDown = true;
            }
            return isDown;
        }

        public static bool DownUpControl(KryptonForm form, KryptonHeaderGroup headerGroup, int maxheight, int minheight, int speed, bool isDown)
        {
            if (isDown)
            {                
                headerGroup.Height = maxheight;
                isDown = false;
            }
            else if (!isDown)
            {                
                headerGroup.Height = minheight;                
                isDown = true;
            }
            return isDown;
        }

        public static void TextHint(KryptonTextBox txtHint, Color color, string fontstyle, int fontsize)
        {
            Font fontHint = new Font(new FontFamily(fontstyle), fontsize, FontStyle.Italic);
            txtHint.StateCommon.Content.Font = fontHint;
            txtHint.StateCommon.Content.Color1 = color;
        }

        public static void TextContent(KryptonTextBox txtContent, Color color, string fontstyle, int fontsize)
        {
            Font fontContent = new Font(new FontFamily(fontstyle), fontsize, FontStyle.Regular);
            txtContent.StateCommon.Content.Font = fontContent;
            txtContent.StateCommon.Content.Color1 = color;
        }

        public static void CenterToParent(KryptonPanel child, KryptonForm parent, string direction, int space)
        {
            int locationX = 0;
            int locationY = 0;
            if (direction.Equals(Constants.HORISONTAL_TOP))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - child.Height;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT))
            {
                locationX = 0;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT))
            {
                locationX = parent.Width - child.Width;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.HORISONTAL_TOP_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0 + space;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - space;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT_CUSTOM))
            {
                locationX = 0 + space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT_CUSTOM))
            {
                locationX = parent.Width - space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.CENTER))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            child.Location = new Point(locationX, locationY);

        }

        public static void CenterToParent(KryptonPanel child, KryptonPanel parent, string direction, int space)
        {
            int locationX = 0;
            int locationY = 0;
            if (direction.Equals(Constants.HORISONTAL_TOP))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - child.Height;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT))
            {
                locationX = 0;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT))
            {
                locationX = parent.Width - child.Width;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.HORISONTAL_TOP_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0 + space;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - space;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT_CUSTOM))
            {
                locationX = 0 + space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT_CUSTOM))
            {
                locationX = parent.Width - space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.CENTER))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            child.Location = new Point(locationX, locationY);

        }

        public static void CenterToParent(KryptonButton child, KryptonPanel parent, string direction, int space)
        {
            int locationX = 0;
            int locationY = 0;
            if (direction.Equals(Constants.HORISONTAL_TOP))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - child.Height;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT))
            {
                locationX = 0;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT))
            {
                locationX = parent.Width - child.Width;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.HORISONTAL_TOP_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = 0 + space;
            }
            if (direction.Equals(Constants.HORISONTAL_BOT_CUSTOM))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height - space;
            }
            if (direction.Equals(Constants.VERTICAL_LEFT_CUSTOM))
            {
                locationX = 0 + space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.VERTICAL_RIGHT_CUSTOM))
            {
                locationX = parent.Width - space;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            if (direction.Equals(Constants.CENTER))
            {
                locationX = parent.Width / 2 - child.Width / 2;
                locationY = parent.Height / 2 - child.Height / 2;
            }
            child.Location = new Point(locationX, locationY);
        }

        public static bool ValidateLongNumber(string strLong)
        {
            try
            {                
                Convert.ToInt64(strLong);
                return true;
            }
            catch (Exception)
            {                
                return false;
            }
        }

        public static bool ValidateMoney(KryptonTextBox textBox)
        {
            try
            { 
                string strLong = textBox.Text.Trim().Replace(".", "");
                Convert.ToInt64(strLong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ValidateIntNumber(string strInt)
        {
            try
            {
                Convert.ToInt32(strInt);
                return true;
            }
            catch (Exception)
            {                
                return false;
            }
        }

        public static bool ValidateDoubleNumber(string strDouble)
        {
            try
            {
                Convert.ToDouble(strDouble);
                return true;
            }
            catch (Exception)
            {
               
                return false;
            }
        }

        public static bool ValidateULongNumber(string strULong)
        {
            try
            {
                Convert.ToUInt64(strULong);
                return true;
            }
            catch (Exception)
            {
                //KryptonMessageBox.Show(Constants.INVALIDATE_VALUE, Constants.CONFIRM, MessageBoxButtons.OK,
                //                MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool isNumber(string text)
        {
            bool textIsNumeric = true;
            try
            {
               long.Parse(text);
            }
            catch
            {
                textIsNumeric = false;
            }
            return textIsNumeric;
        }

        public static void SetDataCombobox(KryptonComboBox cbbControl, string obj)
        {
            if (obj.Equals(Constants.MATERIAL_SEARCH))
            {
                var materialBus = new MaterialBUS();
                var listMaterial = materialBus.LoadAllMaterials();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                foreach (MaterialDTO item in listMaterial)
                {
                    cbbControl.Items.Add(item.MaterialName);
                }
            }
            if (obj.Equals(Constants.CONSTRUCTION))
            {
                var constructionBus = new ConstructionBus();
                cbbControl.DataSource = constructionBus.LoadAllConstructions();
                cbbControl.ValueMember = Constants.CONSTRUCTION_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.CONSTRUCTION_DISPLAYMEMBER;
            }
            if (obj.Equals(Constants.CONSTRUCTION_SEARCH))
            {
                var constructionBus = new ConstructionBus();
                var listCons = constructionBus.LoadAllConstructions();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                foreach (ConstructionDTO cons in listCons)
                {
                    cbbControl.Items.Add(cons.ConstructionName);
                }
            }
            if (obj.Equals(Constants.ACCOUNT_SEARCH))
            {
                var accountBus = new FinalAccountBUS();
                var listacc = accountBus.GetFinalAccount(0, Constants.EMPTY_TEXT, Constants.EMPTY_TEXT, Constants.EMPTY_TEXT, DateTime.Parse("1/1/1753 12:00:00 AM"), DateTime.Parse("12/31/9998 12:00:00 AM"));
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                foreach (FinalAccountDTO acc in listacc)
                {
                    cbbControl.Items.Add(acc.FinalAccountName);
                }
            }
            if (obj.Equals(Constants.USER))
            {
                var employeeBus = new EmployeeBUS();
                cbbControl.DataSource = employeeBus.LoadAllUser();
                cbbControl.ValueMember = Constants.EMPLOYEE_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.EMPLOYEE_DISPLAYMEMBER;
            }

            if (obj.Equals(Constants.EMPLOYEE))
            {
                var employeeBus = new EmployeeBUS();
                cbbControl.DataSource = employeeBus.LoadAllEmployee();
                cbbControl.ValueMember = Constants.EMPLOYEE_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.EMPLOYEE_DISPLAYMEMBER;
            }

            if (obj.Equals(Constants.EMPLOYEE_SEARCH))
            {
                var employeeBus = new EmployeeBUS();
                var listEmp = new List<EmployerDTO>();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                listEmp = employeeBus.LoadAllEmployee();
                foreach (EmployerDTO emp in listEmp)
                {
                    cbbControl.Items.Add(emp.Fullname);
                }
            }

            if (obj.Equals(Constants.DEBT))
            {
                var debtBus = new DebtBUS();
                cbbControl.DataSource = debtBus.GetDebt(0, Constants.EMPTY_TEXT, -1);
                cbbControl.ValueMember = Constants.DEBT_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.DEBT_DISPLAYMEMBER;
            }

            if (obj.Equals(Constants.DEBT_SEARCH))
            {
                var debtBus = new DebtBUS();
                var listDebt = new List<DebtDTO>();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                listDebt = debtBus.GetDebt(0, Constants.EMPTY_TEXT, -1);
                foreach (DebtDTO debtDTO in listDebt)
                {
                    cbbControl.Items.Add(debtDTO.DebtName);
                }
            }
            
            if (obj.Equals(Constants.STATUS))
            {
                cbbControl.Items.Add(Constants.ACTIVE);
                cbbControl.Items.Add(Constants.INACTIVE);
            }

            if (obj.Equals(Constants.STATUS_SEARCH))
            {
                cbbControl.Items.Add(Constants.ALL);
                cbbControl.Items.Add(Constants.ACTIVE);
                cbbControl.Items.Add(Constants.INACTIVE);
            }

            if (obj.Equals(Constants.MATERIAL))
            {
                var materialBus = new MaterialBUS();
                cbbControl.DataSource = materialBus.LoadAllMaterials();
                cbbControl.ValueMember = Constants.MATERIAL_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.MATERIAL_DISPLAYMEMBER;
            }

            if (obj.Equals(Constants.TO_PLACE))
            {
                cbbControl.Items.Add(Constants.CONSTRUCTION_WAREHOUSE);
                cbbControl.Items.Add(Constants.MAIN_WAREHOUSE);
            }

            if (obj.Equals(Constants.IS_PAY))
            {
                cbbControl.Items.Add(Constants.PAY);
                cbbControl.Items.Add(Constants.NOTPAY);
            }

            if (obj.Equals(Constants.MAIN_WAREHOUSE))
            {
                var warehouseBus = new WarehouseBUS();
                cbbControl.DataSource = warehouseBus.LoadWarehouses(Constants.EMPTY_TEXT, Constants.MAIN_WAREHOUSE, -1);
                cbbControl.ValueMember = Constants.WAREHOUSE_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.WAREHOUSE_DISPLAYMEMBER;
            }

            if (obj.Equals(Constants.WAREHOUSE_TYPE))
            {
                cbbControl.Items.Add(Constants.CONSTRUCTION_WAREHOUSE);
                cbbControl.Items.Add(Constants.MAIN_WAREHOUSE);
            }

            if (obj.Equals(Constants.WAREHOUSE_SEARCH))
            {                
                var warehouseBus = new WarehouseBUS();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                List<WarehouseDTO> listWH = warehouseBus.LoadWarehouses(Constants.EMPTY_TEXT, Constants.EMPTY_TEXT, -1);
                foreach (WarehouseDTO WHDTO in listWH)
                {
                    cbbControl.Items.Add(WHDTO.WarehouseName);
                }
            }

            if (obj.Equals(Constants.WAREHOUSE_TYPE_SEARCH))
            {
                cbbControl.Items.Add(Constants.ALL);
                cbbControl.Items.Add(Constants.CONSTRUCTION_WAREHOUSE);
                cbbControl.Items.Add(Constants.MAIN_WAREHOUSE);
            }

            if (obj.Equals(Constants.ROLE))
            {
                var roleBus = new RoleBUS();
                cbbControl.DataSource = roleBus.GetWithoutAdmin();
                cbbControl.DisplayMember = Constants.ROLE_DISPLAYMEMBER;
                cbbControl.ValueMember = Constants.ROLE_VALUEMEMBER;
            }

            if (obj.Equals(Constants.ROLE_SEARCH))
            {
                var roleBus = new RoleBUS();
                cbbControl.Items.Clear();
                cbbControl.Items.Add(Constants.ALL);
                List<RoleDTO> lisRole = roleBus.GetWithoutAdmin();
                foreach (RoleDTO roleDTO in lisRole)
                {
                    cbbControl.Items.Add(roleDTO.RoleName);
                }
            }

            if (cbbControl.Items.Count > 0)
            {
                cbbControl.SelectedIndex = 0;                
            }
            
        }

        public static long GetDataCombobox(KryptonComboBox cbbControl, string obj)
        {
            if (obj.Equals(Constants.EMPLOYEE))
            {
                var empObj = (EmployerDTO) cbbControl.SelectedItem;
                return empObj.employeeID;
            }
            if (obj.Equals(Constants.DEBT))
            {
                var debtObj = (DebtDTO) cbbControl.SelectedItem;
                return debtObj.DebtID;
            }
            if (obj.Equals(Constants.ROLE))
            {
                var roleObj = (RoleDTO)cbbControl.SelectedItem;
                return roleObj.RoleID;
            }
            return 0;
        }

        public static bool IsAllow(string right)
        {
            long rightValue = 0;
            foreach (RightDTO rightDTO in Global.Rights)
            {
                if (right.Equals(rightDTO.RightName))
                {
                    rightValue = rightDTO.Value;
                }
            }
            return (rightValue & CurrentUser.RightsValue) != 0;
        }

        public static void SetDataTextBox(List<KryptonTextBox> listtxtControl, string obj)
        {
            foreach (KryptonTextBox txtControl in listtxtControl)
            {
                if (obj.Equals(Constants.NUMBER))
                {
                    txtControl.Text = Constants.ZERO_NUMBER;
                }
            }            
        }

        public static void SetDataTextBox(KryptonTextBox txtControl, string obj)
        {
            if (obj.Equals(Constants.NUMBER))
            {
                txtControl.Text = Constants.ZERO_NUMBER;
            }
        }

        public static void SetLayoutDataGridview(CheckBox _ckBox, KryptonDataGridView dgvControl)
        {
            dgvControl.RowHeadersWidth = 25;
            dgvControl.Columns[0].Width = 25;
            dgvControl.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvControl.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Rectangle rect = dgvControl.GetCellDisplayRectangle(0, -1, true);
            _ckBox.Size = new Size(18, 18);            
            _ckBox.BackColor = Color.Transparent;
            rect.Location = new Point(30, 4);
            _ckBox.Location = rect.Location;
            dgvControl.Controls.Add(_ckBox);
        }

        public static void CheckBoxCheck(CheckBox _ckBox, KryptonDataGridView dgvControl)
        {
            for (int j = 0; j < dgvControl.RowCount; j++)
            {
                DataGridViewCell c = dgvControl.Rows[j].Cells[0];
                c.AccessibilityObject.Value = _ckBox.Checked.ToString();
                dgvControl[0, j].Value = _ckBox.Checked;
                dgvControl.Rows[j].Selected = _ckBox.Checked;
            }
            dgvControl.EndEdit();
            dgvControl.Refresh();

        }

        public static long ConvertMoneyToLong(string strValue, string charFomat)
        {
            try
            {
                return Convert.ToInt64(strValue.Trim().Replace(charFomat, Constants.EMPTY_TEXT));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string ConvertLongToMoney(long number, string charFomat)
        {
            string result = Constants.EMPTY_TEXT;
            string strNumber = number.ToString();
            int sizeStr = strNumber.Length;
            for (int i = 0; i < sizeStr; i++)
            {
                result += strNumber[i];
                int tempSize = sizeStr - i - 1;
                float a = (sizeStr - i - 1) % 3;
                if (tempSize != 0 && a == 0)
                {
                    result += ".";                    
                }
            }            
            return result;
        }

        public static void TextBoxRequireInput(KryptonTextBox textBox)
        {
            textBox.StateCommon.Border.Color1 = Color.Red;
            textBox.StateCommon.Border.Color2 = Color.Red;
            textBox.StateCommon.Border.ColorStyle = PaletteColorStyle.SolidAllLine;
            textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.Bottom;
        }

        public static void TextBoxRequireInputed(KryptonTextBox textBox)
        {
            textBox.StateCommon.Border.Color1 = Color.Empty;
            textBox.StateCommon.Border.Color2 = Color.Empty;
            textBox.StateCommon.Border.ColorStyle = PaletteColorStyle.Inherit;
            textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.Inherit;
        }

        public static List<RoleDTO> SetCompleteRole(List<RoleDTO> listItem, string keySearch)
        {
            var listDes = new List<RoleDTO>();
            foreach (var item in listItem)
            {
                if (item.RoleName.Contains(keySearch))
                {
                    listDes.Add(item);
                }
            }
            return listDes;
        }

        public static void TabNormal(KryptonGroupBox groupBox)
        {
            groupBox.Height = 27;
            groupBox.Location = new Point(groupBox.Location.X, 30 - groupBox.Height);
            groupBox.StateCommon.Back.Color1 = Color.Khaki;
            groupBox.StateCommon.Back.Color2 = Color.White;
            groupBox.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassCenter;
            groupBox.StateCommon.Border.Color1 = Color.Gold;
            groupBox.StateCommon.Border.Color2 = Color.White;
            groupBox.StateCommon.Border.ColorStyle = PaletteColorStyle.SolidInside;
            groupBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.TopLeftRight;
            groupBox.StateCommon.Border.Rounding = 5;
        }

        public static void TabHover(KryptonGroupBox groupBox)
        {
            groupBox.Height = 27;
            groupBox.Location = new Point(groupBox.Location.X, 30 - groupBox.Height);
            groupBox.StateCommon.Back.Color1 = Color.Orange;
            groupBox.StateCommon.Back.Color2 = Color.White;
            groupBox.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassCenter;
            groupBox.StateCommon.Border.Color1 = Color.Orange;
            groupBox.StateCommon.Border.Color2 = Color.White;
            groupBox.StateCommon.Border.ColorStyle = PaletteColorStyle.SolidInside;
            groupBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.TopLeftRight;
            groupBox.StateCommon.Border.Rounding = 5;
        }

        public static void TabEnter(KryptonGroupBox groupBox)
        {
            groupBox.Height = 30;
            groupBox.Location = new Point(groupBox.Location.X, 30 - groupBox.Height);
            groupBox.StateCommon.Back.Color1 = Color.NavajoWhite;
            groupBox.StateCommon.Back.Color2 = Color.White;
            groupBox.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;
            groupBox.StateCommon.Border.Color1 = Color.Red;
            groupBox.StateCommon.Border.Color2 = Color.White;
            groupBox.StateCommon.Border.ColorStyle = PaletteColorStyle.SolidInside;
            groupBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.TopLeftRight;
            groupBox.StateCommon.Border.Rounding = 5;
        }

        public static double Percentage(double numerator, double denominator)
        {
            double result = (numerator/denominator)*100;
            result = Convert.ToDouble(result.ToString("0.00"));
            return result;
        }

        public static void DrawChart(Chart chart, object[] obj, string title, SeriesChartType chartType)
        {
            chart.Titles.Clear();
            chart.Titles.Add(title);
            chart.Series[0].Points.DataBindXY(obj, "Name", obj, "Value");
            chart.Series[0].ChartType = chartType;// Set the bar width
            chart.Series[0]["PointWidth"] = "0.5";// Show data points labels
            chart.Series[0].IsValueShownAsLabel = true;// Set data points label style
            chart.Series[0]["BarLabelStyle"] = "Center";// Show chart as 3D
            chart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;// Draw chart as 3D Cylinder
            chart.Series[0]["DrawingStyle"] = "Cylinder";
        }

        public static DateTime GetFirstDateInMonth()
        {            
            string month = DateTime.Today.Month.ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            string year = DateTime.Today.Year.ToString();
            string firstDateInMonthStr = month + "/01/" + year + " 00:00:00";
            return DateTime.ParseExact(firstDateInMonthStr, "MM/dd/yyyy hh:mm:ss", null);
        }

        public static bool btnHideShowClick(ButtonSpecAny btnHideShow)
        {
            bool isDown;
            if (btnHideShow.Type == PaletteButtonSpecStyle.ArrowDown)
            {
                btnHideShow.Type = PaletteButtonSpecStyle.ArrowUp;
                isDown = true;
            }
            else
            {
                btnHideShow.Type = PaletteButtonSpecStyle.ArrowDown;
                isDown = false;
            }
            return isDown;
        }

        public static bool btnHideShowHeaderGroupClick(ButtonSpecAny btnHideShow)
        {
            bool isDown;
            if (btnHideShow.Type == PaletteButtonSpecStyle.ArrowDown)
            {
                isDown = false;
            }
            else
            {
                isDown = true;
            }
            return isDown;
        }
        public static void SetLayoutForm(KryptonForm form, string type)
        {
            if (type.Equals(Constants.CHILD_FORM))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.WindowState = FormWindowState.Maximized;
                form.GroupBorderStyle = PaletteBorderStyle.InputControlRibbon;
                form.MinimumSize = new Size(800, 600);

                
                form.StateCommon.Header.Back.Color1 = Color.Khaki;
                form.StateCommon.Header.Back.Color2 = Color.White;
                form.StateCommon.Header.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;

                form.StateCommon.Header.Content.ShortText.Color1 = Color.Black;
                form.StateCommon.Header.Content.ShortText.Color2 = Color.Black;
                form.StateCommon.Header.Content.ShortText.ColorStyle = PaletteColorStyle.GlassSimpleFull;
                form.StateCommon.Header.Content.ShortText.Font = new Font("Tahoma", 10, FontStyle.Bold);
                form.StateCommon.Header.Content.ShortText.TextH = PaletteRelativeAlign.Center;

                form.StateCommon.Header.Border.Color1 = Color.Khaki;
                
                form.StateCommon.Back.Color1 = Color.Khaki;
                form.StateCommon.Back.Color2 = Color.White;
                form.StateCommon.Back.ColorStyle = PaletteColorStyle.Dashed;                
            }

            if(type.Equals(Constants.DIALOG_FORM))
            {               
                form.ShowIcon = true;
                form.FormBorderStyle = FormBorderStyle.Fixed3D;
                form.GroupBorderStyle = PaletteBorderStyle.InputControlRibbon;
                form.MaximizeBox = false;
                form.MinimizeBox = false;                

                form.StateCommon.Header.Back.Color1 = Color.FromArgb(43, 135, 173);
                form.StateCommon.Header.Back.Color2 = Color.FromArgb(164, 210, 229);
                form.StateCommon.Header.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;

                form.StateCommon.Header.Content.ShortText.Color1 = Color.White;
                form.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                form.StateCommon.Header.Content.ShortText.ColorStyle = PaletteColorStyle.GlassSimpleFull;
                form.StateCommon.Header.Content.ShortText.Font = new Font("Tahoma", 11, FontStyle.Bold);
                form.StateCommon.Header.Content.ShortText.TextH = PaletteRelativeAlign.Center;

                form.StateCommon.Back.Color2 = Color.FromArgb(43, 135, 173);
                form.StateCommon.Back.Color1 = Color.FromArgb(164, 210, 229);
                form.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
            }
        }
        
        public static void SetLayoutHeaderGroup(KryptonHeader header, string type)
        {
            if (type.Equals(Constants.CHILD_FORM))
            {
                header.HeaderStyle = HeaderStyle.Secondary;
                header.StateCommon.Back.Color1 = Color.Khaki;
                header.StateCommon.Back.Color2 = Color.White;
                header.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
                header.StateCommon.Border.Rounding = 4;
                header.StateCommon.Border.DrawBorders = PaletteDrawBorders.BottomLeftRight;
                header.StateCommon.Content.ShortText.Font = new Font("Tahoma", 9, FontStyle.Bold);                
            }
        }

        public static void SetDaulftDatagridview(KryptonDataGridView dataGridView)
        {
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.StateCommon.Background.Color1 = Color.White;
            dataGridView.RowHeadersWidth = 25;
            dataGridView.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(43, 135, 173);
            dataGridView.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(164, 210, 229);
            dataGridView.StateCommon.HeaderColumn.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
            dataGridView.StateCommon.HeaderColumn.Border.Rounding = 3;
            dataGridView.StateCommon.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.TopLeftRight;
            dataGridView.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dataGridView.StateCommon.HeaderColumn.Content.Font = new Font("Tahoma", 9);
        }

        public static void SetLayoutSplipContainer(KryptonSplitContainer splitContainer, int panelfix)
        {
            splitContainer.SeparatorStyle = SeparatorStyle.HighProfile;
            splitContainer.StateCommon.Separator.Back.Color1 = Color.FromArgb(43, 135, 173);
            splitContainer.StateCommon.Separator.Back.Color2 = Color.FromArgb(164, 210, 229);
            splitContainer.StateCommon.Separator.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
            if (panelfix == 0)
            {
                splitContainer.FixedPanel = FixedPanel.None;

            }
            if (panelfix == 1)
            {
                splitContainer.FixedPanel = FixedPanel.Panel1;

            }
            if (panelfix == 2)
            {
                splitContainer.FixedPanel = FixedPanel.Panel2;

            }
        }

        public static void SetLayoutPanelChildForm(KryptonPanel panel)
        {
            panel.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
        }

        public static void SetLayoutPanelNewForm(KryptonPanel panel)
        {
            panel.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
        }

        public static void SetLayoutGroupBoxChildForm(KryptonGroupBox groupBox)
        {
            groupBox.StateCommon.Back.Color1 = Color.FromArgb(62, 92, 144);
            groupBox.StateCommon.Content.ShortText.Color1 = Color.White;
            groupBox.StateCommon.Content.ShortText.Font = new Font("Tahoma", 9);
            groupBox.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
        }

        public static void SetLayoutSplipContainerInChildForm(KryptonSplitContainer splitContainer)
        {
            splitContainer.StateCommon.Back.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel1.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel2.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel1.Padding = new Padding(5, 0, 0, 5);
            splitContainer.Panel2.Padding = new Padding(0, 0, 5, 5);
        }

        public static void SetLayoutSplipContainerNewForm(KryptonSplitContainer splitContainer)
        {
            splitContainer.StateCommon.Back.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel1.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel2.StateCommon.Color1 = Color.FromArgb(41, 57, 85);
            splitContainer.Panel1.Padding = new Padding(5);
            splitContainer.Panel2.Padding = new Padding(5);
        }

        public static void SetTextBoxNumberLeave(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                textBox.Text = Constants.ZERO_NUMBER;
            }
        }

        public static void SetTextBoxMoneyLeave(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                textBox.Text = Constants.ZERO_NUMBER;
            }
            else
            {
                if (ValidateMoney(textBox))
                {
                    long money = ConvertMoneyToLong(textBox.Text, ".");
                    textBox.Text = ConvertLongToMoney(money, ".");
                }
                else
                {
                    textBox.Text = Constants.ZERO_NUMBER;
                }
            }
        }

        public static void SetTextBoxNumberEnter(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals(Constants.ZERO_NUMBER))
            {
                textBox.Text = Constants.EMPTY_TEXT;
            }
        }

        public static void SetLayoutGroupBoxSearch(KryptonGroupBox groupBox)
        {
            groupBox.StateCommon.Back.Color1 = Color.FromArgb(62, 92, 144);
            groupBox.CaptionOverlap = 0;
            groupBox.StateCommon.Border.Rounding = 5;
            groupBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.BottomLeftRight;
        }

        public static void SetLayoutGroupBoxButton(KryptonGroupBox groupBox)
        {
            groupBox.StateCommon.Back.Color1 = Color.FromArgb(41, 57, 85);
            groupBox.CaptionOverlap = 0;
            groupBox.StateCommon.Border.Rounding = 5;
            groupBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
        }

        public static void SetLayoutButton(KryptonButton button)
        {
            button.OverrideDefault.Back.Color1 = Color.FromArgb(219, 203, 93);
            button.OverrideDefault.Back.Color2 = Color.White;
            button.OverrideDefault.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
            button.OverrideDefault.Border.Color1 = Color.Khaki;
            button.OverrideDefault.Border.Rounding = 4;

            button.StateCommon.Back.Color1 = Color.Khaki;
            button.StateCommon.Back.Color2 = Color.White;
            button.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassCenter;
            button.StateCommon.Border.Color1 = Color.Khaki;
            button.StateCommon.Border.Rounding = 4;

            button.StatePressed.Back.Color1 = Color.Gold;
            button.StatePressed.Back.Color2 = Color.White;
            button.StatePressed.Back.ColorStyle = PaletteColorStyle.GlassSimpleFull;
            button.StatePressed.Border.Color1 = Color.Orange;
            button.StatePressed.Border.Rounding = 4;
        }

        public static void SetLayoutGroupBoxNewForm(KryptonGroupBox groupBox)
        {
            groupBox.StateCommon.Back.Color1 = Color.FromArgb(62, 92, 144);
            groupBox.StateCommon.Content.ShortText.Color1 = Color.White;
            groupBox.StateCommon.Content.ShortText.Font = new Font("Tahoma", 9);
            groupBox.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
        }

        public static bool ValidateNotEmptyText(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals(Constants.EMPTY_TEXT))
            {
                ListError.Add(Constants.ERROR_EMPTY_TEXT);
                return false;
            }
            return true;
        }

        public static bool ValidatePhoneNumber(KryptonTextBox textBox)
        {
            var phonenumber = textBox.Text;
            if (!phonenumber.Equals(Constants.EMPTY_TEXT))
            {
                phonenumber = phonenumber.Replace("-", "");
                phonenumber = phonenumber.Replace("(", "");
                phonenumber = phonenumber.Replace(")", "");
                if (phonenumber.Length < 10 || phonenumber.Length > 11)
                {
                    ListError.Add(Constants.ERROR_LENTH_PHONENUMBER);
                    for (int i = 0; i < phonenumber.Length; i++)
                    {
                        if (phonenumber[i] < '0' || phonenumber[i] > '9')
                        {
                            ListError.Add(Constants.ERROR_FORMAT_PHONENUMBER);
                            return false;
                        }
                    }
                    return false;
                }                
            }
            return true;
        }

        public static string FomatPhoneNumber(string phonenumber)
        {
            string result = Constants.EMPTY_TEXT;
            phonenumber = phonenumber.Replace("-", "");
            phonenumber = phonenumber.Replace("(", "");
            phonenumber = phonenumber.Replace(")", "");
            string header = "(" + phonenumber.Substring(0, phonenumber.Length - 7) + ")";
            string mainNumber = phonenumber.Substring(phonenumber.Length - 7);
            mainNumber = mainNumber[0] + "-" + mainNumber.Substring(1, 3) + "-" + mainNumber.Substring(4);
            result = header + mainNumber;
            return result;
        }

        public static bool ValidateDateFromTo(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            if (dateTimeFrom > dateTimeTo)
            {
                ListError.Add(Constants.INVALID_DATE);
                return false;
            }
            return true;
        }

        public static bool ValidateInputNumber(string strNumber)
        {
            for (int i = 0; i < strNumber.Length; i++)
            {
                if (strNumber[i] < '0' || strNumber[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        public static int GenerateStatus(string strStatus)
        {
            int isActie;
            if (strStatus.Equals(Constants.PAY))
            {
                isActie = Constants.ISACTIVE_TRUE;
            }
            else
            {
                isActie = Constants.ISACTIVE_FALSE;
            }
            return isActie;
        }
    }
}
