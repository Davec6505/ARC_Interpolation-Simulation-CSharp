using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Algos_Test
{
    public partial class Form1 : Form
    {
        Interpolator Interp = new Interpolator();
        Cords crd;
        Bitmap DrawArea;
        Graphics g;
        Pen p = new Pen(Color.Black, 2.5f);
        Pen p2 = new Pen(Color.Red, 2.5f);
        Pen grid = new Pen(Color.Gray, 1.0f);
        private double xFin = 0;
        private double yFin = 0;
        private int x2 = 0;
        private int y2 = 0;
        private double degree = 0;
        private double deg_ = 0;
        private double divisor = 0.00;
        private double newDeg = 0.00;
        private double inch_mm = 0.0393701;
        private int timer1_interval = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Result_rTb.SelectionTabs = new int[] { 2, 2, 1, 2 };
            crd = new Cords();
            tmr1.Interval = 10;
        }

        private void ValuesToUse()
        {
            double temp = 0.00;
            int t1_temp = 0;
            Result_rTb.Clear();
            crd.Dir = Dir_textBox.Text;

            if (double.TryParse(XStart_textBox.Text,out temp))
                crd.XStart = temp;
            if (double.TryParse(Ystart_textBox.Text, out temp))
                crd.YStart = temp;
            if (double.TryParse(I_textBox.Text, out temp))
                crd.I = temp;
            if (double.TryParse(J_textBox.Text, out temp))
                crd.J = temp;
            if (double.TryParse(Deg_textBox.Text, out temp))
                crd.deg = temp;
            if (int.TryParse(Timer_tBox.Text, out t1_temp))
                timer1_interval = t1_temp;

            tmr1.Interval = timer1_interval;

        }

        private void CalcValues()
        {
            crd.CalcRadius();
            crd.CalcCenter();
            crd.angleStart    = crd.CalcAngle(crd.X, crd.Y);
            crd.QuadrantStart = crd.GetQuadrantA(crd.I,crd.J);
            crd.Calc_I_J_End();
            crd.QuadrantFin   = crd.GetQuadrantA(crd.I_end, crd.J_end);
            crd.angleEnd      = crd.CalcAngle(crd.I_end, crd.J_end);
            crd.CalcStep();
            crd.GetNextStep();
            Console.WriteLine($"< Radius {crd.Radius} : xCen {crd.xCenter} : yCen {crd.yCenter} " +
                              $"qStart {crd.QuadrantStart} : qEnd {crd.QuadrantFin} : Iend {crd.I_end} : Jend {crd.J_end} : angS {crd.angleStart} : " +
                              $"angEnd {crd.angleEnd} >");
        }

        private void btnCalcRadii_Click(object sender, EventArgs e)
        {

            ValuesToUse();
            CalcValues();
            CalcDivisor();
            xFin = (int)crd.XFinnish;
            yFin = (int)crd.YFinnish;
            WriteToTextBoxes();
        }

        private void WriteToTextBoxes()
        {
            Xfinnish_textBox.Text = xFin.ToString();
            Yfinnish_textBox.Text = yFin.ToString();
            Q_textBox.Text = crd.QuadrantStart.ToString();
            QFtextBox.Text = crd.QuadrantFin.ToString();
            Radius_textBox.Text = crd.Radius.ToString();
            X0textBox.Text = crd.x0.ToString();
            Y0textBox.Text = crd.y0.ToString();
            N_textBox1.Text = divisor.ToString();
        }

        private void CalcDivisor()
        {
            if (crd.Dir == "G02")
            {
                newDeg = 360 / crd.deg;
                crd.N = ((2 * Math.PI * crd.Radius) / newDeg);
                divisor = crd.deg / crd.N;
            }
            if(crd.Dir == "G03")
            {
                newDeg = 360 /  crd.deg;
                crd.N = ((2 * Math.PI * crd.Radius) / newDeg);
                divisor = crd.deg / crd.N;
            }
        }

        double tempX_I, tempY_J, degA,degB,degT;



        private void butCalDeg_Click(object sender, EventArgs e)
        {
            double temp = 0.00;
            ValuesToUse();
            //get initial angle from current position to radius center

            Radius_textBox.Text = crd.Radius.ToString();

            if (double.TryParse(Xfinnish_textBox.Text, out temp))
                crd.XFinnish = temp;
            if (double.TryParse(Yfinnish_textBox.Text, out temp))
                crd.YFinnish = temp;

            CalcValues();
            CalcDivisor();
            degT = TestQuadrnt();
            WriteToTextBoxes();

            Console.WriteLine( crd.angleStart.ToString() + " : " + crd.angleEnd.ToString() + " : " + degT.ToString());
            Deg_textBox.Text = crd.deg.ToString();

        }

        private double TestQuadrnt()
        {
            double totalDeg = 0.00;

            if (crd.I_end >= 0 && crd.J_end < 0)
            {
                if (crd.angleEnd > crd.angleStart)
                    totalDeg = crd.angleStart - crd.angleEnd;
                else if (crd.angleEnd < crd.angleStart && crd.angleEnd > -crd.angleStart)
                    totalDeg = crd.angleEnd + crd.angleStart;
                else if (crd.angleEnd < -crd.angleStart)
                    totalDeg = 360 + crd.angleEnd + crd.angleStart;
            }
            else if (crd.I_end >= 0 && crd.J_end >= 0)
            {
                totalDeg = crd.angleStart + crd.angleEnd;
            }
            else if (crd.I_end < 0 && crd.J_end >= 0)
            {
                totalDeg = crd.angleStart + crd.angleEnd;
            }
            else if (crd.I_end < 0 && crd.J_end < 0)
            { 
                totalDeg = 360 + crd.angleEnd + crd.angleStart; 
            }

            Console.WriteLine("TotalDeg = "+ totalDeg);
            return totalDeg;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            DrawArea = new Bitmap(PicBx.Size.Width, PicBx.Size.Height);

            Draw();
            if(crd.Dir == "G02")
            {
                degree = 0;
                //crd.deg = degree;
                deg_ = crd.deg;
                Console.WriteLine("G02 " + deg_);
            }

            if (crd.Dir == "G03")
            {
                degree = 360;
                //crd.deg = degree;
                deg_ = 360.0 - crd.deg;
                Console.WriteLine("G03 " + deg_);
            }
                tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (crd.Dir == "G02")
            {
               degree += divisor;
                if (degree >= deg_)
                {
                    tmr1.Stop();
                }
            }

            if (crd.Dir == "G03")
            {
                degree -= divisor;
                if (degree <= deg_)
                {
                    tmr1.Stop();
                }

            }


            crd.deg = degree;
            crd.CalcStep();
            crd.GetNextStep();
            Draw();
        }

        public void Draw()
        {
         //   DrawArea = new Bitmap(PicBx.Size.Width, PicBx.Size.Height);
            PicBx.Image = DrawArea;
            g = Graphics.FromImage(DrawArea);


            g.DrawLine(grid, PicBx.Width/2, 0, PicBx.Height/2,PicBx.Height);
            g.DrawLine(grid, 0, PicBx.Width/2, PicBx.Height, PicBx.Height/2);
            g.DrawLine(p2, crd.XS, crd.YS, crd.XS + 1, crd.YS + 1);
            g.DrawLine(p, (int)crd.XFinnish, (int)crd.YFinnish, (int)crd.XFinnish +1, (int)crd.YFinnish+1);// crd.XC, crd.YC);
            Result_rTb.AppendText(crd.XFinnish + "\t" + crd.YFinnish + "\t" + deg_ + "\t" + degree + Environment.NewLine);
            Result_rTb.ScrollToCaret();
        }


        private void PicBx_MouseUp(object sender, MouseEventArgs e)
        {
            int x = 0;
            int y = 0;
            x = e.X;
            y = e.Y;
            tbXYMousePos.Text = x.ToString() + ":" + y.ToString();
        }
    }
}
