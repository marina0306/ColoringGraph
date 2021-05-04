using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoringGraph
{
    public partial class EdgeContraction : Form
    {
        private int[,] matrix;
        private int[,] newMatrix;
        private MainForm mainForm;
        public EdgeContraction(int[,] matrix, MainForm mainForm)
        {
            InitializeComponent();
            this.matrix = matrix;
            this.mainForm = mainForm;
        }

        private void contraction_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(vertex1.Text) - 1;
            int v2 = Convert.ToInt32(vertex2.Text) - 1;
            if(matrix[v1, v2] == 1)
            {
                newMatrix = getNewMatrix(v1, v2);
            }
            mainForm.setNewMatrix(newMatrix);
            Close();
        }

        private int[,] getNewMatrix(int v1, int v2)
        {
            int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            int min = Math.Min(v1, v2);
            int max = Math.Max(v1, v2);

            for(int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(0); j++)
                {
                    if (i == min)
                    {
                        if (matrix[v1, j] == 1 || matrix[v2, j] == 1)
                        {
                            newMatrix[i, j] = 1;
                        }
                        else
                        {
                            newMatrix[i, j] = 0;
                        }
                    }
                    else if (j == min)
                    {
                        if ((matrix[i, v1] == 1 || matrix[i, v2] == 1) && i != max)
                        {
                            newMatrix[i, j] = 1;
                        }
                        else
                        {
                            newMatrix[i, j] = 0;
                        }
                    }
                    else if (!(i != min && (i == v1 || i == v2)))
                    {
                        if (i < min && j < min)
                        {
                            newMatrix[i, j] = matrix[i, j];
                        }
                        if (i < min && j > min)
                        {
                            newMatrix[i, j] = matrix[i, j + 1];
                        }
                        if(i > min && j < min)
                        {
                            newMatrix[i, j] = matrix[i + 1, j];
                        }
                        if (i > min && j > min)
                        {
                            newMatrix[i, j] = matrix[i + 1, j + 1];
                        }
                    }
                    if(i == j)
                    {
                        newMatrix[i, j] = 0;
                    }
                }
            }

            return newMatrix;
        }

        public int[,] getMatrix()
        {
            return newMatrix;
        }
    }
}
