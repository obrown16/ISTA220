using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        // This is an application that takes 10 numbers between 1 and 100 and returns the sum.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 integers to calculate the sum.");
            int sum = 0;
            int count = 0;

            Calcsums();
            Console.WriteLine($"The sum is {sum}.");

            void Calcsums()
            {
                count++;
                //increments count by 1 from 0
                Console.WriteLine($"The integer count is {count}:");
                sum += int.Parse(Console.ReadLine());
                // sum variable adds the users input
                if (count < 10)
                    Calcsums();
                else
                    return;

            }
        }
    }
}
