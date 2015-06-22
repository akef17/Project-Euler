using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler55
    {
        long Lychrel(long num, long count)
        {
            long revsum = num + Reverse(num);

            if (count > 50)
                return 1;

            if (revsum == (Reverse(revsum)))
                return 0;

            return Lychrel(revsum, ++count);
        }

        long Reverse(long x)
        {
            long num;
            long newnum = 0;
            if (x >= 0 && x <= 9)
                return x;
            while (x >= 1)
            {
                num = x % 10;
                newnum = newnum * 10 + num;
                x /= 10;
            }
            return newnum;
        }

        public long Answer()
        {
            long count = 0;

            for (long i = 0; i <= 10000; i++)
            {
                count += Lychrel(i,0);
            }
            return count;
        }

    }
}