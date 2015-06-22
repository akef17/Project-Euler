using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler38
    {
        long PanDigital(long n)
        {
            long x;
            long num;
            long digcount = 0;

            for (x = 1; x <= DigitCount(n); x++)
            {
                long count = 0;
                long tempn = n;
                while (tempn >= 1)
                {
                    num = tempn % 10;
                    if (num == x)
                    {
                        count++;
                    }
                    tempn /= 10;
                }
                if (count == 1)
                    digcount++;
            }
            if (DigitCount(n) == digcount)
                return n;
            else
                return 0;
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
        long numMult(long num)
        {
            long i = 2;
            long newNum = num;
            while(DigitCount(newNum)<9)
            {
                newNum = NumberConcat(newNum, num * i);
                    i++;
            }
            if (DigitCount(newNum) == 9)
                return newNum;
            else
                return 0;
        }

        public long Answer()
        {
            long max = 0;
            for (long i=1; i<10000;i++)
            {
                if ((PanDigital(numMult(i))) > max)
                    max = PanDigital(numMult(i));
            }
            return max;
        }

    }
}

