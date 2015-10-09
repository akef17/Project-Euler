using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler72
    {
        long CountRemove(long n)
        {
            long i;
            long count = 0;
            for (i = 2; 2 * i <= n; i++)
            {
                if (n % i == 0)
                {
                    int j = 1;
                    while (i * j < n)
                    {
                        count++;
                        j++;
                    }
                }
            }
            return count;
        }

        public long Answer(long n)
        {
            long total = ((n * (n-1))/2);
            for (long i = 1; i <= n; i++)
            {
                total -= CountRemove(i);
            }
            return total;
        }
    }
}
