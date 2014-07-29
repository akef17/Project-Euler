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
            /*string line = Console.ReadLine();*/
            Euler58 calc = new Euler58();
            /*calc.method(line);*/
            float answer = calc.Answer();
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}
