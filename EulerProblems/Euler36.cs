using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler36
    {
        long Reverse(long x)
        {
            long num;
            long newnum = 0;
            if (x >= 0 && x <= 9)
                return x;
            while (x >= 1)
            {
                num = x % 10;
                newnum = newnum * 10 + num;
                x /= 10;
            }
            return newnum;
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

        public long Binary(long decnum)
        {
            long binnum = 0;
            for (long i = 19; i >= 0; i--)
            {
                if (decnum >= Exponential(2, i))
                {
                    binnum += Exponential(10, i);
                    decnum -= Exponential(2, i);
                }
            }
            return binnum;
        }
        public long Answer()
        {
            long i;
            long sum = 0;
            for (i = 0; i < 1000000; i++)
            {
                if (Reverse(i) == i && Reverse(Binary(i)) == Binary(i))
                    sum += i;
            }
            return sum;
        }
    }
}
