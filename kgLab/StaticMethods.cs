using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    public static class StaticMethods
    {
        public static void RoundButton(Button button)
        {
            GraphicsPath p = new GraphicsPath(FillMode.Winding);
            p.AddEllipse(0, 0, button.Height, button.Height);
            p.AddEllipse(button.Width - button.Height, 0, button.Height, button.Height);
            p.AddRectangle(new Rectangle(button.Height / 2, 0, button.Width - button.Height, button.Height));
            button.Region = new Region(p);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}
