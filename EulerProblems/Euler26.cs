using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler26
    {
       public int RemainderCount(int x)
        {
            int r1 = Exponential(10,DigitCount(x)) % x;
            int vrem = r1;
            int count = 1;
            for (int i = 0; i < 1000; i++)
            {
                vrem = (vrem * 10) % x;
                if (count >= x || vrem == 0)
                    return 0;
                if (vrem == r1)                                 
                    return count;                
                    count++;
                
            }
            return count;
        }
       public int Exponential(int x, int y)
       {
           int z;
           int power = 1;
           if (y == 0)
               return 1;
           for (z = 1; z <= y; z++)
           {
               power *= x;
           }
           return power;
       }
       int DigitCount(int n)
       {
           int count = 0;
           while (n >= 1)
           {
               count++;
               n /= 10;
           }
           return count;
       }
       public int Answer(){
       
          int max = 0;
          int maxi = 0;
          for (int i = 1; i < 1000; i++)
          {
              if (RemainderCount(i) > max)
              {
                  max = RemainderCount(i);
                  maxi = i;
              }
          }
          return maxi;

           }
                    
       
    }
}
