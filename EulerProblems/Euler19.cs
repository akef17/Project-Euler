using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Euler19
    {
        bool IsLeap(int year)
        {
            bool leap = false;
            if (year % 4 == 0 && year % 100 != 0)
                leap = true;
            if (year % 400 == 0)
                leap = true;
            return leap;
        }

        int GetDaysInMonth(int month, int year)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;

            if (month == 2)
            {
                if (IsLeap(year))
                    return 29;
                return 28;
            }
            return 31;
        }

        public int Answer()
        {
            int month = 1;
            int dayOfWeek = 7;
            int dayOfMonth = 1;
            int year = 1900;
            int count = 0;

            while (year < 2001)
            {
                if (dayOfMonth == 1 && dayOfWeek == 1 && year >= 1901)
                {
                    count++;
                }

                dayOfWeek++;
                dayOfMonth++;

                if (dayOfWeek > 7)
                    dayOfWeek = 1;

                if (dayOfMonth > GetDaysInMonth(month, year))
                {
                    dayOfMonth = 1;
                    month++;
                }

                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            return count;
        }
    }
}