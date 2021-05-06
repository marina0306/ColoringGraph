using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringGraph
{
    class Colors
    {
        private static List<Color> colors = new List<Color>();

        public static void generateColors(int[,] matrix)
        {
            int maxColor = 16777215;
            int iter = maxColor / (matrix.GetLength(0) - 1);
            int current = maxColor;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string color = Convert.ToString(current, 16);
                while (color.Length < 6)
                {
                    color = "0" + color;
                }
                colors.Add(ColorTranslator.FromHtml("#" + color));
                current -= iter;
            }
        }

        public static void resetColors()
        {
            colors = new List<Color>();
        }

        public static Dictionary<Color, bool> getColorList()
        {
            Dictionary<Color, bool> boolColors = new Dictionary<Color, bool>();

            foreach(Color col in colors)
            {
                boolColors.Add(col, true);
            }

            return boolColors;
        }

        public static Dictionary<Color, bool> returnColor(Dictionary<Color, bool> boolColor)
        {
            foreach (Color col in colors)
            {
                boolColor[col] = true;
            }

            return boolColor;
        }
    }
}
