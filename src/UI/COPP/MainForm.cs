using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;

namespace COPP
{
    public partial class MainForm : Form
    {
        GuassianRandom gr = new GuassianRandom();
        ParamSS ss = null;
        public MainForm()
        {
            InitializeComponent();
            ss = new ParamSS();
            curveViewer.MouseMoved += new CurveViewer.MouseMovedEvt(curveViewer_MouseMoved);
        }

        void curveViewer_MouseMoved(double x, double y)
        {

            if(labelXY.InvokeRequired)
            {
                labelXY.Invoke(new CurveViewer.MouseMovedEvt(curveViewer_MouseMoved),new object[] { x,y});

            }
            else
            {
                string text = "Time: " + x + "\nPrice: " + y + "$";
                labelXY.Text = text;
            }

        }

      
        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            CalibrationForm cf = new CalibrationForm(ss);
            DialogResult r = cf.ShowDialog();
            if (r == DialogResult.OK) /** Calibration successful */
            {
                if(cf.generatedSpot!=null) curveViewer.AddCurve(new CurveViewer.Curve(cf.generatedSpot, Color.Red));
                ss = cf.ss;


                foreach (DataGridViewRow dgvr in dataGridViewFutures.Rows)
                {
                    DataGridViewCellCollection cells = dgvr.Cells;
                    double mat = (double)cells[0].Value;
                    cells[1].Value = PriceFuture(mat);
                }


                foreach (DataGridViewRow dgvr in dataGridViewOption.Rows)
                {
                    DataGridViewCellCollection cells = dgvr.Cells;
                    Option newOpt = new Option()
                    {
                        Value = (double)cells[0].Value,
                        StrikePrice = (double)cells[1].Value,
                        DaysTilExpiry = (int)cells[2].Value,
                        Type = (string)cells[3].Value,
                    };
                    cells[4].Value = PriceOption(newOpt);
                }



            }
        }

        private void buttonSetAxis_Click(object sender, EventArgs e)
        {

            if (numericUpDownYmax.Value < numericUpDownYmin.Value)
            {
                double t = (double)numericUpDownYmax.Value;
                numericUpDownYmax.Value = numericUpDownYmin.Value;
                numericUpDownYmin.Value = (decimal)t;
            }


            if (numericUpDownXMas.Value < numericUpDownXMin.Value)
            {
                double t = (double)numericUpDownXMas.Value;
                numericUpDownXMas.Value = numericUpDownXMin.Value;
                numericUpDownXMin.Value = (decimal)t;
            }

            if (numericUpDownYmax.Value != numericUpDownYmin.Value)
            {
                curveViewer.SetYMax((double)numericUpDownYmax.Value);
                curveViewer.SetYMin((double)numericUpDownYmin.Value);
            }
            if (numericUpDownXMas.Value != numericUpDownXMin.Value)
            {
                curveViewer.SetXMin((double)numericUpDownXMin.Value);
                curveViewer.SetXMax((double)numericUpDownXMas.Value);
            }


        }

        private void buttonAddOption_Click(object sender, EventArgs e)
        {
            AddOptionForm aoptf = new AddOptionForm(ss.Sigma_x);
            if (aoptf.ShowDialog() == DialogResult.OK)
            {
                Option newOpt = aoptf.opt;
                dataGridViewOption.Rows.Add(new object[] { newOpt.Value, newOpt.StrikePrice, newOpt.DaysTilExpiry, newOpt.Type, PriceOption(newOpt) });
            }
        }

        private double PriceOption(Option o)
        {
            // price option with ss 

            double price = 0.0;
            double xt = ss.Sigma_x;
            double delta = (double)7 / (double)360;
            double et = Math.Log(o.Value) - ss.Sigma_x;
            double nbWeeks = (o.DaysTilExpiry / 7);

            for (int i = 0; i < nbWeeks; i++)
            {
                double dx, de;
                dx = gr.NextGuassian();
                de = ss.P_xe * delta / dx;
                // xt = Math.Exp(-ss.K * delta) * xt + gr.NextGuassian() * delta;
                // et = ss.Mu_e * delta + et + gr.NextGuassian() * delta;
                xt += (-ss.K * xt - ss.Lambda_X) * delta + ss.Sigma_x * dx * delta;
                et += (ss.Mu_e - ss.Lambda_e) * delta + ss.Sigma_e * de * delta;
            }


            double f = Math.Exp(et + xt); // afficher

            if (o.Type == "Call")
                price = Math.Exp(-0.03/* to change.?*/* nbWeeks) * Math.Max(f - o.StrikePrice, 0);
            else
                price = Math.Exp(-0.03/* to change.?*/* nbWeeks) * Math.Max(o.StrikePrice - f, 0);
            //while (true)
            // Console.WriteLine(gr.NextGuassian());
            Console.WriteLine("f:{0}, xt:{1}, et:{2}, price:{3}", f, xt, et, price);

            return price;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewOption.Rows.Clear();
        }

        private void buttonExportImage_Click(object sender, EventArgs e)
        {
            //export to bmp
            Bitmap image = new Bitmap(curveViewer.Width, curveViewer.Height);
            curveViewer.DrawToBitmap(image, new Rectangle(new Point(), curveViewer.Size));
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image.Save(saveFileDialog1.FileName);
            }
        }

        private void buttonLoadCurve_Click(object sender, EventArgs e)
        {
            //load
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextReader tw = new StreamReader(openFileDialog1.FileName);
                while (tw.Peek() >= 0)
                {
                    string line = tw.ReadLine();
                    string[] parts = line.Split(new[] { ',' });
                    CurveViewer.Curve c = new CurveViewer.Curve();
                    List<double> ld = new List<double>();
                    for (int i = 0; i < parts.Length - 1; i++)
                    {
                        ld.Add(Double.Parse(parts[i], NumberStyles.AllowDecimalPoint | NumberStyles.Float));
                    }
                    c.Col = Color.FromName(parts[parts.Length - 1]);
                    c.Data = ld.ToArray();
                    curveViewer.AddCurve(c);

                }
                tw.Close();


            }




        }

        private void buttonSaveCurve_Click(object sender, EventArgs e)
        {
            //save
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);

                foreach (CurveViewer.Curve c in curveViewer.CurveList)
                {
                    for (int i = 0; i < c.Data.Length; i++)
                    {
                        tw.Write(c.Data[i]);
                        tw.Write(',');
                    }
                    tw.Write(c.Col.Name);
                    tw.Write('\n');
                }
                tw.Close();

            }

        }

        private void buttonClearCurve_Click(object sender, EventArgs e)
        {
            curveViewer.CurveList.Clear();
            curveViewer.Invalidate();
        }

        private void buttonRemoveOption_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridViewOption.SelectedRows)
            {
                dataGridViewOption.Rows.Remove(a);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            CurveViewer.Curve c = new CurveViewer.Curve();
            int t = 200;
            List<double> gen = new List<double>();
            for (double i = 0; i < t; i = i + (double)7 / 360)
            {
                double elnst = (Math.Exp(-ss.K * i) * ss.x0) + ss.e0 + ss.Mu_e * i;
                double varlnst = ((1 - Math.Exp(-2 * ss.K * i)) * ((ss.Sigma_x * ss.Sigma_x) / (2 * ss.K))) + (ss.Sigma_e * ss.Sigma_e * i) + (2 * (1 - Math.Exp(ss.K * i)) * ((ss.P_xe * ss.Sigma_x * ss.Sigma_e) / ss.K));
                double lnst = elnst
                               + 1 / 2 * varlnst;


                gen.Add(Math.Exp(lnst));
            }


        
            c.Data = gen.ToArray();
            curveViewer.AddCurve(c);




        }

        private void buttonAddFuture_Click(object sender, EventArgs e)
        {
            AddFutureForm aff = new AddFutureForm();
            if (aff.ShowDialog() == DialogResult.OK)
            {
                dataGridViewFutures.Rows.Add(new object[] { aff.Maturity, PriceFuture(aff.Maturity) });

            }
        }


        private double PriceFuture(double mat)
        {
            double firstpart = (Math.Exp(-ss.K * mat) * ss.x0) + ss.e0;
            double at = ss.Mu_e/**star */ * mat - (1 - Math.Exp(1 - Math.Exp(-ss.K * mat))) * (ss.Lambda_X / ss.K) + 1 / 2 * ((1 - Math.Exp(-2 * ss.K * mat)) * ((ss.Sigma_x * ss.Sigma_x) / (2 * ss.K)) +
                (ss.Sigma_e * ss.Sigma_e * mat) + 2 * (1 - Math.Exp(1 - Math.Exp(-ss.K * mat))) * ((ss.P_xe * ss.Sigma_x * ss.Sigma_e) / ss.K));
            double price = Math.Exp(firstpart + at);
            Console.WriteLine("Price :" + price);
            return price;
        }
        private void buttonRemoveFuture_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridViewFutures.SelectedRows)
            {
                dataGridViewFutures.Rows.Remove(a);
            }
        }

        private void buttonClearFuture_Click(object sender, EventArgs e)
        {
            dataGridViewFutures.Rows.Clear();
        }

        private void buttonLoadFutures_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextReader tw = new StreamReader(openFileDialog1.FileName);
                while (tw.Peek() >= 0)
                {
                    string line = tw.ReadLine();

                    try
                    {
                        double mat = Double.Parse(line, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                        dataGridViewFutures.Rows.Add(new object[]{mat,PriceFuture(mat)});
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

            }
        }

        private void buttonSaveFutures_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);

                foreach (DataGridViewRow a in dataGridViewFutures.Rows)
                {
                    DataGridViewCellCollection cells = a.Cells;
                    tw.Write(cells[0].Value);
                    tw.Write(tw.NewLine);
                }

                tw.Close();

            }
        }

        private void buttonLoadOption_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextReader tw = new StreamReader(openFileDialog1.FileName);
                while (tw.Peek() >= 0)
                {
                    string line = tw.ReadLine();
                    string[] parts = line.Split(',');
                    if (parts.Length != 4) continue;
                    try
                    {
                        Option newOpt = new Option()
                        {
                            Value = Double.Parse(parts[0], NumberStyles.AllowDecimalPoint | NumberStyles.Float),
                            StrikePrice = Double.Parse(parts[1], NumberStyles.AllowDecimalPoint | NumberStyles.Float),
                            DaysTilExpiry = Int32.Parse(parts[2]),
                            Type = parts[3],
                        };
                        dataGridViewOption.Rows.Add(new object[] { newOpt.Value, newOpt.StrikePrice, newOpt.DaysTilExpiry, newOpt.Type, PriceOption(newOpt) });
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
             

                tw.Close();

            }
        }

        private void buttonSaveOption_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);

                foreach (DataGridViewRow a in dataGridViewOption.Rows)
                {
                    DataGridViewCellCollection cells = a.Cells;
                    tw.Write(cells[0].Value);
                    tw.Write(',');
                    tw.Write(cells[1].Value);
                    tw.Write(',');
                    tw.Write(cells[2].Value);
                    tw.Write(',');
                    tw.Write(cells[3].Value);
                    tw.Write(tw.NewLine);

                }

                tw.Close();

            }
        }




    }
}
