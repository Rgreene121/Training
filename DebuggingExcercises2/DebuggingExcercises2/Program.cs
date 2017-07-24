using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExcercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program():

            DebugFour1 deb = new DebugFour1();
            DebugFour2 deb2 = new DebugFour2();
            deb.Four1();
            deb2.FourTwo();
            DebugFour4 deb4 = new DebugFour4();
            deb4.Four4();
        }
    }
}
