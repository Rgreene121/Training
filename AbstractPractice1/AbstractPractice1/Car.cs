using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1
{
    class Car
    {
        public int mileage = 60;

        public string color = "Blue";

        private string formula = "a + b";



        public int GetMileage()
        {
            return mileage;
        }

        public string GetColor()
        {
            return color;

        }
        private string GetEngineformula()
        {
            return formula;

        }
        public string DisplayEngineFormula()
        {
            return GetEngineformula();
        }
    }
}
