using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler58
    {
        float IsPrime(float n)
        {
            float i;
            float count = 0;
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
        public float Answer()
        {
            float count = 1;
            float primecount = 0;

            for (float x = 3; x <= 7000; x=x+2)
            {
                if (IsPrime(x * x - (x - 1)) == 1)
                    primecount++;
                if (IsPrime(x * x - (2 * (x - 1))) == 1)
                    primecount++;
                if (IsPrime(x * x - (3 * (x - 1))) == 1)
                    primecount++;
                count += 4;
                if (primecount / count < .1)
                    return x;
            }
            return primecount/count;
        }
    }
}
