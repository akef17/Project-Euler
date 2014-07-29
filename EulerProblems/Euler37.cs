using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler37
    {
        int IsPrime(int n)
        {
            int i;
            int count = 0;
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

        

        int TruncPrime1(int n)
        {
            int retn = n;
            while (n >= 1)
            {
                if (IsPrime(n) == 1 && n < 10)
                    return retn;
                if (IsPrime(n) == 1)
                    n /= 10;
                else
                    n = 0;
            }
            return n;
        }
        int TruncPrime2(int n)
        {
            int retn = n;
            while (n >= 1)
            {
                if (IsPrime(n) == 1 && n < 10)
                    return retn;
                if (IsPrime(n) == 1)
                    n = n % Exponential(10, DigitCount(n)-1);
                else
                    n = 0;
            }
            return n;
        }
        public int DigitCount(int n)
        {
            int count = 0;
            while (n >= 1)
            {
                count++;
                n /= 10;
            }
            return count;
        }
        public int Answer()
        {
            int sum = 0;
          //  int count = 0;
            int x;
            for (x = 10; x < 100000; x++)
            {
                if (TruncPrime1(x) > 0 && (TruncPrime2(x) > 0))
                {
                    sum += x;
           //         count++;
                }
            }
            return sum;
        }
        public int Exponential(int x, int y)
        {
            int z;
            int power = 1;
            if (y == 0)
                return 1;
            for (z = 1; z <= y; z++)
            {
                power *= x;
            }
            return power;
        }
    }
}

