using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice2
{


    enum Burgers
    {
        Whopper = 1,
        BigMac,
        Single
            
    }
        

    class Program
    {
        static void Main(string[] args)
        {


            int BChoice;
            Console.WriteLine("Which burger is your favorite \n 1. Whopper \n 2. BigMac \n 3. Wendy's Single");
            string sandwich = Console.ReadLine();

            int.TryParse(sandwich, out BChoice);

            switch ((Burgers)BChoice)
            {
                case Burgers.Whopper:
                    Console.WriteLine("Burger king is a great ");
                    break;

                case Burgers.BigMac:
                    Console.WriteLine("McDonalds is a classic place");
                    break;

                case Burgers.Single:
                    Wendys();
                    break;

                    //Console.WriteLine("Wendy's food taste homemade");
                    break;
            }
            Console.WriteLine("Out of the burger switch");
            Console.ReadLine();
        }
        public static void Wendys()
        {
            Console.WriteLine("Wendys burgers are awesome!!");

        }




    }
}
