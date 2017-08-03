using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice2
{
    class Program
    {

        public interface IJog
        {
            void run();
            void tennisShoes();
                

        }
        public interface IFly
        {
            void plane();
        }
        public class Excercise: IFly, IJog
        {
            public void plane()
            {
                Console.WriteLine();
                
            }
            public void run()
            {
                Console.WriteLine();
            }
            public void tennisShoes()
            {
                Console.WriteLine();

            }
            

        }
        static void Main(string[] args)
        {
            Excercise e = new Excercise ();
            e.plane();
            e.run();
            e.tennisShoes();
            Console.ReadLine();
                

        }


    }
    
}
