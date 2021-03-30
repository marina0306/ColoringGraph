﻿using System;
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
    public partial class MainForm : Form
    {
        private int vertex, edge;
        private int[,] array;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vertexQuantity.Minimum = 1;
            vertexQuantity.Maximum = 10;
        }

        private void vertexQuantity_ValueChanged(object sender, EventArgs e)
        {
            edgeQuantity.Maximum = vertexQuantity.Value * (vertexQuantity.Value - 1) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vertex = Decimal.ToInt32(vertexQuantity.Value);
            array = new int[vertex, vertex];

            if(completeGraph.Checked)
            {
                edge = vertex * (vertex - 1) / 2;
                for (int i = 0; i < vertex; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        if (i != j)
                        {
                            array[i, j] = 1;
                        }
                    }
                }
            }
            else
            {
                edge = Decimal.ToInt32(edgeQuantity.Value);
                array = getRandomMatrix();
            }

            putArrayInGrid(array);

        }

        private int[,] getRandomMatrix()
        {
            int[,] array = new int[vertex, vertex];
            Random random = new Random();
            int firstVert, secondVert;

            for (int i = 0; i < edge; i++)
            {
                firstVert = random.Next(1, vertex + 1);
                secondVert = random.Next(1, vertex + 1);

                if (array[firstVert - 1, secondVert - 1] == 1 || firstVert == secondVert)
                {
                    i--;
                }
                else
                {
                    array[firstVert - 1, secondVert - 1] = 1;
                    array[secondVert - 1, firstVert - 1] = 1;
                }
            }

            return array;
        }

        private void matrix_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.matrix.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.matrix.Rows[index].HeaderCell.Value = indexStr;
        }

        private void buildGraph_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(array);
            graph.Show();
        }

        private void firstFitButton_Click(object sender, EventArgs e)
        {
            FirstFitAlgorithm algorithm = new FirstFitAlgorithm(array);
            algorithm.getVertex();
            algorithm.color();

            Graph graph = new Graph(array, algorithm.getColors());
            graph.Show();
        }

        private void degreeBasedAlgorithm_Click(object sender, EventArgs e)
        {
            DegreeBasedAlgorithm algorithm = new DegreeBasedAlgorithm(array);
            algorithm.getVertex();
            algorithm.color();

            Graph graph = new Graph(array, algorithm.getColors());
            graph.Show();
        }

        private void putArrayInGrid(int[,] array)
        {
            matrix.ColumnCount = vertex;
            matrix.RowCount = vertex;
            matrix.ColumnHeadersVisible = true;

            for (int i = 0; i < vertex; i++)
            {
                matrix.Columns[i].Name = (i + 1).ToString();
            }

            for(int i = 0; i < vertex; i++)
            {
                for(int j = 0; j < vertex; j++)
                {
                    matrix.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }
    }
}
