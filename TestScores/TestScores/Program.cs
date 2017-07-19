using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //int idNum;
            int sum = 0;
            int total = 100;
            //Array  = ArraySegment();

            int rNum = rand.Next(1, 100);
            int realNum;

            for (int i = 0; i <= 100; i++)

            {
                Console.WriteLine("Enter a Number");
                string score = Console.ReadLine();
                int.TryParse(score, out total);
            }
            //while(idNum < sum || idNum >= total)
            if (sum == 101)
            {
                Console.WriteLine("You must enter a valid score");
                score = Console.ReadLine();
                int.TryParse(score, out total);
            }
            else if (total <= 100 )
            {
                Console.WriteLine("You are on the right track");
            }
            //while (Get(input) != Sentinel)
            //{
            //    Process(input);
            //}


        }
            

    }
}
