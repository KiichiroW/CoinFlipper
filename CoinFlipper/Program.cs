using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coinFlip = new Random();
            int heads = 0;
            int tails = 0;

            Console.WriteLine("What two options are you debating?");

            Console.Write("Option 1: ");
            string option1 = Console.ReadLine().ToString();
            Console.Write("Option 2: ");
            string option2 = Console.ReadLine().ToString();


            for (int i = 0; i < 10; i++)
            {
                int result = coinFlip.Next(0, 2);
                
                if (result == 0)
                {
                    Console.WriteLine("H");
                    heads++;
                }

                if (result == 1)
                {
                    Console.WriteLine("T");
                    tails++;
                }
            }

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Heads: " + heads);
            Console.WriteLine("Tails: " + tails);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;

            if (heads > tails)
            {
                Console.WriteLine(option1);
            }

            else
            {
                Console.WriteLine(option2);
            }

            Console.ReadLine();
        }
    }
}
