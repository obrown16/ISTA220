using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter scores to determine letter Grade");
            int count = 0;
            double sum = 0;
            CalculateAverage();

            void CalculateAverage()
            {

                CalcSum();
                double Average = sum / 10;
                if (Average <= 59)
                {
                    Console.WriteLine("Your letter grade is: F.");
                }
                else if (Average >= 60 && Average <= 69)
                {
                    Console.WriteLine("Your letter grade is: D.");
                }
                else if (Average >= 70 && Average <= 79)
                {
                    Console.WriteLine("Your letter grade is: C.");
                }

                else if (Average >= 80 && Average <= 89)
                {
                    Console.WriteLine("Your latter grade is: B.");
                }

                else if (Average >= 90)
                {
                    Console.WriteLine("Your letter grade is: A.");
                }
                else
                {
                    return;
                }

                void CalcSum()
                {

                    count++;
                    Console.WriteLine($"Enter your grades. Grade number {count}.");
                    sum += double.Parse(Console.ReadLine());
                    if (count < 10)
                    {
                        CalcSum();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
