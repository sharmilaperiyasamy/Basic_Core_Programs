using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Harmonic
    {
        public void Harmonic_number()
        {
            Console.WriteLine("Enter the number to find the Harmonic Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            float Harmonic = 1;

            if (Number != 0)
            {
                for (int i = 2; i <= Number; i++)
                {
                    Harmonic = Harmonic + (1 / i);
                }
                Console.WriteLine("Harmonic number of " + Number + " is " + Harmonic);
            }
        }
    }
}
