using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05b
{

    //Write a method that accepts an array as an argument and prints the
    //reversed array.For example, if you pass the method Array B, it should print[9, 7, 5, 3, 1].

    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9};
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 3, 5, 9};

            void RevArray(int[] p)//p for parameters
            {
                int[] ArrayD = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int j = (p.Length - i);
                    ArrayD[i] = p[--j];
                }

                foreach (int e in ArrayD)
                {
                    Console.WriteLine(e);
                }

            }
            RevArray(ArrayB);
        }
    }
}
