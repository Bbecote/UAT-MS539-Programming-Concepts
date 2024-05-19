using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Create a graphics object from the button's surface
            Graphics graphics = pevent.Graphics;
            
            // Save the current state of the graphics object
            graphics.Save();

            // Translate the graphics object to the center of the button
            graphics.TranslateTransform(Width / 2, Height / 2);

            // Rotate the graphics object 45 degrees
            graphics.RotateTransform(45);

            // Translate the graphics objective back to top-left
            graphics.TranslateTransform(-Width / 2, -Height / 2);

            // Draw the buttons background and border
            base.OnPaint(pevent);

            // Restore the orginal state of hte graphics object
            //graphics.Restore();
        }
    }
}
