using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsePracticeNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old were you when you got married?");
            double firstNum = double.Parse(Console.ReadLine());
            string single = Console.ReadLine().ToLower();

            if (firstNum > 1 && firstNum <= 21)
            {
                Console.WriteLine("You were too young and should have lived more first");
            }

            else if (firstNum >= 22 && firstNum <= 36)
            {
                Console.WriteLine("You got married at a good age for having children");
            }
            else if (firstNum >= 37 && firstNum <= 45)
            {
                Console.WriteLine("You were at a mature and stable age");
            }

            else if (firstNum >= 46 && firstNum <= 100)
            {
                Console.WriteLine("You must be on your second marriage");
            }
            else
            {
                Console.WriteLine("I guess you have never been married");
            }

            Console.ReadLine();
        }
    }
}
