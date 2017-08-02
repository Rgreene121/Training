using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice3
{

    enum GameOfThrones
    {
        Westeros = 1,
        KingsLanding,
        Winterfell,
        RiverRun
    }
    class Program
    
    {
        static void Main(string[] args)

        {
            int KingdomCh;

            Console.WriteLine("Which Kingdom will sit on the Iron throne? \n 1. Westeros \n 2. KingsLanding \n 3. Winterfell \n 4. RiverRun");

            string king = Console.ReadLine();

            int.TryParse(king, out KingdomCh);

            switch ((GameOfThrones)KingdomCh)
            {
                case GameOfThrones.Westeros:
                    Console.WriteLine("Westero's doesn't have enough power to keep the throne");
                    break;

                case GameOfThrones.KingsLanding:
                    Console.WriteLine("The Lanisters are too corrupt ");
                    break;

                case GameOfThrones.Winterfell:
                    Console.WriteLine("There must always be a stark in Winterfell ");
                    break;

                case GameOfThrones.RiverRun:
                    Console.WriteLine("The Tullys are all dead now ");
                    break;

            }
            Console.WriteLine("The night walkers are coming for them all");
            Console.ReadLine();
        }

            public static void GOT()
        {
            Console.WriteLine("GOT is awesome!!");



        }
        }
    }

