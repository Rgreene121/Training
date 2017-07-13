using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine().ToLower();


            switch (color)

            {
                case "red":
                    Console.WriteLine("red is an ok color");
                    break;

                case "blue":
                    Console.WriteLine("blue is a nice color");
                    break;

                case "pink":
                    Console.WriteLine("pink is pretty a color");
                    break;

                default:
                    Console.WriteLine("You are an idiot");
                    break;
                        
            }

            Console.Write("We broke out of the loop");
            Console.Write("\n today is rainy out");

            Console.ReadLine();

            Console.WriteLine("what is your favorite pasta dish \n 1. lasagne \n 2. spagetti \n 3. ravioli");
            
            // double foodChoice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type 1 for lasagne\nType 2 for Spagetti\nType 3 for Ravioli\n");
            //int foodChoice = Convert.ToInt32(ReadLine().ToUpper());
            string foodChoice = ReadLine().ToUpper();
            int foodLike;
            int.TryParse(foodChoice, out foodLike);

            switch (foodLike)
            {
                case 1:
                    Console.WriteLine("Lasagne is great");
                    break;

                case 2:

                    Console.WriteLine("Spagetti is good");
                    break;

                case 3:

                    Console.WriteLine("Ravioli is for kids");
                    break;

                default:

                    Console.WriteLine("Thats not a pasta choice we recognize");
                    break;

            }ReadLine();

        }
    }
}

