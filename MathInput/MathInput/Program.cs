using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first # to add");
            string firstNum = Console.ReadLine();
            int firstN = Convert.ToInt32(firstNum);


            Console.WriteLine("Give me the second # to add");
            string secondN = Console.ReadLine();
            int secondN = Convert.ToInt32(secondN);

            double sum = secondN + firstN;

            Console.WriteLine($"your first number was {firstN} and your second number was {secondN} the sum is {sum}");
            Console.ReadLine();


        }
    }
}
