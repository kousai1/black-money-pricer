using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COPP
{
    public class ParamSS : Param
    {
        public double K { get; set; }
        public double Mu_e { get; set; }
        public double Sigma_x { get; set; }
        public double Sigma_e { get; set; }
        public double P_xe { get; set; }
        public double Lambda_X { get; set; }
        public double Lambda_e { get; set; }
        public double x0 { get; set; }
        public double e0 { get; set; }
        public int MaxIter { get; set; }
        public ParamSS()
        {
            K = 1;
            MaxIter = 1000;
            Mu_e = 0.05;
            Sigma_x = 0.1;
            Sigma_e = 0.1;
            P_xe = 0.5;
            Lambda_X = 0;
            Lambda_e = 0.1;
            x0 = 0.1;
            e0 = 0;
        }
    }
}
