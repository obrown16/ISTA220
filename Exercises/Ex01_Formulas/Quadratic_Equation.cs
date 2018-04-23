using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    // This is a program to solve the quadratic Equation.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficient 'a': ");                                // Asks user for coefficient 'a'
            double coeA = double.Parse(Console.ReadLine());                                  // User inputs value for 'a'
            Console.WriteLine("Enter the coefficient 'b': ");                                // Asks user for coefficient 'b'
            double coeB = double.Parse(Console.ReadLine());                                  // User inputs value for 'b'
            Console.WriteLine("Enter the coefficient 'c': ");                                // Asks user for coefficient 'c'
            double coeC = double.Parse(Console.ReadLine());                                  // User inputs value for 'c'

            double x1 = (-coeB + Math.Sqrt(coeB * coeB - 4 * coeA * coeC)) / (2 * coeA);          // Calculates the first value of x
            double x2 = (-coeB - Math.Sqrt(coeB * coeB - 4 * coeA * coeC)) / (2 * coeA);          // Calculates the second value of x

            Console.WriteLine($" x = ({x1},{x2})");                                         // Prints the values of x in the form of x=(x1,x2)

        }
    }
}
