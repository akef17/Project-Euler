using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler56
    {
        int PowerCount(int bases, int exponent)
        {
            int sum = 0;
            int[] digits = new int[300];
            for (int initialize = 0; initialize<300;initialize++)
            {
                digits[initialize] = 0;
            }
            digits[0] = 1;

            for (int j = 1; j <= exponent; j++)
            {
                for(int k=299; k>=0;k--)
                {
                    digits[k] = bases * digits[k];
                }
                for(int n = 0;n<= 298;n++)
                {
                    (digits[n + 1]) += digits[n] / 10;
                    digits[n] = digits[n] % 10;
                }

            }
            for (int l = 0; l <= 250;l++)
            {
                sum += digits[l];
            }
            return sum;
        }
        public int Answer()
        {
            int bases;
            int exponent;
            int max = 0;
            for (bases = 1; bases < 100; bases++)
            {
                for (exponent = 1; exponent < 100; exponent++)
                {
                    if (PowerCount(bases, exponent) > max)
                        max = PowerCount(bases, exponent);
                }
            }
            return max;
        }
        
    }
    
}
 