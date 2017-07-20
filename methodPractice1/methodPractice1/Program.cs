using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurants r = new Restaurants();
            Fashion f = new Fashion();

            Console.WriteLine("This is the main method landing page");


            r.Chipotle();
            f.Pants(); 
            Console.ReadLine();
        }
        public void Addition()
        {


        }
        public void Multiply()
        {

        }
        public void Division()
        {

        }

    }
    class Fashion
    {
        public void Shirts()
        {
            Console.WriteLine("Button up's");
            Console.WriteLine("V necks");
            Console.WriteLine("Henley");


        }
        public void Pants()
        {
            Console.WriteLine("Button fly");
            Console.WriteLine("Zip up");
        }

        
        public void Shoes()
        {


        
        }











    }
}
