﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringGraph
{
    class IncidenceAlgorithm : IAlgorithm
    {
        private int[,] matrix;
        private Dictionary<Color, bool> colors = new Dictionary<Color, bool>();
        private Dictionary<int, Color> coloredVertex = new Dictionary<int, Color>();
        private Dictionary<int, int> vertexNeighs = new Dictionary<int, int>();
        private Dictionary<int, int> vertexColorNeighs = new Dictionary<int, int>();

        public IncidenceAlgorithm(int[,] matrix)
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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                vertexNeighs.Add(i, 0);
                vertexColorNeighs.Add(i, 0);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        vertexNeighs[i]++;
                    }
                }
            }
        }

        public void color()
        {
            while (coloredVertex.Count != matrix.GetLength(0))
            {
                List<int> maxNeigh = new List<int>();
                int max = 0;
                int vertex;

                foreach (int number in vertexColorNeighs.Keys)
                {
                    if (vertexColorNeighs[number] > max)
                    {
                        max = vertexColorNeighs[number];
                    }
                }

                foreach (int number in vertexColorNeighs.Keys)
                {
                    if (vertexColorNeighs[number] == max)
                    {
                        maxNeigh.Add(number);
                    }
                }

                if (maxNeigh.Count > 1)
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
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            if (matrix[vertex, i] == 1 && vertexColorNeighs.ContainsKey(i))
                            {
                                vertexColorNeighs[i]++;
                            }
                        }
                        vertexColorNeighs.Remove(vertex);
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
