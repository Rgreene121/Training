using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name??");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + " How are you today?");
            Console.ReadLine();

            Console.WriteLine("I am glad to hear that");
            Console.ReadLine();

            Console.WriteLine("What is your age??");
            string age = Console.ReadLine();

            Console.WriteLine("You are a {0} year old man", age);
            Console.WriteLine(" {0} you are an {1} year old guy, am I right?", name, age, age);
            Console.ReadLine();

            Console.WriteLine("Are you going out tonight:", age);
            string goingOut = Console.ReadLine();

            Console.WriteLine($"My name is {name} I am {age} and {goingOut} of course");
            Console.ReadLine();




            Console.WriteLine();










        }
    }
}
