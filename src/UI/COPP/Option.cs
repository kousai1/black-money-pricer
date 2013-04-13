using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COPP
{
    public class Option : Asset
    {

        
        public double StrikePrice { get; set; }
        public int DaysTilExpiry { get; set; }
        public string Type { get; set; }


        public Option()
        {

        }
        public Option(double sp, int d, double val, DateTime t, string type, double v, double r)
            : base(val, t, type,v,r)
        {
            StrikePrice = sp;
            DaysTilExpiry = d;
        }

    }
}
