using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructDestructPractice
{
    class Test
    {
        private double length = 5;
        //This is a constructor below...same name as the class itself
        //loads before the page loads. 

        public Test(double y)
        {
            double x = y + 5;
            Console.WriteLine("this is the constructor talking now!");
            Console.WriteLine("");
        }
        ~Test()
        {
            System.Diagnostics.Trace.WriteLine("We are cleaning up our mess now!!");
        }





    }
}
