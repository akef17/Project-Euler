using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler35
    {
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
        public int Rotate(int x)
        {
            int num;
            int newnum = 0;
            if (x >= 0 && x <= 9)
                return x;            
                num = x % 10;
                newnum = (x / 10) + (num * Exponential(10, DigitCount(x/10)));           
            return newnum;
        }
       public int Answer()
        
            {
                int x;
                int count = 0;
                for (x = 0; x < 1000000; x++)
                {
                    if ((IsPrime(x) == 1) && ((IsPrime(Rotate(x))) == 1) && ((IsPrime(Rotate(Rotate(x)))) == 1) && ((IsPrime(Rotate(Rotate(Rotate(x))))) == 1) && (IsPrime(Rotate(Rotate(Rotate(Rotate(x))))) == 1) && (IsPrime(Rotate(Rotate(Rotate(Rotate(Rotate(x))))))) == 1)
                        count++;
                }
            return count;
            }
         
        
    }
}

