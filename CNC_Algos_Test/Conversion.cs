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
            if (v < 0.001)
                throw new Exception("Argument is not in mm");
            
            return v / 0.0393;

        }

        public double mm2In(double v)
        {
            if(v < 0.001)
              throw new Exception("Argument is to small");
            
            return v * 0.0393;
        }
    }
}
