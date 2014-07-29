using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler6
    {
       public int SquareofSums()
       {
        int x;
        int sum1 = 0;
        for (x=1;x<=100;x++)
        {
            sum1 += x;
        }
        return sum1 * sum1;
        }
    public int SumofSquares()
       {
           int y;
           int sum2 = 0;
           for (y = 0; y <= 100; y++)
           {
               sum2 += y * y;
           }
           return sum2;
       }

    
    }
}
