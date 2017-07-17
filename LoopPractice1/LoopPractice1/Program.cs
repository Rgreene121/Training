using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 11, 22, 55, 88, 165 };
            string[] stars = { "Beyonce", "Rhianna", "Madonna", "Solange","Jim Jones","R.Kelly"};


            for(int i = 0; i < 10; i++)


            {
                Console.WriteLine($"The value of i is {i}");
                //Console.WriteLine("The value of i is {0}", i);

            }
            Console.ReadLine();

            for (int k = 0; k < stars.Length; ++k)

                for (int f = 0; f < 7; ++f)
                {
                    Console.WriteLine($"The stars are " + (stars[k]));
                    Console.WriteLine($"The stars are " + (numbers[f]));
                }
            Console.ReadLine();

            for (int d = 0;d < numbers.Length; ++d)
            {
                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
            }
            Console.ReadLine();
        }
    }
}
