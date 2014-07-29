using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler21
    {
        public int DivisorSum(int n)
        {
            int x;
            int sum = 0;
            for (x = 1; x < n; x++)
            {
                if (n % x == 0)
                    sum += x;
            }

                return sum;
        }
         int Amicable(int n)
        {
            if (DivisorSum(DivisorSum(n)) == n && (DivisorSum(n)) != n)
                return n;
            else
                return 0;
        }
         public int Answer()
         {
             int x;
             int sum = 0;
             for (x = 1; x < 10000; x++)
             {
                 sum += Amicable(x);
             }
             return sum;
         }
    }
}
