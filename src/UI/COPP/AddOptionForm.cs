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
    public partial class AddOptionForm : Form
    {

        public Option opt
        {
            get
            {
                
                Option o = new Option();
                o.StrikePrice = Double.Parse(textBox1.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                o.Value = Double.Parse(textBox2.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);
                if (radioButtonDate.Checked)
                {
                    o.DaysTilExpiry = (int)numericUpDownnbDays.Value;
                }
                else
                {
                    DateTime buyt = dateTimePickerBuy.Value;
                    DateTime expiryt = dateTimePickerexpiry.Value;

                    TimeSpan t = expiryt - buyt;
                    o.DaysTilExpiry = (int)t.TotalDays;
                }


                if (radioButtonCall.Checked)
                    o.Type = "Call";
                else o.Type = "Put";

                o.Volatility = Double.Parse(textBoxVolatility.Text, NumberStyles.AllowDecimalPoint | NumberStyles.Float);

                return o;
            }
        }
        public AddOptionForm(double volatility)
        {
            InitializeComponent();
            this.textBoxVolatility.Text = volatility.ToString();
        }
    }
}
