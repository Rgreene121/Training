using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite amusement park?");
            string park= Console.ReadLine();

            Console.WriteLine("When was the last time you went?");
            string lastTime = Console.ReadLine();

            Console.WriteLine($"My favorite amusement {park} is {lastTime}, I was last there 10 years ago");
            Console.ReadLine();






        }
    }
}
