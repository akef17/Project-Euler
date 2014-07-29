using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler7
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
    
    public double Loop(){
    double y;
    double i = 0;
    for (y=0;i<10001;y++){
        if (IsPrime(y) == 1)
        {
            i++;
        }
    }
            return (y-1);
        
    }
    
}
}
