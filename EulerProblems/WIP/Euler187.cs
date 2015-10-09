using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler187
    {
        float IsPrime(float n)
        {
            float i;
            float count = 0;
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    count++;
                if (count == 2)
                    return 0;
            } 
            return count;
          
        }
        public long Answer(){

            long count = 0;

        for (long i=0; i < 100000; i++){
            
        if(IsPrime(i) == 1)
            count++;
        }
            return count;
        }
    }
}
