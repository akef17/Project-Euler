using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler53
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

            public double Conbinatorics(double x, double y)
            {

                double comb = Factorial(x) / (Factorial(y) * Factorial(x - y));
                return comb;
            }

        public double Calc(){
            double count = 0;
            for (double x = 100; x > 0; x--)
            {
                for (double y = 0; y <= x; y++)
                {

                    if (Conbinatorics(x, y) > 1000000)
                        count++;
                }
            }
            return count;
        }
    

}
    
}
