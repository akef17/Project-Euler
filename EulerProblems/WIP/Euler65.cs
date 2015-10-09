using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler65
    {
        long DigitSum(long num)
        {
            long sum = 0;
            while(num>0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public long Answer(long num)
        {
            long numer = 1;
            long numer2 = 0;
            long denom = 1;
            long denom2 = 0;
            long tempnum2 = 0;
            if (num % 3 == 0)
                denom = 2*num/3;

            long newnum;
            long tempnum;
            for (long i = num-1; i > 0; i--)
            {
                if (i % 3 == 0)
                    newnum = i * 2 / 3;
                else if (i == 1)
                    newnum = 2;
                else newnum = 1;

                tempnum = denom * newnum + numer;
                if (i == 1)
                    return DigitSum(tempnum);
                numer = denom;
                denom = tempnum;
            }
            return 0;
        }
    }
}
