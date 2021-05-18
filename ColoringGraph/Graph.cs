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
    public partial class Graph : Form
    {
        private int[,] matrix;
        private Dictionary<int, Color> colors;

        public Graph(int[,] matrix)
        {
            InitializeComponent();
            this.matrix = matrix;
        }

        public Graph(int[,] matrix, Dictionary<int, Color> colors)
        {
            InitializeComponent();
            this.matrix = matrix;
            this.colors = colors;
        }

        private Brush getBrush(int vertex)
        {
            Brush brush;
            if(colors != null)
            {
                brush = new SolidBrush(colors[vertex]);
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }

            return brush;
        }

        private Brush getStringBrush(int vertex)
        {
            Brush brush;
            if (colors != null)
            {
                brush = new SolidBrush(Color.Black);
            }
            else
            {
                brush = new SolidBrush(Color.White);
            }

            return brush;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            PointF[] points = new PointF[matrix.GetLength(0)];
            float x = p.Width / 2;
            float y = 0;
            float angle = 360 / matrix.GetLength(0);
            float currentAngle = 0;
            float w = p.Width - 30;
            float h = p.Height - 30;

            for (int i = 0; i < points.Length; i++)
            {
                float radians = currentAngle * (float)Math.PI / 180;

                x = h / 2 * (float)Math.Sin(radians) + w / 2;
                y = -h / 2 * (float)Math.Cos(radians) + h / 2;

                points[i] = new PointF(x, y);

                currentAngle += angle;
            }

            List<PointF> linePointsBegin = new List<PointF>();
            List<PointF> linePointsEnd = new List<PointF>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = i; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        PointF first = new PointF(points[i].X + 10, points[i].Y + 10);
                        PointF last = new PointF(points[j].X + 10, points[j].Y + 10);

                        linePointsBegin.Add(first);
                        linePointsEnd.Add(last);

                        g.DrawLine(new Pen(new SolidBrush(Color.Black)), first, last);
                    }
                }
            }

            for (int i = 0; i < points.Length; i++)
            {
                Brush brush = getBrush(i);
                Brush stringBrush = getStringBrush(i);
                g.FillEllipse(brush, new RectangleF(points[i], new Size(20, 20)));
                if(i < 9)
                {
                    g.DrawString((i + 1).ToString(), new Font("Arial", 15, FontStyle.Regular), stringBrush, points[i]);
                }
                else
                {
                    g.DrawString((i + 1).ToString(), new Font("Arial", 11, FontStyle.Regular), stringBrush, points[i]);
                }
            }
        }
    }
}
