using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler48
    {
        long SelfPower(long n)
        {
            long i;
            long num = 1;
            for (i = 1; i <= n; i++)
            {
                num = (num * n) % 10000000000;
            }
            return num;
        }
        public long Answer()
        {
            long sum = 0;
            for (long i = 1; i <= 1000; i++)
            {
                sum += SelfPower(i);
            }
            return sum%10000000000;
        }
    }
}
