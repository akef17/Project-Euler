using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProblems
{
    class Euler40_S_
    {
        public int Answer()
        {
            string positiveIntConcat =  "";
            int i = 1;

            while (positiveIntConcat.Length <= 1000000)
            {
                string currentvalue;
               
                currentvalue = i.ToString();
                positiveIntConcat += currentvalue;
                i++;
            }
            int outputnum = 1;
            string currentChar = "";
            currentChar = (positiveIntConcat[0]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[9]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[99]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[999]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[9999]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[99999]).ToString();
            outputnum *= Convert.ToInt32(currentChar);

            currentChar = (positiveIntConcat[999999]).ToString();
            outputnum *= Convert.ToInt32(currentChar);
 
            return outputnum;
        }

    }
}
