using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler97
    {
        public long Answer()
        {
            long num = 0;
            long[] digits = new long[10];
            for (long initialize = 0; initialize <= 9; initialize++)
            {
                digits[initialize] = 0;
            }
            digits[0] = 1;

            for (long j = 1; j <= 7830457; j++)
            {
                for (long k = 9; k >= 0; k--)
                {
                    digits[k] = 2 * digits[k];
                    if (digits[k] > 9)
                    {
                        digits[k] = digits[k] - 10;
                        if (k != 9)
                            (digits[k + 1])++;
                    }

                }

            }

            for (long l = 9; l >= 0; l--)
            {
                num *= 10;
                num += digits[l];
            }
            return ((num*28433)+1)%10000000000;
        }
    }
}
