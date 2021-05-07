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
    public partial class AnalysisForm : Form
    {
        private Dictionary<int, List<int>> exhaustedAlgorithm;
        private Dictionary<int, List<int>> firstFitAlgorithm;
        private Dictionary<int, List<int>> degreeBasedAlgorithm;
        private Dictionary<int, List<int>> saturationAlgorithm;
        private Dictionary<int, List<int>> incidenceAlgorithm;

        public AnalysisForm(Dictionary<int, List<int>> exhaustedAlgorithm, Dictionary<int, List<int>> firstFitAlgorithm,
            Dictionary<int, List<int>> degreeBasedAlgorithm, Dictionary<int, List<int>> saturationAlgorithm,
            Dictionary<int, List<int>> incidenceAlgorithm)
        {
            InitializeComponent();
            this.exhaustedAlgorithm = exhaustedAlgorithm;
            this.firstFitAlgorithm = firstFitAlgorithm;
            this.degreeBasedAlgorithm = degreeBasedAlgorithm;
            this.saturationAlgorithm = saturationAlgorithm;
            this.incidenceAlgorithm = incidenceAlgorithm;
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {

        }

        private void buildDiagram_Click(object sender, EventArgs e)
        {
            buildChart(exhaustedAlgorithm, 0);
            buildChart(firstFitAlgorithm, 1);
            buildChart(saturationAlgorithm, 2);
            buildChart(degreeBasedAlgorithm, 3);
            buildChart(incidenceAlgorithm, 4);
        }

        private void buildChart(Dictionary<int, List<int>> table, int seriesNumber)
        {
            double x, y, avg = 0, number = 0;
            chart1.Series[seriesNumber].Points.Clear();
            chart1.Series[seriesNumber].Legend = "Legend1";
            chart1.Series[seriesNumber].ChartArea = "ChartArea1";
            chart1.Series[seriesNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (int vertexNumber in table.Keys)
            {
                foreach(int colorNumber in table[vertexNumber])
                {
                    number++;
                    avg += colorNumber;
                }

                y = avg / number;
                x = vertexNumber;
                chart1.Series[seriesNumber].Points.AddXY(x, y);

                number = 0;
                avg = 0;
            }
        }
    }
}
