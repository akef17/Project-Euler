using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler71
    {
        int ClosestFraction(int denominator)
        {
            int numerator = (denominator * 3) / 7;
                return numerator;
        }


        public int Answer()
        {
            int numerator = 0;
            decimal minDiff = 1;
            for (int i = 1; i <= 1000000; i++)
            {
                decimal decDenom = System.Convert.ToDecimal(i);
                decimal decNumer = System.Convert.ToDecimal(ClosestFraction(i));
                decimal fraction = decNumer / decDenom;
                decimal three = 3;
                decimal seven = 7;
                decimal threebyseven = three / seven;
                if (fraction == threebyseven)
                    continue;
                if (threebyseven - fraction < minDiff)
                {
                    minDiff = threebyseven - fraction;
                    numerator = ClosestFraction(i);
                }
            }
            return numerator;
        }
    }
}
