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



            int sum = TotalNumber(Age, DaysInYear);
            Console.WriteLine($"You have been alive {sum} since your birth");
            Console.ReadLine();

        }
        public static int TotalNumber(int Age, int DaysInYear)
        {

            int sum = Age * DaysInYear;

            return sum;




        }

       
    }

    
    
}
