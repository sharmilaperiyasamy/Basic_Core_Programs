using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Alphabet
    {
        public void Letter()
        {
            Console.WriteLine("Enter the Alphabet to check whether it is a Vowel or Consonant : ");
            char a = Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
            {
                Console.WriteLine(a + " is a Vowel");
            }
            else
            {
                Console.WriteLine(a + " is a Consonant");
            }
        }
    }
}
