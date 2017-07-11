using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string favColor = Console.ReadLine().ToUpper();

            if (favColor == "RED")
            {

                Console.WriteLine("red is good");
                Console.WriteLine("we found a match!!!");
                Console.ReadLine();

            }
            else
            {


                Console.WriteLine("Whatever!!!");
                Console.WriteLine(" we definitely did not find a match");
                Console.ReadLine();


            }

            Console.WriteLine("We are out of here");
            Console.ReadLine();








        }
    }
}
