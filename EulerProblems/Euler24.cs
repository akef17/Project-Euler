using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler24
    {
        long OnetoNineCheck(long num)
        {
            long tempNum;
            long digit;
            long count = 0;
            long tempCount = 0;
            if (num >= 123456789 && num <= 9876543210)
            {
                for (int i = 1; i <= 9; i++)
                {
                    tempNum = num;
                    while (tempNum >= 1)
                    {
                        digit = tempNum % 10;
                        if (i == digit)
                        {
                            tempCount++;
                            if (tempCount > 1)
                                return 0;
                        }
                        tempNum /= 10;
                    } 
                    if (tempCount == 1)
                        count++;

                    tempCount = 0;
                }
                if (count == 9)
                    return 1;
            }
            return 0;
        }
        public long Answer()
        {
            long count = 0;

            for (long i = 123456789; i < 10000000000; i++)
            {
                count += OnetoNineCheck(i);

                if (count == 1000000)
                    return i;
     
            }
            return 0;
        }
    }
}
