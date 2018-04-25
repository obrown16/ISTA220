using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a Tank crew within a tank platoon
            Driver Dan = new Driver();
            Gunner John = new Gunner();
            TankCdr Oscar = new TankCdr();
            Loader Matt = new Matt();

            Console.WriteLine("Hello and welcome");
            Console.WriteLine("I'll let the crew introduce themselves");
            Console.WriteLine();

            //Call the crew to talk
            Dan.Talk();
            John.Talk();
            Oscar.Talk();
            Matt.Talk();
        
        }
    }
}
