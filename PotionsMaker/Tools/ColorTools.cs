using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsMaker.Tools
{
    public class ColorTools
    {
        public Color col;
        public static string ChangeColor(string newColString, string actualColString)
        {
            Color newColor = ColorTranslator.FromHtml(newColString);
            Color actualColor = ColorTranslator.FromHtml(actualColString);
            int r = (newColor.R + actualColor.R) / 2;
            int g = (newColor.G + actualColor.G) / 2;
            int b = (newColor.B + actualColor.B) / 2;

            Color colB = Color.FromArgb(r, g, b);
            return ColorTranslator.ToHtml(colB);
        }
    }
}
