using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int guessNum;
            //int score;
            int actualNum;
            int numOfGuess = 1;


            int randNum = r.Next(1, 11);
            Console.WriteLine("Guess a number between 1 and 10");

            do
            {
                string numGuess = Console.ReadLine();
                while (!int.TryParse(numGuess, out actualNum) || actualNum < 1 || actualNum > 10)

                {
                    Console.WriteLine($"Your entry of {numGuess} is not the correct random number needed \n Please try again");

                    numGuess = Console.ReadLine();
                    //int.TryParse(numGuess, out actualNum);
                    //Console.ReadLine();
                    numOfGuess++;
                }

                if (randNum == actualNum)
                {
                    Console.WriteLine($"Your guess of {randNum} was correct \n You guessed{numOfGuess} times...You are a winner!!!");
                    Console.ReadLine();
                }
                else if (actualNum >= 10)

                {
                    Console.WriteLine($"You are entered a number greater than 10 \n Please try again");
                }
                else

                {
                    Console.WriteLine($"Your guess of {actualNum} was not correct...\n Guess again");
                    numOfGuess++;
                }

            } while (actualNum != randNum);
            //Console.ReadLine();
        }                 
    }
}
