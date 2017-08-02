using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Employee e = new Employee();

            e.FirstName = "Rabi";
            e.LastName = "Basir";
            e.IdNumber = 5000;
            e.SocNumber = 555555555;
            e.Tuition = 500;
            p.DisplayInfo(e);

            p.DisplayInfo(e);
        }
        public void DisplayInfo(Employee emp)
        {
            Console.WriteLine($"My first name is {emp.FirstName}, my last name is {emp.LastName}, my id number is {emp.IdNumber}, and my social number is {emp.SocNumber}");

            Console.ReadLine();


        }
    }
}
