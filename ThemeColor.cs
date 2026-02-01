using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> colorlist = new List<string>()
        {
           "#545C5C",
           "#545C5C",
           "#545C5C"
        };

        public static Color ChangeColorBrightness (Color color, double correctionFactor)
        {
            double red = (double)color.R;
            double green = (double)color.G;
            double blue = (double)color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A ,(byte)red, (byte)green, (byte)blue);
        }

    }
}
