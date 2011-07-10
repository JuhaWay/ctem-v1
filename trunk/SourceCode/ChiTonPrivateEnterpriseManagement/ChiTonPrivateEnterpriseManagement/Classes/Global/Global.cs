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
        public static bool DownUpControl(KryptonForm form, KryptonPanel panel, int maxheight, int minheight, int speed, bool isDown)
        {
            if (isDown)
            {
                while (panel.Height <= maxheight)
                {
                    panel.Height += speed;
                    form.Refresh();
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
                KryptonMessageBox.Show(Constants.INVALIDATE_VALUE, Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
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
                KryptonMessageBox.Show(Constants.INVALIDATE_VALUE, Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
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
                KryptonMessageBox.Show(Constants.INVALIDATE_VALUE, Constants.CONFIRM, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
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
            if (obj.Equals("Construction"))
            {
                var constructionBus = new ConstructionBus();
                cbbControl.DataSource = constructionBus.LoadAllConstructions();
                cbbControl.ValueMember = Constants.CONSTRUCTION_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.CONSTRUCTION_DISPLAYMEMBER;
            }
            if (obj.Equals("Employee"))
            {
                var employeeBus = new EmployeeBUS();
                cbbControl.DataSource = employeeBus.LoadAllEmployee();
                cbbControl.ValueMember = Constants.EMPLOYEE_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.EMPLOYEE_DISPLAYMEMBER;
            }
            if (obj.Equals("Debt"))
            {
                var debtBus = new DebtBUS();
                cbbControl.DataSource = debtBus.GetAll();
                cbbControl.ValueMember = Constants.DEBT_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.DEBT_DISPLAYMEMBER;
            }

            if (obj.Equals("Status"))
            {
                cbbControl.Items.Add(Constants.ACTIVE);
                cbbControl.Items.Add(Constants.INACTIVE);
            }
            if (obj.Equals("Material"))
            {
                var materialBus = new MaterialBUS();
                cbbControl.DataSource = materialBus.LoadAllMaterials();
                cbbControl.ValueMember = Constants.MATERIAL_VALUEMEMBER;
                cbbControl.DisplayMember = Constants.MATERIAL_DISPLAYMEMBER;
            }
            cbbControl.SelectedIndex = 0;
        }

        public static long GetDataCombobox(KryptonComboBox cbbControl, string obj)
        {
            if (obj.Equals(Constants.EMPLOYEE))
            {
                var empObj = (EmployerDTO) cbbControl.SelectedItem;
                return empObj.employeeID;
            }
            if (obj.Equals("Debt"))
            {
                var debtObj = (DebtDTO) cbbControl.SelectedItem;
                return debtObj.DebtID;
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
            return (rightValue & Global.CurrentUser.RightsValue) != 0;
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
            for (int i = 1; i < dgvControl.ColumnCount; i++)
            {
                dgvControl.Columns[i].Width = (dgvControl.Width - dgvControl.RowHeadersWidth - dgvControl.Columns[0].Width) / (dgvControl.ColumnCount - 1);
            }
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

        public static void ClearTextboxSalary(KryptonTextBox textBox)
        {
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = Constants.EMPTY_TEXT;
            }
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
        }

        public static void TextBoxRequireInputed(KryptonTextBox textBox)
        {
            textBox.StateCommon.Border.Color1 = Color.Yellow;
        }

        public static void TextBoxNonRequireInput(KryptonTextBox textBox)
        {
            textBox.StateCommon.Border.Color1 = Color.Black;
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
    }
}
