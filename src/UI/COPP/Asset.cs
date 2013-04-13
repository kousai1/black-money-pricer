using System;
using System.Collections.Generic;
using System.Text;

namespace COPP
{
    public class Asset : Param
    {
        public double Value { get; set; } // spot
        public DateTime Time { get; set; }
        public string CrudeOilType { get; set; }


        public Asset()
        {


        }
        public Asset(double val, DateTime t, string type, double v, double r)
            : base(v,r)
        {
            Value = val;
            Time = t;
            CrudeOilType = type;
        }
    }
}
