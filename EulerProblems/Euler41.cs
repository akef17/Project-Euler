using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler41
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
                return n;
            else
                return 0;
        }

         int DigitCount(int n)
        {
            int count = 0;
            while (n >= 1)
            {
                count++;
                n /= 10;
            }
            return count;
        }
         int PanDigital(int n)
         {
             int x;
             int num;
             int digcount = 0;
             
             for (x = 1; x <= DigitCount(n);x++)
             {
                 int count = 0;
                 int tempn = n;
                 while (tempn >= 1)
                 {
                     
                    
                     num = tempn % 10;
                     if (num == x)
                     {
                         count++;
                     }

                     tempn /= 10;
                     
                 }
                 if (count == 1)
                     digcount++;
             }
             if (DigitCount(n) == digcount)
                 return n;
             else
                 return 0;
         }
         public int Answer()
         {
             int x;
             int max = 0;
             for (x = 10; x < 1000000000; x++)
             {
                 if (IsPrime(PanDigital(x)) > max)
                     max = IsPrime(PanDigital(x));
             }
             return max;
         }
    }
}

