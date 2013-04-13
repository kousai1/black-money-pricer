using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;



// MathWorks assemblies that ship with Builder for .NET
// and should be registered in Global Assembly Cache
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using Schwartz;


namespace COPP
{
    public partial class CalibrationForm : Form
    {
        int lcount;
        int pcount;
        Thread t = null;
        public ParamSS ss
        {
            get;

            set;
        }
        double likelihood;
        int nbiter;
        List<double> maturities = new List<double>();
        List<double> futureList = new List<double>();
        double[] spot = null;
        public double[] generatedSpot = null;

        public CalibrationForm(ParamSS s = null)
        {
            if (s != null)
                ss = s;
            else
                ss = new ParamSS();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            InitializeComponent();

            labelk.Text = ss.K.ToString();
            labellambdax.Text = ss.Lambda_X.ToString();
            labellambdae.Text = ss.Lambda_e.ToString();
            labelsigma_e.Text = ss.Sigma_e.ToString();
            labelsigma_x.Text = ss.Sigma_x.ToString();
            labelpxe.Text = ss.P_xe.ToString();
            labelmu_e.Text = ss.Mu_e.ToString();
            labele0.Text = ss.e0.ToString();
            labelx0.Text = ss.x0.ToString();
            labelMaxIter.Text = ss.MaxIter.ToString();
        }

        private void buttonLoadFutures_Click(object sender, EventArgs e)
        {
            DataOpenerForm dof = new DataOpenerForm();
            if (DialogResult.OK == dof.ShowDialog())
            {
                try
                {
                    futureList.Clear();
                    int currentParts = 0;
                    StreamReader sr = dof.GetStream();
                    lcount = 0;

                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        if (lcount == 0)
                        {
                            line = Regex.Replace(line, @"\s+", ",");
                            string[] parts = line.Split(new[] { ',' });
                            pcount = parts.Length;
                            for (int i = 0; i < pcount; i++)
                                maturities.Add(Double.Parse(parts[i], NumberStyles.AllowDecimalPoint | NumberStyles.Float));
                        }


                        lcount++;
                    }
                    sr.Close();
                    if (lcount == 0 || pcount == 0) return;

                    while (currentParts < pcount)
                    {
                        sr = dof.GetStream();
                        sr.ReadLine();
                        while (sr.Peek() >= 0)
                        {
                            string line = sr.ReadLine();
                            line = Regex.Replace(line, @"\s+", ",");
                            string[] parts = line.Split(new[] { ',' });
                            futureList.Add(Math.Log(Double.Parse(parts[currentParts], NumberStyles.AllowDecimalPoint | NumberStyles.Float)));
                        }
                        currentParts++;
                        sr.Close();
                    }
                    buttonCalibrate.Enabled = true;

                    labele0.Text = futureList[0].ToString();
                }
                catch (Exception)
                {
                    futureList.Clear();
                    MessageBox.Show("File not formated");
                }
            }
        }

        private void StartCalibration()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            ss.K = Double.Parse(this.labelk.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Lambda_X = Double.Parse(this.labellambdax.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Sigma_x = Double.Parse(this.labelsigma_x.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Mu_e = Double.Parse(this.labelmu_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Sigma_e = Double.Parse(this.labelsigma_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Lambda_e = Double.Parse(this.labellambdae.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.P_xe = Double.Parse(this.labelpxe.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.e0 = Double.Parse(this.labele0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.x0 = Double.Parse(this.labelx0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.MaxIter = Int32.Parse(this.labelMaxIter.Text);
            try
            {
            MWNumericArray maxitera = new MWNumericArray(ss.MaxIter);
            MWNumericArray e0a = new MWNumericArray(ss.e0);
            MWNumericArray x0a = new MWNumericArray(ss.x0);
            MWNumericArray maturity = new MWNumericArray(maturities.ToArray());
            MWNumericArray futures = new MWNumericArray(pcount, lcount - 1, futureList.ToArray());
            MWNumericArray k = new MWNumericArray(ss.K);
            MWNumericArray lambdax = new MWNumericArray(ss.Lambda_X);
            MWNumericArray lambdae = new MWNumericArray(ss.Lambda_e);
            MWNumericArray sigmax = new MWNumericArray(ss.Sigma_x);
            MWNumericArray sigmae = new MWNumericArray(ss.Sigma_e);
            MWNumericArray p_xe = new MWNumericArray(ss.P_xe);
            MWNumericArray mu_e = new MWNumericArray(ss.Mu_e);
            Schwartz.Schwartz s = null;
           
                 s = new Schwartz.Schwartz();
          
            MWArray[] Results;
            try
            {
                /** Call matlab */
                Results = (MWArray[])s.SchwartzAndSmith(12,maxitera, x0a, e0a, maturity, futures, k, mu_e, sigmax, sigmae, p_xe, lambdae, lambdax);
            }
            catch
            {
                MessageBox.Show("Calibration aborted!");
                return;
            }

            /** Spot vector */
            double[,] ret = (double[,])Results[0].ToArray();
            this.generatedSpot = new double[ret.Length];
            for (int i = 0; i < ret.Length; i++)
                this.generatedSpot[i] = ret[0, i];


            ss.K = (double)((MWNumericArray)Results[1]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.Mu_e = (double)((MWNumericArray)Results[2]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.Sigma_x = (double)((MWNumericArray)Results[3]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.Sigma_e = (double)((MWNumericArray)Results[4]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.P_xe = (double)((MWNumericArray)Results[5]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.Lambda_e = (double)((MWNumericArray)Results[6]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.Lambda_X = (double)((MWNumericArray)Results[7]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.x0 = (double)((MWNumericArray)Results[8]).ToVector(MWArrayComponent.Real).GetValue(0);
            ss.e0 = (double)((MWNumericArray)Results[9]).ToVector(MWArrayComponent.Real).GetValue(0);
            likelihood = (double)((MWNumericArray)Results[10]).ToVector(MWArrayComponent.Real).GetValue(0);
            nbiter = (int)((double)((MWNumericArray)Results[11]).ToVector(MWArrayComponent.Real).GetValue(0));
            }
            catch (Exception)
            {
                MessageBox.Show("It seems your computer does not have a working copy of the Matlab Compiler Runtime\n Calibration cannot be done without, but you can still use the rest of the program.");
                this.Invoke(new CalibrationDoneCallback(CalibrationDone), this);
                return;

            }
            this.Invoke(new CalibrationDoneCallback(CalibrationDone), this);
        }

        private delegate void CalibrationDoneCallback(object sender);
        private void CalibrationDone(object s)
        {
            labelk.Text = ss.K.ToString();
            labellambdax.Text = ss.Lambda_X.ToString();
            labellambdae.Text = ss.Lambda_e.ToString();
            labelsigma_e.Text = ss.Sigma_e.ToString();
            labelsigma_x.Text = ss.Sigma_x.ToString();
            labelpxe.Text = ss.P_xe.ToString();
            labelmu_e.Text = ss.Mu_e.ToString();
            labelx0.Text = ss.x0.ToString();
            labele0.Text = ss.e0.ToString();
            DisableWhileCalibrating(true);
            buttonOk.Enabled = true;
            t = null;

            if (generatedSpot == null) return;
            if(nbiter>=ss.MaxIter)
                MessageBox.Show("Failed to calibrate!");
            else if (spot == null)
                MessageBox.Show("Parameters loaded!\n Likelihood= " + likelihood + "\n Number of iterations:" + nbiter);
            else
            {
                double mse = 0;
                for (int i = 0; i < spot.Length - 1; i++)
                {
                    mse += (spot[i] - generatedSpot[i]) * (spot[i] - generatedSpot[i]);
                }
                mse /= spot.Length;
                MessageBox.Show("Parameters loaded, spot mse = " + mse + "\n Likelihood= " + likelihood + "\n Number of iterations:" + nbiter );
            }
        }


        private void DisableWhileCalibrating(bool state)
        {
            buttonBrowser.Enabled = state;
            buttonCalibrate.Enabled = state;
            buttonDefault.Enabled = state;
            buttonLoad.Enabled = state;
            buttonSave.Enabled = state;
            buttonSet.Enabled = state;
            buttonSpotBrowser.Enabled = state;
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                DisableWhileCalibrating(false);
                t = new Thread(new ThreadStart(StartCalibration));
                t.Start();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Abort();
                
                DisableWhileCalibrating(true);
            }
            else
            {
                Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //load
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                TextReader tr = new StreamReader(openFileDialog1.FileName);

                ss.K = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Lambda_e = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Lambda_X = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Mu_e = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.P_xe = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Rate = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Sigma_e = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.Sigma_x = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.e0 = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.x0 = Double.Parse(tr.ReadLine(), NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                ss.MaxIter = Int32.Parse(tr.ReadLine());

                labelk.Text = ss.K.ToString();
                labellambdax.Text = ss.Lambda_X.ToString();
                labellambdae.Text = ss.Lambda_e.ToString();
                labelsigma_e.Text = ss.Sigma_e.ToString();
                labelsigma_x.Text = ss.Sigma_x.ToString();
                labelpxe.Text = ss.P_xe.ToString();
                labelmu_e.Text = ss.Mu_e.ToString();
                labele0.Text = ss.e0.ToString();
                labelx0.Text = ss.x0.ToString();
                labelMaxIter.Text = ss.MaxIter.ToString();

                tr.Close();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //save
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
                tw.WriteLine(ss.K);
                tw.WriteLine(ss.Lambda_e);
                tw.WriteLine(ss.Lambda_X);
                tw.WriteLine(ss.Mu_e);
                tw.WriteLine(ss.P_xe);
                tw.WriteLine(ss.Rate);
                tw.WriteLine(ss.Sigma_e);
                tw.WriteLine(ss.Sigma_x);
                tw.WriteLine(ss.e0);
                tw.WriteLine(ss.x0);
                tw.WriteLine(ss.MaxIter);
                tw.Close();
            }

        }

        private void CalibrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
                t.Abort();
        }

        private void buttonLoadSpot_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            //spot for mse
            List<double> l = new List<double>();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextReader tw = new StreamReader(openFileDialog1.FileName);
                while (tw.Peek() >= 0)
                {
                    string line = tw.ReadLine();
                    string[] parts = line.Split(new[] { ',' });
                    foreach (string s in parts)
                    {
                        l.Add(Double.Parse(s, NumberStyles.AllowDecimalPoint | NumberStyles.Float));
                    }
                }
                tw.Close();
                spot = l.ToArray();
            }


        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            ss = new ParamSS();
            labelk.Text = ss.K.ToString();
            labellambdax.Text = ss.Lambda_X.ToString();
            labellambdae.Text = ss.Lambda_e.ToString();
            labelsigma_e.Text = ss.Sigma_e.ToString();
            labelsigma_x.Text = ss.Sigma_x.ToString();
            labelpxe.Text = ss.P_xe.ToString();
            labelmu_e.Text = ss.Mu_e.ToString();
            labele0.Text = ss.e0.ToString();
            labelx0.Text = ss.x0.ToString();
            labelMaxIter.Text = ss.MaxIter.ToString();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            ss.K = Double.Parse(this.labelk.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Lambda_X = Double.Parse(this.labellambdax.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Sigma_x = Double.Parse(this.labelsigma_x.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Mu_e = Double.Parse(this.labelmu_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Sigma_e = Double.Parse(this.labelsigma_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.Lambda_e = Double.Parse(this.labellambdae.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.P_xe = Double.Parse(this.labelpxe.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.e0 = Double.Parse(this.labele0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.x0 = Double.Parse(this.labelx0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
            ss.MaxIter = Int32.Parse(this.labelMaxIter.Text);



            ParamCalibrationForm pcf = new ParamCalibrationForm()
            {
                ss = this.ss
            };
            if (pcf.ShowDialog() == DialogResult.OK)
            {
                ss = pcf.ss;
                labelk.Text = ss.K.ToString();
                labellambdax.Text = ss.Lambda_X.ToString();
                labellambdae.Text = ss.Lambda_e.ToString();
                labelsigma_e.Text = ss.Sigma_e.ToString();
                labelsigma_x.Text = ss.Sigma_x.ToString();
                labelpxe.Text = ss.P_xe.ToString();
                labelmu_e.Text = ss.Mu_e.ToString();
                labele0.Text = ss.e0.ToString();
                labelx0.Text = ss.x0.ToString();
                labelMaxIter.Text = ss.MaxIter.ToString();
            }
        }




    }
}
