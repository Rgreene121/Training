using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace switchPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favSeason;
            int favTimeofYear = 0;
            bool yes;

            Console.WriteLine("What is your favorite season \n 1. spring \n 2. summer \n 3. fall \n 4. winter?");
            string favSeason = Console.ReadLine();
            int.TryParse(favSeason, out favTimeofYear);

            switch (favTimeofYear)
            {
                case 1:
                Console.WriteLine("Spring flowers bring May showers");
                    break;

                case 2:
                    Console.WriteLine("Summer time is legendary");
                    break;

                case 3:
                    Console.WriteLine("fall is back to school time");
                    break;

                case 4:
                    Console.WriteLine("Winter is coming, and it is the longest one yet");
                    break;



            }
            ReadLine();



        }
    }
}
