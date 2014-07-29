using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler3
    {

        double IsPrime(double n)
        {
            double i;
            double count = 0;
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 1)
                return 1;
            else
                return 0;


        }
        public double Math()
        {
            double x;
            double y = 600851475143;
            double factor = 0;
            
            
            for(x=2;x<6000000000;x++){
                if((y % x) == 0){
                    factor = y / x;
                    if (IsPrime(factor) == 1)
                    {
                        return factor;
                    }
                }
            } return 0;

        }
    }
}
