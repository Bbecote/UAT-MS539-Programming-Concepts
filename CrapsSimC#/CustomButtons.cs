using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace CrapsSimC_
{
    public class CustomButtons : Button
    {
        protected virtual GraphicsPath GetButtonPath()
        {
            return new GraphicsPath();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            this.Region = new Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
