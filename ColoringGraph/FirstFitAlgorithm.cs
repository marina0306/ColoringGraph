using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringGraph
{
    class FirstFitAlgorithm : IAlgorithm
    {
        private int[,] matrix;
        private Dictionary<Color, bool> colors = new Dictionary<Color, bool>();
        private List<int> vertexOrder = new List<int>();
        private Dictionary<int, Color> coloredVertex = new Dictionary<int, Color>();

        public FirstFitAlgorithm(int[,] matrix)
        {
            this.matrix = matrix;

            colors.Add(Color.Red, true);
            colors.Add(Color.Yellow, true);
            colors.Add(Color.Green, true);
            colors.Add(Color.Blue, true);
            colors.Add(Color.Purple, true);
            colors.Add(Color.Brown, true);
            colors.Add(Color.Gray, true);
            colors.Add(Color.Pink, true);
            colors.Add(Color.Orange, true);
            colors.Add(Color.LightGreen, true);
        }

        public void getVertex()
        {
            int vertexCount = matrix.GetLength(0);
            Random random = new Random();
            for(int i = 0; i < vertexCount; i++)
            {
                int number;
                do
                {
                    number = random.Next(0, vertexCount);
                }
                while (vertexOrder.Contains(number));
                vertexOrder.Add(number);
            }
        }

        public void color()
        {
            foreach(int vertex in vertexOrder)
            {
                for(int i = 0; i < vertexOrder.Count; i++)
                {
                    if(matrix[vertex, i] == 1 && coloredVertex.ContainsKey(i))
                    {
                        colors[coloredVertex[i]] = false;
                    }
                }

                foreach(Color col in colors.Keys)
                {
                    if(colors[col])
                    {
                        coloredVertex.Add(vertex, col);
                        break;
                    }
                }

                returnColors();
            }
        }

        public Dictionary<int, Color> getColors()
        {
            return coloredVertex;
        }

        public void returnColors()
        {
            colors[Color.Red] = true;
            colors[Color.Yellow] = true;
            colors[Color.Green] = true;
            colors[Color.Blue] = true;
            colors[Color.Purple] = true;
            colors[Color.Brown] = true;
            colors[Color.Gray] = true;
            colors[Color.Pink] = true;
            colors[Color.Orange] = true;
            colors[Color.LightGreen] = true;
        }
    }
}
