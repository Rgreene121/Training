using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            PapaJohns pj = new PapaJohns();
            PizzaHut ph = new PizzaHut();

            pj.Sauce = "Tomato";
            pj.Pork1 = "Italian Sausage";
            pj.Veg1 = "Mushrooms";
            pj.PrintToppings();

            Console.WriteLine();

            ph.Sauce = "Marinara";
            ph.Bread1 = "Zesty Crust";
            ph.Meat1 = "Chicken";
            ph.PrintToppings();

            Console.ReadLine();
         
           
        }
    }
}
