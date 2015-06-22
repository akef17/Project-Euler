using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler16
    {        
        
       public int Answer()
        {
            int sum = 0;
            int[] digits = new int[350];
            for (int initialize = 0; initialize<=330;initialize++)
            {
                digits[initialize] = 0;
            }
            digits[0] = 1;

            for (int j = 1; j <= 1000; j++)
            {
                for(int k=330; k>=0;k--)
                {
                    digits[k] = 2 * digits[k];
                    if (digits[k] > 9)
                    {
                        digits[k] = digits[k] - 10;
                        (digits[k + 1])++;
                    }
                }

            }
            for (int l = 0; l <= 330;l++)
            {
                sum += digits[l];
            }
            return sum;
        }
    }
}