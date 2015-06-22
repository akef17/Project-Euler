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
        float Pseudodiv(int x,int y)
        {
            int a = x / 10;
            int b = x % 10;
            int c = y / 10;
            int d = y % 10;

            float af = (float)a;
            float bf = (float)b;
            float cf = (float)c;
            float df = (float)d;
            // add logic to count for multiple matches
            //if (a == c)
            //    return (bf / df);
            if (a == d)
                return (bf / cf);
            if (b == c)
                return (af / df);
            //if (b == d)
            //    return (af / cf);
            return (float)(-1);
        }
        int Numerator(int x, int y)
        {
            float a = (float)x;
            float b = (float)y;
            float c = Pseudodiv(x, y);
            if ((a/b) == c)
                return x;
            return 1;
        }
        int Denominator(int x, int y)
        {
            float a = (float)x;
            float b = (float)y;
            float c = Pseudodiv(x, y);
            if ((a/b) == c)
                return y;
            return 1;
        }
        public int Answer()
        {
            int prodnum = 1;
            int proddemom = 1;
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < i; j++)
                {
                    if (j % 10 == 0 && i % 10 == 0)
                        continue;
                    prodnum *= Numerator(j, i);
                    proddemom *= Denominator(j, i);
                    if (Numerator(j, i) != 1)
                    {
                        Console.WriteLine(Numerator(j, i));
                        Console.WriteLine(Denominator(j, i));
                    }
                }
            }
            return Factor(prodnum, proddemom);
        }
    }
}
