using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RBLXex.Helpers
{
    internal class UIHelper
    {
        public const int defaultRadius = 5;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr RegionRoundedRectangle(int xOffset, int yOffset, int width, int height, int cornerWidth, int cornerHeight);

        //Rounds the edges of the control off
        //#TODO somehow smooth it out so it doesnt look as jagged on radiuses above 5px
        public static void RoundEdges(Control control, Graphics graphics, int radius = defaultRadius)
        {
            graphics.CompositingQuality = CompositingQuality.Default;
            graphics.InterpolationMode = InterpolationMode.Bicubic;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Region reg = Region.FromHrgn(RegionRoundedRectangle(1, 1, control.Width, control.Height, radius, radius));

            control.Region = reg;
        }

        //Runs the method given on the UI thread
        public static void SwitchToUI(Form form, Delegate method)
        {
            form.Invoke(method);
        }
    }
}
