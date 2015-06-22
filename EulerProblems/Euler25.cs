using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler25
    {
        public int Answer()
        {
            int[] num1 = new int[1001];
            int[] num2 = new int[1001];
            for (int initialize = 0; initialize <= 1000; initialize++)
            {
                num1[initialize] = 0;
                num2[initialize] = 0;
            }
            num1[0] = 1;

            for (int j = 1; j <= 100000; j++)
            {
                if (j % 2 == 1)
                {
                    for (int k = 0; k <= 1000; k++)
                    {
                        num1[k] += num2[k];
                        if (num1[k] > 9)
                        {
                            num1[k] = num1[k] - 10;
                            (num1[k + 1])++;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k <= 1000; k++)
                    {
                        num2[k] += num1[k];
                        if (num2[k] > 9)
                        {
                            num2[k] = num2[k] - 10;
                            (num2[k + 1])++;
                        }
                    }
                }
                if ((num1[999] > 0) || (num2[999] > 0))
                    return j;
            }
            return 0;
        }
    }

}