using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    enum Shoes
    {
        SteveMadden = 1,
        JessicaSimpson,
        RedBottoms,
        Candies
    }
    
     
    enum Movies
    {
        Jaws = 1,
        Goodfellas,
        Heat,
        Avatar,
        Inception,
        GetOut,  
        Scarface,
    }
    class Program
    {
        static void Main(string[] args)
        {
            int favMovie;

            Console.WriteLine("Which Movie is your favorite \n 1. Jaws \n 2.Goodfellas \n 3. Heat \n 4. Avatar \n 5. Inception \n 6. GetOut \n 7. Scarface");

            string favorite = Console.ReadLine();

            int.TryParse(favorite, out favMovie);

            switch ((Movies)favMovie)
            {
                case Movies.Jaws:
                    Console.WriteLine("Jaws is a great movie");
                    break;

                case Movies.Goodfellas:
                    Console.WriteLine("Goodfellas is a classic");
                    break;
                case Movies.Heat:
                    Console.WriteLine("Heat!");
                    break;

                case Movies.Avatar:
                    Console.WriteLine("Avatar was a visual masterpiece");
                    break;

                case Movies.GetOut:
                    Console.WriteLine("GetOut is a new movie");
                    break;

            }

            int favShoe;

            Console.WriteLine("Which Shoe is your favorite \n 1. SteveMadden \n 2.JessicaSimpson \n 3. RedBottoms \n 4. Candies ");

            string Shoes1 = Console.ReadLine();

            int.TryParse(Shoes1, out favShoe);

            switch ((Shoes)favShoe)
            {
                case Shoes.SteveMadden:
                    Console.WriteLine("Steve is a great heel");
                    break;

                case Shoes.JessicaSimpson:
                    Console.WriteLine("Jessica is a great heel");
                    break;

                case Shoes.RedBottoms:
                    Console.WriteLine("RedBottoms is an expensive heel");
                    break;



            }

               
                

                    



            
                

                Console.ReadLine();

        }
    }
}
