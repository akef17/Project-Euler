using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler12
    {
        int Divisors(int n)
        {
            int i;
            int count = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            return count;
        }
         int Trinumber(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n;
                n--;
            }
            return sum;
        }
         public int Answer()
         {
            int n;
            for (n = 1; n < 1000000; n++)
            {
                if ((Divisors(Trinumber(n)) > 500))
                    return Trinumber(n);
                    
            }
            return 0;
         }

    }
}
