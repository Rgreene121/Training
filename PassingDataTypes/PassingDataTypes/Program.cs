using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 5, 12, 66, 27 };
            string [] nameArray = {"Nancy Drew",  "Columbo",  "The Hardy Boys"};

            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("The value of the ArrayInt array is " + arrayInt[i]);

            }
            Console.WriteLine("we are now out of the loop");
            Console.ReadLine();
            MaxArray(arrayInt);
            SumArray(arrayInt);
            ListNames(nameArray);
        }   
        public static void SumArray(int [] arrayVals)
        {
            int sumation = arrayVals.Sum();
            Console.WriteLine($"The sum of the array is {sumation}");
            Console.ReadLine();
        }
        public static void MaxArray(int [] intArray)
        {
            int maxVal = intArray.Max();
            Console.WriteLine($"The max value of the array is {maxVal}");
            Console.ReadLine();
        }
        public static void ListNames(string [] Names)
        {
            //string allNames = Names.
            for (int k = 0; k < Names.Length; k++)
            {
                Console.WriteLine("The names of the ArrayNames array are " + Names[k]);
            }
            Console.ReadLine();

        }
        
    }
}
