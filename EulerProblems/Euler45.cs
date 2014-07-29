using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler45
    {
        float TriNum(float n)
        {
            for (float x = 1000;x < 10000;x++){
                if (((2 * n) / (x + 1)) == x)
                    return 1;
            }
            return 0;
            
        }
        float PentNum(float n)
        {
            for (float x = 1000; x < 10000; x++)
            {
                if (((2 * n) / (3*x - 1)) == x)
                    return 1;
            }
            return 0;
        }
        int HexNum(float n)
        {
            for (float x = 1000; x < 10000; x++)
            {
                if ((n / (2*x - 1)) == x)
                    return 1;
            }
            return 0;
        }
        public float Calc()
        {
            float x;
            for (x = 10000000; x < 20000000; x++)
            {
                if ((TriNum(x) == 1) && (PentNum(x) == 1) && (HexNum(x) == 1))
                    return x;
            }
            return 0;
        }
    }
}
