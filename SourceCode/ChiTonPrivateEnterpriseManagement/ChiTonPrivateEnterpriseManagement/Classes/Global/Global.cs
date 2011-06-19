using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
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
    }
}
