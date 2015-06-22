using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler52
    {
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
                    }
                }
                a /= 10;
            }
            return count;
        }
        public long Answer()
        {
            long DCN;
            for(long n = 1; n < 1000000; n++)
            {
                DCN = DigitCount(n);

                if ((DCN == DigitCount(6*n)) && (DCN == DigitCheck(n,2*n)) && (DCN == DigitCheck(n, 3*n)) &&
                   (DCN == DigitCheck(n, 4 * n)) && (DCN == DigitCheck(n, 5 * n)) && (DCN == DigitCheck(n, 6 * n)))
            return n;

            }
            return 0;
        }
    }
}
