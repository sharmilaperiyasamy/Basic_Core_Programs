using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Power_Of_2
    {
        public void Power()
        {
            Console.WriteLine("Enter the number to find the power of 2 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int power = 1;

            if ((n >= 0) && (n < 31))
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine("2 power of " + i + " : " + power);
                    power = power * 2;
                }
            }
            else
            {
                Console.WriteLine("Please enter the number between 0 and 30");
            }
        }
    }
}
