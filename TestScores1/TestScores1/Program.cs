using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 1;
            int highNum = 100;

            Console.WriteLine("Enter a valid test score");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while (idNum < lowNum || idNum >= highNum)
            {
                Console.WriteLine($"The Id number you entered {valNum} \n" + $"must be between {lowNum} and {highNum} \n Try again");
                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);
                Console.ReadLine();

            }

        }
    }
}
