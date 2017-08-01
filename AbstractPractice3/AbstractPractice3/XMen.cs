using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice3
{
    abstract class MarvelUniverse
    {
        public abstract string Marvel();
        
    }
    class XMen : MarvelUniverse
    {
        string Wolverine;
        string Storm;
        string Rogue;

        public override string Marvel()
        {
            string GoodGuys = "XMen";
            return GoodGuys;
        }

    }
    class Villians : MarvelUniverse
    {
        string Magneto = "Eric";
        string Mystic = "Raven";
        string SaberTooth;

        public override string Marvel()
        {
            string Rightous = "Justice";
            return Rightous;

        }
        private string BadGuys()
        {
            Magneto = "Eric";
            return Magneto;
        }
        public string GoodGuys()
        {
            String Xavier = "Professor";
            return Xavier;

        }
    }

}
