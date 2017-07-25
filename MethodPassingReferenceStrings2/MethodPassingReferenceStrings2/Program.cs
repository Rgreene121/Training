using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("player 1 ...What is your first name??");
            string player1 = Console.ReadLine();
            NameChange(player1);
            Console.WriteLine($"in the main method...the name of player 1 is {player1}");
            NameTransform(ref player1);
            Console.WriteLine($"Inside of the very main method the value of player 1 is {player1}");

            Console.ReadLine();


        }
        public static void NameChange(string origPlayer1)
        {
            origPlayer1 = "new Player 1";
            Console.WriteLine($"Inside of the Name change method, the name of Player 1 \n is {origPlayer1}");

        }
        public static void NameTransform(ref string player1)
        {
            player1 = "I am the mother of Dragons!!";
            Console.WriteLine($"today {player1}");

        }
    }
}
