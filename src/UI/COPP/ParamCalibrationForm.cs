using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace COPP
{
    public partial class ParamCalibrationForm : Form
    {
        public ParamSS ss
        {
            get
            {
                ParamSS s = new ParamSS();
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                s.K = Double.Parse(this.textBoxk.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.Lambda_X = Double.Parse(this.textBoxLambda_x.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.Sigma_x = Double.Parse(this.textBoxSigma_x.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.Mu_e = Double.Parse(this.textBoxMu_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.Sigma_e = Double.Parse(this.textBoxSigma_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.Lambda_e = Double.Parse(this.textBoxLambda_e.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.P_xe = Double.Parse(this.textBoxPe_x.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.e0 = Double.Parse(this.textBoxe0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.x0 = Double.Parse(this.textBoxx0.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                s.MaxIter = (int)numericUpDownMaxIter.Value;
                return s;
            }
            set
            {
                textBoxk.Text = value.K.ToString();
                textBoxLambda_x.Text = value.Lambda_X.ToString();
                textBoxLambda_e.Text = value.Lambda_e.ToString();
                textBoxSigma_e.Text = value.Sigma_e.ToString();
                textBoxSigma_x.Text = value.Sigma_x.ToString();
                textBoxPe_x.Text = value.P_xe.ToString();
                textBoxMu_e.Text = value.Mu_e.ToString();
                textBoxe0.Text = value.e0.ToString();
                textBoxx0.Text = value.x0.ToString();
                numericUpDownMaxIter.Value = value.MaxIter;
            }

        }


        public ParamCalibrationForm()
        {
            InitializeComponent();
        }

   
       

       
    }
}
