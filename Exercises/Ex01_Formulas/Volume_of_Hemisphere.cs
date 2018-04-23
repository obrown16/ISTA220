using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {
            float vol;
            float pi = 3.14159F;
            Console.WriteLine("Enter a radius length: ");
            float r = float.Parse(Console.ReadLine());
            vol = ((4 / 3) * pi * (r * r * r)) / 2;
            Console.WriteLine($"The volume of the hemisphere is: {vol}");
        }
    }
}
