using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler34
    {
        public int Factorial(int n)
        {
            int x;
            int fact = 1;
            for (x = n; x > 0; x--)
            {
                fact *= x;
            }
            return fact;
        }
        public int DigitFac(int n)
        {
            int sum = 0;
            int num;
            while (n >= 1)
            {
                num = n % 10;
                sum += Factorial(num);
                n /= 10;

            }
            return sum;


        }
        public int Answer()
        {
            int count = 0;
            for (int x = 3; x < 5000000; x++)
            {
                if (DigitFac(x) == x)
                    count += x;
            }
            return count;
        }
    }
}