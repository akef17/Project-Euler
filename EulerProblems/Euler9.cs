using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler9
    {
        public int EquCalc()
        {
            int a;
            int b;
            int c;
            for (c = 500; c > 300; c--)
            {
                for (b = c - 1; b > 0; b--)
                {
                    for (a = b - 1; a > 0; a--)
                    {
                        if(((a*a)+(b*b)==(c*c))){
                            if(a+b+c==1000)
                                return a*b*c;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
