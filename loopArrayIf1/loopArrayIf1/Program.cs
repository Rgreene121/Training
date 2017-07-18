using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopArrayIf1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            int[] pieces = { 33, 51, 22, 78, 90 };

            for (d = 1; d < pieces.Length; ++d)
            {
                if (pieces[d] == 51)
                    Console.WriteLine($"The value of the pieces array is currently {pieces[d]}");
                {
                    //Console.WriteLine($"The value of the pieces array is currently {pieces[d]}");
                    Console.WriteLine($"We found area 51");
                    break;

                }
                //Console.WriteLine("The loop is over");

                //Console.ReadLine();
            }
            Console.ReadLine();

            string[] cars = { "Buick", "datsun", "BMW", "chevy", "Corvette" };

            for (int e = 0; e < cars.Length; ++e)
            {
                if (cars[e] == "Corvette")
                {

                    Console.WriteLine("we found the vette");
                        break;



                }


            }
            Console.WriteLine("we are out of the loop");
            Console.ReadLine();

            foreach (string car in cars)
            {
                Console.WriteLine(car);



            }
            Console.Read();
        }
    }
}
