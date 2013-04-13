using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace COPP
{
    class CurveViewer : UserControl
    {



        public delegate void MouseMovedEvt(double x, double y);
        public event MouseMovedEvt MouseMoved;


        public class Curve
        {
            public List<PointF> points = new List<PointF>();
            public double[] Data
            {
                get;
                set;
            }

            public Color Col
            {
                get;
                set;
            }


            public Curve()
            {
                Col = Color.Red;
            }
            public Curve(Color c)
            {
                Col = c;
            }
            public Curve(double[] data)
            {
                Data = data;
            }
            public Curve(double[] data, Color c)
            {
                Data = data;
                Col = c;
            }
        }


        private NoFlickerPanel panel1;
        double maxy, miny;
        int mousex, mousey;
        double maxx, minx;
        private List<Curve> curveList = new List<Curve>();
        public List<Curve> CurveList
        {
            get
            {
                return curveList;

            }
            private set
            {

                curveList = value;
            }
        }

        public void AddCurve(Curve c)
        {
            curveList.Add(c);

            maxx = 0;
            minx = 0;
            maxy = 0;
            miny = Double.MaxValue;

            foreach (Curve cu in curveList)
            {
                foreach (double a in cu.Data)
                {
                    if (a > maxy)
                        maxy = a;
                    if (a < miny)
                        miny = a;
                }

                if (cu.Data.Length > maxx)
                    maxx = cu.Data.Length;

                maxy = Math.Ceiling(maxy);
            }

            foreach (Curve cu in curveList)
            {
                EnsureCurve(cu);
            }

            panel1.Invalidate();
        }

        public void EnsureCurve(Curve c)
        {
            c.points.Clear();
            double diffy = maxy - miny;
            double stepx = (double)((double)(this.Width - 1) / (double)maxx);
            stepx *= c.Data.Length;
            stepx /= c.Data.Length - 1;
            double pos = 0;

            foreach (double a in c.Data)
            {
                float x = (float)pos;
                float y = (float)((a - miny) / diffy * (this.Height - 1));
                PointF p = new PointF(x, this.Height - y - 1);
                c.points.Add(p);
                pos += stepx;
            }

        }

        public void EnsureItems()
        {
            foreach (Curve c in curveList)
            {
                EnsureCurve(c);
            }
        }
        public void SetYMin(double my)
        {
            miny = my;
            EnsureItems();
            panel1.Invalidate();
        }

        public void SetYMax(double my)
        {
            maxy = my;
            EnsureItems();
            panel1.Invalidate();
        }


        public void SetXMin(double my)
        {
            minx = my;
            EnsureItems();
            panel1.Invalidate();
        }

        public void SetXMax(double my)
        {
            maxx = my;
            EnsureItems();
            panel1.Invalidate();
        }



        public CurveViewer()
            : base()
        {
            InitializeComponent();
            mousex = 0;
            mousey = 0;

            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mousex = e.X;
            mousey = e.Y;

            double valy;
            if (curveList.Count == 0) return;
            double valx = mousex * ((maxx - minx) / (Width - 1)) + minx;

            Curve c = curveList[0];
            try
            {
                valy = c.Data[(int)Math.Ceiling(valx)];
            }
            catch (Exception)
            {
                return;
            }
            this.Invalidate();
            MouseMoved(valx, valy);
        }

        protected override void OnResize(EventArgs e)
        {
            EnsureItems();
        }

        private void InitializeComponent()
        {
            this.panel1 = new COPP.NoFlickerPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 443);
            this.panel1.TabIndex = 0;
            // 
            // CurveViewer
            // 
            this.Controls.Add(this.panel1);
            this.Name = "CurveViewer";
            this.Size = new System.Drawing.Size(700, 443);
            this.ResumeLayout(false);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen whitePen = new Pen(Color.White, 1);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 1);
            SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Font drawFont = new Font("Verdana", 6);

            foreach (Curve c in curveList)
            {
                Pen pen = new Pen(c.Col, 1);
                if (c.points.Count > 0)
                {
                    e.Graphics.DrawCurve(pen, c.points.ToArray());
                }
            }

            if (mousey != 0 && mousex != 0 && curveList.Count >= 1)
            {

                Curve c = curveList[0];
                double valx = mousex * ((maxx - minx) / (Width - 1)) + minx;
                double valy = c.Data[(int)Math.Floor(valx)];
                
                double diffy = maxy - miny;
                float curvey = c.points[(int)Math.Floor(valx)].Y;
                Console.WriteLine(curvey);

                e.Graphics.DrawLine(blackPen, new Point(mousex, 0), new Point(mousex, Height - 1)); // ok



                e.Graphics.DrawLine(blackPen, new PointF(0, curvey), new PointF(Width - 1, curvey));
                //Console.WriteLine("{0},{1} ; {2},{3}", mousex, 0, mousex, Height - 1);
            }


            e.Graphics.DrawLine(blackPen, new Point(0, 0), new Point(0, Height - 1));
            e.Graphics.DrawLine(blackPen, new Point(0, Height - 1), new Point(Width - 1, Height - 1));

            for (float i = 0; i < Height - 1; i += ((float)(Height - 1) / (float)10))
            {
                e.Graphics.DrawLine(blackPen, new PointF(0, i), new PointF(2, i));
            }



            for (float i = 0; i < Width - 1; i += (float)(Width - 1) / (float)10)
            {
                e.Graphics.DrawLine(blackPen, new PointF(i, Height - 1), new PointF(i, Height - 3));
            }




            e.Graphics.DrawString(maxy.ToString(), drawFont, drawBrush, new Point(1, 0));
            e.Graphics.DrawString(miny.ToString(), drawFont, drawBrush, new Point(1, Height - 30));
            e.Graphics.DrawString(minx.ToString(), drawFont, drawBrush, new Point(15, Height - 15));
            e.Graphics.DrawString(maxx.ToString(), drawFont, drawBrush, new Point(Width - 30, Height - 15));
        }




    }
}
