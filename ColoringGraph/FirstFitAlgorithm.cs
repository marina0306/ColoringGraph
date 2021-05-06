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

            colors = Colors.getColorList();
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

                colors = Colors.returnColor(colors);
            }
        }

        public Dictionary<int, Color> getColors()
        {
            return coloredVertex;
        }
    }
}
