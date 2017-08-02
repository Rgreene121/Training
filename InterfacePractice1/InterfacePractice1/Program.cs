using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice1
{
    class Program
    {
        public interface Iwork
        {
            void Printing();
            void Display();


        }
        public interface IClean
        {
            void Shop();
        }
        public class Names : Iwork, IClean, IRun
        {
            private string coder = "nice";

            public void Printing()
            {
                Console.WriteLine("I love me");
            }
            public void Display()
            {
                Console.WriteLine("I love Tone");

            }
           
            public void Shop()
            {
                Console.WriteLine("Shopping is really really fun!!!");

            }
            public void Sprint()
            {
                Console.WriteLine("I like to move it, move it!!");

            }

            
        }
        static void Main(string[] args)
        {
            Names n = new Names();
            n.Display();
            n.Printing();
            n.Sprint();
            Console.ReadLine();
        }
        public interface IRun 
        {
            void Sprint();

        }




    }
}
