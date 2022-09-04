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
        Func<double, double, int> Quad;// = GetQuadrant;

        public double XStart { get; set; }
        public double YStart { get; set; }
        public double XFinnish { get; set; }
        public double YFinnish { get; set; }
        public double I { get; set; }
        public double J { get; set; }
        public double I_end{ get; set; }
        public double J_end { get; set; }
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
        public double angleStart { get; set; }
        public double angleEnd { get; set; }
        public double angleTotal { get; set; }
        public double angleBRad { get; set; }

        public double deg2rad = 0.0;// Math.PI / 180; // 1radians = 180/pi  || 1deg = pi/180
        public double rad2deg = 0.0;//180.0 / Math.PI;
        public double X, Y, xF, yF, xCenter, yCenter, xRad, yRad, degOffSet;

        public Cords()
        {
            deg2rad = Math.PI / 180; // 1radians = 180/pi  || 1deg = pi/180
            rad2deg = 180.0 / Math.PI;
        }

        public void CalcRadius()
        {
            X = Math.Abs(I);
            Y = Math.Abs(J);
            Radius = Math.Sqrt((X*X) + (Y*Y) );
        }

        public void CalcCenter()
        {
            xCenter = XStart + I;
            yCenter = YStart + J;

            XC = (int)xCenter;
            YC = (int)yCenter;
        }


        public void Calc_I_J_End()
        {
            I_end = XFinnish - xCenter;
            J_end = YFinnish - yCenter;
        }

        public double CalcAngle(double x,double y)
        {
            
            angleA =  Math.Atan2(Math.Abs(y), Math.Abs(x));
            return angleA * rad2deg;
        }

        public int GetQuadrantA(double i, double j)
        {
            if ((i < 0) && (j >= 0))
                return 1;
            else if ((i >= 0) && (j >= 0))
                return 2;
            else if ((i >= 0) && (j < 0))
                return 3;
            else if ((i < 0) && (j < 0))
                return 4;
            else return 0;

        }
        public int GetQuadrantB(double i, double j)
        {
            if ((i >= 0) && (j >= 0))
                return 1;
            else if ((i >= 0) && (j < 0))
                return 2;
            else if ((i < 0) && (j < 0))
                return 3;
            else if ((i < 0) && (j >= 0))
                return 4;
            else return 0;

        }


        /// <summary>
        /// Calculate the Steps to move
        /// </summary>

        public void CalcStep()
        {

            if (QuadrantStart == 1 || QuadrantStart == 3)
                angleB = deg - angleStart;

            if (QuadrantStart == 2 || QuadrantStart == 4)
                angleB = deg + angleStart;

            angleBRad = angleB * deg2rad;

            //get the xFin and yFin values
            //calculate N value       
            //  N = 2 * Math.PI * Radius;//(XFinnish - XStart) + ( YFinnish - YStart);

            //Debug write section for visualisation of variables
         /*   Debug.WriteLine($"QuadrantStart:= {QuadrantStart}");
            Debug.WriteLine($"deg:= {deg};  angleAdeg:= {angleAdeg};   angleB:= {angleB}");
            Debug.WriteLine($"xCenter:= {xCenter};  yCenter:= {yCenter};  X:= {X};  Y:= {Y}");
            Debug.WriteLine($"Radius:= {Radius}; angleBRad:= {angleBRad}");
            Debug.WriteLine($"xF:= {XFinnish}; yF:= {YFinnish}");
         */
        }

        public void GetNextStep()
        {
            if (QuadrantStart == 1 || QuadrantStart == 4)
            {
                XFinnish = xCenter + (Radius * Math.Cos(angleBRad));
                YFinnish = yCenter + (Radius * Math.Sin(angleBRad));//
            }
            if (QuadrantStart == 2 || QuadrantStart == 3)
            {
                XFinnish = xCenter - (Radius * Math.Cos(angleBRad));
                YFinnish = yCenter - (Radius * Math.Sin(angleBRad));//
            }
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