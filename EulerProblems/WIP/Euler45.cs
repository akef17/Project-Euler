using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler45
    {
        long TriNum(long n)
        {
            for (long x = 1;x < 10000;x++){
                if ((((2 * n) / (x + 1)) == x) && (((2 * n) % (x + 1)) == 0))
                    return 1;
            }
            return 0;
            
        }
        long PentNum(long n)
        {
            for (long x = 1; x < 10000; x++)
            {
                if ((((2 * n) / (3*x - 1)) == x) && (((2 * n) % (3*x - 1)) == 0))
                    return 1;
            }
            return 0;
        }
        long HexNum(long n)
        {
            for (long x = 1; x < 10000; x++)
            {
                if (((n / (2*x - 1)) == x) && ((n % (2*x - 1)) == 0))
                    return 1;
            }
            return 0;
        }
        public long Answer()
        {
            long x;
            for (x = 40756; x < 20000000; x++)
            {
                if ((TriNum(x) == 1) && (PentNum(x) == 1) && (HexNum(x) == 1))
                    return x;
            }
            return 0;
        }
    }
}
