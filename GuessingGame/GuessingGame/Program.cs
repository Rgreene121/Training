using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Random rnd = new Random();
            Vacation v = new Vacation();
            

            Console.WriteLine("Hello world");

            p.Working();
            Talking();
            Thinking();
            v.bahamas();
            v.cancun();
            v.Nice();
            
        
            Console.WriteLine("Im back bitches");
            Console.ReadKey();
        }
        public void Working()
        {
            Console.WriteLine("It's me snitches");

        }
        public static void Talking()
        {
            Console.WriteLine("Talking alot can be hazardous to your health");
            
            
        }
        public static void Thinking()
        {
            Console.WriteLine("I think that you are smart");

        }
       private static void Options()
       {
            Console.WriteLine("Hello world");
            Console.ReadLine();
       }
        
    }
    
    
}
