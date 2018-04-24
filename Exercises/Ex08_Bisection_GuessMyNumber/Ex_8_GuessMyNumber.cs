using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int ReturnValue = random.Next(1, 1000);
            int Guess = 0;

            Console.WriteLine("I just guessed a number between 1-1000.  Guess what number it is?");

            while (Guess != ReturnValue)
            {
                Guess = int.Parse(Console.ReadLine());

                while (Guess < ReturnValue)
                {
                    Console.WriteLine($"No, the number I'm thinking of is higher than {Guess}" + " .  keep guessing please!");
                    Console.ReadLine();

                }
                while (Guess > ReturnValue)
                {
                    Console.WriteLine($"No, the number I'm thinking of is lower than {Guess}" +
                        " .  keep guessing please!");
                    Console.ReadLine();
                }
            }
            while (Guess == ReturnValue)
            {
                Console.WriteLine($"Great Job! The answer was {ReturnValue}");
                Console.ReadLine();
            }
        }
    }
}
