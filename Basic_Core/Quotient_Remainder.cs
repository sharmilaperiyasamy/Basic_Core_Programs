using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Quotient_Remainder
    {
        public void Maths()
        {
            Console.WriteLine("Enter the Dividend : ");
            int Dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            Console.WriteLine("Quotient is " + Quotient);

            int Remainder = Dividend % Divisor;
            Console.WriteLine("Remainder is " + Remainder);
        }
    }
}
