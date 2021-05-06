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
    }
}
