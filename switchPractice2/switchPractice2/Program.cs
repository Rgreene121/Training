using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace switchPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car");
            string car = ReadLine().ToLower();

            switch (car)

            {
                case "chevy":
                    Console.WriteLine("chevy is a good car");
                    break;

                case "pontiac":
                    Console.WriteLine("They dont make those cars anymore");
                    break;

                case "ford":
                    Console.WriteLine("ford breaks down alot");
                    break;

                case "gmc":
                    Console.WriteLine("GMC has alot of recalls");
                    break;

                default:
                    Console.WriteLine("I think you should do more research before buying a car");
                    break;

            }

            ReadLine();

        }
        
         


    }
}
