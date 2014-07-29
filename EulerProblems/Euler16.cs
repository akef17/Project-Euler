using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler16
    {
        public float Exponential(float x, float y)
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
        float DigitSum(float n)
        {
            float num;
            float sum = 0;
            while (n > 1)
            {
                num = n % 10;
                sum += num;
                n /= 10;
            }
            return sum;
        }
        public float Answer(float n,float m)
        {
            return DigitSum(Exponential(n,m));
        }
    }
}
