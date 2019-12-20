using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator_Form
{
    class _Double
    {
        public BigInteger intgr { get; set; }
        public BigInteger flt { get; set; }
        public string GetBigDouble
        {
            set
            {
                if (value.Contains('.'))
                {
                    String[] ashar = value.Split('.');
                    intgr = BigInteger.Parse(ashar[0]);
                    flt = BigInteger.Parse(ashar[1]);
                }
                else
                {
                    String[] ashar = value.Split('.');
                    intgr = BigInteger.Parse(ashar[0]);
                    flt = 0;
                }
            }
            get
            {
                GetBigDouble = intgr.ToString() + "." + flt.ToString();
                return GetBigDouble;
            }
        }
    }
}
