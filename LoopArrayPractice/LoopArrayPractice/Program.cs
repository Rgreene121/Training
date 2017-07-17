using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green", "purple", "orange" };

            for (int i = 0; i < colors.Length; ++i)

            {
                //Array.Reverse(colors);
                Console.WriteLine($"Here are the colors of the colors array " + colors[i]);

            }
            Console.ReadLine();

            int[] nums = new int[5];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;
            nums[4] = 50;

            for (int n = 0; n < nums.Length; ++n)
            {
                Console.WriteLine("The values of array nums is " + (nums[n]));

            }
            Console.ReadLine();
            int name = Convert.ToInt16(Console.ReadLine());
            char[] letters = new char[] { 'v', 'i', 'n', 'c', 'e' };
            for(int m=0; m < letters.Length; ++m)
            {
                Console.Write($"The value of the letters array are {(letters[m])}");
            }
            Console.ReadKey();

            for (int m = 0; m < letters.Length; ++m)
            {
                Console.Write((letters));
                Console.ReadKey();
            }

        }
    }
}
