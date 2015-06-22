using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler112
    {
        long Bouncy(long num)
        {
            long digit = num % 10;
            long olddigit;
            long count = 0;
            while (num >= 1)
            {
                olddigit = digit;
                digit = num % 10;
                if (((olddigit > digit) && (count > 0)) || (((olddigit < digit) && (count < 0))))
                    return 1;
                   
                if(olddigit > digit)
                    count--;
                if(digit > olddigit)
                    count++;               
               
                num /= 10;

                if (((olddigit > digit) && (count > 0)) || (((olddigit < digit) && (count < 0))))
                    return 1;
            }          
            return 0;
        }
        public long Answer()
        {
            
            long bouncySum = 0;
            for (long i = 1; i < 10000000; i++)
            {                              
                bouncySum += Bouncy(i);
                  
                if (i * 99 == bouncySum * 100)
                    return i;
            }
            return 0;
        }
    }
}
