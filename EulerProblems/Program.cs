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
            Euler65 calc = new Euler65();
            /*calc.method(line);*/
            long answer = calc.Answer(44);
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}
