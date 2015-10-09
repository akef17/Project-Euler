using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler94
    {
        long Exponential(long x, int y)
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
        long IsSquare(long num)
        {
            for (long i = 1; i * i <= num; i++)
            {
                if (i * i == num)
                    return i;
            }
            return -1;
        }
        public long Answer()
        {
            long count = 0;
            for (long x = 0; ((3 * x) + 1) < 1000000000; x++)
            {
                if ((x + 1) % 2 == 0 && IsSquare((Exponential(x, 2) - Exponential(((x + 1) / 2), 2))) % 2 == 0)
                    count += (3 * x) + 1;
            }
            return count;
        }

    }
}
