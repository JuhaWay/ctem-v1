using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    class Global
    {
        public void DrawPanelBorder(Panel panel, Color color1, Color color2)
        {
            Graphics g = panel.CreateGraphics();

            Rectangle panelRect = panel.ClientRectangle;

            Point p1 = new Point(panelRect.Left, panelRect.Top); //top left
            Point p2 = new Point(panelRect.Right - 1, panelRect.Top); //Top Right
            Point p3 = new Point(panelRect.Left, panelRect.Bottom - 1); //Bottom Left
            Point p4 = new Point(panelRect.Right - 1, panelRect.Bottom - 1); //Bottom Right

            Pen pen1 = new Pen(color1);
            Pen pen2 = new Pen(color2);

            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p1, p3);
            g.DrawLine(pen2, p2, p4);
            g.DrawLine(pen2, p3, p4);
        }
    }
}
