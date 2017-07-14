using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite sport");
            //string sport = Console.ReadLine().ToLower();
            //string favSport = (sport == "hockey" || sport == "football" || sport == "golf") ? "Great choice" : "Bad choice";
            //Console.WriteLine(favSport);
            //Console.ReadLine();


            //Console.WriteLine("what kind of foods do you like");
            //string food = Console.ReadLine().ToLower();
            //Console.WriteLine("Name a 2nd food you like");
            //string food2 = Console.ReadLine().ToLower();
            //Console.WriteLine("Name a 3rd food you like");
            //string food3 = Console.ReadLine().ToLower();

            //string foodChoice = (food == "chicken" && food2 == "shrimp" && food3 == "fish") ? "Good Choice" : "Bad Choice";
            //Console.WriteLine(foodChoice);
            //Console.ReadLine();




            Console.WriteLine("What kind of makeup do you like?");
            string makeUp = Console.ReadLine().ToLower();
            string makeUp2 = Console.ReadLine().ToLower();
            Console.WriteLine("Do you like dressing up");
            string dressingUp = Console.ReadLine().ToLower();
            string makeupChoice = (makeUp == "mac" && makeUp2 == "sephora") ? "Good Choice" : "Bad Choice";
            Console.WriteLine($"I like {makeUp} and I like dressing up");
           // Console.ReadKey();
            Console.WriteLine(makeupChoice);
            Console.ReadLine();

        }
    }
}
c