using System;
using System.Collections.Generic;
using System.Text;

namespace COPP
{
    public class Param
    {
        public double Volatility { get; set; }
        public double Rate { get; set; }
        public Param()
        {


        }
        public Param(double v, double r)
        {
            Volatility = v;
            Rate = r;
        }

    }
}
