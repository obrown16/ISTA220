using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3c_Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_Radius;
            double Radius; 
            double Circ; //Circumference
            double Area;
            Calculate();

            void Calculate()
            {
                try
                {
                    Console.WriteLine("Hello and Welcome to the quadratic program");
                    Console.Write("Please enter the RADIUS: ");
                    str_Radius = Console.ReadLine();
                    Radius = double.Parse(str_Radius);
                    if (Radius > 100 || Radius < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    Circ = checked(6.28318 * Radius);
                    Area = checked(3.14159 * Radius * Radius);
                    Console.WriteLine($"The circumference of this circle is:{Circ}");
                    Console.WriteLine($"The area of this circle is:{Area}");
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    Calculate();
                }
                catch (ArgumentNullException aEx)
                {
                    Console.WriteLine(aEx.Message);
                    Calculate();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Radius must be between 0 and 100");
                    Calculate();
                }
                finally
                {
                    Console.WriteLine("Thanks, all done");
                }
            }
        }
    }
}
