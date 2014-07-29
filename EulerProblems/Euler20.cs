using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler20
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
             public double Counter(double x){
                 double sum = 0;
                 double val;
        double y = Factorial(x);
                 while(y>1){                    
                     val = Math.Floor(y % 10);
                     sum += val;
                     y = y / 10;

                 }
                 return sum;
                     
             }
    }
}
