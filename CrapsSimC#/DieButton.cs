using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsSimC_
{
    public partial class DieButton : Button
    {

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            int size = Math.Min(Width, Height);
            Point center = new Point(Width / 2, Height / 2);
            Point[] points = new Point[]
            {
                new Point(center.X, center.Y - size /2),
                new Point(center.X +  size /2, center.Y),
                new Point(center.X, center.Y + size /2),
                new Point(center.X - size /2, center.Y)
            };
            path.AddLines(points);
            path.CloseFigure();

            Region = new Region(path);

            pevent.Graphics.FillPath(new SolidBrush(BackColor), path);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, format);
        }
    }
}
