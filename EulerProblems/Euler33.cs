using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler33
    {
        public int Factor(int x, int y)
        {
            int i;

            for (i = x; i > 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                    return Factor(x / i, y / i);
            }
            return (y);
        }
        int Pseudodiv(int x,int y)
        {
            int a = x / 10;
            int b = x % 10;
            int c = y / 10;
            int d = y % 10;

            if (a == c && a != 0 && d != 0)
                return b / d;
            if (a == d && a != 0 && c !=0)
                return b / c;
            if (b == c && b != 0 && d != 0)
                return a / d;
            if (b == d && b != 0 && c != 0)
                return a / c;
            return -1;
        }
        int Num(int x, int y)
        {
            float a = (float)x;
            float b = (float)y;
            float c = (float)Pseudodiv(x, y);
            if ((a/b) == c)
                return x;
            return 1;
        }
        int Denom(int x, int y)
        {
            float a = (float)x;
            float b = (float)y;
            float c = (float)Pseudodiv(x, y);
            if ((a/b) == c)
                return y;
            return 1;
        }
        public int Answer()
        {
            int i;
            int j;
            int prodnum = 1;
            int denomnum = 1;
            for (i = 10; i < 100; i++)
            {
                for (j = 10; j < 100; j++)
                {
                    prodnum *= Num(i, j);
                    denomnum *= Denom(i, j);
                }
            }
            return Factor(prodnum, denomnum);
        }
    }
}
