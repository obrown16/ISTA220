using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a value for the radius to begin: ");
                double radius = double.Parse(Console.ReadLine());

                if (radius < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius can not be a negative number!");
                }

                double pie = 3.14159;
                double circ = checked(2 * pie * radius);
                double area = checked(radius * radius * pie);
                double volume = checked(1.33333 * pie * (radius * radius * radius) / 2);      
                                                                                              
                Console.WriteLine("The circumference of your circle is {0}", circ);  
                Console.WriteLine("The area of your circle is {0}", area);                     
                Console.WriteLine("The volume of your hemisphere is {0}", volume);
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
                Console.WriteLine("This is all this program can do, Thanks");
            }
        }
    }
}
