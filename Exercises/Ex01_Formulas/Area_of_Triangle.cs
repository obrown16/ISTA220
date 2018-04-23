using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{

    // This program is to determine the area of a triangle given the length of three sides. 
    // Use Heron's Formula. Sides are designated a, b, and c. p is half the circumference, a+b+c/2
    // assuming all side length has an integer greater than zero.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for side A: ");                       // The first side of the triangle is of length 'A'
            int A = int.Parse(Console.ReadLine());                                 // Reads the user input for side 'A'
            Console.WriteLine("Enter a value for side B: ");                       // The second side of the triangle is of lenth 'B'
            int B = int.Parse(Console.ReadLine());                                 // Reads the user input for side 'B'
            Console.WriteLine("Enter a value for side C: ");                       // The third side of the triangle is of lenth 'C'
            int C = int.Parse(Console.ReadLine());                                 // Reads the user input for the side 'C'

            double p = (A + B + C) / 2;                                            // p is the sum of all sides divided by two. P is a variable that
                                                                                   // is then used to find area herons formula.
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - B));              // Herons formula
            Console.WriteLine($"The area of the triangle is: {area}");             // Displays the results from formula
        }
    }
}
