using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bob";
            string password = "agent";

            Console.WriteLine("What is your username");
            string inputName = Console.ReadLine();
            {
                Console.WriteLine("The username that you entered is incorrect, try again");
                Console.ReadLine();

            }
            Console.ReadLine();

            Console.WriteLine("What is your password");
            string pw = Console.ReadLine();

            //int x = 5;

            while (inputName != userName && pw != password)
            {
                Console.WriteLine("The combination that you entered is not correct");
                Console.WriteLine("Try again");
                inputName = Console.ReadLine();
                pw = Console.ReadLine();
            }

            Console.WriteLine("That was the correct username....and password Hooray");
            Console.ReadKey();

        }
    }
}
