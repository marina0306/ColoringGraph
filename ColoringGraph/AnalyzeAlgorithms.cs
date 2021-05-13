using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColoringGraph
{
    class AnalyzeAlgorithms
    {
        private int iterations, maxVertex;
        private int currentVertex;
        private int usedColors;
        private Dictionary<int, List<int>> exhaustedAlgorithm = new Dictionary<int, List<int>>();
        private Dictionary<int, List<int>> firstFitAlgorithm = new Dictionary<int, List<int>>();
        private Dictionary<int, List<int>> degreeBasedAlgorithm = new Dictionary<int, List<int>>();
        private Dictionary<int, List<int>> saturationAlgorithm = new Dictionary<int, List<int>>();
        private Dictionary<int, List<int>> incidenceAlgorithm = new Dictionary<int, List<int>>();

        private Dictionary<int, List<double>> eTime = new Dictionary<int, List<double>>();
        private Dictionary<int, List<double>> ffTime = new Dictionary<int, List<double>>();
        private Dictionary<int, List<double>> dbTime = new Dictionary<int, List<double>>();
        private Dictionary<int, List<double>> sTime = new Dictionary<int, List<double>>();
        private Dictionary<int, List<double>> iTime = new Dictionary<int, List<double>>();

        public AnalyzeAlgorithms(int iterations, int maxVertex)
        {
            this.iterations = iterations;
            this.maxVertex = maxVertex;
            currentVertex = 5;

            getInitialTable(incidenceAlgorithm);
            getInitialTable(saturationAlgorithm);
            getInitialTable(degreeBasedAlgorithm);
            getInitialTable(firstFitAlgorithm);
            getInitialTable(exhaustedAlgorithm);

            getInitialTable(eTime);
            getInitialTable(ffTime);
            getInitialTable(dbTime);
            getInitialTable(sTime);
            getInitialTable(iTime);
        }

        private void getInitialTable(Dictionary<int, List<int>> algorithmTable) 
        {
            int initial = currentVertex;

            while(initial < maxVertex)
            {
                algorithmTable.Add(initial, new List<int>());
                initial += 5;
            }

            algorithmTable.Add(maxVertex, new List<int>());
        }

        private void getInitialTable(Dictionary<int, List<double>> algorithmTable)
        {
            int initial = currentVertex;

            while (initial < maxVertex)
            {
                algorithmTable.Add(initial, new List<double>());
                initial += 5;
            }

            algorithmTable.Add(maxVertex, new List<double>());
        }

        public void startAnalyze()
        {
            while (currentVertex <= maxVertex)
            {
                for(int i = 0; i < iterations; i++)
                {
                    int[,] matrix = generateMatrix(currentVertex);

                    Colors.resetColors();
                    Colors.generateColors(matrix);

                    ExhaustedAlgorithm ea = new ExhaustedAlgorithm(matrix);
                    FirstFitAlgorithm ffa = new FirstFitAlgorithm(matrix);
                    DegreeBasedAlgorithm dba = new DegreeBasedAlgorithm(matrix);
                    SaturationAlgorithm sa = new SaturationAlgorithm(matrix);
                    IncidenceAlgorithm ia = new IncidenceAlgorithm(matrix);

                    addTable(ea, exhaustedAlgorithm, eTime);
                    addTable(ffa, firstFitAlgorithm, ffTime);
                    addTable(dba, degreeBasedAlgorithm, dbTime);
                    addTable(sa, saturationAlgorithm, sTime);
                    addTable(ia, incidenceAlgorithm, iTime);
                }

                if(currentVertex != maxVertex && (currentVertex + 5) > maxVertex)
                {
                    currentVertex = maxVertex;
                }
                else
                {
                    currentVertex += 5;
                }
            }

            AnalysisForm analysisForm = 
                new AnalysisForm(exhaustedAlgorithm, firstFitAlgorithm, 
                degreeBasedAlgorithm, saturationAlgorithm, incidenceAlgorithm, 
                eTime, ffTime, dbTime, sTime, iTime);
            analysisForm.Show();
        }

        private void addTable(IAlgorithm algorithm, Dictionary<int, List<int>> algorithmTable, Dictionary<int, List<double>> algTime)
        {
            algorithm.getVertex();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            algorithm.color();
            timer.Stop();
            usedColors = getColorNumber(algorithm.getColors());
            algorithmTable[currentVertex].Add(usedColors);
            algTime[currentVertex].Add(timer.ElapsedMilliseconds);
        }

        private int getColorNumber(Dictionary<int, Color> coloredVertex) 
        {
            List<Color> usedColors = new List<Color>();

            foreach(int number in coloredVertex.Keys)
            {
                if (!usedColors.Contains(coloredVertex[number]))
                {
                    usedColors.Add(coloredVertex[number]);
                }
            }

            return usedColors.Count;
        }

        private int[,] generateMatrix(int vertex)
        {
            int[,] array = new int[vertex, vertex];
            Random random = new Random();
            int maxEdge = vertex * (vertex - 1) / 2;
            int edge = random.Next(0, maxEdge);
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
    }
}
