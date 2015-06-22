using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler206
    {
        long DigitTest(long n)
        {
            
            if (n % 10 == 0)
            {
                n/=100;
                for (long i = 9; i >= 1; n /= 100)
                {
                    if (n % 10 != i)
                        return 0;
                    i--;
                }
                return 1;
            }
            else
                return 0;
        }
        public long Answer()
        {
            for (long i = 1000000000; i < 1400000000; i++)
            {
                if ((DigitTest((i * i))) == 1)
                    return i;
            }
            return 0;
        }
    }
}
