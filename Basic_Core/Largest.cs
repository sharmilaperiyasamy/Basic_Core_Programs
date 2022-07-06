using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Largest
    {
        public void Find()
        {
            Console.WriteLine("Enter the three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("Largest number is " + num1);
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("Largest number is " + num2);
            }
            else
            {
                Console.WriteLine("Largest number is " + num3);
            }
        }
    }
}
