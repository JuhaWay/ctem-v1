using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    class Global
    {
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
    }
}
