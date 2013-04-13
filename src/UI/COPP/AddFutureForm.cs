using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace COPP
{
    public partial class AddFutureForm : Form
    {
      
        public double Maturity
        {
            get
            {
                return (double)Double.Parse(textBoxMaturity.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float); 
            }

            set
            {
                textBoxMaturity.Text = value.ToString();
            }
        }


        public AddFutureForm()
        {
            InitializeComponent();
        }
    }
}
