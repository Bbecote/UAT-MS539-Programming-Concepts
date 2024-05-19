using CrapsSimC_;
using System.Drawing.Drawing2D;

public class RoundButton : CustomButtons
{
    protected override GraphicsPath GetButtonPath()
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        return path;
    }
}
