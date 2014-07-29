using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler2
    {
        int input;
       public void method(string number)
        {
             input = Convert.ToInt32(number);
        }
       public int sum = 0;
       
        public int Fib(int x)
        {
           
            if (x == 1)
                return 1;
            else if (x == 2)
                return 2;
            else
            {
                
                return (Fib(x - 1) + Fib(x - 2));
            }
        }


        public void EvenSum(int fibans)
        {
            int i = 0;
            if (fibans < 4000000)
            {
                i = fibans;
            }
            
            if (i % 2 == 0)
            {
                sum += i;
            }
          
        }
        public void Calculation(){

        
    while (input>=1){



        EvenSum(Fib(input));


        input--;
    }
    }
    }
}
    