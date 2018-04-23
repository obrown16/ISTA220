using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //The next 4 lines create a new instance of each class and invokes the default constructor(BigCow, etc..)
            Cow BigCow = new Cow();
            Pig Piggy = new Pig();
            Chicken Robot = new Chicken();
            Horse MrEd = new Horse();

           
            while (true)
            //Pick the farm animal you want to learn about operation
            {
                Console.WriteLine(" To learn about the farm animals: Press (A) for cow, " +
                    "(B) for Pig, (C) for Chicken, (D) for horse:");
                Console.WriteLine();

                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();
                //gather the input. Console.ReadKey (user types a single key)
                // the returned information comes as an instance of a class called ConsoleKeyInfo. 
                //That class has a property called Key which has method called ToString
                switch (operation.ToUpper()) // ToUpper allows user to input lower case or upper case letters.
                {
                    case "A":
                        Console.WriteLine();
                        BigCow.Eats();
                        BigCow.Moves();
                        BigCow.Speak();
                        BigCow.Lives();
                        break;
                    case "B":
                        Console.WriteLine();
                        Piggy.Eats();
                        Piggy.Moves();
                        Piggy.Speak();
                        Piggy.Lives();
                        break;
                    case "C":
                        Console.WriteLine();
                        Robot.Eats();
                        Robot.Moves();
                        Robot.Speak();
                        Robot.Lives();
                        break;
                    case "D":
                        Console.WriteLine();
                        MrEd.Eats();
                        MrEd.Moves();
                        MrEd.Speak();
                        MrEd.Lives();
                        break;
                    case "E":
                        return;              
                    default:
                        Console.WriteLine("Choose from supported operations");
                        continue;
                }
            }

        }
    }
}
