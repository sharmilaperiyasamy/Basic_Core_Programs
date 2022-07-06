using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    internal class Flip_Coin
    {
        public void Flip()
        {
            Console.WriteLine("Number of times the coin to be flipped : ");
            int count = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int heads = 0, tails = 0;

            for (int i = 0; i < count; i++)
            {
                int flip = random.Next(0, 2);
                if (flip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            int HeadsPercent = heads * 100 / count;
            int TailsPercent = tails * 100 / count;
            Console.WriteLine("Heads Percentage is " + HeadsPercent + "%");
            Console.WriteLine("Tails Percentage is " + TailsPercent + "%");
        }
    }
}
