using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC_Algos_Test
{
    public class Conversion
    {
        public double In2mm(double v)
        {
            double res = v / 0.0393;

            if (res < 0.001)
                throw new Exception("Argument is not in mm");

            return res;
        }
    }
}
