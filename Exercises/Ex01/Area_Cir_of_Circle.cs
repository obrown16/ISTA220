using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        { // Program to find the area and circumference of a circle
            float radius;                                                  //declare variable radius as a double
            float PI = 3.14159f;                                            // variable PI as a double is assigned an operator 
            float area, Cir;                                               // variable area and cir are declared as double
            Console.WriteLine("Enter the Radius of a Circle: ");            // asking user to enter radius
            radius = float.Parse(Console.ReadLine());                      
            area = PI * radius * radius;
            Cir = 2 * PI * radius;
            Console.WriteLine("The Area of a Circle is " + area);
            Console.WriteLine("The Circumference of a Circle is " + Cir);
        }
    }
}
