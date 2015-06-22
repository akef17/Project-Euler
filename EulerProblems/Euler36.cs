using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler36
    {
        ulong Reverse(ulong x)
        {
            ulong num;
            ulong newnum = 0;
            if (x >= 0 && x <= 9)
                return x;
            while (x >= 1)
            {
                num = x % 10;
                newnum = newnum * 10 + num;
                x /= 10;
            }
            return newnum;
        }
        ulong Exponential(ulong x, ulong y)
        {
            ulong z;
            ulong power = 1;
            if (y == 0)
                return 1;
            for (z = 1; z <= y; z++)
            {
                power *= x;
            }
            return power;
        }

        public ulong Binary(ulong decnum)
        {
            ulong binnum = 0;
            ulong i = 21;
            do 
            {
                i--;
                if (decnum >= Exponential(2, i))
                {
                    binnum += Exponential(10, i);
                    decnum -= Exponential(2, i);                  
                }
            }
            while(i>0);

            return binnum;
        }
        public ulong Answer()
        {
            ulong i;
            ulong sum = 0;
            for (i = 1; i < 1000000; i++)
            {                
                if (Reverse(i) == i && Reverse(Binary(i)) == Binary(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
