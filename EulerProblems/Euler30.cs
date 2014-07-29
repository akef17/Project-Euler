using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler30
    {
        int DigitPowers(int n)
        {
            int sum = 0;
            int num;
            while (n >= 1)
            {
                num = n % 10;
                sum += (num * num * num * num * num);
                n /= 10;
            }
            return sum;
        }
        public int Answer()
        {
            int x;
            int sum = 0;
            for (x=0;x<10000000;x++)
            {
                if (x == DigitPowers(x))
                    sum += x;
            }
            return sum-1;
        }
    }
}
