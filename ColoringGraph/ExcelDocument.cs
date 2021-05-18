using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ColoringGraph
{
    class ExcelDocument
    {
        private Workbook workbook;
        private Worksheet worksheet;
        private Application app;

        public void createDocument(Dictionary<int, List<int>> exhaustedAlgorithm, Dictionary<int, List<int>> firstFitAlgorithm,
            Dictionary<int, List<int>> degreeBasedAlgorithm, Dictionary<int, List<int>> saturationAlgorithm,
            Dictionary<int, List<int>> incidenceAlgorithm, Dictionary<int, List<double>> eTime, Dictionary<int, List<double>> ffTime,
            Dictionary<int, List<double>> dbTime, Dictionary<int, List<double>> sTime, Dictionary<int, List<double>> iTime)
        {
            object Nothing = System.Reflection.Missing.Value;
            app = new Application();
            app.Visible = false;
            workbook = app.Workbooks.Add(Nothing);
            worksheet = (Worksheet)workbook.Sheets[1];
            worksheet.Name = "WorkSheet";

            int Row = 1, Column = 3;

            foreach(int Key in exhaustedAlgorithm.Keys)
            {
                worksheet.Cells[Row, 1] = "Число вершин";
                worksheet.Cells[Row, 2] = Key;

                worksheet.Cells[Row + 1, 1] = "Исчерпывающая раскраска";
                worksheet.Cells[Row + 3, 1] = "Последовательная раскраска";
                worksheet.Cells[Row + 5, 1] = "Раскраска с наибольшей степенью";
                worksheet.Cells[Row + 7, 1] = "Насыщенная раскраска";
                worksheet.Cells[Row + 9, 1] = "Раскраска по охвату вершин";

                int k = 1;

                for(int i = 0; i < 5; i++)
                {
                    worksheet.Cells[Row + k, 2] = "Число цветов";
                    worksheet.Cells[Row + k + 1, 2] = "Время работы";

                    k += 2;
                }

                for(int i = 0; i < exhaustedAlgorithm[Key].Count; i++)
                {
                    worksheet.Cells[Row + 1, Column + i] = exhaustedAlgorithm[Key][i];
                    worksheet.Cells[Row + 2, Column + i] = eTime[Key][i];

                    worksheet.Cells[Row + 3, Column + i] = firstFitAlgorithm[Key][i];
                    worksheet.Cells[Row + 4, Column + i] = ffTime[Key][i];

                    worksheet.Cells[Row + 5, Column + i] = degreeBasedAlgorithm[Key][i];
                    worksheet.Cells[Row + 6, Column + i] = dbTime[Key][i];

                    worksheet.Cells[Row + 7, Column + i] = saturationAlgorithm[Key][i];
                    worksheet.Cells[Row + 8, Column + i] = sTime[Key][i];

                    worksheet.Cells[Row + 9, Column + i] = incidenceAlgorithm[Key][i];
                    worksheet.Cells[Row + 10, Column + i] = iTime[Key][i];
                }

                Row += 11;
            }

            worksheet.Columns.AutoFit();
        }

        public Workbook getWorkbook()
        {
            return workbook;
        }

        public Worksheet getWorksheet()
        {
            return worksheet;
        }

        public Application getApp()
        {
            return app;
        }
    }
}
