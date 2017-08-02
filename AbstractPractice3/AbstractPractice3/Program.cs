using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            MarvelUniverse XMen = new XMen();

            string chaos;
            string mayhem;

            mayhem = XMen.Marvel();

            Console.WriteLine($"Justice comes to us all in {mayhem}");
            Console.ReadLine();

        }

    }
}
