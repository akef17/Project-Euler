using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler63
    {
        float Exponential(float x,float y)
        {
            float z;
            float power = 1;
            if (y == 0)
                return 1;
            for (z = 1; z <= y; z++)
            {
                power *= x;
            }
            return power;
        }
        float DigitCount(float x)
        {
            float count = 0;
            while (x >= 1)
            {
                x = x / 10;
                count++;
            }
            return count;
        }
       public float Answer()
        {
            float x;
            float y;
            float count = 0;
            for (y = 0; y < 25; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    if (DigitCount(Exponential(x, y)) == y)
                        count++;
                }
            }
            return count;
        }
    }
}
