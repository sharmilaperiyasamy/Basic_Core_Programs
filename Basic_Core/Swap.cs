using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Swap
    {
        public void Swapping()
        {
            Console.WriteLine("Enter the First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping:");
            Console.WriteLine("The value of A is " + a);
            Console.WriteLine("The value of B is " + b);

            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("The value of A is " + a);
            Console.WriteLine("The value of B is " + b);
        }
    }
}
