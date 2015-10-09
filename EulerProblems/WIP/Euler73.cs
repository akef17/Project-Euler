using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler73
    {
        long IsReduced(decimal numer, decimal denom)
        {
            for (decimal i = 2; i*i <= numer && i*i <= denom;i++)
            {
                if (numer % i == 0 && denom % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        long BetweenCount(long denom)
        {
            long count = 0;
            long numer = (denom / 3) + 1;
            decimal oneHalf = .5m;
            decimal decnumer = System.Convert.ToDecimal(numer);
            decimal decdenom = System.Convert.ToDecimal(denom);

            while(decnumer/decdenom < oneHalf)
            {
                if (IsReduced(decnumer, decdenom) == 1)
                {
                    count++;
                }
                decnumer++;
            }
            return count;
        }

        public long Answer()
        {
            long count = 0;
            for (long i=4; i <= 12000; i++)
            {
                count += BetweenCount(i);
            }
            return count;
        }
    }
}
