using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler32
    {
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
        long PanDigital(long n)
        {
            long x;
            long num;
            long digcount = 0;

            for (x = 1; x <= DigitCount(n); x++)
            {
                if (DigitCount(n) != 9)
                    return 0;

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
        long NumberConcat(long mult1, long mult2, long product)
        {
            long concatnum = mult2 * Exponential(10, DigitCount(product)) + product;
            concatnum += mult1 * Exponential(10, DigitCount(concatnum));
            return concatnum;
        }
        public long Answer()
        {
            long sum = 0;
            long prod;
            long[] prodarray;
            long k = 0;
            for (long i = 1; i < 10000; i++)
            {
                for (long j = 1; j < 10000; j++)
                {
                    prod = i * j;
                    if (PanDigital(NumberConcat(i, j, prod)) != 0)
                    {
                        
                            Console.WriteLine(prod);
                        
                        sum += prod;
                    }
                }
            }
            return sum;
        }
    }
}
