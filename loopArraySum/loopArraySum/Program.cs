using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopArraySum
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            int sum = 0;

            //total = 110
            int [] nums = { 5, 10, 15, 20, 10, 50 };
            for(int r = 0; r < nums.Length; ++r)
            {
                Console.WriteLine($"{sum} + {nums[r]}");
                sum += nums[r];
                //Console.WriteLine("The sum of the array is equal to )");
                Console.ReadKey();
            }

            Console.WriteLine($"The total value of the nums equals {sum}");
            Console.ReadLine();
        }
    }
}
