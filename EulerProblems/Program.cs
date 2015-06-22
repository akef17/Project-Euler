using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {            
      //      string line = Console.ReadLine();
            Test calc = new Test();
            /*calc.method(line);*/
            string answer = calc.test();
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}
