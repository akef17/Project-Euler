using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler4
    {
        int Reverse(int x)
        {
            int num;
                int newnum = 0;
            if (x >= 0 && x <= 9)
                return x;
            while(x>=1){
            num = x % 10;
            newnum = newnum*10 + num; 
            x /= 10;
            }
            return newnum;
        }
        public int Answer()
        {
            int x;
            int y;
            int pal = 0;
            int maxpal = 0;
            for (x = 100000; x < 1000000; x++)
            {
                if (Reverse(x) == x)                   
                {
                    for (y = 999; y > 100; y--)
                    {
                        if (x % y == 0 && (x / y) < 1000 )
                            pal = x;
                    }
                }
                if (pal > maxpal)
                    maxpal = pal;
                    
            }
            return maxpal;
        }

    }
}
