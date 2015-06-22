using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler20
    {
        public int Answer()
        {
            int multiplier;
            int[] digits = new int[200];
            for (int initialize = 0; initialize <= 175; initialize++)
            {
                digits[initialize] = 0;
            }
            digits[0] = 1;
            for (multiplier = 1; multiplier <= 100; multiplier++)
            {
                for (int i = 0; i <= 175; i++)
                {
                    digits[i] = digits[i] * multiplier;
                }
                for (int j = 0; j <= 175; j++)
                {
                    if (digits[j] >= 10)
                    {
                        digits[j + 1] += digits[j] / 10;
                        digits[j] = digits[j] % 10;
                    }
                }
            }
            int sum = 0;
            int k;

            for (k = 0; k <= 175; k++)
                sum += digits[k];
           
           
            return sum;
        }
               
    }
}
