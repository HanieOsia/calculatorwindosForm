using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator_Form
{
    class Bigdouble
    {
        public _Double Sum(_Double FirstNumber, _Double SecondNumber)
        {
            _Double Result = new _Double();
            Result.intgr = (FirstNumber.intgr + SecondNumber.intgr);
            Result.flt = (FirstNumber.flt + SecondNumber.flt);
            List<int> length = new List<int>();
            length.Add(FirstNumber.flt.ToString().Length);
            length.Add(SecondNumber.flt.ToString().Length);
            if(Result.flt.ToString().Length>length.Max())
            {
                Result.intgr++;
                Result.flt = Result.flt-BigInteger.Parse(Math.Pow(10,length.Max()).ToString());
            }
            
            return Result;
        }
        public _Double Minus(_Double FirstNumber, _Double SecondNumber)
        {
            _Double Result = new _Double();
            if (FirstNumber.intgr > SecondNumber.intgr && FirstNumber.flt > SecondNumber.flt) 
            {
                Result.intgr = FirstNumber.intgr - SecondNumber.intgr;
                Result.flt = FirstNumber.flt - SecondNumber.flt;
            }
            if (FirstNumber.intgr > SecondNumber.intgr && FirstNumber.flt < SecondNumber.flt)
            {
                Result.intgr = FirstNumber.intgr - SecondNumber.intgr;
                Result.flt = -(SecondNumber.flt - FirstNumber.flt);
            }
            if (FirstNumber.intgr < SecondNumber.intgr && FirstNumber.flt > SecondNumber.flt)
            {
                Result.intgr = -(SecondNumber.intgr - FirstNumber.intgr);
                Result.flt = FirstNumber.flt - SecondNumber.flt;
            }
            if (FirstNumber.intgr < SecondNumber.intgr && FirstNumber.flt < SecondNumber.flt)
            {
                Result.intgr = -(SecondNumber.intgr - FirstNumber.intgr);
                Result.flt = -(SecondNumber.flt - FirstNumber.flt);
            }

            return Result;
        }
        public _Double Multiplication(_Double FirstNumber, _Double SecondNumber)
        {
            _Double Result = new _Double();
            List<int> length = new List<int>();
            length.Add(FirstNumber.flt.ToString().Length);
            length.Add(SecondNumber.flt.ToString().Length);
            string ResultFN = FirstNumber.intgr.ToString() + FirstNumber.flt.ToString();
            string ResultSN = SecondNumber.intgr.ToString() + SecondNumber.flt.ToString();
            BigInteger zarb = BigInteger.Parse(ResultFN)*BigInteger.Parse(ResultSN);
            length.Add(zarb.ToString().Length);
            Result.intgr = BigInteger.Parse(zarb.ToString().Substring(0, zarb.ToString().Length - (FirstNumber.flt.ToString().Length + SecondNumber.flt.ToString().Length)));
            Result.flt= BigInteger.Parse(zarb.ToString().Substring(zarb.ToString().Length - (FirstNumber.flt.ToString().Length + SecondNumber.flt.ToString().Length)));
            return Result;
        }
        public _Double Division(_Double FirstNumber, _Double SecondNumber)
        {

            _Double Result = new _Double();
            List<int> length = new List<int>();
            length.Add(FirstNumber.flt.ToString().Length);
            length.Add(SecondNumber.flt.ToString().Length);
            string ResultFN = FirstNumber.intgr.ToString() + FirstNumber.flt.ToString();
            string ResultSN = SecondNumber.intgr.ToString() + SecondNumber.flt.ToString();
            BigInteger taghsim = (BigInteger.Parse(ResultFN) * BigInteger.Parse(Math.Pow(10, length.Max()).ToString())) / (BigInteger.Parse(ResultSN) * BigInteger.Parse(Math.Pow(10, length.Max()).ToString()));
            if (taghsim.ToString().Contains('.'))
            {
                String[] rs = taghsim.ToString().Split('.');
                Result.intgr = BigInteger.Parse(rs[0]);
                Result.flt = BigInteger.Parse(rs[1]);
            }
            else
            {
                String[] rs = taghsim.ToString().Split('.');
                Result.intgr = BigInteger.Parse(rs[0]);
                Result.flt = 0;
            }


            return Result;
        }
    }
}
