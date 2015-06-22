using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler27
    {
        long IsPrime(long n)
        {
            long i;
            long count = 0;
            for (i = 1; i*i <= n; i++)
            {
                if (n % i == 0)
                    count++;
                if (count == 2)
                    return 0;
            }
            if (count == 1)
                return 1;
            else
                return 0;
        }
        public long Answer()
        {
            
            long count = 0;
            long maxCount = 0;
            long n = 0;
            long abProd = 0;
            long quadSum = 0;
            long a;

            for (long b = 0; b < 1000; b++)
            {
                for (a = -1000; a < 1000; a++)
                {
                    do
                    {                        
                        quadSum = n * n + n * a + b;

                        if (count > maxCount)
                        {
                            maxCount = count;
                            abProd = a * b;
                        }
                        n++;
                        count++;
                    }
                    while (IsPrime(quadSum) == 1);

                    n = 0;
                    count = 0;     
                    }
                                   
                }
            return abProd;
            }
        }
}
