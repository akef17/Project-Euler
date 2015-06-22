using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler58
    {
        int IsPrime(long n)
        {
            long i;
            long count = 0;
            for (i = 1; (i*i) <= n; i++)
            {
                if (n % i == 0)
                    count++;
                if (count == 2)
                    return 0;
            }
            if (count == 1)
                return 1;
            else
                return 0;
        }
        public long Answer()
        {
            long count = 1;
            long primecount = 0;

            for (long x = 3; x <= 50000; x+=2)
            {
                if (IsPrime(x * x - (x - 1)) == 1)
                    primecount++;
                if (IsPrime(x * x - (2 * (x - 1))) == 1)
                    primecount++;
                if (IsPrime(x * x - (3 * (x - 1))) == 1)
                    primecount++;
                count += 4;
                if (primecount * 10 < count )
                {
                    return x;
                }
            }
            return primecount;
        }
    }
}
