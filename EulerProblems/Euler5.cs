using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler5
    {
       public int Calc()
        {


            int x;
            int small = 400000000;
            for (x = 400000000; x > 0; x--)
            {
                if ((x % 20 == 0) && (x % 19 == 0) && (x % 18 == 0) && (x % 17 == 0) && (x % 16 == 0) && (x % 15 == 0) && (x % 14 == 0) && (x % 13 == 0) && (x % 12 == 0) && (x % 11 == 0))
                {
                    small = x;
                }
            }
            return small;
        }
    }
}
