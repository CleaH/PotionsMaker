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
        public static string ChangeColor(Color newColor, string actualColString)
        {
            Color actualColor = ColorTranslator.FromHtml(actualColString);
            int r = (newColor.R + actualColor.R) / 2;
            int g = (newColor.G + actualColor.G) / 2;
            int b = (newColor.B + actualColor.B) / 2;

            Color colB = Color.FromArgb(r, g, b);
            return ColorTranslator.ToHtml(colB);
        }


        public static string ChangeColor(Color newColor, string actualColString, int numberIngredients)
        {
            if (numberIngredients == 0) numberIngredients = 1;
            else if (numberIngredients > 8) numberIngredients = 8;
            Color actualColor = ColorTranslator.FromHtml(actualColString);
            int r = (newColor.R + actualColor.R* numberIngredients) / (1+ numberIngredients);
            int g = (newColor.G + actualColor.G * numberIngredients) / (1 +numberIngredients);
            int b = (newColor.B + actualColor.B * numberIngredients) / (1 + numberIngredients);

            Color colB = Color.FromArgb(r, g, b);
            return ColorTranslator.ToHtml(colB);
        }
    }
}
