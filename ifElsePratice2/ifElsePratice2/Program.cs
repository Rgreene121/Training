using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsePratice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car?");
            string favorite = Console.ReadLine().ToLower();

            if (favorite == "chevy")
            {
                Console.WriteLine("I like chevies also!!");
            }
            else if (favorite == "dodge")
            {
                Console.WriteLine("Those are NICE!!");
            }
            else
            {
                Console.WriteLine("we dont understand that car choice");

            }

            Console.ReadLine();




 


        }
    }
}
