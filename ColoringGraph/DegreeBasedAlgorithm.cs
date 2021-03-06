using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringGraph
{
    class DegreeBasedAlgorithm : IAlgorithm
    {
        private int[,] matrix;
        private Dictionary<Color, bool> colors = new Dictionary<Color, bool>();
        private Dictionary<int, Color> coloredVertex = new Dictionary<int, Color>();
        private Dictionary<int, int> vertexNeighs = new Dictionary<int, int>();
        private Dictionary<int, int> vertexColorNeighs = new Dictionary<int, int>();

        public DegreeBasedAlgorithm(int[,] matrix)
        {
            this.matrix = matrix;

            colors = Colors.getColorList();
        }

        public void getVertex()
        {
            for(int i = 0; i < matrix.GetLength(0);i++)
            {
                vertexNeighs.Add(i, 0);
                vertexColorNeighs.Add(i, 0);
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        vertexNeighs[i]++;
                    }
                }
            }
        }

        public void color()
        {
            while(coloredVertex.Count != matrix.GetLength(0))
            {
                List<int> maxNeigh = new List<int>();
                int max = 0;
                int vertex;

                foreach (int number in vertexNeighs.Keys)
                {
                    if (vertexNeighs[number] > max)
                    {
                        max = vertexNeighs[number];
                    }
                }

                foreach (int number in vertexNeighs.Keys)
                {
                    if (vertexNeighs[number] == max)
                    {
                        maxNeigh.Add(number);
                    }
                }

                if(maxNeigh.Count > 1)
                {
                    Random random = new Random();
                    int number = random.Next(0, maxNeigh.Count);
                    vertex = maxNeigh[number];
                }
                else
                {
                    vertex = maxNeigh[0];
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[vertex, i] == 1 && coloredVertex.ContainsKey(i))
                    {
                        colors[coloredVertex[i]] = false;
                    }
                }

                foreach (Color col in colors.Keys)
                {
                    if (colors[col])
                    {
                        coloredVertex.Add(vertex, col);
                        vertexNeighs.Remove(vertex);
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
