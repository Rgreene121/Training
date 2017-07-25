using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string raven;
            string partner = "Kofi";
            raven = "Hello my name is Harry Potter";
            Console.WriteLine($"Hello {raven}, who is your {partner}");
            Console.WriteLine($"Hello {partner} you are the second player");
            //int.TryParse(partner, out secondPlayer);
            
            Console.ReadLine();
        }
        public static void NewName(string kim)
        {
            kim = newName();
            Console.WriteLine($"I thought your name was Harry?");
            Console.ReadLine();


        }

        private static string newName()
        {
            throw new NotImplementedException();
        }
    }
}
