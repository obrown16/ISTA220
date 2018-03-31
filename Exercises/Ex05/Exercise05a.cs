using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05a
{
    class Program
    {
		// Write a program that counts the number of elements in an integer array, and then sums 
		// the elements in an integer array. Using the count and sum, compute the mean of each
		// element of the array.
		
        static void Main(string[] args)
        {
            int[] ArrayA = {0, 2, 4, 6, 8, 10};
            int[] ArrayB = { 2, 3, 5, 7, 9};
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int count = 0;
            int sum = 0;
            double mean = 0.0;
            foreach (int e in ArrayA)
            {
                count++; //increments count by one
                sum = e + sum; //each time the loop runs it will add the value of the array to each sum
            }

            mean = sum / count;
            Console.WriteLine( $"The count is {count}");
            Console.WriteLine($"The count is {sum}");
            Console.WriteLine($"The count is {mean}");

        }
    }
}
