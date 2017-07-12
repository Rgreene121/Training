using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;


namespace ifElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Your number {num1} is greater than your number of {num2}");

            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Your number of {num1} is less than your number of {num2}");
            }
            else
            {
                Console.WriteLine($"Your number of {num1} is equal to your number of {num2}");
            }
            Console.ReadLine();

            //WriteLine("Give me a first number");
            //double var1 = Convert.ToDouble(ReadLine());
            //WriteLine("Enter another number");
            //decimal var2 = Convert.ToDecimal(ReadLine());
            //WriteLine("Enter a 3rd number");





        }
    }
}
