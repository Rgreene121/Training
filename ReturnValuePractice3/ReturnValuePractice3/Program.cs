using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int t = 6;


            int sum = sumOfNum(x, t);
            
            Console.WriteLine($"The total of {x} + {t} is {sum}...");
            Console.ReadLine();


        }
        private static int sumOfNum(int n1, int n2)
        {
            int sum = n1 + n2;

            return sum;



            
            //Console.WriteLine("I got this");
            //Console.ReadLine();
                

        }
            
    }
}
