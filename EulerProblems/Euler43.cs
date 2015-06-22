using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler43
    {
        long IsPrime(long n)
        {
            long i;
            long count = 0;
            for (i = 1; i * i <= n; i++)
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

        long NumberConcat(long num1, long num2)
        {
            long concatnum = num1 * Exponential(10, DigitCount(num2)) + num2;
            return concatnum;
        }

        long Exponential(long x, long y)
        {
            long z;
            long power = 1;
            if (y == 0)
                return 1;
            for (z = 1; z <= y; z++)
            {
                power *= x;
            }
            return power;
        }

        long DigitCount(long n)
        {
            long count = 0;
            while (n >= 1)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        public long Answer()
        {
            for (long i = 17; i >= 2; i--)
                if (IsPrime(i) == 0)
                    continue;

        }
    }
}
