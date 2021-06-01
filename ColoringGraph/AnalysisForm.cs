using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ColoringGraph
{
    public partial class AnalysisForm : Form
    {
        private Dictionary<int, List<int>> exhaustedAlgorithm;
        private Dictionary<int, List<int>> firstFitAlgorithm;
        private Dictionary<int, List<int>> degreeBasedAlgorithm;
        private Dictionary<int, List<int>> saturationAlgorithm;
        private Dictionary<int, List<int>> incidenceAlgorithm;

        private Dictionary<int, List<double>> eTime;
        private Dictionary<int, List<double>> ffTime;
        private Dictionary<int, List<double>> dbTime;
        private Dictionary<int, List<double>> sTime;
        private Dictionary<int, List<double>> iTime;

        public AnalysisForm(Dictionary<int, List<int>> exhaustedAlgorithm, Dictionary<int, List<int>> firstFitAlgorithm,
            Dictionary<int, List<int>> degreeBasedAlgorithm, Dictionary<int, List<int>> saturationAlgorithm,
            Dictionary<int, List<int>> incidenceAlgorithm, Dictionary<int, List<double>> eTime, Dictionary<int, List<double>> ffTime,
            Dictionary<int, List<double>> dbTime, Dictionary<int, List<double>> sTime, Dictionary<int, List<double>> iTime)
        {
            InitializeComponent();
            this.exhaustedAlgorithm = exhaustedAlgorithm;
            this.firstFitAlgorithm = firstFitAlgorithm;
            this.degreeBasedAlgorithm = degreeBasedAlgorithm;
            this.saturationAlgorithm = saturationAlgorithm;
            this.incidenceAlgorithm = incidenceAlgorithm;

            this.eTime = eTime;
            this.ffTime = ffTime;
            this.dbTime = dbTime;
            this.sTime = sTime;
            this.iTime = iTime;
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {

        }

        private void buildDiagram_Click(object sender, EventArgs e)
        {
            buildChart(exhaustedAlgorithm, 0, eTime);
            buildChart(firstFitAlgorithm, 1, ffTime);
            buildChart(saturationAlgorithm, 2, sTime);
            buildChart(degreeBasedAlgorithm, 3, dbTime);
            buildChart(incidenceAlgorithm, 4, iTime);
        }

        private void buildChart(Dictionary<int, List<int>> table, int seriesNumber, Dictionary<int, List<double>> tableTime)
        {
            double x, y, avg = 0, number = 0;
            chart1.Series[seriesNumber].Points.Clear();
            chart1.Series[seriesNumber].Legend = "Legend1";
            chart1.Series[seriesNumber].ChartArea = "ChartArea1";
            chart1.Series[seriesNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Title = "Число вершин";
            chart1.ChartAreas[0].AxisY.Title = "Число цветов";
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

            avg = 0; 
            number = 0;
            chart2.Series[seriesNumber].Points.Clear();
            chart2.Series[seriesNumber].Legend = "Legend1";
            chart2.Series[seriesNumber].ChartArea = "ChartArea1";
            chart2.Series[seriesNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart2.ChartAreas[0].AxisX.Title = "Число вершин";
            chart2.ChartAreas[0].AxisY.Title = "Время работы";
            foreach (int vertexNumber in tableTime.Keys)
            {
                foreach (int colorNumber in tableTime[vertexNumber])
                {
                    number++;
                    avg += colorNumber;
                }

                y = avg / number;
                x = vertexNumber;
                chart2.Series[seriesNumber].Points.AddXY(x, y);

                number = 0;
                avg = 0;
            }
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "AnalyzedData";
            saveFileDialog1.Filter = "Excel Files|*.xlsx";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelDocument excelDocument = new ExcelDocument();
                excelDocument.createDocument(exhaustedAlgorithm, firstFitAlgorithm, degreeBasedAlgorithm, saturationAlgorithm,
                    incidenceAlgorithm, eTime, ffTime, dbTime, sTime, iTime);

                excelDocument.getWorksheet().SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, 
                    Type.Missing, Type.Missing);
                excelDocument.getWorkbook().Close(false, Type.Missing, Type.Missing);
                excelDocument.getApp().Quit();
                MessageBox.Show("Данные успешно сохранены");
            }
        }
    }
}
