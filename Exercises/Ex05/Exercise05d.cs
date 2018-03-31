using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05d
{
    //Write a method that takes an unsorted integer array and prints a sorted
   // array.Use Array C as your test array.Do you recognize this list of numbers?

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 1, 2, 6, 5, 3, 5, 9 };

            for (int i = 0; i < C.Length-1; i++)
            {
                int next = i + 1;
                Console.WriteLine($"{i}: {C[i]}   {next}: {C[next]}");
                if (C[i] > C[next])
                {
                    int temp = C[i];
                    C[next] = C[i];
                    C[i] = temp;


                }
            }


            foreach (int item in C)
            {
                Console.WriteLine(item);
            }
        }
    }
}
