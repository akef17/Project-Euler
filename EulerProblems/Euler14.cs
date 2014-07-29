using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler14
    {        
        long Collatz(long n,long count)
        {
            if (n == 1)
                return count;
            if (n % 2 == 0)  {     
                count++;     
                return Collatz(n / 2,count++);   
            }        
            else                {
                count++;
                return Collatz(3 * n + 1,count++);   
            }
        }
        public long Answer()
        {
            long x;
            long max = 0;
            long xmax = 0;
            for (x = 1; x < 1000000; x++)
            {
                if (Collatz(x, 0) > max)
                {
                    max = Collatz(x, 0);
                    xmax = x;
                }
            }
            return xmax;
        }
    }
}
