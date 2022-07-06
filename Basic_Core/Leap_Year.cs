using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Leap_Year
    {
        public void Leap()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int yearLength = year.ToString().Length;

            if (yearLength == 4)
            {
                if ((year % 4 == 0) && (year % 100 != 0))
                {
                    Console.WriteLine(year + " is a Leap year");
                }
                else if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is a Leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap year");
                }
            }
            else
            {
                Console.WriteLine("Please enter the 4 digit number");
            }
        }
    }
}
