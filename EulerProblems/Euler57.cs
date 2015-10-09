using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler57
    {
        int DigitCount(int n)
        {
            int count = 0;
            while (n >= 1)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        public int Answer()
        {
            int numer = 3;
            int olddenom = 2;
            int denom = 2;
            int count = 0;

            for (int i=2; i<=1000;i++ )
            {
                olddenom = denom;
                denom += numer;
                numer = denom + olddenom;
                if (DigitCount(denom) > 8 || DigitCount(numer) > 8)
                {
                    olddenom /= 10;
                    denom /= 10;
                    numer /= 10;
                }
                if (DigitCount(numer) > DigitCount(denom))
                    count++;
            }
            return count;
        }
    }
}
