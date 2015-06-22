using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler76
    {
        public int Answer(int num)
        {
            int addcount = 0;
            for (int i = 2; i <= num / 2; i++)
            {
                addcount += num / i;
            }
                if (num == 2)
                    return 1;

            return (addcount + Answer(num - 1));
        }

    }
}
