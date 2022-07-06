using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Even_Odd
    {
        public void Manipulate()
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Given number is an even number");
            }
            else
            {
                Console.WriteLine("Given number is an odd number");
            }
        }
    }
}
