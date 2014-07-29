using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler15
    {
        public double Factorial(double n)
        {
            double x;
            double fact = 1;
            for (x = n; x > 0; x--)
            {
                fact *= x;
            }
            return fact;
        }
       public double Conbinatorics(double x,double y)
        {
            
          double comb = Factorial(x) / (Factorial(y) * Factorial(x - y));
          return comb;
        }

    }
}
