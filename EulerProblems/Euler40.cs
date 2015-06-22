using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler40
    {
        int Reverse(int x)
        {
            int num;
            int newnum = 0;
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

        int DigitValue(int n)
        {
            int countTotal = 1;
            int tempi;
            int rev;
            for (int i = 1; i <= 1000000; i++)
            {
                tempi = i;
                rev = Reverse(i);
                int count = 1;
                while (tempi > 0)
                {
                    if (countTotal == n)
                    {
                        
                        for (int j = 1; j < count; j++)
                        {
                            rev /= 10;
                        }
                        return rev%10;
                    }
                       
                    tempi /= 10;
                    count++;
                    countTotal++;
                   
                }


            }
            return 0;
        }

        public int Answer()
        {
            int product;

            product = DigitValue(1) * DigitValue(10) * DigitValue(100) * DigitValue(1000) * DigitValue(10000) * DigitValue(100000) * DigitValue(1000000);
            
                return product;
        }
    }
}