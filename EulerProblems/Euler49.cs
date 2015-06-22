using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler49
    {
        long RemoveDigit(long num, long digit)
        {
            long count = 0;
            long tempnum = num;
            long remainnum = 0;
            for(;tempnum>=1;tempnum/=10)
            {

                if (tempnum % 10 == digit)
                    return tempnum/10 * Exponential(10, DigitCount(remainnum)) + remainnum;
                    remainnum += (tempnum%10) * Exponential(10, count);
                        count++;
            }
                return 0;
        }
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

        long NumberConcat(long num1, long num2, long num3)
        {
            long concatnum = num2 * Exponential(10, DigitCount(num3)) + num3;
            concatnum += num1 * Exponential(10, DigitCount(concatnum));
            return concatnum;
        }
        long DigitCheck(long a, long b)
        {
            long count = 0;
            long digita;
            long tempb;
            while (a >= 1)
            {
                tempb = b;
                digita = a % 10;
                for (; tempb >= 1; tempb /= 10)
                {
                    if (tempb % 10 == digita)
                    {
                        count++;
                        tempb = 0;
                        b = RemoveDigit(b, digita);
                    }
                }
                a /= 10;
            }
            return count;

        }
        public long Answer()
        {
            for (long i = 1000; i < 10000; i++)
            {
                if (i == 1487)
                    continue;

                if (IsPrime(i) == 1)
                    for (long j = i+1; j < 10000; j++)
                    {
                        if (DigitCheck(i,j) == 4 && IsPrime(j) == 1)
                        {
                            long k = 2 * j - i;
                            if (k < 10000 && (DigitCheck(i, k) == 4) && IsPrime(k) == 1)
                            {
                                return NumberConcat(i, j, k);
                            }
                        }
                    }

            }
            return 0;
        }
    }
}
