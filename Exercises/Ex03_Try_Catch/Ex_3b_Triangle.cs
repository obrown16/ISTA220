using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3b_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello and welcome to the triangle calculations program");
                Console.Write("Please enter the length of the first side of the triangle: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Please enter the length of a second side of the triangle: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Finally, please enter the third side of the triangle: ");
                int c = int.Parse(Console.ReadLine());

                if (a < 0 || b < 0 || c < 0)
                {
                    throw new ArgumentOutOfRangeException("Side lengths can not be a negative number");
                }

                double p = checked(((double)a + (double)b + (double)c) / 2);
                double area = checked(Math.Sqrt(p * (p - (double)a) * (p - (double)b) * (p - (double)c)));

                Console.WriteLine("The area of your triangle is {0}", area);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            catch (ArgumentOutOfRangeException aorEx)
            {
                Console.WriteLine(aorEx.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for using this simple and cool program");
            }
        }
    }
}
