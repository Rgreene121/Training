using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice4
{
    class Program
    {
        static void Main(string[] args)
        {

            int Age = 38;
            int DaysInYear = 365;

            double fish = 10;
            double birds = 77;

            double complete = Nature(fish, birds);



            int sum = TotalNumber(Age, DaysInYear);
            Console.WriteLine($"You have been alive {sum} since your birth");
            Console.ReadLine();

            Console.WriteLine($"There are a total of {complete} fish and birds in the zoo");
            Console.ReadLine();

        }
        public static int TotalNumber(int Age, int DaysInYear)
        {

            int sum = Age * DaysInYear;

            return sum;

        }
        public static double Nature(double fish, double birds)
        {
            double complete = fish * birds;

            return complete;

        }

       
    }

    
    
}
