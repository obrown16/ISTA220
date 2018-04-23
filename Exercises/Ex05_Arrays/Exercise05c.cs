using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05c
{
    //Write a function that accepts three parameters, a direction (right or left), a number of places, and an
    //array, which prints the appropriate rotation.

    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 3, 5, 9 };

            RotateArray(1,2, ArrayB);
            //rotate left if dir == 0 or right == 1
            // number of places to rotate

            void RotateArray(int Dir, int Place, int[] p)
            {
                int[] Result = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int pos = (i + 2) % p.Length;
                    Result[i] = p[pos];
                }

                foreach (int e in Result)
                {
                    Console.WriteLine(e);
                }
            }

   
        }
    }
}
