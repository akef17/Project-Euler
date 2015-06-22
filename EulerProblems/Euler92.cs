using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler92
    {
         long DigitChain(long num)
        {
            long sum = 0;
            long digit;
            while (num >= 1)
            {
                digit = (num % 10);
                sum += digit * digit;
                num /= 10;
            }
            if (sum == 89)
                return 1;
            if (sum == 1)
                return 0;
            return DigitChain(sum);
        }
         public long Answer()
         {
             long sum = 0;
             for (int i = 1; i < 10000000; i++)
             {
                 sum += DigitChain(i);
             }
             return sum;
         }
    }
}