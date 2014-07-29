using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler25
    {
        public float DigitCount(float n)
        {
            float count = 0;
            while (n >= 1)
            {
                count++;
                n /= 10;
            }
            return count;
        }
        public float Fib(float x)
        {

            if (x == 1)
                return 1;
            else if (x == 2)
                return 1;
            else
            {

                return (Fib(x - 1) + Fib(x - 2));
            }
        }
        public float Answer()
        {
            int x;
            for (x = 1000; x < 10000000; x++)
            {
                if (DigitCount(Fib(x)) == 1000)
                    return x;
            }
            return 0;
        }
    }
}

