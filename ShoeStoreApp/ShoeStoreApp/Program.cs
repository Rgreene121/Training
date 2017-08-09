using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShoeStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoeStore s1 = new ShoeStore();

            s1.StyleNumber = 1010;
            s1.Style = "Heel";
            s1.Designer = "Carlos Santana";
            s1.Season = "Summer";
            s1.Color = "Red";
            s1.ShoeColor = false;

            ShoeStore s2 = new ShoeStore();
            s2.StyleNumber = 2020;
            s2.Style = "Mule";
            s2.Designer = "Steve Madden";
            s2.Season = "Fall";
            s2.Color = "Black";
            s2.ShoeColor = true;

            List<ShoeStore> shoeList = new List<ShoeStore>();

            shoeList.Add(s1);
            shoeList.Add(s2);


            foreach (ShoeStore item in shoeList)
            {
                Console.WriteLine($"Our style number is {item.StyleNumber}, made by {item.Designer}, for the season {item.Season}, Style type of {item.Style} and the color is {item.Color}");
            }
            ReadLine();

            foreach (ShoeStore item in shoeList)
            {
                Console.WriteLine($"There is a 30% discount on {s2.Color} shoes {item.ShoeColor}");

                if (item.ShoeColor== true)
                {
                    Console.WriteLine($"We are sold out of {s2.Color}{item.ShoeColor}");

                }

            }
            
            ReadLine();
        }
    }
}
