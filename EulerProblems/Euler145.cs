using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler145
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
        long OddDigitCheck(long num)
        {
            long i;
            for (i = num; i >= 1; i /= 10)
            {
                if ((i % 10) % 2 == 0)
                    return 0;
            }
            return 1;
        }
        public long Answer()
        {
            long i;
            long count = 0;
            for(i=10;i<1000000000;i++)
            {
                if (i % 10 != 0)
                {
                    if (OddDigitCheck(i + Reverse(i)) == 1)
                        count++;
                }
            }
            return count;
        }
    }
}
