using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int rNum = rand.Next(1, 6);
            int realNum;
            //int bNum = rand.Next(22, >= 100; ++ 1);

            Console.WriteLine("Enter a number between 1 and 5");
            string numGuess = Console.ReadLine();

            int.TryParse(numGuess, out realNum);

            //while (realNum < 0 || realNum > 6)
            //{
            //    Console.WriteLine("Your must guess between 1 and 6 \n Guess again");

            //    numGuess = Console.ReadLine();

            //    int.TryParse(numGuess, out realNum);
            
            //}
            while (realNum != rNum)
            {
                Console.WriteLine($"Your guess of {numGuess} was not correct");
                Console.ReadLine();

                numGuess = Console.ReadLine();

                int.TryParse(numGuess, out realNum);
            }
            Console.WriteLine($"Your guess of {numGuess} was correct...Hooray!!");
        }
    }
}
