using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringGraph
{
    interface IAlgorithm
    {
        void getVertex();
        void color();
        Dictionary<int, Color> getColors();
        void returnColors();
    }
}
