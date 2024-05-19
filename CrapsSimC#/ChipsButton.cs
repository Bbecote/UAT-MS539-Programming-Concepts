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
    public partial class ChipsButton : Button
    {

        //private Color CustomBackgroundColor;
        //private Color CustomBorderColor;

        public ChipsButton()
        {
            InitializeComponent();
        }

        //public Color CustomBackgroundColor1 { get => CustomBackgroundColor; set => CustomBackgroundColor = value; }
        //public Color CustomBorderColor1 { get => CustomBorderColor; set => CustomBorderColor = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);

            //pevent.Graphics.FillEllipse(new SolidBrush(CustomBackgroundColor1), 0, 0, ClientSize.Width, ClientSize.Height);
            //pevent.Graphics.DrawEllipse(new Pen(CustomBorderColor1), 0, 0, ClientSize.Width -1, ClientSize.Height -1);

            base.OnPaint(pevent);
        }
    }
}


