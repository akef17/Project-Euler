using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler50
    {
        double IsPrime(double n)
        {
            double i;
            double count = 0;
            for (i = 1; i < n; i++)
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

        public double PrimeSum()
        {
            double y;
            double sum = 0;
            double primesum = 0;
            double maxprimesum = 0;
            for (double x = 0; x < 100; x++)
            {
                for (y = x; sum < 1000000; y++)
                {


                    if (IsPrime(y) == 1)
                    {
                        sum += y;
                        if (IsPrime(sum) == 1 && sum < 1000000)
                            primesum = sum;
                    }

                }
                sum = 0;
                if (maxprimesum < primesum)
                    maxprimesum = primesum;
            }
            
                return (maxprimesum);
            
        }
    }
}
