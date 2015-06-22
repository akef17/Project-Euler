using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler387
    {
        long RightTruncHarshadNum(long num)
        {
            if (num <= 9 && num >= 1)
                return 1;
            long sum = 0;
            long tempNum = num;

            while (tempNum >= 1)
            {
                sum += tempNum % 10;
                tempNum /= 10;
            }
            if (num % sum == 0)
                return RightTruncHarshadNum(num / 10);
            return 0;
        }
    
        long IsPrime(long n)
        {
            long i;
            long count = 0;
            for (i = 1; (i*i) <= n ; i++)
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
            long sum = 0;
            for (long i = 10; i < 1000000000000; i++)
            {
                if (/*(RightTruncHarshadNum(i / 10) == 1)  && */(IsPrime(i) == 1))
                    sum += i;
            }
            return sum;
        }
    }
}