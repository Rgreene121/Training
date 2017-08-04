using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            int newBalance = 5;
            int.TryParse(newBalance, out x);
            Console.WriteLine($"In the main method x = {x}");

            DisplayValueParameters(x);
            Console.WriteLine($"In the main method the value of x is now {x}");

            DisplayNewValue(ref x);
            Console.WriteLine($"The value of exiting x is now {x}");

            DisplaySecondValue(ref x);
            Console.WriteLine($"The value of z is now {x}");

            Console.ReadLine();
        }
    }
}
