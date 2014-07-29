using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler28
    {
       public int SpiralSumation()
        {
            int x;
            int sum = 0;
            for (x = 2; x <= 1001; x++){
            if (x % 2 == 1)
            sum += (4 * x * x - 6 * (x - 1));
        }
            return sum + 1;
        }
    }
}
