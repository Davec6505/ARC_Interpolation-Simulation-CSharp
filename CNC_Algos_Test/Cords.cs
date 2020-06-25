using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC_Algos_Test
{
    class Cords
    {
        public double XStart { get; set; }
        public double YStart { get; set; }
        public double XFinnish { get; set; }
        public double YFinnish { get; set; }
        public double I { get; set; }
        public double J { get; set; }
        public double Radius { get; set; }
        public double N { get; set; }
        public int QuadrantStart { get; set; }
        public int QuadrantFin { get; set; }
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int XS { get; set; }
        public int YS { get; set; }
        public int XC { get; set; }
        public int YC { get; set; }
        public string Dir { get; set; }
        public double angleA { get; set; }
        public double angleAdeg { get; set; }
        public double deg { get; set; }
        public double degRad { get; set; }
        public double angleB { get; set; }
        public double angleBRad { get; set; }

        public Cords()
        {

        }

        double X, Y, xF, yF, xR, yR, xRad, yRad, degOffSet;
        public void CalcRadius()
        {
            Func<double, double, int> Quad =  GetQuadrant;
            int arg1, arg2;
            double deg2rad = Math.PI / 180; // 1radians = 180/pi  || 1deg = pi/180
            double rad2deg = 180.0 / Math.PI;
            double Rt2 = Math.Sqrt(2);

            XS = (int)XStart;
            YS = (int)YStart;

            //get the offset of the angle from 90 deg
  
            xR = XStart + I;
            yR = YStart + J;

            XC = (int)xR;
            YC = (int)yR;

            X = Math.Abs(I);
            Y = Math.Abs(J);
            Radius = Math.Sqrt((X * X) + (Y * Y));

            //find which quadrant the arc starts in
            QuadrantStart = Quad( I, J);

            //get the angle from the x axis
            angleA = Math.Atan2(Y,X);
            angleAdeg = angleA * rad2deg;

     
                if (QuadrantStart == 1 || QuadrantStart == 3)
                    angleB = deg - angleAdeg;

                if (QuadrantStart == 2 || QuadrantStart == 4)
                    angleB = deg + angleAdeg;
            

           

            angleBRad = angleB * deg2rad;

            //get the xFin and yFin values
  
                if (QuadrantStart == 1 || QuadrantStart == 4)
                {
                    XFinnish = xR + (Radius * Math.Cos(angleBRad));
                    YFinnish = yR + (Radius * Math.Sin(angleBRad));//
                }
                if (QuadrantStart == 2 || QuadrantStart == 3)
                {
                    XFinnish = xR - (Radius * Math.Cos(angleBRad));
                    YFinnish = yR - (Radius * Math.Sin(angleBRad));//
                }




            //calculate N value
        
          //  N = 2 * Math.PI * Radius;//(XFinnish - XStart) + ( YFinnish - YStart);

            //Debug write section for visualisation of variables
            Debug.WriteLine($"QuadrantStart:= {QuadrantStart}");
            Debug.WriteLine($"deg:= {deg};  angleAdeg:= {angleAdeg};   angleB:= {angleB}");
            Debug.WriteLine($"xR:= {xR};  yR:= {yR};  X:= {X};  Y:= {Y}");
            Debug.WriteLine($"Radius:= {Radius}; angleBRad:= {angleBRad}");
            Debug.WriteLine($"xF:= {XFinnish}; yF:= {YFinnish}");

        }

        public int GetQuadrant(double i, double j)
        {
            if ((i <= 0) && (j >= 0))
                return 1;
            else if ((i > 0) && (j > 0))
                return 2;
            else if ((i > 0) && (j < 0))
                return 3;
            else if ((i < 0) && (j < 0))
                return 4;
            else return 0;
         
        }

        public void GetOppAdj(out int arg1, out int arg2)
        {
              arg1 = (int)Math.Sqrt((Radius * Radius) - (xR * xR));
              arg2 = (int)Math.Sqrt((Radius * Radius) - (yR * yR));
        }
    }
}
/*
 *             x0 =  (int)(XFinnish - XStart);
            y0 =  (int)(YFinnish - YStart);
            Debug.WriteLine($"[x0:y0] = [{x0}:{y0}]");
            QuadrantStart = GetQuadrant(x0, y0);
            if (I == J) Radius = I * Rt2;
            if (I == 0) Radius = J;
            if (J == 0) Radius = I;
            if ((I > 0) && (J > 0) && (I != J)) Radius = Math.Sqrt((I * I) + (J * J));

            XS = (int)XStart;
            YS = (int)YStart;

            XC = XS + (int)I;
            YC = YS + (int)J;
            QuadrantFin = GetQuadrant((int)XFinnish, (int)YFinnish);
            N = (int)((XStart - XFinnish) + (YStart - YFinnish));
   
*/