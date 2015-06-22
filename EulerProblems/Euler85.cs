using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler85
    {
        int Abs(int a)
        {
            if (a < 0)
                return (-1) * a;
            else
                return a;
        }

        int RectCount(int width, int height)
        {
            return ((width * width + width) * (height * height + height)) / 4; 
        }

        public int Answer()
        {
            int area = 0;
            int diff = 10000000;

            for (int i = 1; i < 5000; i++)
                for (int j = 1; RectCount(i, j) < 2001000; j++)
                {
                    if (Abs(RectCount(i, j) - 2000000) < diff)
                    {
                        diff = Abs(RectCount(i, j) - 2000000);
                        area = i*j;
                    }
                }
            return area;
        }
    }
}
