using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsePract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite movie");
            string favMovie = Console.ReadLine().ToLower();

            if (favMovie == "dude")

            {
                Console.WriteLine("Dude isnt a movie");
                Console.ReadLine();
            }
            else if (favMovie == "matrix")
            {
                Console.WriteLine("The matrix was a legendary movie for vfx");
                Console.ReadLine();


            }
            else if (favMovie == "frailty")

            {
                Console.WriteLine("frailty is a good movie");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you obviously dont watch many movies");
                Console.ReadLine();






            }
            Console.WriteLine($" why do you think {favMovie} is a good movie?");



          

            
                



          





        }
    }
}
