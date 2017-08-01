using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car drive = new Car();

            Console.WriteLine($"Car mileage is {drive.GetMileage()}");

            Console.WriteLine($"Car color is {drive.GetColor()}");

            Console.WriteLine($"The secret formula is {drive.DisplayEngineFormula()}");

            Console.ReadLine();
        }
    }
}
