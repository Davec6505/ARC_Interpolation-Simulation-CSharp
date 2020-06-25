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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            crd = new Cords();
            tmr1.Interval = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            crd.Dir = Dir_textBox.Text;

            crd.XStart = double.Parse(XStart_textBox.Text);
            crd.YStart = double.Parse(Ystart_textBox.Text);

            crd.I = double.Parse(I_textBox.Text);
            crd.J = double.Parse(J_textBox.Text);
            crd.deg = double.Parse(Deg_textBox.Text);
            deg_ = crd.deg;
            crd.CalcRadius();

            xFin = (int)crd.XFinnish;
            yFin = (int)crd.YFinnish;
            Xfinnish_textBox.Text = xFin.ToString();
            Yfinnish_textBox.Text = yFin.ToString();

            Q_textBox.Text = crd.QuadrantStart.ToString();
            QFtextBox.Text = crd.QuadrantFin.ToString();
            Radius_textBox.Text = crd.Radius.ToString();
            N_textBox1.Text = crd.N.ToString();
            X0textBox.Text = crd.x0.ToString();
            Y0textBox.Text = crd.y0.ToString();

          
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

            Debug.WriteLine($"divisor:= {divisor}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawArea = new Bitmap(PicBx.Size.Width, PicBx.Size.Height);

            Draw();
            if(crd.Dir == "G02")
            {
                degree = 0;
                crd.deg = degree;
            }

            if (crd.Dir == "G03")
            {
                degree = 360;
                crd.deg = degree;
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
            crd.CalcRadius();
            Draw();
        }

        public void Draw()
        {
         //   DrawArea = new Bitmap(PicBx.Size.Width, PicBx.Size.Height);
            PicBx.Image = DrawArea;
            g = Graphics.FromImage(DrawArea);


            g.DrawLine(grid, 350, 0, 350, 700);
            g.DrawLine(grid, 0, 350, 700, 350);
            g.DrawLine(p2, crd.XS, crd.YS, crd.XS + 1, crd.YS + 1);
            g.DrawLine(p, (int)crd.XFinnish, (int)crd.YFinnish, (int)crd.XFinnish +1, (int)crd.YFinnish+1);// crd.XC, crd.YC);
        }
    }
}
